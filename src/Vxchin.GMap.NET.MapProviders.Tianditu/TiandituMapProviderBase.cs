using System;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.Projections;

namespace Vxchin.GMap.NET.MapProviders.Tianditu
{
    public abstract class TiandituMapProviderBase : GMapProvider
    {
        private readonly string cat;

        public const string ServerUrl = @"http://t{l}.tianditu.gov.cn/DataServer?T={c}_w&x={x}&y={y}&l={z}&tk={k}";

        public const string ServerLetters = @"01234567";

        public TiandituMapProviderBase(string category, int maxZoom = 18)
        {
            cat = category;
            MinZoom = 1;
            MaxZoom = maxZoom;
        }

        public static string ApiKey = String.Empty;

        public override PureProjection Projection => MercatorProjection.Instance;

        private GMapProvider[] overlays;

        public override GMapProvider[] Overlays => overlays ?? (overlays = new[] { this });

        public override PureImage GetTileImage(GPoint pos, int zoom)
        {
            var url = MakeTileImageUrl(pos, zoom);
            return GetTileImageUsingHttp(url);
        }
        public virtual string MakeTileImageUrl(GPoint pos, int zoom)
        {
            var url = ServerUrl;

            url = url.Replace("{l}", "{0}");
            url = url.Replace("{c}", "{1}");
            url = url.Replace("{x}", "{2}");
            url = url.Replace("{y}", "{3}");
            url = url.Replace("{z}", "{4}");
            url = url.Replace("{k}", "{5}");

            var letter = String.IsNullOrEmpty(ServerLetters) ? "" : ServerLetters[GetServerNum(pos, ServerLetters.Length)].ToString();
            return String.Format(url, letter, cat, pos.X, pos.Y, zoom, ApiKey);
        }
    }
}
