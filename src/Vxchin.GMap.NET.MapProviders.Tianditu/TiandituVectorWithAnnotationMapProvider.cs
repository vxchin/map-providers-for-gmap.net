using System;
using GMap.NET.MapProviders;

namespace Vxchin.GMap.NET.MapProviders.Tianditu
{
    public class TiandituVectorWithAnnotationMapProvider : TiandituMapProviderBase
    {
        private static TiandituVectorWithAnnotationMapProvider instance;

        public static TiandituVectorWithAnnotationMapProvider Instance => instance ?? (instance = new TiandituVectorWithAnnotationMapProvider());


        public override Guid Id => new Guid("EBC7E90D-E71C-424B-92BE-D1E8184951D6");

        public override string Name => nameof(TiandituVectorWithAnnotationMapProvider);

        public override GMapProvider[] Overlays => new GMapProvider[] { TiandituVectorMapProvider.Instance, this };

        public TiandituVectorWithAnnotationMapProvider() : base("cva") { }
    }
}
