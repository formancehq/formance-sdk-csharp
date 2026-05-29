# Formance SDK

## Overview

Formance Stack API: Open, modular foundation for unique payments flows

# Introduction
This API is documented in **OpenAPI format**.

# Authentication
Formance Stack offers one forms of authentication:
  - OAuth2
OAuth2 - an open protocol to allow secure authorization in a simple
and standard method from web, mobile and desktop applications.
<SecurityDefinitions />

### Available Operations

* [GetVersions](#getversions) - Show stack version information

## GetVersions

Show stack version information

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getVersions" method="get" path="/versions" -->
```csharp
using FormanceSDK;

var sdk = new Formance();

var res = await sdk.GetVersionsAsync();

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.GetVersionsResponse](../../Models/Requests/GetVersionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |