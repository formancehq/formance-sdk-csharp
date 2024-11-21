# FormanceSearchV1
(*Search.V1*)

## Overview

### Available Operations

* [~~SearchgetServerInfo~~](#searchgetserverinfo) - Get server info :warning: **Deprecated**
* [~~Search~~](#search) - search.v1 :warning: **Deprecated**

## ~~SearchgetServerInfo~~

Get server info

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using formance;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Search.V1.SearchgetServerInfoAsync();

// handle response
```

### Response

**[SearchgetServerInfoResponse](../../Models/Requests/SearchgetServerInfoResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4XX, 5XX                            | \*/\*                               |

## ~~Search~~

Elasticsearch.v1 query engine

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using formance;
using formance.Models.Components;
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
    Raw = new QueryRaw() {},
};

var res = await sdk.Search.V1.SearchAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Query](../../Models/Components/Query.md)  | :heavy_check_mark:                         | The request object to use for the request. |

### Response

**[SearchResponse](../../Models/Requests/SearchResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4XX, 5XX                            | \*/\*                               |