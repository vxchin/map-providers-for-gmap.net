using System.Windows.Forms;
using GMap.NET.WindowsForms;

namespace GMap.NET.MapProviders.Tianditu.Demo.WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (!GMapControl.IsDesignerHosted)
            {
                MainMap.MapProvider = TiandituMapProviders.ImageMap;
                MainMap.Position = new PointLatLng(34.2250209512632, 108.880734443665);
                MainMap.Manager.Mode = AccessMode.ServerOnly;
            }
        }
    }
}
