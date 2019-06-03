using System;
using GMap.NET.MapProviders;

namespace Vxchin.GMap.NET.MapProviders.Tianditu
{
    public class TiandituImageWithAnnotationMapProvider : TiandituMapProviderBase
    {
        private static TiandituImageWithAnnotationMapProvider instance;

        public static TiandituImageWithAnnotationMapProvider Instance => instance ?? (instance = new TiandituImageWithAnnotationMapProvider());


        public override Guid Id => new Guid("802BE4D1-A1AD-4BF6-9C22-D2859529E38D");

        public override string Name => nameof(TiandituImageWithAnnotationMapProvider);

        public override GMapProvider[] Overlays => new GMapProvider[] { TiandituImageMapProvider.Instance, this };

        public TiandituImageWithAnnotationMapProvider() : base("cia") { }
    }
}
