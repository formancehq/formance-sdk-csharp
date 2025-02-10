# FormanceReconciliationV1
(*Reconciliation.V1*)

## Overview

### Available Operations

* [ReconciliationgetServerInfo](#reconciliationgetserverinfo) - Get server info
* [CreatePolicy](#createpolicy) - Create a policy
* [ListPolicies](#listpolicies) - List policies
* [DeletePolicy](#deletepolicy) - Delete a policy
* [GetPolicy](#getpolicy) - Get a policy
* [Reconcile](#reconcile) - Reconcile using a policy
* [ListReconciliations](#listreconciliations) - List reconciliations
* [GetReconciliation](#getreconciliation) - Get a reconciliation

## ReconciliationgetServerInfo

Get server info

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ReconciliationgetServerInfoAsync();

// handle response
```

### Response

**[ReconciliationgetServerInfoResponse](../../Models/Requests/ReconciliationgetServerInfoResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| FormanceSDK.Models.Errors.ReconciliationErrorResponse | default                                               | application/json                                      |
| FormanceSDK.Models.Errors.SDKException                | 4XX, 5XX                                              | \*/\*                                                 |

## CreatePolicy

Create a policy

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

PolicyRequest req = new PolicyRequest() {
    Name = "XXX",
    LedgerName = "default",
    LedgerQuery = new Dictionary<string, object>() {
        { "key", "<value>" },
    },
    PaymentsPoolID = "XXX",
};

var res = await sdk.Reconciliation.V1.CreatePolicyAsync(req);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [PolicyRequest](../../Models/Components/PolicyRequest.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[CreatePolicyResponse](../../Models/Requests/CreatePolicyResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| FormanceSDK.Models.Errors.ReconciliationErrorResponse | default                                               | application/json                                      |
| FormanceSDK.Models.Errors.SDKException                | 4XX, 5XX                                              | \*/\*                                                 |

## ListPolicies

List policies

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ListPoliciesAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |

### Response

**[ListPoliciesResponse](../../Models/Requests/ListPoliciesResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| FormanceSDK.Models.Errors.ReconciliationErrorResponse | default                                               | application/json                                      |
| FormanceSDK.Models.Errors.SDKException                | 4XX, 5XX                                              | \*/\*                                                 |

## DeletePolicy

Delete a policy by its id.

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.DeletePolicyAsync(policyID: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `PolicyID`         | *string*           | :heavy_check_mark: | The policy ID.     | XXX                |

### Response

**[DeletePolicyResponse](../../Models/Requests/DeletePolicyResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| FormanceSDK.Models.Errors.ReconciliationErrorResponse | default                                               | application/json                                      |
| FormanceSDK.Models.Errors.SDKException                | 4XX, 5XX                                              | \*/\*                                                 |

## GetPolicy

Get a policy

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.GetPolicyAsync(policyID: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `PolicyID`         | *string*           | :heavy_check_mark: | The policy ID.     | XXX                |

### Response

**[GetPolicyResponse](../../Models/Requests/GetPolicyResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| FormanceSDK.Models.Errors.ReconciliationErrorResponse | default                                               | application/json                                      |
| FormanceSDK.Models.Errors.SDKException                | 4XX, 5XX                                              | \*/\*                                                 |

## Reconcile

Reconcile using a policy

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ReconcileAsync(
    policyID: "XXX",
    reconciliationRequest: new ReconciliationRequest() {
        ReconciledAtLedger = System.DateTime.Parse("2021-01-01T00:00:00.000Z"),
        ReconciledAtPayments = System.DateTime.Parse("2021-01-01T00:00:00.000Z"),
    }
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `PolicyID`                                                                | *string*                                                                  | :heavy_check_mark:                                                        | The policy ID.                                                            | XXX                                                                       |
| `ReconciliationRequest`                                                   | [ReconciliationRequest](../../Models/Components/ReconciliationRequest.md) | :heavy_check_mark:                                                        | N/A                                                                       |                                                                           |

### Response

**[ReconcileResponse](../../Models/Requests/ReconcileResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| FormanceSDK.Models.Errors.ReconciliationErrorResponse | default                                               | application/json                                      |
| FormanceSDK.Models.Errors.SDKException                | 4XX, 5XX                                              | \*/\*                                                 |

## ListReconciliations

List reconciliations

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ListReconciliationsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |

### Response

**[ListReconciliationsResponse](../../Models/Requests/ListReconciliationsResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| FormanceSDK.Models.Errors.ReconciliationErrorResponse | default                                               | application/json                                      |
| FormanceSDK.Models.Errors.SDKException                | 4XX, 5XX                                              | \*/\*                                                 |

## GetReconciliation

Get a reconciliation

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.GetReconciliationAsync(reconciliationID: "XXX");

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            | Example                |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `ReconciliationID`     | *string*               | :heavy_check_mark:     | The reconciliation ID. | XXX                    |

### Response

**[GetReconciliationResponse](../../Models/Requests/GetReconciliationResponse.md)**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| FormanceSDK.Models.Errors.ReconciliationErrorResponse | default                                               | application/json                                      |
| FormanceSDK.Models.Errors.SDKException                | 4XX, 5XX                                              | \*/\*                                                 |