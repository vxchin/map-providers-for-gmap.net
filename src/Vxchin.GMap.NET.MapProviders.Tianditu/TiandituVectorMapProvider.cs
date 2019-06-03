using System;

namespace Vxchin.GMap.NET.MapProviders.Tianditu
{
    public class TiandituVectorMapProvider : TiandituMapProviderBase
    {
        private static TiandituVectorMapProvider instance;

        public static TiandituVectorMapProvider Instance => instance ?? (instance = new TiandituVectorMapProvider());

        public override Guid Id => new Guid("265F2F86-E98A-4AFA-B4D3-7CD6E1A40D16");

        public override string Name => nameof(TiandituVectorMapProvider);

        public TiandituVectorMapProvider() : base("vec") { }
    }
}
