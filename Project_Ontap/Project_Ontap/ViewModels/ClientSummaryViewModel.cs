﻿using Microcharts;
using Prism.Commands;
using Prism.Mvvm;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Ontap.ViewModels
{
	public class ClientSummaryViewModel : BindableBase
	{

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

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

        public ClientSummaryViewModel()
        {
            Username = App.Current.Properties["Email"].ToString();
            ChartData = PerformanceChart;
        }
	}
}
