using System;

namespace GMap.NET.MapProviders.Tianditu.Internal
{
    internal class TiandituImageWithoutAnnotationMapProvider : TiandituMapProviderBase
    {
        public static readonly TiandituImageWithoutAnnotationMapProvider Instance = new TiandituImageWithoutAnnotationMapProvider();

        private GMapProvider[] _overlays;

        private TiandituImageWithoutAnnotationMapProvider() : base("img")
        {
        }

        public override Guid Id { get; } = new Guid("641a71cc-7cc9-4adb-b1ab-c672b2d00829");

        public override string Name { get; } = nameof(TiandituImageWithoutAnnotationMapProvider);

        public override GMapProvider[] Overlays => _overlays ?? (_overlays = new GMapProvider[] { this });
    }
}