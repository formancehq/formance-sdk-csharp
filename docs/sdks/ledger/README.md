# Ledger

## Overview

### Available Operations

* [GetInfo](#getinfo) - Show server information
* [GetMetrics](#getmetrics) - Read in memory metrics

## GetInfo

Show server information

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetInfo" method="get" path="/api/ledger/_/info" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.GetInfoAsync();

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V2GetInfoResponse](../../Models/Requests/V2GetInfoResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Ledger.V2ErrorResponseError | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## GetMetrics

Read in memory metrics

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMetrics" method="get" path="/api/ledger/_/metrics" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.GetMetricsAsync();

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[GetMetricsResponse](../../Models/Requests/GetMetricsResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Ledger.V2ErrorResponseError | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |