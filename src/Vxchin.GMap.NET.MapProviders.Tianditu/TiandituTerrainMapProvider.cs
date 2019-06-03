using System;

namespace Vxchin.GMap.NET.MapProviders.Tianditu
{
    public class TiandituTerrainMapProvider : TiandituMapProviderBase
    {
        private static TiandituTerrainMapProvider instance;

        public static TiandituTerrainMapProvider Instance => instance ?? (instance = new TiandituTerrainMapProvider());

        public override Guid Id => new Guid("2614F583-925F-4D66-96BE-315609245A3E");

        public override string Name => nameof(TiandituTerrainMapProvider);

        public TiandituTerrainMapProvider() : base("ter", 14) { }
    }
}
