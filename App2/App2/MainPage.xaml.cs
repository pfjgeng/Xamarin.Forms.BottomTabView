﻿using System.Collections.Generic;
using Xamarin.Forms;

using DuGu.XFLib.Controls;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        List<TabViewChildren> Childrens;
        public MainPage()
        {
            InitializeComponent();
            Childrens = new List<TabViewChildren>()
            {
                new TabViewChildren(){UnSelectImageSource = "" },
                new TabViewChildren(){UnSelectImageSource = ""  },
                new TabViewChildren(){UnSelectImageSource = ""  },
            };
            tabView.AddChildrenViews(Childrens);
            tabView.SelectedChanged += tabView_SelectedChanged;
        }

        private void tabView_SelectedChanged(object sender, TabViewChangedEventArgs e)
        {
            Color color = Color.White;
            switch (e.Index)
            {
                case 0: color = Color.Black; break;
                case 1: color = Color.Red; break;
                case 2: color = Color.Blue; break;
            }
            var view = e.View;
            view.BackgroundColor = color;
            Title = e.Index.ToString();
        }
    }
}
