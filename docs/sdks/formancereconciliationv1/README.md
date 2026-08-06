# Reconciliation.V1

## Overview

### Available Operations

* [GetServerInfoReconciliation](#getserverinforeconciliation) - Get server info
* [CreatePolicy](#createpolicy) - Create a policy
* [ListPolicies](#listpolicies) - List policies
* [DeletePolicy](#deletepolicy) - Delete a policy
* [GetPolicy](#getpolicy) - Get a policy
* [Reconcile](#reconcile) - Reconcile using a policy
* [ListReconciliations](#listreconciliations) - List reconciliations
* [GetReconciliation](#getreconciliation) - Get a reconciliation
* [CreateRule](#createrule) - Create a rule
* [ListRules](#listrules) - List rules
* [GetRule](#getrule) - Get a rule
* [PatchRule](#patchrule) - Patch a rule (partial update)
* [DeleteRule](#deleterule) - Delete a rule (cascades to evaluations + alerts + alert events)
* [EvaluateRule](#evaluaterule) - Evaluate a rule now
* [ListEvaluations](#listevaluations) - List evaluations
* [GetEvaluation](#getevaluation) - Get an evaluation
* [ListAlerts](#listalerts) - List alerts
* [GetAlert](#getalert) - Get an alert
* [ListAlertEvents](#listalertevents) - List alert events (append-only timeline)
* [AckAlert](#ackalert) - Acknowledge an alert
* [ResolveAlert](#resolvealert) - Resolve an alert (fixed_by_booking)
* [AcceptAlert](#acceptalert) - Accept an alert (accepted_by_business)
* [SnoozeAlert](#snoozealert) - Snooze an alert's notifications until a future instant
* [UnsnoozeAlert](#unsnoozealert) - Lift a snooze early

## GetServerInfoReconciliation

Get server info

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getServerInfo_reconciliation" method="get" path="/api/reconciliation/_info" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.GetServerInfoReconciliationAsync();

// handle response
```

### Response

**[GetServerInfoReconciliationResponse](../../Models/Requests/GetServerInfoReconciliationResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## CreatePolicy

Create a policy

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPolicy" method="post" path="/api/reconciliation/policies" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Reconciliation;
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

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [PolicyRequest](../../Models/Reconciliation/PolicyRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[CreatePolicyResponse](../../Models/Requests/CreatePolicyResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## ListPolicies

List policies

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPolicies" method="get" path="/api/reconciliation/policies" -->
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
| `RequestBody`                                                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                                                      |                                                                                                                                                                                                                                                          |

### Response

**[ListPoliciesResponse](../../Models/Requests/ListPoliciesResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## DeletePolicy

Delete a policy by its id.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deletePolicy" method="delete" path="/api/reconciliation/policies/{policyID}" -->
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

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## GetPolicy

Get a policy

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPolicy" method="get" path="/api/reconciliation/policies/{policyID}" -->
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

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## Reconcile

Reconcile using a policy

### Example Usage

<!-- UsageSnippet language="csharp" operationID="reconcile" method="post" path="/api/reconciliation/policies/{policyID}/reconciliation" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Reconciliation;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ReconcileAsync(
    policyID: "XXX",
    reconciliationRequest: new ReconciliationRequest() {
        ReconciledAtLedger = System.DateTime.Parse("2021-01-01T00:00:00.000Z").ToUniversalTime(),
        ReconciledAtPayments = System.DateTime.Parse("2021-01-01T00:00:00.000Z").ToUniversalTime(),
    }
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   | Example                                                                       |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `PolicyID`                                                                    | *string*                                                                      | :heavy_check_mark:                                                            | The policy ID.                                                                | XXX                                                                           |
| `ReconciliationRequest`                                                       | [ReconciliationRequest](../../Models/Reconciliation/ReconciliationRequest.md) | :heavy_check_mark:                                                            | N/A                                                                           |                                                                               |

### Response

**[ReconcileResponse](../../Models/Requests/ReconcileResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## ListReconciliations

List reconciliations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listReconciliations" method="get" path="/api/reconciliation/reconciliations" -->
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
| `RequestBody`                                                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                                                      |                                                                                                                                                                                                                                                          |

### Response

**[ListReconciliationsResponse](../../Models/Requests/ListReconciliationsResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## GetReconciliation

Get a reconciliation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getReconciliation" method="get" path="/api/reconciliation/reconciliations/{reconciliationID}" -->
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

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## CreateRule

Create a rule

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRule" method="post" path="/api/reconciliation/rules" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Reconciliation;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

RuleRequest req = new RuleRequest() {
    Name = "<value>",
    TemplateKind = TemplateKind.LedgerVsPoolDrift,
    TemplateSpec = new Dictionary<string, object>() {

    },
    Schedule = new Schedule() {
        Kind = Kind.Cron,
        Expr = "*/15 * * * *",
        Tz = "UTC",
        SafetyMargin = "30s",
    },
};

var res = await sdk.Reconciliation.V1.CreateRuleAsync(req);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [RuleRequest](../../Models/Reconciliation/RuleRequest.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[CreateRuleResponse](../../Models/Requests/CreateRuleResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## ListRules

List rules

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRules" method="get" path="/api/reconciliation/rules" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ListRulesAsync(
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
| `RequestBody`                                                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                                                      |                                                                                                                                                                                                                                                          |

### Response

**[ListRulesResponse](../../Models/Requests/ListRulesResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## GetRule

Get a rule

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRule" method="get" path="/api/reconciliation/rules/{ruleID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.GetRuleAsync(ruleID: "fd71d712-041d-4271-b7c5-c9adac177f52");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `RuleID`           | *string*           | :heavy_check_mark: | The rule ID.       |

### Response

**[GetRuleResponse](../../Models/Requests/GetRuleResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## PatchRule

Patch a rule (partial update)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRule" method="patch" path="/api/reconciliation/rules/{ruleID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Reconciliation;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.PatchRuleAsync(
    ruleID: "0b4aa7b1-cc5d-4700-91ec-4983510fef86",
    rulePatchRequest: new RulePatchRequest() {
        Schedule = new Schedule() {
            Kind = Kind.Cron,
            Expr = "*/15 * * * *",
            Tz = "UTC",
            SafetyMargin = "30s",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RuleID`                                                            | *string*                                                            | :heavy_check_mark:                                                  | The rule ID.                                                        |
| `RulePatchRequest`                                                  | [RulePatchRequest](../../Models/Reconciliation/RulePatchRequest.md) | :heavy_check_mark:                                                  | N/A                                                                 |

### Response

**[PatchRuleResponse](../../Models/Requests/PatchRuleResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## DeleteRule

Delete a rule (cascades to evaluations + alerts + alert events)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteRule" method="delete" path="/api/reconciliation/rules/{ruleID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.DeleteRuleAsync(ruleID: "3254b217-2184-4bf4-bbc8-b529fa29bd7c");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `RuleID`           | *string*           | :heavy_check_mark: | The rule ID.       |

### Response

**[DeleteRuleResponse](../../Models/Requests/DeleteRuleResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## EvaluateRule

Evaluate a rule now

### Example Usage

<!-- UsageSnippet language="csharp" operationID="evaluateRule" method="post" path="/api/reconciliation/rules/{ruleID}/evaluate" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.EvaluateRuleAsync(
    ruleID: "e9d27cb2-b7fc-4383-b319-936c01a66703",
    evaluateRuleRequest: new FormanceSDK.Models.Reconciliation.EvaluateRuleRequest() {
        SafetyMargin = "30s",
        SourcePITs = new Dictionary<string, DateTime>() {
            { "ledger:main#0", System.DateTime.Parse("2026-06-30T23:59:59Z").ToUniversalTime() },
            { "pool:acct#0", System.DateTime.Parse("2026-06-30T23:00:00Z").ToUniversalTime() },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `RuleID`                                                                                        | *string*                                                                                        | :heavy_check_mark:                                                                              | The rule ID.                                                                                    |
| `EvaluateRuleRequest`                                                                           | [Models.Reconciliation.EvaluateRuleRequest](../../Models/Reconciliation/EvaluateRuleRequest.md) | :heavy_minus_sign:                                                                              | N/A                                                                                             |

### Response

**[EvaluateRuleResponse](../../Models/Requests/EvaluateRuleResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## ListEvaluations

List evaluations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEvaluations" method="get" path="/api/reconciliation/evaluations" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ListEvaluationsAsync(
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
| `RequestBody`                                                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                                                      |                                                                                                                                                                                                                                                          |

### Response

**[ListEvaluationsResponse](../../Models/Requests/ListEvaluationsResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## GetEvaluation

Get an evaluation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvaluation" method="get" path="/api/reconciliation/evaluations/{evaluationID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.GetEvaluationAsync(evaluationID: "121717d3-a7d1-444d-9d11-6ea2dc0d3db5");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `EvaluationID`     | *string*           | :heavy_check_mark: | The evaluation ID. |

### Response

**[GetEvaluationResponse](../../Models/Requests/GetEvaluationResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## ListAlerts

List alerts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAlerts" method="get" path="/api/reconciliation/alerts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ListAlertsAsync(
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
| `RequestBody`                                                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                                                      |                                                                                                                                                                                                                                                          |

### Response

**[ListAlertsResponse](../../Models/Requests/ListAlertsResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## GetAlert

Get an alert

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAlert" method="get" path="/api/reconciliation/alerts/{alertID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.GetAlertAsync(alertID: "c7c54af9-81a4-4208-844b-4f25f89cf8a1");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AlertID`          | *string*           | :heavy_check_mark: | The alert ID.      |

### Response

**[GetAlertResponse](../../Models/Requests/GetAlertResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## ListAlertEvents

Returns a page of the events recorded for this alert — every evaluation
that touched it plus every manual transition. The list is append-only;
events are never modified or deleted. Ordered most-recent-first and
cursor-paginated: a long-lived alert's timeline is unbounded (one row per
failing evaluation), so callers must page through it.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAlertEvents" method="get" path="/api/reconciliation/alerts/{alertID}/events" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ListAlertEventsAsync(
    alertID: "259536e6-acd5-4e38-9154-10e46ea2bc63",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `AlertID`                                                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                                                       | The alert ID.                                                                                                                                                                                                                                            |                                                                                                                                                                                                                                                          |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |

### Response

**[ListAlertEventsResponse](../../Models/Requests/ListAlertEventsResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## AckAlert

Acknowledge an alert

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ackAlert" method="post" path="/api/reconciliation/alerts/{alertID}/ack" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.AckAlertAsync(
    alertID: "5439ab64-6482-49fb-993f-3411bfe19fef",
    ackAlertRequest: new FormanceSDK.Models.Reconciliation.AckAlertRequest() {
        By = "ops@buildr.com",
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `AlertID`                                                                               | *string*                                                                                | :heavy_check_mark:                                                                      | The alert ID.                                                                           |
| `AckAlertRequest`                                                                       | [Models.Reconciliation.AckAlertRequest](../../Models/Reconciliation/AckAlertRequest.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |

### Response

**[AckAlertResponse](../../Models/Requests/AckAlertResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## ResolveAlert

Resolve an alert (fixed_by_booking)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="resolveAlert" method="post" path="/api/reconciliation/alerts/{alertID}/resolve" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.ResolveAlertAsync(
    alertID: "53527ec3-b39f-4eee-ac1d-6e2bad87f240",
    resolveAlertRequest: new FormanceSDK.Models.Reconciliation.ResolveAlertRequest() {
        By = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `AlertID`                                                                                       | *string*                                                                                        | :heavy_check_mark:                                                                              | The alert ID.                                                                                   |
| `ResolveAlertRequest`                                                                           | [Models.Reconciliation.ResolveAlertRequest](../../Models/Reconciliation/ResolveAlertRequest.md) | :heavy_check_mark:                                                                              | N/A                                                                                             |

### Response

**[ResolveAlertResponse](../../Models/Requests/ResolveAlertResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## AcceptAlert

Accept an alert (accepted_by_business)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="acceptAlert" method="post" path="/api/reconciliation/alerts/{alertID}/accept" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.AcceptAlertAsync(
    alertID: "5550ef95-072d-4bbb-9d3b-6a9dd307b2bd",
    acceptAlertRequest: new FormanceSDK.Models.Reconciliation.AcceptAlertRequest() {
        By = "<value>",
        Note = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `AlertID`                                                                                     | *string*                                                                                      | :heavy_check_mark:                                                                            | The alert ID.                                                                                 |
| `AcceptAlertRequest`                                                                          | [Models.Reconciliation.AcceptAlertRequest](../../Models/Reconciliation/AcceptAlertRequest.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |

### Response

**[AcceptAlertResponse](../../Models/Requests/AcceptAlertResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## SnoozeAlert

Mutes the alert's webhook notifications until `until`. The alert keeps
failing, keeps its status, and keeps counting against period-green —
only its notifications are suppressed, even if the discrepancy changes.
The first failing evaluation at or after `until` clears the snooze and
notifies once. Re-snoozing overwrites the window. Rejects RESOLVED
alerts and a non-future `until`.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="snoozeAlert" method="post" path="/api/reconciliation/alerts/{alertID}/snooze" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.SnoozeAlertAsync(
    alertID: "96529a25-9005-499e-a0ec-daa0ae32f4cb",
    snoozeAlertRequest: new FormanceSDK.Models.Reconciliation.SnoozeAlertRequest() {
        By = "ops@buildr.com",
        Until = System.DateTime.Parse("2026-07-17T12:27:27.142Z").ToUniversalTime(),
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `AlertID`                                                                                     | *string*                                                                                      | :heavy_check_mark:                                                                            | The alert ID.                                                                                 |
| `SnoozeAlertRequest`                                                                          | [Models.Reconciliation.SnoozeAlertRequest](../../Models/Reconciliation/SnoozeAlertRequest.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |

### Response

**[SnoozeAlertResponse](../../Models/Requests/SnoozeAlertResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |

## UnsnoozeAlert

Clears an active snooze before its window elapses. Idempotent —
unsnoozing an alert that is not snoozed returns it unchanged.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="unsnoozeAlert" method="post" path="/api/reconciliation/alerts/{alertID}/unsnooze" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Reconciliation.V1.UnsnoozeAlertAsync(
    alertID: "a1f12fdd-d9de-483a-b3c6-41ec79a76231",
    unsnoozeAlertRequest: new FormanceSDK.Models.Reconciliation.UnsnoozeAlertRequest() {
        By = "ops@buildr.com",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `AlertID`                                                                                         | *string*                                                                                          | :heavy_check_mark:                                                                                | The alert ID.                                                                                     |
| `UnsnoozeAlertRequest`                                                                            | [Models.Reconciliation.UnsnoozeAlertRequest](../../Models/Reconciliation/UnsnoozeAlertRequest.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |

### Response

**[UnsnoozeAlertResponse](../../Models/Requests/UnsnoozeAlertResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| FormanceSDK.Models.Reconciliation.ErrorResponseError | default                                              | application/json                                     |
| FormanceSDK.Models.Errors.SDKException               | 4XX, 5XX                                             | \*/\*                                                |