using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.UI.GeoAnalysis;
using MapApp.Model;
using MapApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;

namespace MapApp.Views
{
    /// <summary>
    /// Interaction logic for MapView.xaml
    /// </summary>
    public partial class MyMapView : UserControl
    {
        // URLs to various services used to provide an interesting scene for the sample.
        private readonly Uri _worldElevationService =
            new Uri("https://elevation3d.arcgis.com/arcgis/rest/services/WorldElevation3D/Terrain3D/ImageServer");

        private readonly Uri _buildingService =
            new Uri(
                "https://tiles.arcgis.com/tiles/P3ePLMYs2RVChkJx/arcgis/rest/services/Buildings_Brest/SceneServer/layers/0");

        internal void CreateOverlay(Dictionary<double,MyMapPoint> points)
        {
            GraphicsOverlay overlay = new GraphicsOverlay();

            // Add points to the graphics overlay
            foreach (MyMapPoint point in points.Values)
            {
                // Create new graphic and add it to the overlay
                //MapPoint baseMapPoint1 = new MapPoint(25.905114, -80.767646, SpatialReferences.WebMercator);
                overlay.Graphics.Add(new Graphic(point.SDKMapPoint));
            }

            // Create symbol for points
            SimpleMarkerSymbol pointSymbol = new SimpleMarkerSymbol()
            {
                Color = Color.Yellow,
                Size = 20,
                Style = SimpleMarkerSymbolStyle.X
            };

            // Create simple renderer with symbol
            SimpleRenderer renderer = new SimpleRenderer(pointSymbol);

            // Set renderer to graphics overlay
            overlay.Renderer = renderer;

            // Add created overlay to the MapView
            MySceneView.GraphicsOverlays.Add(overlay);
        }

        public MyMapView()
        {

            InitializeComponent();
            // Create a scene with elevation.
            Surface sceneSurface = new Surface();
            sceneSurface.ElevationSources.Add(new ArcGISTiledElevationSource(_worldElevationService));
            Scene myScene = new Scene(Basemap.CreateImagery())
            {
                BaseSurface = sceneSurface
            };

            // Create and add a building layer.
            ArcGISSceneLayer buildingsLayer = new ArcGISSceneLayer(_buildingService);
            myScene.OperationalLayers.Add(buildingsLayer);

            // Create and add an analysis overlay.
            AnalysisOverlay measureAnalysisOverlay = new AnalysisOverlay();
            MySceneView.AnalysisOverlays.Add(measureAnalysisOverlay);
            //SpatialReference spref = new SpatialReference(26717); // NAD_1927_UTM_Zone_17N
            MapPoint baseMapPoint1 = new MapPoint(25.905114, -80.767646, SpatialReferences.WebMercator);
            MapPoint start = new MapPoint(-4.494677, 48.384472, 24.772694, SpatialReferences.Wgs84);

            double latitude = double.Parse("50.250000"); // No difference if values are between 19.75N and 50.25N
            double longitude = double.Parse("-81.000000"); // 81.0W is the central meridian for UTM 17N
            SpatialReference spref = new SpatialReference(26717); // NAD_1927_UTM_Zone_17N
            MapPoint baseMapPoint = new MapPoint(longitude, latitude, SpatialReferences.Wgs84);

            MapPoint mapPoint1 = GeometryEngine.Project(baseMapPoint, spref) as MapPoint;


            MySceneView.SetViewpointCamera(new Camera(baseMapPoint1, 200, 0, 45, 0));
            // Show the scene in the view.
            MySceneView.Scene = myScene;










        }

        private void GoToPointButton_OnClick(object sender, RoutedEventArgs e)
        {
            double pointIndex = double.Parse(IndexTextBox.Text);
            var points = this.DataContext as PointsViewModel;
            MySceneView.SetViewpointCamera(new Camera(points.Points[pointIndex].Lat, points.Points[pointIndex].Longe,800, 0, 45, 0));
        }
    }
}
