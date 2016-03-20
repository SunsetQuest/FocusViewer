using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using BriefConfig;
using System.Drawing.Drawing2D;
using System.Collections;

namespace FocusViewer
{
    public partial class frmMain : Form
    {
        /// <summary>The number of symbols (or tickers) that will be read. (CURRENTLY HARD CODED TO 32) </summary>
        const int TickerCount = 32;

        /// <summary>The number of attributes (or tickers) that will be read. (CURRENTLY HARD CODED TO 32)</summary>
        const int AttributeCount = 32;

        /// <summary>Display size for code bits (X dimension).</summary>
        //const int FocusCodeSets = 32;

        /// <summary>Display size for code bits (Y dimension).</summary>
        const int FocusCodeLanes = 32;

        /// <summary>Display size for code bits (Z dimension).</summary>
        const int FocusCodeBits = 32;

        /// <summary>The number of Briefs that have been loaded.</summary>
        int briefCt = 0;

        /// <summary>A list of symbols (or tickers).  (CURRENTLY HARD CODED TO 32)</summary>
        List<string> symbols = new List<string>();

        /// <summary>Data Context</summary>
        DataClasses1DataContext dc = new DataClasses1DataContext();

        string[] HeaderNames = new string[TickerCount * AttributeCount + 32];

        /// <summary>Contains the last code/program image so we can compare it next time.</summary>
        BitArray[][] lastCode;

        /// <summary>
        /// Contains the Heat-Map counters for each bit position.
        /// Typical: int[/*32 Sets*/][/*32 Lanes*/][/*32 Bits*/]
        /// </summary>
        int[/*Sets*/][/*Lanes*/][/*Bits*/] imageHeatMap;

        /// <summary>Each stock item: [10000s brfRowId][32 symbol][26 attributes]</summary>
        float[/*brfRowId*/][/*symbol*/][/*attribute*/] stockItems;


        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: This line of code pre-loads data into the 'focusDataSet.CodeUpdates' table.
            codeUpdatesTableAdapter.Fill(focusDataSet.CodeUpdates);

            //download symbols
            var symbolRows = (from b in dc.Symbols where b.Type == "STK" orderby b.SymbolID select b);

            if (symbolRows.Count() != TickerCount)
                MessageBox.Show("Warning: There must be " + TickerCount + " tickers.", "Warning");

            // Populate symbols list and symbol choices combo-box
            foreach (var symbol in symbolRows)
            {
                symbols.Add(symbol.Name.Trim());
                listBoxSymbols.Items.Add(symbol.Name.Trim());
            }
        }

        private void RefreshCodeUpdates(object sender, EventArgs e)
        {
            //var myTableData = from p in dc.CodeUpdates
            //                  //where p.Field1 == "Item1"
            //                  orderby p.ide descending
            //                  select p;
            //dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, myTableData);

            codeUpdatesTableAdapter.Fill(this.focusDataSet.CodeUpdates);

            //dataGridViewCodeUpdates.DataSource = myTableData;
            //chartCodeStats.Series[0].Points.Invalidate();
            //chartCodeStats.DataSource = this.focusDataSet.CodeUpdates; //myTableData;

            chartCodeStats.DataBind();

            //chartCodeStats.Refresh();
            //Object temp = chart2.DataSource;
            //chart2.DataSource = null;
            //chart2.DataSource = temp;
            //chart2.Series[0].Points.DataBindXY(xAxis, yAxis); 

            //this.codeUpdatesTableAdapter.ClearBeforeFill = true;
            //this.codeUpdatesTableAdapter.Fill(this.focusDataSet.CodeUpdates);
            //chart.Series[0].Points.DataBindXY(xAxis, yAxis); 

            //numericUpDown1.Maximum = focusDataSet.CodeUpdates.Count - 1;
            //numericUpDown1.Value = focusDataSet.CodeUpdates.Count - 1;

            if (checkBoxShowAvg.Checked)
            {

                if (chartCodeStats.Series["DisplayScore"].Points.Count > 20)
                {
                    chartCodeStats.DataManipulator.FinancialFormula(FinancialFormula.ExponentialMovingAverage, 
                        "20", "DisplayScore", "AvgDispScore");
                    chartCodeStats.Series["AvgDispScore"].ChartType = SeriesChartType.FastLine;
                }

                if (chartCodeStats.Series["DispUnTested"].Enabled)
                    if (chartCodeStats.Series["DispUnTested"].Points.Count > 20)
                    {
                        chartCodeStats.DataManipulator.FinancialFormula(FinancialFormula.ExponentialMovingAverage, 
                            "20", "DispUnTested", "AvgUTDispScore");
                        chartCodeStats.Series["AvgUTDispScore"].ChartType = SeriesChartType.FastLine;
                    }
            }
        }

        private void AddSymbToBrfChart(object sender, EventArgs e)
        {
            //Make sure we have downloaded some Briefs
            if (briefCt == 0)
                btnDownloadAllBriefs_Click(null, null);

            // Get attribute and ticker that the user wants to download 
            int attribIdx = comboBoxAttribToShow.SelectedIndex;
            if (attribIdx < 0)
            {
                MessageBox.Show("You must select an attribute.");
                return;
            }
            string attribName = BrfConfig.AttribSpecs[attribIdx].Symbol;

            int symbolIdx = listBoxSymbols.SelectedIndex;
            if (symbolIdx < 0)
            {
                MessageBox.Show("You must select an symbol.");
                return;
            }
            string symbolName = symbols[symbolIdx].Trim();

            string newName = symbolName + "-" + attribName;

            // Make sure this item is not already displayed 
            if (chartBrfs.Series.Where(n => (n.Name == newName)).Count() > 0)
                return;

            Series series1 = new Series(); //chart1.Series.Add(seriesArray[i]);
            series1.ChartArea = BrfConfig.AttribSpecs[attribIdx].UseLeftAxis ? "ChartAreaPrice" : "ChartAreaVolume";
            series1.ChartType = BrfConfig.AttribSpecs[attribIdx].ChartType; //set bar graph or line graph
            series1.Legend = "Legend1";
            series1.Name = newName;
            //series1.YValuesPerPoint = 4;
            chartBrfs.Series.Add(series1);
            for (int brfRowId = 0; brfRowId < briefCt; brfRowId++)
                series1.Points.Add(stockItems[brfRowId][symbolIdx][attribIdx]);
        }

        /// <summary>
        /// Resizes an image by a given percentage.
        /// Source: PsychoCoder (2008) http://www.dreamincode.net/forums/topic/365461-Resize-an-image-in-C%23/
        /// </summary>
        /// <param name="img">the image to resize</param>
        /// <param name="percentage">Percentage of change (i.e for 105% of the original provide 105)</param>
        /// <returns>The resized image.</returns>
        public Image ResizeImage(Image img, int percentage)
        {
            // Get the height and width of the image.
            int originalW = img.Width;
            int originalH = img.Height;

            // Get the new size based on the percentage change.
            int resizedW = originalW * percentage;
            int resizedH = originalH * percentage;

            // Create a new Bitmap the size of the new image.
            Bitmap bmp = new Bitmap(resizedW, resizedH);

            // Create a new graphic from the Bitmap
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw the newly resized image.
            graphic.DrawImage(img, 0, 0, resizedW, resizedH);

            // Dispose and free up the resources.
            graphic.Dispose();

            // Return the image.
            return bmp;
        }

        /// <summary>
        /// When the user click up or down this functions re-calculates the change-map or heat-map based on the selected record.
        /// </summary>
        private void CodeVisualizer_UP_DOWN(object sender, EventArgs e)
        {
            //lets set min/max
            int? begRowId = dc.CodeUpdates.Min(u => (int?)u.ide);
            int? endRowId = dc.CodeUpdates.Max(u => (int?)u.ide);

            if (begRowId.HasValue)
                numericUpDownCodeVisualizer.Minimum = begRowId.Value;
            if (endRowId.HasValue)
                numericUpDownCodeVisualizer.Maximum = endRowId.Value;

            //Now lets fill the table
            var myTableData = from p in dc.CodeUpdates
                              where p.ide == (int)numericUpDownCodeVisualizer.Value
                              orderby p.ide
                              select p;

            if (myTableData.Count() == 0)
                return;

            BitArray focusBits = new BitArray(myTableData.First().code.ToArray());
            int focusCodeSets = focusBits.Length / (FocusCodeLanes * FocusCodeBits);

            BitArray[][] code = new BitArray[focusCodeSets][];
            for (int set = 0; set < focusCodeSets; set++)
            {
                code[set] = new BitArray[FocusCodeLanes];
                for (int lane = 0; lane < FocusCodeLanes; lane++)
                    code[set][lane] = new BitArray(FocusCodeBits);
            }


            for (int set = 0; set < focusCodeSets; set++)
                for (int lane = 0; lane < FocusCodeLanes; lane++)
                    for (int bit = 0; bit < FocusCodeBits; bit++)
                        code[set][lane][bit] = focusBits[(set * FocusCodeLanes * FocusCodeBits) + (lane * FocusCodeBits) + bit];

            // setup lastCode if we have never used it
            if (lastCode == null)
            {
                lastCode = new BitArray[focusCodeSets][];
                for (int set = 0; set < focusCodeSets; set++)
                {
                    lastCode[set] = new BitArray[FocusCodeLanes];
                    for (int lane = 0; lane < FocusCodeLanes; lane++)
                        lastCode[set][lane] = new BitArray(32);
                }
            }

            // setup imageHeatMap if we have never used it
            if (imageHeatMap == null)
            {
                imageHeatMap = new int[focusCodeSets][][];
                for (int set = 0; set < focusCodeSets; set++)
                {
                    imageHeatMap[set] = new int[FocusCodeLanes][];
                    for (int lane = 0; lane < FocusCodeLanes; lane++)
                        imageHeatMap[set][lane] = new int[FocusCodeBits];
                }
            }

            // Lets count the total bits set for informational purposes 
            int totalBitsSet = 0;

            // Lets create the Heat Map or Change Map
            Bitmap pt = new Bitmap(focusCodeSets * FocusCodeLanes, FocusCodeBits);
            for (int set = 0; set < focusCodeSets; set++)
                for (int lane = 0; lane < FocusCodeLanes; lane++)
                    for (int bit = 0; bit < FocusCodeBits; bit++)
                    {
                        Color colorForPixal;
                        if (checkBoxLockForChangeHeatMap.Checked)
                        {
                            if (code[set][lane][bit] != lastCode[set][lane][bit])
                                imageHeatMap[set][lane][bit]++;

                            int heat = imageHeatMap[set][lane][bit];
                            heat = Math.Min(heat * 32, 255);
                            colorForPixal = Color.FromArgb(heat, heat, heat);
                        }
                        else // lets just do highlight the changes
                        {
                            if (code[set][lane][bit])
                                colorForPixal = (lastCode[set][lane][bit]) ? Color.Blue : Color.Yellow;
                            else
                                colorForPixal = (lastCode[set][lane][bit]) ? Color.Red : Color.White;
                        }

                        // Lets count the total bits set for informational purposes 
                        if (code[set][lane][bit])
                            totalBitsSet++;

                        pt.SetPixel((lane * focusCodeSets) + set, bit, colorForPixal);
                    }

            // Resize image
            const int Pixels = 8;
            Bitmap newImage = new Bitmap(focusCodeSets * FocusCodeLanes * Pixels/2, FocusCodeBits * Pixels);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.InterpolationMode = InterpolationMode.NearestNeighbor;
                gr.PixelOffsetMode = PixelOffsetMode.Half;
                gr.DrawImage(pt, new Rectangle(0, 0, focusCodeSets * FocusCodeLanes * Pixels/2, FocusCodeBits * Pixels));
            }
            pictureBox1.Image = newImage;

            // If 'Lock For Image Difference' is not checked then
            //   lets update 'lastCode' so that we know what changed last time. 
            if (!checkBoxLockForImageDiff.Checked)
            {
                for (int set = 0; set < focusCodeSets; set++)
                    for (int lane = 0; lane < FocusCodeLanes; lane++)
                        for (int bit = 0; bit < FocusCodeBits; bit++)
                            lastCode[set][lane][bit] = code[set][lane][bit];
            }
            lblCodeViewerOnes.Text = "1's:" + totalBitsSet + "  (" + ((totalBitsSet * 100) / (focusCodeSets * FocusCodeLanes * FocusCodeBits)) + "%)";
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {
            chartBrfs.Series.Clear();
        }

        private void btnDownloadAllBriefs_Click(object sender, EventArgs e)
        {
            int TOTAL_CT = (int)numericUpDownDownloadCt.Value;

            var all_briefs = (from b in dc.Briefs orderby b.BriefID select b.BriefBytes);
            var briefs = all_briefs.Skip(Math.Max(0, all_briefs.Count() - TOTAL_CT)).Take(TOTAL_CT);
            briefCt = briefs.Count();

            stockItems = new float[briefCt + 10/*for growth while downloading*/][][];
            for (int b = 0; b < briefCt + 10; b++)
            {
                stockItems[b] = new float[TickerCount][];
                for (int s = 0; s < TickerCount; s++)
                    stockItems[b][s] = new float[AttributeCount];
            }

            int brfRow = 0;
            foreach (var brief in briefs)
            {

                byte[] brfSetAsBytes = brief.ToArray();
                MemoryStream stream = new MemoryStream(brfSetAsBytes);
                BinaryReader reader = new BinaryReader(stream);

                long Length = reader.BaseStream.Length;
                if (Length != 4224)
                {
                    MessageBox.Show("unexpected brief length - Expected: 4224  Encountered: " + Length);
                    continue;
                }

                for (int i = 0; i < TickerCount; i++) //for each header item
                    reader.ReadSingle(); //skip over headers;don't save anything

                for (int s = 0; s < TickerCount; s++)
                    for (int i = 0; i < AttributeCount; i++)
                    {
                        float val = reader.ReadSingle();
                        stockItems[brfRow][s][i] = val;
                    }
                brfRow++;
            }
        }

        // Source: 2009 http://stackoverflow.com/a/632920/2352507
        public static string ConvertHexArrayToString(byte[] p)
        {
            char[] c = new char[p.Length * 2 + 2];
            byte b;
            c[0] = '0'; c[1] = 'x';
            for (int y = 0, x = 2; y < p.Length; ++y, ++x)
            {
                b = ((byte)(p[y] >> 4));
                c[x] = (char)(b > 9 ? b + 0x37 : b + 0x30);
                b = ((byte)(p[y] & 0xF));
                c[++x] = (char)(b > 9 ? b + 0x37 : b + 0x30);
            }
            return new string(c);
        }

        private void btnFillBriefRawDataTable_Click(object sender, EventArgs e)
        {
            const int ColPageWidth = 32;
            const int RowPageHight = 1024;

            SuspendLayout();
            //dataGridViewRawBriefs.SuspendLayout();
            dataGridViewRawBriefs.Rows.Clear();
            dataGridViewRawBriefs.Columns.Clear();

            // Only initiate headers if needed
            if (HeaderNames[0] == null)
            {
                int curCol = 0;
                for (int h = 0; h < 32; h++)
                    HeaderNames[curCol++] = "Hdr" + h.ToString();

                for (int s = 0; s < 32; s++)
                    for (int a = 0; a < 32; a++)
                        HeaderNames[curCol++] = BrfConfig.AttribSpecs[a].Symbol + ":" + symbols[s].ToString();
            }

            if (numericUpDownStartCol.Value > ((32 * 32 + 32) - ColPageWidth))
            {
                numericUpDownStartCol.Value = (32 * 32 + 32) - ColPageWidth;
                MessageBox.Show("Scroll Right to see the last 32 columns.");
            }

            int begCol = (int)numericUpDownStartCol.Value;
            int begRow = (int)numericUpDownStartRow.Value;

            // Add the headers
            string[] hdrs = new string[ColPageWidth];
            Array.Copy(HeaderNames, begCol, hdrs, 0, ColPageWidth);


            // Add two header columns
            int hdrColCt = 0;
            DataGridViewTextBoxColumn hdrColumn = new DataGridViewTextBoxColumn();
            hdrColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            hdrColumn.HeaderText = "BrfID";
            hdrColumn.ReadOnly = true;
            hdrColumn.Frozen = true;
            dataGridViewRawBriefs.Columns.Add(hdrColumn);
            hdrColCt++;
            DataGridViewTextBoxColumn hdrColumn2 = new DataGridViewTextBoxColumn();
            hdrColumn2.HeaderText = "RawBytes";
            hdrColumn2.ReadOnly = true;
            hdrColumn2.Frozen = true;
            hdrColumn2.Width = 60;
            hdrColumn2.DefaultCellStyle.BackColor = Color.LightGray;
            hdrColumn2.DividerWidth = 5;
            dataGridViewRawBriefs.Columns.Add(hdrColumn2);
            hdrColCt++;


            //Add data columns
            foreach (string hdr in hdrs)
            {
                // Add header column
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = hdr.Replace(":", " ");
                //col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                col.Width = 50;
                dataGridViewRawBriefs.Columns.Add(col);
            }

            // Add the data 
            var briefs = (from b in dc.Briefs orderby b.BriefID select b).Skip(begRow).Take(RowPageHight);
            float[] buf = new float[RowPageHight + hdrColCt];
            foreach (var brief in briefs)
            {
                Buffer.BlockCopy(brief.BriefBytes.ToArray(), begCol * sizeof(float), buf, 
                    hdrColCt * sizeof(float), ColPageWidth * sizeof(float));
                string[] stringFormat = Array.ConvertAll(buf, i => i.ToString());
                stringFormat[0] = brief.BriefID.ToString();
                stringFormat[1] = ConvertHexArrayToString(brief.BriefBytes.ToArray());
                dataGridViewRawBriefs.Rows.Add(stringFormat);
            }

            ResumeLayout();
        }

        private void tabPageCodeChart_Enter(object sender, EventArgs e)
        {
            if (chartCodeStats.DataSource == null)
                RefreshCodeUpdates(this, null);
        }

        /// <summary>
        /// Submit changes to the database.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
        }

        private void btnDeleteCodeAfterSelected_Click(object sender, EventArgs e)
        {
            DeleteRowsInPredAndCodeUpdates(true);
        }

        private void btnDeleteCodeBeforeSelected_Click(object sender, EventArgs e)
        {
            DeleteRowsInPredAndCodeUpdates(false);
        }

        /// <summary>
        /// Deletes the predictions and CodeUpdate history either before or after the current selection. 
        /// </summary>
        /// <param name="DeleteAfterSelected">True=Delete values greater then selected the id. False=Delete values less then the selected id.</param>
        private void DeleteRowsInPredAndCodeUpdates(bool DeleteAfterSelected)
        {
            int selectedVal;
            try
            {
                selectedVal = (int)dataGridViewCodeUpdates.CurrentRow.Cells["ideDataGridViewTextBoxColumn"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return;
            }
            if (selectedVal <= 0)
                return;

            DialogResult result = MessageBox.Show("Delete older code rows with an ide "
                + (DeleteAfterSelected ? "AFTER (greater then)" : "BEFORE(less then) ")
                + selectedVal.ToString() + " ?", "Warning - Delete History", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.FocusConnectionString);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = "delete from Preds where CodeVerID " + (DeleteAfterSelected ? "> " : "< ") + selectedVal;
                cmd1.Connection = con;
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "delete from CodeUpdates where ide " + (DeleteAfterSelected ? "> " : "< ") + selectedVal;
                cmd2.Connection = con;
                con.Open();
                int PredsDeleted = cmd1.ExecuteNonQuery();
                int codesDeleted = cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(PredsDeleted.ToString() + " Preds and " + codesDeleted.ToString() + " CodeUpdates were deleted.");
                RefreshCodeUpdates(this, null);

            }
        }

        /// <summary>
        /// Deletes ALL predictions and CodeUpdate history. 
        /// </summary>
        private void btnWipeCode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete code update history and all predictions?", "Warning", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(FocusViewer.Properties.Settings.Default.FocusConnectionString);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = "delete from Preds";
                cmd1.Connection = con;
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "delete from CodeUpdates where ide > 101";
                cmd2.Connection = con;
                con.Open();
                int PredsDeleted = cmd1.ExecuteNonQuery();
                int codesDeleted = cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(PredsDeleted.ToString() + " Preds and " + codesDeleted.ToString() + " CodeUpdates were deleted.");
                RefreshCodeUpdates(this, null);
            }
        }

        private void checkBoxShowTradeCtOnChart_CheckedChanged(object sender, EventArgs e)
        {
            chartCodeStats.Series["AvgTradeCt"].Enabled = ((CheckBox)sender).Checked;
            chartCodeStats.ResetAutoValues(); // re-calculates the axes scales
        }

        private void checkBoxShowRawScores_CheckedChanged(object sender, EventArgs e)
        {
            chartCodeStats.Series["unTestedScore"].Enabled = ((CheckBox)sender).Checked;
            chartCodeStats.Series["score"].Enabled = ((CheckBox)sender).Checked;
            chartCodeStats.Series["DispUnTested"].Enabled = !((CheckBox)sender).Checked;
            chartCodeStats.Series["DisplayScore"].Enabled = !((CheckBox)sender).Checked;
            chartCodeStats.ResetAutoValues(); // re-calculates the axes scales
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                double widthFactor = ((double)pictureBox1.Image.Width / pictureBox1.Width) / 8;
                double lengthFactor = ((double)pictureBox1.Image.Height / pictureBox1.Height) / 8;

                lblCurrentCord.Text = string.Format("Set:{0} Lane:{1} Bit:{2}",
                    (int)(e.X * widthFactor) % 4, (int)(e.X * widthFactor) / 4, (int)(e.Y * lengthFactor));
            }
        }

        private void checkBoxShowAvgScores_CheckedChanged(object sender, EventArgs e)
        {
            //SeriesChartType newType = (((CheckBox)sender).Checked) ? SeriesChartType.Spline : SeriesChartType.FastLine;
            //chartCodeStats.Series["unTestedScore"].ChartType = newType;
            //chartCodeStats.Series["score"].ChartType = newType;
            //chartCodeStats.Series["DispUnTested"].ChartType = newType;
            //chartCodeStats.Series["DisplayScore"].ChartType = newType;
            //chartCodeStats.Series["AvgTradeCt"].ChartType = newType;

            if (checkBoxShowAvg.Checked)
                RefreshCodeUpdates(null, null);
            else
            {
                try { chartCodeStats.Series.Remove(chartCodeStats.Series["AvgDispScore"]); } catch (Exception) { }
                try { chartCodeStats.Series.Remove(chartCodeStats.Series["AvgUTDispScore"]); } catch (Exception) { }

            }
            // Re-calculate the axes scales.
            chartCodeStats.ResetAutoValues();
        }

        private void dataGridViewCodeUpdates_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCodeUpdates.CurrentCell != null)
            {
                int rowindex = dataGridViewCodeUpdates.CurrentCell.RowIndex;
                double curTotalTime = (double)dataGridViewCodeUpdates.Rows[dataGridViewCodeUpdates.CurrentCell.RowIndex].Cells[2].Value;
                chartCodeStats.ChartAreas[0].CursorX.Position = curTotalTime;
            }
        }
    }
}

