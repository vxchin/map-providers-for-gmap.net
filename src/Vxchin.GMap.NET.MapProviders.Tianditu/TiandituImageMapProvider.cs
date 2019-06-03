using System;

namespace Vxchin.GMap.NET.MapProviders.Tianditu
{
    public class TiandituImageMapProvider : TiandituMapProviderBase
    {
        private static TiandituImageMapProvider instance;

        public static TiandituImageMapProvider Instance => instance ?? (instance = new TiandituImageMapProvider());

        public override Guid Id => new Guid("1883D8B5-9279-4D13-934A-AE333F20B5A1");

        public override string Name => nameof(TiandituImageMapProvider);

        public TiandituImageMapProvider() : base("img") { }
    }
}
