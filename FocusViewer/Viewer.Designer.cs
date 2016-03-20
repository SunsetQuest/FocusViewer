namespace FocusViewer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxSymbols = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownDownloadCt = new System.Windows.Forms.NumericUpDown();
            this.btnDownloadAllBriefs = new System.Windows.Forms.Button();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.comboBoxAttribToShow = new System.Windows.Forms.ComboBox();
            this.btnAddSymbToChart = new System.Windows.Forms.Button();
            this.chartBrfs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCodeChart = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewCodeUpdates = new System.Windows.Forms.DataGridView();
            this.ideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brfVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twkBitFlipCtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unTestedScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayScore1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayUnTestedScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noChangeDetCtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keepWithSmallDegCtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degradeFloorCtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailedMinTrdCtRuleCt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrdCtAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trd0Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trd1Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trd2Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trd3Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trd4Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trd5Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trd6Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trd7Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyScore31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeUpdatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.focusDataSet = new FocusViewer.FocusDataSet();
            this.checkBoxShowAvg = new System.Windows.Forms.CheckBox();
            this.checkBoxShowRawScores = new System.Windows.Forms.CheckBox();
            this.checkBoxShowTradeCtOnChart = new System.Windows.Forms.CheckBox();
            this.btnDeleteCodeAboveSelected = new System.Windows.Forms.Button();
            this.btnDeleteCodeBelowSelected = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDeleteAllCode = new System.Windows.Forms.Button();
            this.btnRefreshCode = new System.Windows.Forms.Button();
            this.chartCodeStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageCodeVisualizer = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentCord = new System.Windows.Forms.Label();
            this.numericUpDownCodeVisualizer = new System.Windows.Forms.NumericUpDown();
            this.checkBoxLockForChangeHeatMap = new System.Windows.Forms.CheckBox();
            this.lblCodeViewerOnes = new System.Windows.Forms.Label();
            this.checkBoxLockForImageDiff = new System.Windows.Forms.CheckBox();
            this.tabPageStockChart = new System.Windows.Forms.TabPage();
            this.tabPageBrfRawData = new System.Windows.Forms.TabPage();
            this.dataGridViewRawBriefs = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFillBriefRawDataTable = new System.Windows.Forms.Button();
            this.numericUpDownStartRow = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartCol = new System.Windows.Forms.NumericUpDown();
            this.codeUpdatesTableAdapter = new FocusViewer.FocusDataSetTableAdapters.CodeUpdatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDownloadCt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBrfs)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageCodeChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCodeUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeUpdatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCodeStats)).BeginInit();
            this.tabPageCodeVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCodeVisualizer)).BeginInit();
            this.tabPageStockChart.SuspendLayout();
            this.tabPageBrfRawData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRawBriefs)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartCol)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.listBoxSymbols);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownDownloadCt);
            this.splitContainer1.Panel2.Controls.Add(this.btnDownloadAllBriefs);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearChart);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxAttribToShow);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddSymbToChart);
            this.splitContainer1.Panel2.Controls.Add(this.chartBrfs);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1100, 786);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 3;
            // 
            // listBoxSymbols
            // 
            this.listBoxSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSymbols.FormattingEnabled = true;
            this.listBoxSymbols.Location = new System.Drawing.Point(0, 0);
            this.listBoxSymbols.Name = "listBoxSymbols";
            this.listBoxSymbols.Size = new System.Drawing.Size(283, 709);
            this.listBoxSymbols.TabIndex = 8;
            this.listBoxSymbols.DoubleClick += new System.EventHandler(this.AddSymbToBrfChart);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 709);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 77);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Back Count:";
            // 
            // numericUpDownDownloadCt
            // 
            this.numericUpDownDownloadCt.AllowDrop = true;
            this.numericUpDownDownloadCt.Increment = new decimal(new int[] {
            4800,
            0,
            0,
            0});
            this.numericUpDownDownloadCt.Location = new System.Drawing.Point(506, 5);
            this.numericUpDownDownloadCt.Maximum = new decimal(new int[] {
            480000,
            0,
            0,
            0});
            this.numericUpDownDownloadCt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDownloadCt.Name = "numericUpDownDownloadCt";
            this.numericUpDownDownloadCt.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownDownloadCt.TabIndex = 7;
            this.numericUpDownDownloadCt.ThousandsSeparator = true;
            this.numericUpDownDownloadCt.Value = new decimal(new int[] {
            48000,
            0,
            0,
            0});
            // 
            // btnDownloadAllBriefs
            // 
            this.btnDownloadAllBriefs.Location = new System.Drawing.Point(249, 3);
            this.btnDownloadAllBriefs.Name = "btnDownloadAllBriefs";
            this.btnDownloadAllBriefs.Size = new System.Drawing.Size(137, 21);
            this.btnDownloadAllBriefs.TabIndex = 6;
            this.btnDownloadAllBriefs.Text = "(Re)download All Briefs";
            this.btnDownloadAllBriefs.UseVisualStyleBackColor = true;
            this.btnDownloadAllBriefs.Click += new System.EventHandler(this.btnDownloadAllBriefs_Click);
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(168, 3);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(75, 21);
            this.btnClearChart.TabIndex = 5;
            this.btnClearChart.Text = "Clear All";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // comboBoxAttribToShow
            // 
            this.comboBoxAttribToShow.FormattingEnabled = true;
            this.comboBoxAttribToShow.Items.AddRange(new object[] {
            "0;volume_day",
            "1;volume_ths",
            "2;largTrdPrc",
            "3;price_high",
            "4;price_loww",
            "5;price_last",
            "6;price_bidd",
            "7;price_askk",
            "8;volume_bid",
            "9;volume_ask",
            "10;price_medn",
            "11;price_mean",
            "12;price_mode",
            "13;buyy_price",
            "14;sell_price",
            "15;largTrdVol",
            "16;prcModeCnt",
            "17;vol_at_ask",
            "18;vol_no_chg",
            "19;vol_at_bid",
            "20;BidUpTicks",
            "21;BidDnTicks",
            "22;sale_count",
            "23;extIndex00",
            "24;extIndex01",
            "24;extIndex02",
            "24;extIndex03",
            "24;extIndex04",
            "24;extIndex05",
            "24;extIndex06",
            "24;extIndex07",
            "24;extIndex08"});
            this.comboBoxAttribToShow.Location = new System.Drawing.Point(3, 4);
            this.comboBoxAttribToShow.Name = "comboBoxAttribToShow";
            this.comboBoxAttribToShow.Size = new System.Drawing.Size(111, 21);
            this.comboBoxAttribToShow.TabIndex = 4;
            this.comboBoxAttribToShow.Text = "13;buyy_price";
            // 
            // btnAddSymbToChart
            // 
            this.btnAddSymbToChart.Location = new System.Drawing.Point(120, 3);
            this.btnAddSymbToChart.Name = "btnAddSymbToChart";
            this.btnAddSymbToChart.Size = new System.Drawing.Size(42, 21);
            this.btnAddSymbToChart.TabIndex = 3;
            this.btnAddSymbToChart.Text = "Add";
            this.btnAddSymbToChart.UseVisualStyleBackColor = true;
            this.btnAddSymbToChart.Click += new System.EventHandler(this.AddSymbToBrfChart);
            // 
            // chartBrfs
            // 
            chartArea1.AxisX.Interval = 4800D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartAreaPrice";
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartAreaVolume";
            this.chartBrfs.ChartAreas.Add(chartArea1);
            this.chartBrfs.ChartAreas.Add(chartArea2);
            this.chartBrfs.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartBrfs.Legends.Add(legend1);
            this.chartBrfs.Location = new System.Drawing.Point(0, 0);
            this.chartBrfs.Name = "chartBrfs";
            this.chartBrfs.Size = new System.Drawing.Size(813, 786);
            this.chartBrfs.TabIndex = 2;
            this.chartBrfs.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCodeChart);
            this.tabControl1.Controls.Add(this.tabPageCodeVisualizer);
            this.tabControl1.Controls.Add(this.tabPageStockChart);
            this.tabControl1.Controls.Add(this.tabPageBrfRawData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 818);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageCodeChart
            // 
            this.tabPageCodeChart.Controls.Add(this.splitContainer2);
            this.tabPageCodeChart.Location = new System.Drawing.Point(4, 22);
            this.tabPageCodeChart.Name = "tabPageCodeChart";
            this.tabPageCodeChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCodeChart.Size = new System.Drawing.Size(1106, 792);
            this.tabPageCodeChart.TabIndex = 1;
            this.tabPageCodeChart.Text = "Code Chart";
            this.tabPageCodeChart.UseVisualStyleBackColor = true;
            this.tabPageCodeChart.Enter += new System.EventHandler(this.tabPageCodeChart_Enter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewCodeUpdates);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.checkBoxShowAvg);
            this.splitContainer2.Panel2.Controls.Add(this.checkBoxShowRawScores);
            this.splitContainer2.Panel2.Controls.Add(this.checkBoxShowTradeCtOnChart);
            this.splitContainer2.Panel2.Controls.Add(this.btnDeleteCodeAboveSelected);
            this.splitContainer2.Panel2.Controls.Add(this.btnDeleteCodeBelowSelected);
            this.splitContainer2.Panel2.Controls.Add(this.btnSubmit);
            this.splitContainer2.Panel2.Controls.Add(this.btnDeleteAllCode);
            this.splitContainer2.Panel2.Controls.Add(this.btnRefreshCode);
            this.splitContainer2.Panel2.Controls.Add(this.chartCodeStats);
            this.splitContainer2.Size = new System.Drawing.Size(1100, 786);
            this.splitContainer2.SplitterDistance = 393;
            this.splitContainer2.TabIndex = 4;
            // 
            // dataGridViewCodeUpdates
            // 
            this.dataGridViewCodeUpdates.AllowUserToAddRows = false;
            this.dataGridViewCodeUpdates.AutoGenerateColumns = false;
            this.dataGridViewCodeUpdates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCodeUpdates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ideDataGridViewTextBoxColumn,
            this.brfVersionDataGridViewTextBoxColumn,
            this.totalTimeDataGridViewTextBoxColumn,
            this.addedDataGridViewTextBoxColumn,
            this.pROGDataGridViewTextBoxColumn,
            this.codeDataGridViewImageColumn,
            this.signalsDataGridViewTextBoxColumn,
            this.twkBitFlipCtDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.unTestedScoreDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.DisplayScore1,
            this.DisplayUnTestedScore,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.noChangeDetCtDataGridViewTextBoxColumn,
            this.keepWithSmallDegCtDataGridViewTextBoxColumn,
            this.degradeFloorCtDataGridViewTextBoxColumn,
            this.FailedMinTrdCtRuleCt,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.TrdCtAvg,
            this.Trd0Ct,
            this.Trd1Ct,
            this.Trd2Ct,
            this.Trd3Ct,
            this.Trd4Ct,
            this.Trd5Ct,
            this.Trd6Ct,
            this.Trd7Ct,
            this.MyScore0,
            this.MyScore1,
            this.MyScore2,
            this.MyScore3,
            this.MyScore4,
            this.MyScore5,
            this.MyScore6,
            this.MyScore7,
            this.MyScore8,
            this.MyScore9,
            this.MyScore10,
            this.MyScore11,
            this.MyScore12,
            this.MyScore13,
            this.MyScore14,
            this.MyScore15,
            this.MyScore16,
            this.MyScore17,
            this.MyScore18,
            this.MyScore19,
            this.MyScore20,
            this.MyScore21,
            this.MyScore22,
            this.MyScore23,
            this.MyScore24,
            this.MyScore25,
            this.MyScore26,
            this.MyScore27,
            this.MyScore28,
            this.MyScore29,
            this.MyScore30,
            this.MyScore31});
            this.dataGridViewCodeUpdates.DataSource = this.codeUpdatesBindingSource;
            this.dataGridViewCodeUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCodeUpdates.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCodeUpdates.Name = "dataGridViewCodeUpdates";
            this.dataGridViewCodeUpdates.RowHeadersWidth = 30;
            this.dataGridViewCodeUpdates.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCodeUpdates.Size = new System.Drawing.Size(1100, 393);
            this.dataGridViewCodeUpdates.TabIndex = 1;
            this.dataGridViewCodeUpdates.SelectionChanged += new System.EventHandler(this.dataGridViewCodeUpdates_SelectionChanged);
            // 
            // ideDataGridViewTextBoxColumn
            // 
            this.ideDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ideDataGridViewTextBoxColumn.DataPropertyName = "ide";
            this.ideDataGridViewTextBoxColumn.HeaderText = "ide";
            this.ideDataGridViewTextBoxColumn.Name = "ideDataGridViewTextBoxColumn";
            this.ideDataGridViewTextBoxColumn.ReadOnly = true;
            this.ideDataGridViewTextBoxColumn.Width = 5;
            // 
            // brfVersionDataGridViewTextBoxColumn
            // 
            this.brfVersionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.brfVersionDataGridViewTextBoxColumn.DataPropertyName = "brfVersion";
            this.brfVersionDataGridViewTextBoxColumn.HeaderText = "brfVersion";
            this.brfVersionDataGridViewTextBoxColumn.Name = "brfVersionDataGridViewTextBoxColumn";
            this.brfVersionDataGridViewTextBoxColumn.Width = 5;
            // 
            // totalTimeDataGridViewTextBoxColumn
            // 
            this.totalTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.totalTimeDataGridViewTextBoxColumn.DataPropertyName = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn.HeaderText = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn.Name = "totalTimeDataGridViewTextBoxColumn";
            this.totalTimeDataGridViewTextBoxColumn.Width = 5;
            // 
            // addedDataGridViewTextBoxColumn
            // 
            this.addedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.addedDataGridViewTextBoxColumn.DataPropertyName = "Added";
            this.addedDataGridViewTextBoxColumn.DividerWidth = 5;
            this.addedDataGridViewTextBoxColumn.HeaderText = "Added";
            this.addedDataGridViewTextBoxColumn.Name = "addedDataGridViewTextBoxColumn";
            this.addedDataGridViewTextBoxColumn.Width = 5;
            // 
            // pROGDataGridViewTextBoxColumn
            // 
            this.pROGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.pROGDataGridViewTextBoxColumn.DataPropertyName = "PROG";
            this.pROGDataGridViewTextBoxColumn.HeaderText = "PROG";
            this.pROGDataGridViewTextBoxColumn.Name = "pROGDataGridViewTextBoxColumn";
            this.pROGDataGridViewTextBoxColumn.Width = 5;
            // 
            // codeDataGridViewImageColumn
            // 
            this.codeDataGridViewImageColumn.DataPropertyName = "code";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.codeDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.codeDataGridViewImageColumn.HeaderText = "code";
            this.codeDataGridViewImageColumn.Name = "codeDataGridViewImageColumn";
            this.codeDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codeDataGridViewImageColumn.Width = 21;
            // 
            // signalsDataGridViewTextBoxColumn
            // 
            this.signalsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.signalsDataGridViewTextBoxColumn.DataPropertyName = "Signals";
            dataGridViewCellStyle2.Format = "X08";
            dataGridViewCellStyle2.NullValue = null;
            this.signalsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.signalsDataGridViewTextBoxColumn.DividerWidth = 5;
            this.signalsDataGridViewTextBoxColumn.HeaderText = "Signals";
            this.signalsDataGridViewTextBoxColumn.Name = "signalsDataGridViewTextBoxColumn";
            this.signalsDataGridViewTextBoxColumn.Width = 5;
            // 
            // twkBitFlipCtDataGridViewTextBoxColumn
            // 
            this.twkBitFlipCtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.twkBitFlipCtDataGridViewTextBoxColumn.DataPropertyName = "TwkBitFlipCt";
            this.twkBitFlipCtDataGridViewTextBoxColumn.DividerWidth = 5;
            this.twkBitFlipCtDataGridViewTextBoxColumn.HeaderText = "TwkBitFlipCt";
            this.twkBitFlipCtDataGridViewTextBoxColumn.Name = "twkBitFlipCtDataGridViewTextBoxColumn";
            this.twkBitFlipCtDataGridViewTextBoxColumn.Width = 5;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.Width = 75;
            // 
            // unTestedScoreDataGridViewTextBoxColumn
            // 
            this.unTestedScoreDataGridViewTextBoxColumn.DataPropertyName = "unTestedScore";
            this.unTestedScoreDataGridViewTextBoxColumn.HeaderText = "unTestedScore";
            this.unTestedScoreDataGridViewTextBoxColumn.Name = "unTestedScoreDataGridViewTextBoxColumn";
            this.unTestedScoreDataGridViewTextBoxColumn.Width = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "midEntryPointScore";
            this.dataGridViewTextBoxColumn1.HeaderText = "midEntryPointScore";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // DisplayScore1
            // 
            this.DisplayScore1.DataPropertyName = "DisplayScore";
            this.DisplayScore1.HeaderText = "DisplayScore";
            this.DisplayScore1.Name = "DisplayScore1";
            this.DisplayScore1.Width = 55;
            // 
            // DisplayUnTestedScore
            // 
            this.DisplayUnTestedScore.DataPropertyName = "DisplayUnTestedScore";
            this.DisplayUnTestedScore.DividerWidth = 5;
            this.DisplayUnTestedScore.HeaderText = "DisplayUnTestedScore";
            this.DisplayUnTestedScore.Name = "DisplayUnTestedScore";
            this.DisplayUnTestedScore.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RunCt";
            this.dataGridViewTextBoxColumn2.HeaderText = "RunCt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WinCt";
            this.dataGridViewTextBoxColumn3.HeaderText = "WinCt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CutOffCt";
            this.dataGridViewTextBoxColumn4.HeaderText = "CutOffCt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FailedReRunCt";
            this.dataGridViewTextBoxColumn5.HeaderText = "FailedReRunCt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 5;
            // 
            // noChangeDetCtDataGridViewTextBoxColumn
            // 
            this.noChangeDetCtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.noChangeDetCtDataGridViewTextBoxColumn.DataPropertyName = "NoChangeDetCt";
            this.noChangeDetCtDataGridViewTextBoxColumn.HeaderText = "NoChangeDetCt";
            this.noChangeDetCtDataGridViewTextBoxColumn.Name = "noChangeDetCtDataGridViewTextBoxColumn";
            this.noChangeDetCtDataGridViewTextBoxColumn.Width = 5;
            // 
            // keepWithSmallDegCtDataGridViewTextBoxColumn
            // 
            this.keepWithSmallDegCtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.keepWithSmallDegCtDataGridViewTextBoxColumn.DataPropertyName = "KeepWithSmallDegCt";
            this.keepWithSmallDegCtDataGridViewTextBoxColumn.HeaderText = "KeepWithSmallDegCt";
            this.keepWithSmallDegCtDataGridViewTextBoxColumn.Name = "keepWithSmallDegCtDataGridViewTextBoxColumn";
            this.keepWithSmallDegCtDataGridViewTextBoxColumn.Width = 5;
            // 
            // degradeFloorCtDataGridViewTextBoxColumn
            // 
            this.degradeFloorCtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.degradeFloorCtDataGridViewTextBoxColumn.DataPropertyName = "DegradeFloorCt";
            this.degradeFloorCtDataGridViewTextBoxColumn.HeaderText = "DegradeFloorCt";
            this.degradeFloorCtDataGridViewTextBoxColumn.Name = "degradeFloorCtDataGridViewTextBoxColumn";
            this.degradeFloorCtDataGridViewTextBoxColumn.Width = 5;
            // 
            // FailedMinTrdCtRuleCt
            // 
            this.FailedMinTrdCtRuleCt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FailedMinTrdCtRuleCt.DataPropertyName = "FailedMinTrdCtRuleCt";
            this.FailedMinTrdCtRuleCt.HeaderText = "FailedMinTrdCtRuleCt";
            this.FailedMinTrdCtRuleCt.Name = "FailedMinTrdCtRuleCt";
            this.FailedMinTrdCtRuleCt.Width = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cutoffs0";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cutoffs0";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cutoffs1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cutoffs1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cutoffs2";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cutoffs2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cutoffs3";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cutoffs3";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cutoffs4";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cutoffs4";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cutoffs5";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cutoffs5";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Cutoffs6";
            this.dataGridViewTextBoxColumn12.HeaderText = "Cutoffs6";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Cutoffs7";
            this.dataGridViewTextBoxColumn13.HeaderText = "Cutoffs7";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 50;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Cutoffs8";
            this.dataGridViewTextBoxColumn14.HeaderText = "Cutoffs8";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Cutoffs9";
            this.dataGridViewTextBoxColumn15.HeaderText = "Cutoffs9";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 50;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Cutoffs10";
            this.dataGridViewTextBoxColumn16.DividerWidth = 5;
            this.dataGridViewTextBoxColumn16.HeaderText = "Cutoffs10";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 50;
            // 
            // TrdCtAvg
            // 
            this.TrdCtAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.TrdCtAvg.DataPropertyName = "TrdCtAvg";
            this.TrdCtAvg.HeaderText = "TrdCtAvg";
            this.TrdCtAvg.Name = "TrdCtAvg";
            this.TrdCtAvg.Width = 5;
            // 
            // Trd0Ct
            // 
            this.Trd0Ct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Trd0Ct.DataPropertyName = "Trd0Ct";
            this.Trd0Ct.HeaderText = "Trd0Ct";
            this.Trd0Ct.Name = "Trd0Ct";
            this.Trd0Ct.Width = 5;
            // 
            // Trd1Ct
            // 
            this.Trd1Ct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Trd1Ct.DataPropertyName = "Trd1Ct";
            this.Trd1Ct.HeaderText = "Trd1Ct";
            this.Trd1Ct.Name = "Trd1Ct";
            this.Trd1Ct.Width = 5;
            // 
            // Trd2Ct
            // 
            this.Trd2Ct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Trd2Ct.DataPropertyName = "Trd2Ct";
            this.Trd2Ct.HeaderText = "Trd2Ct";
            this.Trd2Ct.Name = "Trd2Ct";
            this.Trd2Ct.Width = 5;
            // 
            // Trd3Ct
            // 
            this.Trd3Ct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Trd3Ct.DataPropertyName = "Trd3Ct";
            this.Trd3Ct.HeaderText = "Trd3Ct";
            this.Trd3Ct.Name = "Trd3Ct";
            this.Trd3Ct.Width = 5;
            // 
            // Trd4Ct
            // 
            this.Trd4Ct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Trd4Ct.DataPropertyName = "Trd4Ct";
            this.Trd4Ct.HeaderText = "Trd4Ct";
            this.Trd4Ct.Name = "Trd4Ct";
            this.Trd4Ct.Width = 5;
            // 
            // Trd5Ct
            // 
            this.Trd5Ct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Trd5Ct.DataPropertyName = "Trd5Ct";
            this.Trd5Ct.HeaderText = "Trd5Ct";
            this.Trd5Ct.Name = "Trd5Ct";
            this.Trd5Ct.Width = 5;
            // 
            // Trd6Ct
            // 
            this.Trd6Ct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Trd6Ct.DataPropertyName = "Trd6Ct";
            this.Trd6Ct.HeaderText = "Trd6Ct";
            this.Trd6Ct.Name = "Trd6Ct";
            this.Trd6Ct.Width = 5;
            // 
            // Trd7Ct
            // 
            this.Trd7Ct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Trd7Ct.DataPropertyName = "Trd7Ct";
            this.Trd7Ct.DividerWidth = 5;
            this.Trd7Ct.HeaderText = "Trd7Ct";
            this.Trd7Ct.Name = "Trd7Ct";
            this.Trd7Ct.Width = 5;
            // 
            // MyScore0
            // 
            this.MyScore0.DataPropertyName = "MyScore0";
            this.MyScore0.HeaderText = "MyScore0";
            this.MyScore0.Name = "MyScore0";
            // 
            // MyScore1
            // 
            this.MyScore1.DataPropertyName = "MyScore1";
            this.MyScore1.HeaderText = "MyScore1";
            this.MyScore1.Name = "MyScore1";
            // 
            // MyScore2
            // 
            this.MyScore2.DataPropertyName = "MyScore2";
            this.MyScore2.HeaderText = "MyScore2";
            this.MyScore2.Name = "MyScore2";
            // 
            // MyScore3
            // 
            this.MyScore3.DataPropertyName = "MyScore3";
            this.MyScore3.HeaderText = "MyScore3";
            this.MyScore3.Name = "MyScore3";
            // 
            // MyScore4
            // 
            this.MyScore4.DataPropertyName = "MyScore4";
            this.MyScore4.HeaderText = "MyScore4";
            this.MyScore4.Name = "MyScore4";
            // 
            // MyScore5
            // 
            this.MyScore5.DataPropertyName = "MyScore5";
            this.MyScore5.HeaderText = "MyScore5";
            this.MyScore5.Name = "MyScore5";
            // 
            // MyScore6
            // 
            this.MyScore6.DataPropertyName = "MyScore6";
            this.MyScore6.HeaderText = "MyScore6";
            this.MyScore6.Name = "MyScore6";
            // 
            // MyScore7
            // 
            this.MyScore7.DataPropertyName = "MyScore7";
            this.MyScore7.HeaderText = "MyScore7";
            this.MyScore7.Name = "MyScore7";
            // 
            // MyScore8
            // 
            this.MyScore8.DataPropertyName = "MyScore8";
            this.MyScore8.HeaderText = "MyScore8";
            this.MyScore8.Name = "MyScore8";
            // 
            // MyScore9
            // 
            this.MyScore9.DataPropertyName = "MyScore9";
            this.MyScore9.HeaderText = "MyScore9";
            this.MyScore9.Name = "MyScore9";
            // 
            // MyScore10
            // 
            this.MyScore10.DataPropertyName = "MyScore10";
            this.MyScore10.HeaderText = "MyScore10";
            this.MyScore10.Name = "MyScore10";
            // 
            // MyScore11
            // 
            this.MyScore11.DataPropertyName = "MyScore11";
            this.MyScore11.HeaderText = "MyScore11";
            this.MyScore11.Name = "MyScore11";
            // 
            // MyScore12
            // 
            this.MyScore12.DataPropertyName = "MyScore12";
            this.MyScore12.HeaderText = "MyScore12";
            this.MyScore12.Name = "MyScore12";
            // 
            // MyScore13
            // 
            this.MyScore13.DataPropertyName = "MyScore13";
            this.MyScore13.HeaderText = "MyScore13";
            this.MyScore13.Name = "MyScore13";
            // 
            // MyScore14
            // 
            this.MyScore14.DataPropertyName = "MyScore14";
            this.MyScore14.HeaderText = "MyScore14";
            this.MyScore14.Name = "MyScore14";
            // 
            // MyScore15
            // 
            this.MyScore15.DataPropertyName = "MyScore15";
            this.MyScore15.HeaderText = "MyScore15";
            this.MyScore15.Name = "MyScore15";
            // 
            // MyScore16
            // 
            this.MyScore16.DataPropertyName = "MyScore16";
            this.MyScore16.HeaderText = "MyScore16";
            this.MyScore16.Name = "MyScore16";
            // 
            // MyScore17
            // 
            this.MyScore17.DataPropertyName = "MyScore17";
            this.MyScore17.HeaderText = "MyScore17";
            this.MyScore17.Name = "MyScore17";
            // 
            // MyScore18
            // 
            this.MyScore18.DataPropertyName = "MyScore18";
            this.MyScore18.HeaderText = "MyScore18";
            this.MyScore18.Name = "MyScore18";
            // 
            // MyScore19
            // 
            this.MyScore19.DataPropertyName = "MyScore19";
            this.MyScore19.HeaderText = "MyScore19";
            this.MyScore19.Name = "MyScore19";
            // 
            // MyScore20
            // 
            this.MyScore20.DataPropertyName = "MyScore20";
            this.MyScore20.HeaderText = "MyScore20";
            this.MyScore20.Name = "MyScore20";
            // 
            // MyScore21
            // 
            this.MyScore21.DataPropertyName = "MyScore21";
            this.MyScore21.HeaderText = "MyScore21";
            this.MyScore21.Name = "MyScore21";
            // 
            // MyScore22
            // 
            this.MyScore22.DataPropertyName = "MyScore22";
            this.MyScore22.HeaderText = "MyScore22";
            this.MyScore22.Name = "MyScore22";
            // 
            // MyScore23
            // 
            this.MyScore23.DataPropertyName = "MyScore23";
            this.MyScore23.HeaderText = "MyScore23";
            this.MyScore23.Name = "MyScore23";
            // 
            // MyScore24
            // 
            this.MyScore24.DataPropertyName = "MyScore24";
            this.MyScore24.HeaderText = "MyScore24";
            this.MyScore24.Name = "MyScore24";
            // 
            // MyScore25
            // 
            this.MyScore25.DataPropertyName = "MyScore25";
            this.MyScore25.HeaderText = "MyScore25";
            this.MyScore25.Name = "MyScore25";
            // 
            // MyScore26
            // 
            this.MyScore26.DataPropertyName = "MyScore26";
            this.MyScore26.HeaderText = "MyScore26";
            this.MyScore26.Name = "MyScore26";
            // 
            // MyScore27
            // 
            this.MyScore27.DataPropertyName = "MyScore27";
            this.MyScore27.HeaderText = "MyScore27";
            this.MyScore27.Name = "MyScore27";
            // 
            // MyScore28
            // 
            this.MyScore28.DataPropertyName = "MyScore28";
            this.MyScore28.HeaderText = "MyScore28";
            this.MyScore28.Name = "MyScore28";
            // 
            // MyScore29
            // 
            this.MyScore29.DataPropertyName = "MyScore29";
            this.MyScore29.HeaderText = "MyScore29";
            this.MyScore29.Name = "MyScore29";
            // 
            // MyScore30
            // 
            this.MyScore30.DataPropertyName = "MyScore30";
            this.MyScore30.HeaderText = "MyScore30";
            this.MyScore30.Name = "MyScore30";
            // 
            // MyScore31
            // 
            this.MyScore31.DataPropertyName = "MyScore31";
            this.MyScore31.HeaderText = "MyScore31";
            this.MyScore31.Name = "MyScore31";
            // 
            // codeUpdatesBindingSource
            // 
            this.codeUpdatesBindingSource.DataMember = "CodeUpdates";
            this.codeUpdatesBindingSource.DataSource = this.focusDataSet;
            // 
            // focusDataSet
            // 
            this.focusDataSet.DataSetName = "FocusDataSet";
            this.focusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxShowAvg
            // 
            this.checkBoxShowAvg.AutoSize = true;
            this.checkBoxShowAvg.Location = new System.Drawing.Point(212, 3);
            this.checkBoxShowAvg.Name = "checkBoxShowAvg";
            this.checkBoxShowAvg.Size = new System.Drawing.Size(45, 17);
            this.checkBoxShowAvg.TabIndex = 10;
            this.checkBoxShowAvg.Text = "Avg";
            this.checkBoxShowAvg.UseVisualStyleBackColor = true;
            this.checkBoxShowAvg.CheckedChanged += new System.EventHandler(this.checkBoxShowAvgScores_CheckedChanged);
            // 
            // checkBoxShowRawScores
            // 
            this.checkBoxShowRawScores.AutoSize = true;
            this.checkBoxShowRawScores.Location = new System.Drawing.Point(122, 3);
            this.checkBoxShowRawScores.Name = "checkBoxShowRawScores";
            this.checkBoxShowRawScores.Size = new System.Drawing.Size(84, 17);
            this.checkBoxShowRawScores.TabIndex = 10;
            this.checkBoxShowRawScores.Text = "Raw Scores";
            this.checkBoxShowRawScores.UseVisualStyleBackColor = true;
            this.checkBoxShowRawScores.CheckedChanged += new System.EventHandler(this.checkBoxShowRawScores_CheckedChanged);
            // 
            // checkBoxShowTradeCtOnChart
            // 
            this.checkBoxShowTradeCtOnChart.AutoSize = true;
            this.checkBoxShowTradeCtOnChart.Location = new System.Drawing.Point(5, 3);
            this.checkBoxShowTradeCtOnChart.Name = "checkBoxShowTradeCtOnChart";
            this.checkBoxShowTradeCtOnChart.Size = new System.Drawing.Size(94, 17);
            this.checkBoxShowTradeCtOnChart.TabIndex = 9;
            this.checkBoxShowTradeCtOnChart.Text = "Show TradeCt";
            this.checkBoxShowTradeCtOnChart.UseVisualStyleBackColor = true;
            this.checkBoxShowTradeCtOnChart.CheckedChanged += new System.EventHandler(this.checkBoxShowTradeCtOnChart_CheckedChanged);
            // 
            // btnDeleteCodeAboveSelected
            // 
            this.btnDeleteCodeAboveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCodeAboveSelected.Location = new System.Drawing.Point(960, 179);
            this.btnDeleteCodeAboveSelected.Name = "btnDeleteCodeAboveSelected";
            this.btnDeleteCodeAboveSelected.Size = new System.Drawing.Size(101, 35);
            this.btnDeleteCodeAboveSelected.TabIndex = 8;
            this.btnDeleteCodeAboveSelected.Text = "Delete Before Selected";
            this.btnDeleteCodeAboveSelected.UseVisualStyleBackColor = true;
            this.btnDeleteCodeAboveSelected.Click += new System.EventHandler(this.btnDeleteCodeBeforeSelected_Click);
            // 
            // btnDeleteCodeBelowSelected
            // 
            this.btnDeleteCodeBelowSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCodeBelowSelected.Location = new System.Drawing.Point(960, 220);
            this.btnDeleteCodeBelowSelected.Name = "btnDeleteCodeBelowSelected";
            this.btnDeleteCodeBelowSelected.Size = new System.Drawing.Size(101, 35);
            this.btnDeleteCodeBelowSelected.TabIndex = 7;
            this.btnDeleteCodeBelowSelected.Text = "Delete After Selected";
            this.btnDeleteCodeBelowSelected.UseVisualStyleBackColor = true;
            this.btnDeleteCodeBelowSelected.Click += new System.EventHandler(this.btnDeleteCodeAfterSelected_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(960, 343);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 35);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDeleteAllCode
            // 
            this.btnDeleteAllCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAllCode.Location = new System.Drawing.Point(960, 261);
            this.btnDeleteAllCode.Name = "btnDeleteAllCode";
            this.btnDeleteAllCode.Size = new System.Drawing.Size(101, 35);
            this.btnDeleteAllCode.TabIndex = 5;
            this.btnDeleteAllCode.Text = "Delete All";
            this.btnDeleteAllCode.UseVisualStyleBackColor = true;
            this.btnDeleteAllCode.Click += new System.EventHandler(this.btnWipeCode_Click);
            // 
            // btnRefreshCode
            // 
            this.btnRefreshCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshCode.Location = new System.Drawing.Point(960, 302);
            this.btnRefreshCode.Name = "btnRefreshCode";
            this.btnRefreshCode.Size = new System.Drawing.Size(101, 35);
            this.btnRefreshCode.TabIndex = 4;
            this.btnRefreshCode.Text = "Refresh";
            this.btnRefreshCode.UseVisualStyleBackColor = true;
            this.btnRefreshCode.Click += new System.EventHandler(this.RefreshCodeUpdates);
            // 
            // chartCodeStats
            // 
            this.chartCodeStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.ScaleView.SmallScrollMinSize = 0D;
            chartArea3.AxisX2.ScaleView.SmallScrollMinSize = 0D;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.ScaleView.SmallScrollMinSize = 0D;
            chartArea3.AxisY2.IsStartedFromZero = false;
            chartArea3.AxisY2.ScaleView.SmallScrollMinSize = 0D;
            chartArea3.CursorX.Interval = 0.01D;
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.CursorY.Interval = 0.01D;
            chartArea3.CursorY.IsUserEnabled = true;
            chartArea3.CursorY.IsUserSelectionEnabled = true;
            chartArea3.Name = "ChartAreaPrice";
            this.chartCodeStats.ChartAreas.Add(chartArea3);
            this.chartCodeStats.DataSource = this.codeUpdatesBindingSource;
            legend2.Name = "Legend1";
            this.chartCodeStats.Legends.Add(legend2);
            this.chartCodeStats.Location = new System.Drawing.Point(0, 21);
            this.chartCodeStats.Margin = new System.Windows.Forms.Padding(1);
            this.chartCodeStats.Name = "chartCodeStats";
            this.chartCodeStats.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartAreaPrice";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Enabled = false;
            series1.Legend = "Legend1";
            series1.Name = "unTestedScore";
            series1.ToolTip = "unTestedScore";
            series1.XValueMember = "TotalTime";
            series1.YValueMembers = "unTestedScore";
            series2.ChartArea = "ChartAreaPrice";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Enabled = false;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 3;
            series2.Name = "score";
            series2.ToolTip = "score";
            series2.XValueMember = "TotalTime";
            series2.YValueMembers = "score";
            series3.ChartArea = "ChartAreaPrice";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "DispUnTested";
            series3.ToolTip = "DisplayUnTestedScore";
            series3.XValueMember = "TotalTime";
            series3.YValueMembers = "DisplayUnTestedScore";
            series4.ChartArea = "ChartAreaPrice";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "DisplayScore";
            series4.ToolTip = "DisplayScore";
            series4.XValueMember = "TotalTime";
            series4.YValueMembers = "DisplayScore";
            series5.ChartArea = "ChartAreaPrice";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Enabled = false;
            series5.Legend = "Legend1";
            series5.Name = "AvgTradeCt";
            series5.ToolTip = "AvgTradeCt";
            series5.XValueMember = "TotalTime";
            series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series5.YValueMembers = "TrdCtAvg";
            this.chartCodeStats.Series.Add(series1);
            this.chartCodeStats.Series.Add(series2);
            this.chartCodeStats.Series.Add(series3);
            this.chartCodeStats.Series.Add(series4);
            this.chartCodeStats.Series.Add(series5);
            this.chartCodeStats.Size = new System.Drawing.Size(1100, 368);
            this.chartCodeStats.TabIndex = 2;
            this.chartCodeStats.Text = "chartCodeStats";
            // 
            // tabPageCodeVisualizer
            // 
            this.tabPageCodeVisualizer.Controls.Add(this.pictureBox1);
            this.tabPageCodeVisualizer.Controls.Add(this.panel3);
            this.tabPageCodeVisualizer.Location = new System.Drawing.Point(4, 22);
            this.tabPageCodeVisualizer.Name = "tabPageCodeVisualizer";
            this.tabPageCodeVisualizer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCodeVisualizer.Size = new System.Drawing.Size(1106, 792);
            this.tabPageCodeVisualizer.TabIndex = 2;
            this.tabPageCodeVisualizer.Text = "Code Visualizer";
            this.tabPageCodeVisualizer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCurrentCord);
            this.panel3.Controls.Add(this.numericUpDownCodeVisualizer);
            this.panel3.Controls.Add(this.checkBoxLockForChangeHeatMap);
            this.panel3.Controls.Add(this.lblCodeViewerOnes);
            this.panel3.Controls.Add(this.checkBoxLockForImageDiff);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 663);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 126);
            this.panel3.TabIndex = 7;
            // 
            // lblCurrentCord
            // 
            this.lblCurrentCord.AutoSize = true;
            this.lblCurrentCord.Location = new System.Drawing.Point(384, 29);
            this.lblCurrentCord.Name = "lblCurrentCord";
            this.lblCurrentCord.Size = new System.Drawing.Size(105, 13);
            this.lblCurrentCord.TabIndex = 7;
            this.lblCurrentCord.Text = "(mouse over to view)";
            // 
            // numericUpDownCodeVisualizer
            // 
            this.numericUpDownCodeVisualizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCodeVisualizer.Location = new System.Drawing.Point(26, 10);
            this.numericUpDownCodeVisualizer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCodeVisualizer.Name = "numericUpDownCodeVisualizer";
            this.numericUpDownCodeVisualizer.Size = new System.Drawing.Size(119, 32);
            this.numericUpDownCodeVisualizer.TabIndex = 3;
            this.numericUpDownCodeVisualizer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCodeVisualizer.ValueChanged += new System.EventHandler(this.CodeVisualizer_UP_DOWN);
            // 
            // checkBoxLockForChangeHeatMap
            // 
            this.checkBoxLockForChangeHeatMap.AutoSize = true;
            this.checkBoxLockForChangeHeatMap.Location = new System.Drawing.Point(163, 28);
            this.checkBoxLockForChangeHeatMap.Name = "checkBoxLockForChangeHeatMap";
            this.checkBoxLockForChangeHeatMap.Size = new System.Drawing.Size(151, 17);
            this.checkBoxLockForChangeHeatMap.TabIndex = 6;
            this.checkBoxLockForChangeHeatMap.Text = "Lock for change heat map";
            this.checkBoxLockForChangeHeatMap.UseVisualStyleBackColor = true;
            // 
            // lblCodeViewerOnes
            // 
            this.lblCodeViewerOnes.AutoSize = true;
            this.lblCodeViewerOnes.Location = new System.Drawing.Point(384, 11);
            this.lblCodeViewerOnes.Name = "lblCodeViewerOnes";
            this.lblCodeViewerOnes.Size = new System.Drawing.Size(99, 13);
            this.lblCodeViewerOnes.TabIndex = 4;
            this.lblCodeViewerOnes.Text = "lblCodeViewerOnes";
            // 
            // checkBoxLockForImageDiff
            // 
            this.checkBoxLockForImageDiff.AutoSize = true;
            this.checkBoxLockForImageDiff.Location = new System.Drawing.Point(163, 10);
            this.checkBoxLockForImageDiff.Name = "checkBoxLockForImageDiff";
            this.checkBoxLockForImageDiff.Size = new System.Drawing.Size(115, 17);
            this.checkBoxLockForImageDiff.TabIndex = 5;
            this.checkBoxLockForImageDiff.Text = "Lock for image Diff";
            this.checkBoxLockForImageDiff.UseVisualStyleBackColor = true;
            // 
            // tabPageStockChart
            // 
            this.tabPageStockChart.BackColor = System.Drawing.Color.Transparent;
            this.tabPageStockChart.Controls.Add(this.splitContainer1);
            this.tabPageStockChart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageStockChart.Location = new System.Drawing.Point(4, 22);
            this.tabPageStockChart.Name = "tabPageStockChart";
            this.tabPageStockChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStockChart.Size = new System.Drawing.Size(1106, 792);
            this.tabPageStockChart.TabIndex = 0;
            this.tabPageStockChart.Text = "Stock Chart";
            // 
            // tabPageBrfRawData
            // 
            this.tabPageBrfRawData.Controls.Add(this.dataGridViewRawBriefs);
            this.tabPageBrfRawData.Controls.Add(this.panel2);
            this.tabPageBrfRawData.Location = new System.Drawing.Point(4, 22);
            this.tabPageBrfRawData.Name = "tabPageBrfRawData";
            this.tabPageBrfRawData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBrfRawData.Size = new System.Drawing.Size(1106, 792);
            this.tabPageBrfRawData.TabIndex = 3;
            this.tabPageBrfRawData.Text = "Brief Raw Data";
            this.tabPageBrfRawData.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRawBriefs
            // 
            this.dataGridViewRawBriefs.AllowUserToAddRows = false;
            this.dataGridViewRawBriefs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRawBriefs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRawBriefs.ColumnHeadersHeight = 33;
            this.dataGridViewRawBriefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRawBriefs.Location = new System.Drawing.Point(3, 39);
            this.dataGridViewRawBriefs.Name = "dataGridViewRawBriefs";
            this.dataGridViewRawBriefs.ReadOnly = true;
            this.dataGridViewRawBriefs.Size = new System.Drawing.Size(1100, 750);
            this.dataGridViewRawBriefs.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFillBriefRawDataTable);
            this.panel2.Controls.Add(this.numericUpDownStartRow);
            this.panel2.Controls.Add(this.numericUpDownStartCol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 36);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Row Offset:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Col Offset:";
            // 
            // btnFillBriefRawDataTable
            // 
            this.btnFillBriefRawDataTable.Location = new System.Drawing.Point(5, 6);
            this.btnFillBriefRawDataTable.Name = "btnFillBriefRawDataTable";
            this.btnFillBriefRawDataTable.Size = new System.Drawing.Size(77, 26);
            this.btnFillBriefRawDataTable.TabIndex = 13;
            this.btnFillBriefRawDataTable.Text = "Fill Grid";
            this.btnFillBriefRawDataTable.UseVisualStyleBackColor = true;
            this.btnFillBriefRawDataTable.Click += new System.EventHandler(this.btnFillBriefRawDataTable_Click);
            // 
            // numericUpDownStartRow
            // 
            this.numericUpDownStartRow.AutoSize = true;
            this.numericUpDownStartRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStartRow.Increment = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownStartRow.Location = new System.Drawing.Point(428, 6);
            this.numericUpDownStartRow.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownStartRow.Name = "numericUpDownStartRow";
            this.numericUpDownStartRow.Size = new System.Drawing.Size(115, 26);
            this.numericUpDownStartRow.TabIndex = 12;
            this.numericUpDownStartRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownStartRow.ValueChanged += new System.EventHandler(this.btnFillBriefRawDataTable_Click);
            // 
            // numericUpDownStartCol
            // 
            this.numericUpDownStartCol.AutoSize = true;
            this.numericUpDownStartCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStartCol.Increment = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownStartCol.Location = new System.Drawing.Point(189, 6);
            this.numericUpDownStartCol.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numericUpDownStartCol.Name = "numericUpDownStartCol";
            this.numericUpDownStartCol.Size = new System.Drawing.Size(112, 26);
            this.numericUpDownStartCol.TabIndex = 11;
            this.numericUpDownStartCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownStartCol.ValueChanged += new System.EventHandler(this.btnFillBriefRawDataTable_Click);
            // 
            // codeUpdatesTableAdapter
            // 
            this.codeUpdatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 818);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Brief Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDownloadCt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBrfs)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCodeChart.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCodeUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeUpdatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCodeStats)).EndInit();
            this.tabPageCodeVisualizer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCodeVisualizer)).EndInit();
            this.tabPageStockChart.ResumeLayout(false);
            this.tabPageBrfRawData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRawBriefs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartCol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBrfs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStockChart;
        private System.Windows.Forms.TabPage tabPageCodeChart;
        private System.Windows.Forms.Button btnAddSymbToChart;
        private System.Windows.Forms.TabPage tabPageCodeVisualizer;
        private System.Windows.Forms.NumericUpDown numericUpDownCodeVisualizer;
        private System.Windows.Forms.Label lblCodeViewerOnes;
        private System.Windows.Forms.ComboBox comboBoxAttribToShow;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.Button btnDownloadAllBriefs;
        private System.Windows.Forms.ListBox listBoxSymbols;
        private System.Windows.Forms.TabPage tabPageBrfRawData;
        private System.Windows.Forms.DataGridView dataGridViewRawBriefs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFillBriefRawDataTable;
        private System.Windows.Forms.NumericUpDown numericUpDownStartRow;
        private System.Windows.Forms.NumericUpDown numericUpDownStartCol;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewCodeUpdates;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCodeStats;
        private FocusDataSet focusDataSet;
        private System.Windows.Forms.BindingSource codeUpdatesBindingSource;
        private FocusDataSetTableAdapters.CodeUpdatesTableAdapter codeUpdatesTableAdapter;
        private System.Windows.Forms.Button btnDeleteAllCode;
        private System.Windows.Forms.Button btnRefreshCode;
        private System.Windows.Forms.CheckBox checkBoxLockForImageDiff;
        private System.Windows.Forms.CheckBox checkBoxLockForChangeHeatMap;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDeleteCodeBelowSelected;
        private System.Windows.Forms.Button btnDeleteCodeAboveSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brfVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn signalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twkBitFlipCtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unTestedScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayScore1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayUnTestedScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChangeDetCtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keepWithSmallDegCtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degradeFloorCtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailedMinTrdCtRuleCt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrdCtAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trd0Ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trd1Ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trd2Ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trd3Ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trd4Ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trd5Ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trd6Ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trd7Ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore0;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore12;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore13;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore14;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore15;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore16;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore17;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore18;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore19;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore20;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore21;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore22;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore23;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore24;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore25;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore26;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore27;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore28;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore29;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore30;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyScore31;
        private System.Windows.Forms.CheckBox checkBoxShowTradeCtOnChart;
        private System.Windows.Forms.CheckBox checkBoxShowRawScores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCurrentCord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxShowAvg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDownloadCt;
    }
}

