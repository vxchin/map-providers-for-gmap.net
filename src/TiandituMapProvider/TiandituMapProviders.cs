using GMap.NET.MapProviders.Tianditu;

namespace GMap.NET.MapProviders
{
    public static class TiandituMapProviders
    {
        public static TiandituVectorMapProvider VectorMap => TiandituVectorMapProvider.Instance;
        public static TiandituImageMapProvider ImageMap => TiandituImageMapProvider.Instance;
        public static TiandituTerrainMapProvider TerrainMap => TiandituTerrainMapProvider.Instance;

        /// <summary>
        /// 设置天地图的 API Key。
        /// <para>请访问 https://console.tianditu.gov.cn/api/key 申请，API Key 类型请选择“浏览器端”。</para>
        /// </summary>
        /// <param name="apiKey"></param>
        public static void SetApiKey(string apiKey)
        {
            Tianditu.Internal.TiandituMapProviderBase.ApiKey = apiKey;
        }
    }
}