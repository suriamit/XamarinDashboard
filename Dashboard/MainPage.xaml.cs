using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.DataStore;
using Microcharts;
using Xamarin.Forms;
using Entry = Microcharts.Entry;

namespace Dashboard
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            chartOS.Chart = new RadialGaugeChart
            {
                Entries = DataManager.GetOSList(),
                LabelTextSize = 12
            };
            chart3.Chart = new BarChart { 
                Entries = DataManager.GetDesktopList(),
                PointSize = 4,
                LabelTextSize = 12
            };
            chart4.Chart = new DonutChart { Entries = DataManager.GetBrowserList() };


            chartBit9.Chart = new PointChart { Entries = DataManager.GetComplianceTrends() };
            chartMcAfee.Chart = new RadarChart { Entries = DataManager.GetComplianceTrends() };
            chartTanium.Chart = new LineChart
            {
                Entries = DataManager.GetComplianceTrends(),
                LineSize = 4,
                PointSize = 4,
                LabelTextSize = 12

            };
        }
    }
}
