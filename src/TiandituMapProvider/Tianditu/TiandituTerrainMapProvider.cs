using System;
using GMap.NET.MapProviders.Tianditu.Internal;

namespace GMap.NET.MapProviders.Tianditu
{
    public class TiandituTerrainMapProvider : TiandituMapProviderBase
    {
        public static readonly TiandituTerrainMapProvider Instance = new TiandituTerrainMapProvider();

        private GMapProvider[] _overlays;

        private TiandituTerrainMapProvider() : base("cia", 14 /* 18 */)
        {
        }

        public override Guid Id { get; } = new Guid("525da42d-fdba-4112-9173-ac52a6d6cb6d");

        public override string Name { get; } = nameof(TiandituTerrainMapProvider);

        public override GMapProvider[] Overlays =>
            _overlays ?? (_overlays = new GMapProvider[]
                { TiandituTerrainWithoutAnnotationMapProvider.Instance, this });
    }
}