using System;
using GMap.NET.MapProviders.Tianditu.Internal;

namespace GMap.NET.MapProviders.Tianditu
{
    public class TiandituVectorMapProvider : TiandituMapProviderBase
    {
        public static readonly TiandituVectorMapProvider Instance =
            new TiandituVectorMapProvider();

        private GMapProvider[] _overlays;

        private TiandituVectorMapProvider() : base("cva")
        {
        }

        public override Guid Id { get; } = new Guid("3faf480b-f5bf-41a8-aa79-6a3c30ca566c");

        public override string Name { get; } = nameof(TiandituVectorMapProvider);

        public override GMapProvider[] Overlays =>
            _overlays ?? (_overlays = new GMapProvider[] { TiandituVectorWithoutAnnotationMapProvider.Instance, this });
    }
}