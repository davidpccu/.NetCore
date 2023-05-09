# .NetCore

## Startup.cs
+ Startup()
  - 建構式:通常只用來注入 IConfiguration 服務
+ ConfigureServices()
  - 將應用程式所需的「服務」註冊到 DI 容器中
此方法只會在應用程式啟動時執行一次!
+ Configure()
  - 此方法用來設定 ASP.NET Core 如何回應用戶端要求
  - 此方法一定要定義 ASP.NET Core 才能執行
  - 必須認識 Middleware Pipeline 的觀念

## DI

### 使用 DI 相依注入的三步驟
+ 註冊(Register)
  - 將「服務」註冊到 DI 容器中
  - 在 ASP.NET Core 中的專有名詞為「服務集合」
+ 解析(Resolve)
  - 將註冊到DI 容器中的「服務」解析出來使用
  - 服務可以透過「建構式」注入,也可透過「方法」注入
  - ASP.NET Core MVC / Razor Page 可直接從 Views 注入「服務」
+ 釋放(Release)
  - 透過內建的生命週期管理,在註冊服務時宣告「釋放物件」的時間點

### ASP.NET Core 大量使用 DI 設計架構
+ 在ASP.NET Core 有許多內建可注入的"服務"(Framework-provided services)
+ 由 Startup.ConfigureServices()負責設定 DI 容器
  - 將需要的服務加入服務集合(IServiceCollection)
  - 唯有加入服務集合的「服務」才能解析服務集合中的服務
+ 服務集合 (IServiceCollection)負責控管服務的生命週期
  - Transient 每次注入服務時建立一份物件實例 (暫時性實體)
    + 實作工廠模式的服務(Factory Pattern)、....
  - Scoped 每次 HTTP 要求的生命週期內僅會建立一份物件實例 (具範圍的實體)
    + 資料庫連線物件(DbContext)、SmtpClient、....
  - Singleton 整個應用程式生命週期僅會建立一份物件實例 (單一實體)
    + 工具服務、服務組態、無狀態服務、...

