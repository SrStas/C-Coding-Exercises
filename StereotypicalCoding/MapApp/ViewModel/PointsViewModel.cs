using Esri.ArcGISRuntime.Geometry;
using MapApp.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace MapApp.ViewModel
{
    class PointsViewModel
    {


        public Dictionary<double, MyMapPoint> Points
        {
            get;
            set;
        }

        public void LoadPoints()
        {
            Dictionary<double, MyMapPoint> mapPoints = new Dictionary<double, MyMapPoint>();

            StreamReader reader = new StreamReader(File.OpenRead(@"wpf_map_excersize.txt"));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    if (values.Length >= 3)
                    {
                        double pointKey = double.Parse(values[0]);
                        if (mapPoints.ContainsKey(pointKey))
                        {
                            // the key alredy exists
                        }
                        else
                        {
                           
                            
                            mapPoints.Add(pointKey, new MyMapPoint { SDKMapPoint = new MapPoint( double.Parse(values[1]), double.Parse(values[2]),SpatialReferences.WebMercator), Lat = double.Parse(values[1]), Longe = double.Parse(values[2]) });



                        }

                    }
                }


            }


            Points = mapPoints;




        }



       

    }



}
