using Microcharts;
using Prism.Commands;
using Prism.Mvvm;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Ontap.ViewModels
{
    public class AboutViewModel : BindableBase
    {
        public Chart ChartData { get; set; }

        public Chart PerformanceChart => new RadialGaugeChart()
        {
            Entries = new[]
            {
             new Microcharts.Entry(25)
             {
                Color = SKColors.Transparent,
             },
             new Microcharts.Entry(10)
             {
                Color = SKColor.Parse("#1cb31a"),
             }},
            BackgroundColor = SKColors.Transparent

        };

        public AboutViewModel()
        {
            ChartData = PerformanceChart;
        }
    }
}
