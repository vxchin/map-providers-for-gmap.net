using System;

namespace GMap.NET.MapProviders.Tianditu.Internal
{
    internal class TiandituTerrainWithoutAnnotationMapProvider : TiandituMapProviderBase
    {
        public static readonly TiandituTerrainWithoutAnnotationMapProvider Instance = new TiandituTerrainWithoutAnnotationMapProvider();

        private GMapProvider[] _overlays;

        private TiandituTerrainWithoutAnnotationMapProvider() : base("ter", 14)
        {
        }

        public override Guid Id { get; } = new Guid("b1038afe-39cd-4b18-8012-784a9b54aa48");

        public override string Name { get; } = nameof(TiandituTerrainWithoutAnnotationMapProvider);

        public override GMapProvider[] Overlays => _overlays ?? (_overlays = new GMapProvider[] { this });
    }
}