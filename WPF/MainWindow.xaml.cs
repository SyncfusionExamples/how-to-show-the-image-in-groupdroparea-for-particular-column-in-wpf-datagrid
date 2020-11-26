using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using System.ComponentModel;
using Syncfusion.UI.Xaml.Grid.Cells;

namespace CaptionSummaryCustomization
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            datagrid.ExpandAllGroup();           
        }
    }

    internal class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (value as Group).Key.ToString();
            string img = null;
            if(val == "Male")
                return img =  "Image/add.png" ;
            else
                return img = "Image/folder.png";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }       
    }

    public class SortDirectionToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Visibility.Collapsed;

            var direction = (ListSortDirection)value;
            if (parameter.ToString().Equals("Ascending"))
            {
                if (direction == ListSortDirection.Ascending)
                    return Visibility.Visible;
                return Visibility.Collapsed;
            }
            else
            {
                if (direction == ListSortDirection.Descending)
                    return Visibility.Visible;
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
