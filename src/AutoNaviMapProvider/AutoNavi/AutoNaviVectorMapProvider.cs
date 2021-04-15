using System;
using GMap.NET.MapProviders.AutoNavi.Internal;

namespace GMap.NET.MapProviders.AutoNavi
{
    public class AutoNaviVectorMapProvider : AutoNaviMapProviderBase
    {
        public static readonly AutoNaviVectorMapProvider Instance =
            new AutoNaviVectorMapProvider();

        private GMapProvider[] _overlays;

        private AutoNaviVectorMapProvider() : base(7)
        {
        }

        public override Guid Id { get; } = new Guid("6ffb297f-f925-4e1f-b15b-5eebea46fc41");

        public override string Name { get; } = nameof(AutoNaviVectorMapProvider);

        public override GMapProvider[] Overlays => _overlays ?? (_overlays = new GMapProvider[] { this });
    }
}