# Search
(*Search*)

## Overview

### Available Operations

* [SearchgetServerInfo](#searchgetserverinfo) - Get server info
* [Search](#search) - Search

## SearchgetServerInfo

Get server info

### Example Usage

```csharp
using formance;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Search.SearchgetServerInfoAsync();

// handle response
```

### Response

**[SearchgetServerInfoResponse](../../Models/Requests/SearchgetServerInfoResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4XX, 5XX                            | \*/\*                               |

## Search

ElasticSearch query engine

### Example Usage

```csharp
using System.Collections.Generic;
using formance;
using formance.Models.Components;

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

var res = await sdk.Search.SearchAsync(req);

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