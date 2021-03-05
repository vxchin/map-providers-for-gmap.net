using System;
using System.Net;
using GMap.NET.Projections;

namespace GMap.NET.MapProviders.Tianditu.Internal
{
    public abstract class TiandituMapProviderBase : GMapProvider
    {
        // ReSharper disable StringLiteralTypo
        private const string ServerUrl = "http://t{l}.tianditu.gov.cn/{c}_w/wmts" +
                                         "?SERVICE=WMTS&REQUEST=GetTile&VERSION=1.0.0" +
                                         "&LAYER={c}&STYLE=default&TILEMATRIXSET=w&FORMAT=tiles" +
                                         "&TILEMATRIX={z}&TILECOL={x}&TILEROW={y}&tk={k}";
        // ReSharper restore StringLiteralTypo


        private const string ServerLetters = "01234567";

        private readonly string _category;

        protected TiandituMapProviderBase(string category, int maxZoom = 18)
        {
            _category = category;
            MinZoom = 1;
            MaxZoom = maxZoom;
        }

        private static string ServerUrlFormatString { get; } = ServerUrl
            .Replace("{l}", "{0}")
            .Replace("{c}", "{1}")
            .Replace("{x}", "{2}")
            .Replace("{y}", "{3}")
            .Replace("{z}", "{4}")
            .Replace("{k}", "{5}");

        public static string ApiKey { get; set; }

        public override PureProjection Projection => MercatorProjection.Instance;

        public override PureImage GetTileImage(GPoint pos, int zoom)
        {
            EnsureApiKeyIsValid();
            var url = MakeTileImageUrl(pos, zoom);
            return GetTileImageUsingHttp(url);
        }

        protected override void InitializeWebRequest(WebRequest request)
        {
            base.InitializeWebRequest(request);

            switch (request)
            {
                case HttpWebRequest httpWebRequest:
                    httpWebRequest.Accept = null;
                    break;
                default:
                    request.Headers.Remove("Accept");
                    break;
            }
        }

        protected virtual string MakeTileImageUrl(GPoint pos, int zoom)
        {
            var letter = ServerLetters[GetServerNum(pos, ServerLetters.Length)];
            return String.Format(ServerUrlFormatString, letter, _category, pos.X, pos.Y, zoom, ApiKey);
        }

        private static void EnsureApiKeyIsValid()
        {
            if (String.IsNullOrEmpty(ApiKey))
                throw new InvalidOperationException(
                    "未设置天地图的 API Key。请访问 https://console.tianditu.gov.cn/api/key 申请“浏览器端”类型的 API Key，并设置提供程序的 ApiKey 属性。");
        }
    }
}