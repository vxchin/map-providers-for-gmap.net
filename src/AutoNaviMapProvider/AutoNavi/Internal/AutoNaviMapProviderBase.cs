using System;
using System.Net;
using GMap.NET.Projections;

namespace GMap.NET.MapProviders.AutoNavi.Internal
{
    public abstract class AutoNaviMapProviderBase : GMapProvider
    {
        // ReSharper disable StringLiteralTypo
        private const string ServerUrl = "http://wprd0{l}.is.autonavi.com/appmaptile" +
                                         "?x={x}&y={y}&z={z}&style={style}&scl={scl}";
        // ReSharper restore StringLiteralTypo

        private const string ServerLetters = "1234";

        private readonly int _scl;
        private readonly int _style;

        protected AutoNaviMapProviderBase(int style, int scl = 1, int minZoom = 3, int maxZoom = 18)
        {
            _style = style;
            _scl = scl;
            MinZoom = minZoom;
            MaxZoom = maxZoom;
        }

        private string ServerUrlFormatString { get; } = ServerUrl
            .Replace("{l}", "{0}")
            .Replace("{x}", "{1}")
            .Replace("{y}", "{2}")
            .Replace("{z}", "{3}")
            .Replace("{style}", "{4}")
            .Replace("{scl}", "{5}");

        public override PureProjection Projection => MercatorProjection.Instance;

        public override PureImage GetTileImage(GPoint pos, int zoom)
        {
            var url = MakeTileImageUrl(pos, zoom);
            return GetTileImageUsingHttp(url);
        }

        protected virtual string MakeTileImageUrl(GPoint pos, int zoom)
        {
            var letter = ServerLetters[GetServerNum(pos, ServerLetters.Length)];
            return String.Format(ServerUrlFormatString, letter, pos.X, pos.Y, zoom, _style, _scl);
        }
    }
}