# ~~Search.V1~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~GetServerInfoSearch~~](#getserverinfosearch) - Get server info :warning: **Deprecated**
* [~~Search~~](#search) - search.v1 :warning: **Deprecated**

## ~~GetServerInfoSearch~~

Get server info

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getServerInfo_search" method="get" path="/api/search/_info" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Search.V1.GetServerInfoSearchAsync();

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[GetServerInfoSearchResponse](../../Models/Requests/GetServerInfoSearchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ~~Search~~

Elasticsearch.v1 query engine

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="search" method="post" path="/api/search/" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Search;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

Query req = new Query() {
    Ledgers = new List<string>() {
        "quickstart",
    },
    After = new List<string>() {
        "users:002",
    },
    Terms = new List<string>() {
        "destination=central_bank1",
    },
    Sort = "id:asc",
    Policy = "OR",
    Cursor = "YXVsdCBhbmQgYSBtYXhpbXVtIG1heF9yZXN1bHRzLol=",
    Raw = new FormanceSDK.Models.Search.Raw() {},
};

var res = await sdk.Search.V1.SearchAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Query](../../Models/Search/Query.md)      | :heavy_check_mark:                         | The request object to use for the request. |
| `serverURL`                                | *string*                                   | :heavy_minus_sign:                         | An optional server URL to use.             |

### Response

**[SearchResponse](../../Models/Requests/SearchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |