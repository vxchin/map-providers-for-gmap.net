using System;

namespace GMap.NET.MapProviders.AutoNavi.Internal
{
    internal class AutoNaviImageWithoutAnnotationMapProvider : AutoNaviMapProviderBase
    {
        public static readonly AutoNaviImageWithoutAnnotationMapProvider Instance = new AutoNaviImageWithoutAnnotationMapProvider();

        private GMapProvider[] _overlays;

        private AutoNaviImageWithoutAnnotationMapProvider() : base(6)
        {
        }

        public override Guid Id { get; } = new Guid("225ffcfa-4939-4478-9176-f5384621e322");

        public override string Name { get; } = nameof(AutoNaviImageWithoutAnnotationMapProvider);

        public override GMapProvider[] Overlays => _overlays ?? (_overlays = new GMapProvider[] { this });
    }
}