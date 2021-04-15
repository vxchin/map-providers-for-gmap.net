using System;
using GMap.NET.MapProviders.AutoNavi.Internal;

namespace GMap.NET.MapProviders.AutoNavi
{
    public class AutoNaviImageMapProvider : AutoNaviMapProviderBase
    {
        public static readonly AutoNaviImageMapProvider Instance =
            new AutoNaviImageMapProvider();

        private GMapProvider[] _overlays;

        private AutoNaviImageMapProvider() : base(8)
        {
        }

        public override Guid Id { get; } = new Guid("fff6547a-904a-45cd-89a5-0c8d10c43f6b");

        public override string Name { get; } = nameof(AutoNaviImageMapProvider);

        public override GMapProvider[] Overlays =>
            _overlays ?? (_overlays = new GMapProvider[] { AutoNaviImageWithoutAnnotationMapProvider.Instance, this });
    }
}