## Nuget Install 
```shell=
System.Drawing
Line.Messaging
```
## Import this folder to your root folder


## 修改 appsettings.json 追加下列程式
```
  "LineBot": {
    "channelSecret": "YOUR_SECRET",
    "accessToken": "YOUR_TOKEN"
  }
```
> 上述YOUR_SECRET位於LINE開發後台的Basic settings;
YOUR_TOKEN位於LINE開發後台的Messaging API

## 修改Program.cs 追加
```csharp
builder.Services.AddSingleton<LineBotConfig, LineBotConfig>((s)=> new LineBotConfig
{
    channelSecret = builder.Configuration.GetSection("LineBot")["channelSecret"]!,
    accessToken = builder.Configuration.GetSection("LineBot")["accessToken"]!,
});

builder.Services.AddSingleton<ILineService, LineService>();
builder.Services.AddHttpContextAccessor();

```

## 修改Properties\launchSettings.json啟動機制 (關閉SSL)
 針對applicationUrl進行修改