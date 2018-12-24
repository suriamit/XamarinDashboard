using System;
using System.Collections.Generic;
using Microcharts;

namespace Dashboard.DataStore
{
    public class DataManager
    {
        public DataManager()
        {
        }

        internal static List<Entry> GetOSList()
        {
            return
                new List<Entry>
            {
                new Entry(200) {
                    Color = SkiaSharp.SKColor.Parse("#FF1493"),
                    Label = "Windows 7",
                    ValueLabel = "44953"
                },
                new Entry(100) {
                    Color = SkiaSharp.SKColor.Parse("#00BFFF"),
                    Label = "Windows 10",
                    ValueLabel = "13003"
                },
                new Entry(150) {
                    Color = SkiaSharp.SKColor.Parse("#00CED1"),
                    Label = "Windows 2008",
                    ValueLabel = "3995"
                }
            };
        }

        internal static List<Entry> GetDesktopList()
        {
            return
                new List<Entry>
            {
                new Entry(44939) {
                    Color = SkiaSharp.SKColor.Parse("#FF1493"),
                    Label = "Physical Desktop",
                    ValueLabel = "44939"
                },
                new Entry(13706) {
                    Color = SkiaSharp.SKColor.Parse("#00BFFF"),
                    Label = "Laptop",
                    ValueLabel = "13706"
                },
                new Entry(4202) {
                    Color = SkiaSharp.SKColor.Parse("#00CED1"),
                    Label = "Virtual Desktop",
                    ValueLabel = "4202"
                }
            };
        }

        internal static List<Entry> GetBrowserList()
        {
            return
                new List<Entry>
            {
                new Entry(44939) {
                    Color = SkiaSharp.SKColor.Parse("#FF1493"),
                    Label = "IE11",
                    ValueLabel = "65110"
                },
                new Entry(13706) {
                    Color = SkiaSharp.SKColor.Parse("#00BFFF"),
                    Label = "Chrome",
                    ValueLabel = "43429"
                },
                new Entry(4202) {
                    Color = SkiaSharp.SKColor.Parse("#2c3e50"),
                    Label = "IE10",
                    ValueLabel = "24"
                }
            };
        }

        internal static List<Entry> GetComplianceTrends()
        {
            return
                new List<Entry>
            {
                new Entry(93) {
                    Color = SkiaSharp.SKColor.Parse("#FF1493"),
                    Label = "Mon",
                    ValueLabel = "93%"
                },
                new Entry(92) {
                    Color = SkiaSharp.SKColor.Parse("#00BFFF"),
                    Label = "Tue",
                    ValueLabel = "92.5%"
                },
                new Entry(96) {
                    Color = SkiaSharp.SKColor.Parse("#3498db"),
                    Label = "Wed",
                    ValueLabel = "96%"
                },
                new Entry(94) {
                    Color = SkiaSharp.SKColor.Parse("#77d065"),
                    Label = "Thu",
                    ValueLabel = "94%"
                },
                new Entry(95) {
                    Color = SkiaSharp.SKColor.Parse("#b455b6"),
                    Label = "Fri",
                    ValueLabel = "95%"
                }
            };
        }
    }
}
