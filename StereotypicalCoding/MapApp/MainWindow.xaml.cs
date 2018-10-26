using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.UI.GeoAnalysis;
using MapApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MapApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            

           
        }

        private void MapViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            PointsViewModel myPointsViewModel = new PointsViewModel();

            myPointsViewModel.LoadPoints();

            MyMapViewControl.DataContext = myPointsViewModel;
            MyMapViewControl.CreateOverlay(myPointsViewModel.Points);
        }


    }
}
