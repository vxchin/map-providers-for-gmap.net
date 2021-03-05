using System;
using GMap.NET.MapProviders.Tianditu.Internal;

namespace GMap.NET.MapProviders.Tianditu
{
    public class TiandituImageMapProvider : TiandituMapProviderBase
    {
        public static readonly TiandituImageMapProvider Instance =
            new TiandituImageMapProvider();

        private GMapProvider[] _overlays;

        private TiandituImageMapProvider() : base("cia")
        {
        }

        public override Guid Id { get; } = new Guid("70deb2c5-0760-4185-93a0-495a20fceba5");

        public override string Name { get; } = nameof(TiandituImageMapProvider);

        public override GMapProvider[] Overlays =>
            _overlays ?? (_overlays = new GMapProvider[] { TiandituImageWithoutAnnotationMapProvider.Instance, this });
    }
}