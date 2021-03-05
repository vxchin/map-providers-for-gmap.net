using System;

namespace GMap.NET.MapProviders.Tianditu.Internal
{
    internal class TiandituVectorWithoutAnnotationMapProvider : TiandituMapProviderBase
    {
        public static readonly TiandituVectorWithoutAnnotationMapProvider Instance = new TiandituVectorWithoutAnnotationMapProvider();

        private GMapProvider[] _overlays;

        private TiandituVectorWithoutAnnotationMapProvider() : base("vec")
        {
        }

        public override Guid Id { get; } = new Guid("76aefae2-d78b-431d-a940-1237da440ed3");

        public override string Name { get; } = nameof(TiandituVectorWithoutAnnotationMapProvider);

        public override GMapProvider[] Overlays => _overlays ?? (_overlays = new GMapProvider[] { this });
    }
}