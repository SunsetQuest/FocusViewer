using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace BriefConfig
{
    public struct  AttribSpec
    {
        /// <summary>
        /// The stock Symbol. (aka Ticker)
        /// </summary>
        public string Symbol;

        /// <summary>
        /// For Charting, Determines what axis to plot values on. 
        /// True=Left Side Stock Values, False= Right Side Volume Prices
        /// </summary>
        public bool UseLeftAxis;

        /// <summary>
        /// For charting (line or bar)
        /// </summary>
        public SeriesChartType ChartType; 
    }
    
    /// <summary>
    /// Contains a static read-only list of the attribute and their configuration.
    /// </summary>
    public static class BrfConfig
    {
        public static readonly List<AttribSpec> AttribSpecs = new List<AttribSpec>{
        new AttribSpec() { Symbol = "volume_day", UseLeftAxis=false, ChartType=SeriesChartType.Line  },
        new AttribSpec() { Symbol = "volume_ths", UseLeftAxis=true, ChartType=SeriesChartType.Column },
        new AttribSpec() { Symbol = "largTrdPrc", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "price_high", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "price_loww", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "price_last", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "price_bidd", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "price_askk", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "volume_bid", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "volume_ask", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "price_medn", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "price_mean", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "price_mode", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "buyy_price", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "sell_price", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "largTrdVol", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "prcModeCnt", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "vol_at_ask", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "vol_no_chg", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "vol_at_bid", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "BidUpTicks", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "BidDnTicks", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "sale_count", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "extIndex00", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "extIndex01", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "extIndex02", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "extIndex03", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "extIndex04", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "extIndex05", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "extIndex06", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "extIndex07", UseLeftAxis=true, ChartType=SeriesChartType.Line   },
        new AttribSpec() { Symbol = "extIndex08", UseLeftAxis=true, ChartType=SeriesChartType.Line   }};
    }
}