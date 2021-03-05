# Tianditu Map Provider for GMap.NET

## 介绍
用于 [GMap.NET](https://github.com/judero01col/GMap.NET) 的天地图地图提供程序

## 使用说明

典型的使用过程如下：

1. 访问 https://console.tianditu.gov.cn/api/key 申请“浏览器端”类型的 API Key。

   > 注意：在天地图 2020 年更新访问控制策略后，“服务器端”类型的 API Key 无法应用于 GMap.NET！

2. 在初始化天地图提供程序前，使用前一部申请到的 API 作为参数调用 `TiandituMapProviders.SetApiKey(string apiKey)` 方法。

3. 将 `GMapControl` 控件的 `MapProvider` 属性设置为需要的地图提供程序。地图提供程序包括：

   1. `VectorMap`：矢量地图
   2. `ImageMap`: 卫星地图
   3. `TerrainMap`：地形图

```csharp
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
```

项目中包含了 Windows Forms 的示例项目，使用前请在 `app.config` 中配置 `tianditu:appKey`。

## 依赖的 Nuget 包

* GMap.NET.Core [2.0.1,)

## 开发人员

* 秦文轩 (gitee.com/vxchin)

