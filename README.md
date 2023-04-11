# .NetCore

## Startup.cs
+ Startup()
  - 建構式:通常只用來注入 IConfiguration 服務 -
+ ConfigureServices()
  - 將應用程式所需的「服務」註冊到 DI 容器中
此方法只會在應用程式啟動時執行一次! -
+ Configure()
  - 此方法用來設定 ASP.NET Core 如何回應用戶端要求
  - 此方法一定要定義 ASP.NET Core 才能執行
  - 必須認識 Middleware Pipeline 的觀念
