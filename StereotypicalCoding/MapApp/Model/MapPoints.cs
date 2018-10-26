using Esri.ArcGISRuntime.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapApp.Model
{
    class MapPointsModel
    {
    }

    public class MyMapPoint : INotifyPropertyChanged
    {
        
        private double lat;
        private double longe;

        public MapPoint SDKMapPoint { get; set; }
        

        
        public double Lat
        {
            get
            {
                return lat;
            }
            set
            {
                if (lat != value)
                {
                    lat = value;
                    RaisePropertyChanged("Lat");
                    
                }
            }
        }

        public double Longe
        {
            get { return longe; }

            set
            {
                if (longe != value)
                {
                    longe = value;
                    RaisePropertyChanged("Longe");
                    
                }
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
