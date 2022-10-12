﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class gridlayout1 : ContentPage
    {
        public gridlayout1()
        {
            InitializeComponent();
            //Create gridlayout with 8 row / 8 column
            InitializationGridLayout(8, 8);
        }

        private void InitializationGridLayout(int row, int col)
        {
            Grid layout = new Grid
            {
                RowSpacing = 0,
                ColumnSpacing = 0,

                RowDefinitions =
                {
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)}
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width= new GridLength(1, GridUnitType.Star)}
                }
            };

            bool flag = true;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (flag)
                    {
                        layout.Children.Add(new BoxView { Color = Color.Red }, j, i);
                    }
                    else
                    {
                        layout.Children.Add(new BoxView { Color = Color.Blue }, j, i);
                    }
                    flag = !flag;
                }
                if (col % 2 == 0)
                {
                    flag = !flag;
                }
            }
            Content = layout;
        }
    }
}