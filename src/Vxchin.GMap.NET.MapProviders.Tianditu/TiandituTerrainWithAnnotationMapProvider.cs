using System;
using GMap.NET.MapProviders;

namespace Vxchin.GMap.NET.MapProviders.Tianditu
{

    public class TiandituTerrainWithAnnotationMapProvider : TiandituMapProviderBase
    {
        private static TiandituTerrainWithAnnotationMapProvider instance;

        public static TiandituTerrainWithAnnotationMapProvider Instance => instance ?? (instance = new TiandituTerrainWithAnnotationMapProvider());


        public override Guid Id => new Guid("A2AE1109-C93C-43B5-9B91-AADD85CDCFE1");

        public override string Name => nameof(TiandituTerrainWithAnnotationMapProvider);

        public override GMapProvider[] Overlays => new GMapProvider[] { TiandituTerrainMapProvider.Instance, this };

        public TiandituTerrainWithAnnotationMapProvider() : base("cia", 14 /* 18 */) { }
    }
}
