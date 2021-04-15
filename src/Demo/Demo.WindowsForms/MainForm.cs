using System.Windows.Forms;
using GMap.NET.WindowsForms;

namespace GMap.NET.MapProviders.Tianditu.Demo.WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lbMapProviders.Items.AddRange(new GMapProvider[]
            {,
                AutoNaviMapProviders.ImageMap,
                AutoNaviMapProviders.VectorMap,
                TiandituMapProviders.ImageMap,
                TiandituMapProviders.TerrainMap,
                TiandituMapProviders.VectorMap
            });
            if (!GMapControl.IsDesignerHosted)
            {
                MainMap.Position = new PointLatLng(34.2250209512632, 108.880734443665);
                MainMap.Manager.Mode = AccessMode.ServerOnly;
#if DEBUG
                MainMap.ShowTileGridLines = true;
                MainMap.MapScaleInfoEnabled = true;
                MainMap.OnMapZoomChanged += () => lblInfo.Text = $"Zoom Level : {MainMap.Zoom}";
#endif
            }
        }

        private void MainMap_Load(object sender, System.EventArgs e)
        {
            lbMapProviders.SelectedIndex = 0;
        }

        private void lbMapProviders_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (sender is ListBox list && list.SelectedItem is GMapProvider provider)
            {
                MainMap.MapProvider = provider;
            }
        }


    }
}