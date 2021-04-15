using GMap.NET.MapProviders.AutoNavi;

namespace GMap.NET.MapProviders
{
    public static class AutoNaviMapProviders
    {
        public static AutoNaviVectorMapProvider VectorMap => AutoNaviVectorMapProvider.Instance;
        public static AutoNaviImageMapProvider ImageMap => AutoNaviImageMapProvider.Instance;
    }
}