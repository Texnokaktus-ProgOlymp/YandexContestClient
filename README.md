# YandexContestClient

`YandexContestClient` — клиентская библиотека .NET для публичного API Yandex Contest v2. Большая часть API-клиента и моделей сгенерирована Kiota по [OpenAPI-документации](https://api.contest.yandex.net/api/public/v2/api-docs?group=v2).

## Требования

- Для сборки репозитория нужен .NET SDK 10.
- Библиотека нацелена на `netstandard2.1` и может использоваться приложениями, совместимыми с этой платформой.

## Установка пакета

CI публикует пакет `YandexContestClient` в GitHub Packages организации `Texnokaktus-ProgOlymp`. Для доступа к пакету настройте источник GitHub Packages и учетные данные с правом чтения пакетов, затем добавьте пакет в проект:

```bash
dotnet add package YandexContestClient --source "https://nuget.pkg.github.com/Texnokaktus-ProgOlymp/index.json"
```

Версия пакета формируется CI из даты коммита и номера запуска workflow.

## Использование

Клиент можно зарегистрировать в `IServiceCollection`. Передайте ему собственный поставщик OAuth-токена:

```csharp
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using YandexContestClient;
using YandexContestClient.Authentication;
using YandexContestClient.Client;

var services = new ServiceCollection();
services.AddYandexContestClient()
    .AuthenticateWithTokenProvider<ContestTokenProvider>();

using var serviceProvider = services.BuildServiceProvider();
var client = serviceProvider.GetRequiredService<ContestClient>();
var compilers = await client.V2.Compilers.GetAsync();

public sealed class ContestTokenProvider : AccessTokenProviderBase
{
    protected override Task<string> GetTokenAsync(CancellationToken cancellationToken = default)
    {
        var token = Environment.GetEnvironmentVariable("YANDEX_CONTEST_TOKEN");
        return token is null
            ? throw new InvalidOperationException("Set YANDEX_CONTEST_TOKEN before calling the API.")
            : Task.FromResult(token);
    }
}
```

`AccessTokenProviderBase` ограничивает передачу токена хостом `api.contest.yandex.net`. Возвращайте из `GetTokenAsync` сам токен без префикса `OAuth`: библиотека добавит его в заголовок запроса.

`AddYandexContestClient()` регистрирует HTTP request adapter и `ContestClient` с временем жизни scoped. Для пользовательского создания клиента есть перегрузка с фабрикой. `WithObservability()` дополнительно регистрирует параметры наблюдаемости Kiota.

## Сборка из исходников

```bash
dotnet restore YandexContestClient.slnx
dotnet build YandexContestClient.slnx --no-restore
```

Тестовых проектов в репозитории сейчас нет.

## Обновление сгенерированного API-клиента

Установите Kiota CLI и выполните `./update-client.sh`. Скрипт заново генерирует каталог `src/YandexContestClient/Client` по текущей документации API; для этого нужны сеть и доступность документации Yandex Contest.
