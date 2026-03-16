# Ledger.V2

## Overview

### Available Operations

* [ListLedgers](#listledgers) - List ledgers
* [GetLedger](#getledger) - Get a ledger
* [CreateLedger](#createledger) - Create a ledger
* [InsertSchema](#insertschema) - Insert a schema for a ledger
* [GetSchema](#getschema) - Get a schema for a ledger by version
* [ListSchemas](#listschemas) - List all schemas for a ledger
* [UpdateLedgerMetadata](#updateledgermetadata) - Update ledger metadata
* [DeleteLedgerMetadata](#deleteledgermetadata) - Delete ledger metadata by key
* [GetLedgerInfo](#getledgerinfo) - Get information about a ledger
* [CreateBulk](#createbulk) - Bulk request
* [CountAccounts](#countaccounts) - Count the accounts from a ledger
* [ListAccounts](#listaccounts) - List accounts from a ledger
* [GetAccount](#getaccount) - Get account by its address
* [AddMetadataToAccount](#addmetadatatoaccount) - Add metadata to an account
* [DeleteAccountMetadata](#deleteaccountmetadata) - Delete metadata by key
* [ReadStats](#readstats) - Get statistics from a ledger
* [CountTransactions](#counttransactions) - Count the transactions from a ledger
* [ListTransactions](#listtransactions) - List transactions from a ledger
* [CreateTransaction](#createtransaction) - Create a new transaction to a ledger
* [GetTransaction](#gettransaction) - Get transaction from a ledger by its ID
* [AddMetadataOnTransaction](#addmetadataontransaction) - Set the metadata of a transaction by its ID
* [DeleteTransactionMetadata](#deletetransactionmetadata) - Delete metadata by key
* [RevertTransaction](#reverttransaction) - Revert a ledger transaction by its ID
* [GetBalancesAggregated](#getbalancesaggregated) - Get the aggregated balances from selected accounts
* [GetVolumesWithBalances](#getvolumeswithbalances) - Get list of volumes with balances for (account/asset)
* [ListLogs](#listlogs) - List the logs from a ledger
* [ImportLogs](#importlogs)
* [ExportLogs](#exportlogs) - Export logs
* [RunQuery](#runquery) - Run a query template
* [ListExporters](#listexporters) - List exporters
* [CreateExporter](#createexporter) - Create exporter
* [GetExporterState](#getexporterstate) - Get exporter state
* [UpdateExporter](#updateexporter) - Update exporter
* [DeleteExporter](#deleteexporter) - Delete exporter
* [DeleteBucket](#deletebucket) - Delete bucket
* [RestoreBucket](#restorebucket) - Restore bucket
* [ListPipelines](#listpipelines) - List pipelines
* [CreatePipeline](#createpipeline) - Create pipeline
* [GetPipelineState](#getpipelinestate) - Get pipeline state
* [DeletePipeline](#deletepipeline) - Delete pipeline
* [ResetPipeline](#resetpipeline) - Reset pipeline
* [StartPipeline](#startpipeline) - Start pipeline
* [StopPipeline](#stoppipeline) - Stop pipeline

## ListLedgers

List ledgers

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ListLedgers" method="get" path="/api/ledger/v2" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.ListLedgersAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    includeDeleted: false,
    sort: "id:desc"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |
| `IncludeDeleted`                                                                                                                                                                                                                                         | *bool*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | If true, include deleted ledgers in the results. By default, deleted ledgers are excluded.<br/>                                                                                                                                                          | false                                                                                                                                                                                                                                                    |
| `Sort`                                                                                                                                                                                                                                                   | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Sort results using a field name and order (ascending or descending).<br/>Format: `<field>:<order>`, where `<field>` is the field name and `<order>` is either `asc` or `desc`.<br/>                                                                      | id:desc                                                                                                                                                                                                                                                  |

### Response

**[V2ListLedgersResponse](../../Models/Requests/V2ListLedgersResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetLedger

Get a ledger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetLedger" method="get" path="/api/ledger/v2/{ledger}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetLedgerAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |

### Response

**[Models.Requests.V2GetLedgerResponse](../../Models/Requests/V2GetLedgerResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CreateLedger

Create a ledger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2CreateLedger" method="post" path="/api/ledger/v2/{ledger}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.CreateLedgerAsync(
    ledger: "ledger001",
    v2CreateLedgerRequest: new FormanceSDK.Models.Components.V2CreateLedgerRequest() {
        Metadata = new Dictionary<string, string>() {
            { "admin", "true" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 | Example                                                                                     |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Ledger`                                                                                    | *string*                                                                                    | :heavy_check_mark:                                                                          | Name of the ledger.                                                                         | ledger001                                                                                   |
| `V2CreateLedgerRequest`                                                                     | [Models.Components.V2CreateLedgerRequest](../../Models/Components/V2CreateLedgerRequest.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |                                                                                             |

### Response

**[V2CreateLedgerResponse](../../Models/Requests/V2CreateLedgerResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## InsertSchema

Insert a schema for a ledger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2InsertSchema" method="post" path="/api/ledger/v2/{ledger}/schemas/{version}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.InsertSchemaAsync(
    ledger: "ledger001",
    version: "v1.0.0",
    v2SchemaData: new V2SchemaData() {
        Chart = new Dictionary<string, V2ChartSegment>() {
            { "users", new V2ChartSegment() {
                AdditionalProperties = new Dictionary<string, V2ChartSegment>() {
                    { "$userID", new V2ChartSegment() {
                        DotPattern = "^[0-9]{16}$",
                    } },
                },
            } },
        },
        Queries = new Dictionary<string, V2QueryTemplate>() {
            { "key", new V2QueryTemplate() {
                Params = V2QueryParams.CreateQueryTemplateAccountParams(
                    new QueryTemplateAccountParams() {
                        PageSize = 100,
                        Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
                        Sort = "id:desc",
                    }
                ),
            } },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             | Example                                                 |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Ledger`                                                | *string*                                                | :heavy_check_mark:                                      | Name of the ledger.                                     | ledger001                                               |
| `Version`                                               | *string*                                                | :heavy_check_mark:                                      | Schema version.                                         | v1.0.0                                                  |
| `V2SchemaData`                                          | [V2SchemaData](../../Models/Components/V2SchemaData.md) | :heavy_check_mark:                                      | N/A                                                     |                                                         |
| `IdempotencyKey`                                        | *string*                                                | :heavy_minus_sign:                                      | Use an idempotency key                                  |                                                         |

### Response

**[V2InsertSchemaResponse](../../Models/Requests/V2InsertSchemaResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetSchema

Get a schema for a ledger by version

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetSchema" method="get" path="/api/ledger/v2/{ledger}/schemas/{version}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetSchemaAsync(
    ledger: "ledger001",
    version: "v1.0.0"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `Version`           | *string*            | :heavy_check_mark:  | Schema version.     | v1.0.0              |

### Response

**[V2GetSchemaResponse](../../Models/Requests/V2GetSchemaResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListSchemas

List all schemas for a ledger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ListSchemas" method="get" path="/api/ledger/v2/{ledger}/schemas" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2ListSchemasRequest req = new V2ListSchemasRequest() {
    Ledger = "ledger001",
};

var res = await sdk.Ledger.V2.ListSchemasAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [V2ListSchemasRequest](../../Models/Requests/V2ListSchemasRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[V2ListSchemasResponse](../../Models/Requests/V2ListSchemasResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## UpdateLedgerMetadata

Update ledger metadata

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2UpdateLedgerMetadata" method="put" path="/api/ledger/v2/{ledger}/metadata" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.UpdateLedgerMetadataAsync(
    ledger: "ledger001",
    requestBody: new Dictionary<string, string>() {
        { "admin", "true" },
    }
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  | Example                      |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `Ledger`                     | *string*                     | :heavy_check_mark:           | Name of the ledger.          | ledger001                    |
| `RequestBody`                | Dictionary<String, *string*> | :heavy_check_mark:           | N/A                          | {<br/>"admin": "true"<br/>}  |

### Response

**[V2UpdateLedgerMetadataResponse](../../Models/Requests/V2UpdateLedgerMetadataResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeleteLedgerMetadata

Delete ledger metadata by key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2DeleteLedgerMetadata" method="delete" path="/api/ledger/v2/{ledger}/metadata/{key}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.DeleteLedgerMetadataAsync(
    ledger: "ledger001",
    key: "foo"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `Key`               | *string*            | :heavy_check_mark:  | Key to remove.      | foo                 |

### Response

**[V2DeleteLedgerMetadataResponse](../../Models/Requests/V2DeleteLedgerMetadataResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetLedgerInfo

Get information about a ledger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetLedgerInfo" method="get" path="/api/ledger/v2/{ledger}/_info" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetLedgerInfoAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |

### Response

**[V2GetLedgerInfoResponse](../../Models/Requests/V2GetLedgerInfoResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CreateBulk

Bulk request

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2CreateBulk" method="post" path="/api/ledger/v2/{ledger}/_bulk" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2CreateBulkRequest req = new V2CreateBulkRequest() {
    Ledger = "ledger001",
    ContinueOnFailure = true,
    Atomic = true,
    Parallel = true,
    SchemaVersion = "v1.0.0",
    RequestBody = new List<V2BulkElement>() {
        V2BulkElement.CreateDeleteMetadata(
            new V2BulkElementDeleteMetadata() {
                Action = "DELETE_METADATA",
            }
        ),
    },
};

var res = await sdk.Ledger.V2.CreateBulkAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [V2CreateBulkRequest](../../Models/Requests/V2CreateBulkRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[V2CreateBulkResponse](../../Models/Requests/V2CreateBulkResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CountAccounts

Count the accounts from a ledger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2CountAccounts" method="head" path="/api/ledger/v2/{ledger}/accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.CountAccountsAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Ledger`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | Name of the ledger.                                                                   | ledger001                                                                             |
| `Pit`                                                                                 | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |

### Response

**[V2CountAccountsResponse](../../Models/Requests/V2CountAccountsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListAccounts

List accounts from a ledger, sorted by address in descending order.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ListAccounts" method="get" path="/api/ledger/v2/{ledger}/accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2ListAccountsRequest req = new V2ListAccountsRequest() {
    Ledger = "ledger001",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    Sort = "id:desc",
};

var res = await sdk.Ledger.V2.ListAccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [V2ListAccountsRequest](../../Models/Requests/V2ListAccountsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[V2ListAccountsResponse](../../Models/Requests/V2ListAccountsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetAccount

Get account by its address

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetAccount" method="get" path="/api/ledger/v2/{ledger}/accounts/{address}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetAccountAsync(
    ledger: "ledger001",
    address: "users:001"
);

// handle response
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  | Example                                                                                                      |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `Ledger`                                                                                                     | *string*                                                                                                     | :heavy_check_mark:                                                                                           | Name of the ledger.                                                                                          | ledger001                                                                                                    |
| `Address`                                                                                                    | *string*                                                                                                     | :heavy_check_mark:                                                                                           | Exact address of the account. It must match the following regular expressions pattern:<br/>```<br/>^\w+(:\w+)*$<br/>```<br/> | users:001                                                                                                    |
| `Expand`                                                                                                     | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | N/A                                                                                                          |                                                                                                              |
| `Pit`                                                                                                        | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)                        | :heavy_minus_sign:                                                                                           | N/A                                                                                                          |                                                                                                              |

### Response

**[V2GetAccountResponse](../../Models/Requests/V2GetAccountResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## AddMetadataToAccount

Add metadata to an account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2AddMetadataToAccount" method="post" path="/api/ledger/v2/{ledger}/accounts/{address}/metadata" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2AddMetadataToAccountRequest req = new V2AddMetadataToAccountRequest() {
    Ledger = "ledger001",
    Address = "users:001",
    DryRun = true,
    SchemaVersion = "v1.0.0",
    RequestBody = new Dictionary<string, string>() {
        { "admin", "true" },
    },
};

var res = await sdk.Ledger.V2.AddMetadataToAccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [V2AddMetadataToAccountRequest](../../Models/Requests/V2AddMetadataToAccountRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[V2AddMetadataToAccountResponse](../../Models/Requests/V2AddMetadataToAccountResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeleteAccountMetadata

Delete metadata by key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2DeleteAccountMetadata" method="delete" path="/api/ledger/v2/{ledger}/accounts/{address}/metadata/{key}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.DeleteAccountMetadataAsync(
    ledger: "ledger001",
    address: "6753 S Washington Street",
    key: "foo"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            | Example                |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `Ledger`               | *string*               | :heavy_check_mark:     | Name of the ledger.    | ledger001              |
| `Address`              | *string*               | :heavy_check_mark:     | Account address        |                        |
| `Key`                  | *string*               | :heavy_check_mark:     | The key to remove.     | foo                    |
| `IdempotencyKey`       | *string*               | :heavy_minus_sign:     | Use an idempotency key |                        |

### Response

**[V2DeleteAccountMetadataResponse](../../Models/Requests/V2DeleteAccountMetadataResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ReadStats

Get statistics from a ledger. (aggregate metrics on accounts and transactions)


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ReadStats" method="get" path="/api/ledger/v2/{ledger}/stats" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.ReadStatsAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `Ledger`           | *string*           | :heavy_check_mark: | name of the ledger | ledger001          |

### Response

**[V2ReadStatsResponse](../../Models/Requests/V2ReadStatsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CountTransactions

Count the transactions from a ledger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2CountTransactions" method="head" path="/api/ledger/v2/{ledger}/transactions" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.CountTransactionsAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Ledger`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | Name of the ledger.                                                                   | ledger001                                                                             |
| `Pit`                                                                                 | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |

### Response

**[V2CountTransactionsResponse](../../Models/Requests/V2CountTransactionsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListTransactions

List transactions from a ledger, sorted by id in descending order.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ListTransactions" method="get" path="/api/ledger/v2/{ledger}/transactions" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2ListTransactionsRequest req = new V2ListTransactionsRequest() {
    Ledger = "ledger001",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    Sort = "id:desc",
};

var res = await sdk.Ledger.V2.ListTransactionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [V2ListTransactionsRequest](../../Models/Requests/V2ListTransactionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[V2ListTransactionsResponse](../../Models/Requests/V2ListTransactionsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CreateTransaction

Create a new transaction to a ledger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2CreateTransaction" method="post" path="/api/ledger/v2/{ledger}/transactions" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2CreateTransactionRequest req = new V2CreateTransactionRequest() {
    Ledger = "ledger001",
    DryRun = true,
    Force = true,
    SchemaVersion = "v1.0.0",
    V2PostTransaction = new V2PostTransaction() {
        Postings = new List<V2Posting>() {
            new V2Posting() {
                Amount = BigInteger.Parse("100"),
                Asset = "COIN",
                Destination = "users:002",
                Source = "users:001",
            },
        },
        Script = new V2PostTransactionScript() {
            Template = "CUSTOMER_DEPOSIT",
            Plain = @"vars {
            account $user
            }
            send [COIN 10] (
            	source = @world
            	destination = $user
            )
            ",
            Vars = new Dictionary<string, string>() {
                { "user", "users:042" },
            },
        },
        Reference = "ref:001",
        Metadata = new Dictionary<string, string>() {
            { "admin", "true" },
        },
        AccountMetadata = new Dictionary<string, Dictionary<string, string>>() {
            { "key", new Dictionary<string, string>() {
                { "admin", "true" },
            } },
            { "key1", new Dictionary<string, string>() {
                { "admin", "true" },
            } },
            { "key2", new Dictionary<string, string>() {
                { "admin", "true" },
            } },
        },
    },
};

var res = await sdk.Ledger.V2.CreateTransactionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [V2CreateTransactionRequest](../../Models/Requests/V2CreateTransactionRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[Models.Requests.V2CreateTransactionResponse](../../Models/Requests/V2CreateTransactionResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetTransaction

Get transaction from a ledger by its ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetTransaction" method="get" path="/api/ledger/v2/{ledger}/transactions/{id}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetTransactionAsync(
    ledger: "ledger001",
    id: BigInteger.Parse("1234")
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Ledger`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | Name of the ledger.                                                                   | ledger001                                                                             |
| `Id`                                                                                  | *BigInteger*                                                                          | :heavy_check_mark:                                                                    | Transaction ID.                                                                       | 1234                                                                                  |
| `Expand`                                                                              | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `Pit`                                                                                 | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |

### Response

**[Models.Requests.V2GetTransactionResponse](../../Models/Requests/V2GetTransactionResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## AddMetadataOnTransaction

Set the metadata of a transaction by its ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2AddMetadataOnTransaction" method="post" path="/api/ledger/v2/{ledger}/transactions/{id}/metadata" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2AddMetadataOnTransactionRequest req = new V2AddMetadataOnTransactionRequest() {
    Ledger = "ledger001",
    Id = BigInteger.Parse("1234"),
    DryRun = true,
    SchemaVersion = "v1.0.0",
    RequestBody = new Dictionary<string, string>() {
        { "admin", "true" },
    },
};

var res = await sdk.Ledger.V2.AddMetadataOnTransactionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [V2AddMetadataOnTransactionRequest](../../Models/Requests/V2AddMetadataOnTransactionRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[V2AddMetadataOnTransactionResponse](../../Models/Requests/V2AddMetadataOnTransactionResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeleteTransactionMetadata

Delete metadata by key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2DeleteTransactionMetadata" method="delete" path="/api/ledger/v2/{ledger}/transactions/{id}/metadata/{key}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.DeleteTransactionMetadataAsync(
    ledger: "ledger001",
    id: BigInteger.Parse("1234"),
    key: "foo"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            | Example                |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `Ledger`               | *string*               | :heavy_check_mark:     | Name of the ledger.    | ledger001              |
| `Id`                   | *BigInteger*           | :heavy_check_mark:     | Transaction ID.        | 1234                   |
| `Key`                  | *string*               | :heavy_check_mark:     | The key to remove.     | foo                    |
| `IdempotencyKey`       | *string*               | :heavy_minus_sign:     | Use an idempotency key |                        |

### Response

**[V2DeleteTransactionMetadataResponse](../../Models/Requests/V2DeleteTransactionMetadataResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## RevertTransaction

Revert a ledger transaction by its ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2RevertTransaction" method="post" path="/api/ledger/v2/{ledger}/transactions/{id}/revert" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

Models.Requests.V2RevertTransactionRequest req = new FormanceSDK.Models.Requests.V2RevertTransactionRequest() {
    Ledger = "ledger001",
    Id = BigInteger.Parse("1234"),
    DryRun = true,
    SchemaVersion = "v1.0.0",
};

var res = await sdk.Ledger.V2.RevertTransactionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [Models.Requests.V2RevertTransactionRequest](../../Models/Requests/V2RevertTransactionRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[Models.Requests.V2RevertTransactionResponse](../../Models/Requests/V2RevertTransactionResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetBalancesAggregated

Get the aggregated balances from selected accounts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetBalancesAggregated" method="get" path="/api/ledger/v2/{ledger}/aggregate/balances" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetBalancesAggregatedAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Ledger`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | Name of the ledger.                                                                   | ledger001                                                                             |
| `Pit`                                                                                 | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `UseInsertionDate`                                                                    | *bool*                                                                                | :heavy_minus_sign:                                                                    | Use insertion date instead of effective date                                          |                                                                                       |

### Response

**[V2GetBalancesAggregatedResponse](../../Models/Requests/V2GetBalancesAggregatedResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetVolumesWithBalances

Get list of volumes with balances for (account/asset)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetVolumesWithBalances" method="get" path="/api/ledger/v2/{ledger}/volumes" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2GetVolumesWithBalancesRequest req = new V2GetVolumesWithBalancesRequest() {
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    Ledger = "ledger001",
    GroupBy = 3,
    Sort = "id:desc",
};

var res = await sdk.Ledger.V2.GetVolumesWithBalancesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [V2GetVolumesWithBalancesRequest](../../Models/Requests/V2GetVolumesWithBalancesRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[V2GetVolumesWithBalancesResponse](../../Models/Requests/V2GetVolumesWithBalancesResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListLogs

List the logs from a ledger, sorted by ID in descending order.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ListLogs" method="get" path="/api/ledger/v2/{ledger}/logs" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2ListLogsRequest req = new V2ListLogsRequest() {
    Ledger = "ledger001",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    Sort = "id:desc",
};

var res = await sdk.Ledger.V2.ListLogsAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [V2ListLogsRequest](../../Models/Requests/V2ListLogsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[V2ListLogsResponse](../../Models/Requests/V2ListLogsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ImportLogs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ImportLogs" method="post" path="/api/ledger/v2/{ledger}/logs/import" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.ImportLogsAsync(
    ledger: "ledger001",
    v2ImportLogsRequest: System.Text.Encoding.UTF8.GetBytes("0xde3EDEE9e6")
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           | Example               |
| --------------------- | --------------------- | --------------------- | --------------------- | --------------------- |
| `Ledger`              | *string*              | :heavy_check_mark:    | Name of the ledger.   | ledger001             |
| `V2ImportLogsRequest` | *byte[]*              | :heavy_check_mark:    | N/A                   |                       |

### Response

**[V2ImportLogsResponse](../../Models/Requests/V2ImportLogsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ExportLogs

Export logs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ExportLogs" method="post" path="/api/ledger/v2/{ledger}/logs/export" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.ExportLogsAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |

### Response

**[V2ExportLogsResponse](../../Models/Requests/V2ExportLogsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## RunQuery

Run a query template on a ledger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2RunQuery" method="post" path="/api/ledger/v2/{ledger}/queries/{id}/run" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2RunQueryRequest req = new V2RunQueryRequest() {
    Ledger = "ledger001",
    SchemaVersion = "v1.0.0",
    Id = "CUSTOMER_DEPOSIT",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    Sort = "id:desc",
    RequestBody = new V2RunQueryRequestBody() {
        Params = V2QueryParams.CreateQueryTemplateAccountParams(
            new QueryTemplateAccountParams() {
                PageSize = 100,
                Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
                Sort = "id:desc",
            }
        ),
    },
};

var res = await sdk.Ledger.V2.RunQueryAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [V2RunQueryRequest](../../Models/Requests/V2RunQueryRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[V2RunQueryResponse](../../Models/Requests/V2RunQueryResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListExporters

List exporters

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ListExporters" method="get" path="/api/ledger/v2/_/exporters" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.ListExportersAsync();

// handle response
```

### Response

**[Models.Requests.V2ListExportersResponse](../../Models/Requests/V2ListExportersResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CreateExporter

Create exporter

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2CreateExporter" method="post" path="/api/ledger/v2/_/exporters" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2CreateExporterRequest req = new V2CreateExporterRequest() {
    Driver = "<value>",
    Config = new Dictionary<string, object>() {
        { "key", "<value>" },
    },
};

var res = await sdk.Ledger.V2.CreateExporterAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [V2CreateExporterRequest](../../Models/Components/V2CreateExporterRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[Models.Requests.V2CreateExporterResponse](../../Models/Requests/V2CreateExporterResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetExporterState

Get exporter state

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetExporterState" method="get" path="/api/ledger/v2/_/exporters/{exporterID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetExporterStateAsync(exporterID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ExporterID`       | *string*           | :heavy_check_mark: | The exporter id    |

### Response

**[Models.Requests.V2GetExporterStateResponse](../../Models/Requests/V2GetExporterStateResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## UpdateExporter

Update exporter

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2UpdateExporter" method="put" path="/api/ledger/v2/_/exporters/{exporterID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.UpdateExporterAsync(
    exporterID: "<id>",
    v2CreateExporterRequest: new V2CreateExporterRequest() {
        Driver = "<value>",
        Config = new Dictionary<string, object>() {
            { "key", "<value>" },
            { "key1", "<value>" },
            { "key2", "<value>" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `ExporterID`                                                                  | *string*                                                                      | :heavy_check_mark:                                                            | The exporter id                                                               |
| `V2CreateExporterRequest`                                                     | [V2CreateExporterRequest](../../Models/Components/V2CreateExporterRequest.md) | :heavy_check_mark:                                                            | N/A                                                                           |

### Response

**[V2UpdateExporterResponse](../../Models/Requests/V2UpdateExporterResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeleteExporter

Delete exporter

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2DeleteExporter" method="delete" path="/api/ledger/v2/_/exporters/{exporterID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.DeleteExporterAsync(exporterID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ExporterID`       | *string*           | :heavy_check_mark: | The exporter id    |

### Response

**[V2DeleteExporterResponse](../../Models/Requests/V2DeleteExporterResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeleteBucket

Delete a bucket by marking all ledgers in the bucket as deleted (soft delete). All ledgers in the bucket will have their deleted_at field set to the current timestamp.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2DeleteBucket" method="delete" path="/api/ledger/v2/_/buckets/{bucket}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.DeleteBucketAsync(bucket: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Bucket`           | *string*           | :heavy_check_mark: | The bucket name    |

### Response

**[V2DeleteBucketResponse](../../Models/Requests/V2DeleteBucketResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## RestoreBucket

Restore a deleted bucket by unmarking all ledgers in the bucket as deleted. All ledgers in the bucket will have their deleted_at field set to NULL.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2RestoreBucket" method="post" path="/api/ledger/v2/_/buckets/{bucket}/restore" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.RestoreBucketAsync(bucket: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Bucket`           | *string*           | :heavy_check_mark: | The bucket name    |

### Response

**[V2RestoreBucketResponse](../../Models/Requests/V2RestoreBucketResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListPipelines

List pipelines

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ListPipelines" method="get" path="/api/ledger/v2/{ledger}/pipelines" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.ListPipelinesAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |

### Response

**[Models.Requests.V2ListPipelinesResponse](../../Models/Requests/V2ListPipelinesResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CreatePipeline

Create pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2CreatePipeline" method="post" path="/api/ledger/v2/{ledger}/pipelines" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.CreatePipelineAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `Ledger`                                                                                        | *string*                                                                                        | :heavy_check_mark:                                                                              | Name of the ledger.                                                                             | ledger001                                                                                       |
| `V2CreatePipelineRequest`                                                                       | [Models.Components.V2CreatePipelineRequest](../../Models/Components/V2CreatePipelineRequest.md) | :heavy_minus_sign:                                                                              | N/A                                                                                             |                                                                                                 |

### Response

**[Models.Requests.V2CreatePipelineResponse](../../Models/Requests/V2CreatePipelineResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetPipelineState

Get pipeline state

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2GetPipelineState" method="get" path="/api/ledger/v2/{ledger}/pipelines/{pipelineID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetPipelineStateAsync(
    ledger: "ledger001",
    pipelineID: "<id>"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `PipelineID`        | *string*            | :heavy_check_mark:  | The pipeline id     |                     |

### Response

**[Models.Requests.V2GetPipelineStateResponse](../../Models/Requests/V2GetPipelineStateResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeletePipeline

Delete pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2DeletePipeline" method="delete" path="/api/ledger/v2/{ledger}/pipelines/{pipelineID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.DeletePipelineAsync(
    ledger: "ledger001",
    pipelineID: "<id>"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `PipelineID`        | *string*            | :heavy_check_mark:  | The pipeline id     |                     |

### Response

**[V2DeletePipelineResponse](../../Models/Requests/V2DeletePipelineResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ResetPipeline

Reset pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2ResetPipeline" method="post" path="/api/ledger/v2/{ledger}/pipelines/{pipelineID}/reset" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.ResetPipelineAsync(
    ledger: "ledger001",
    pipelineID: "<id>"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `PipelineID`        | *string*            | :heavy_check_mark:  | The pipeline id     |                     |

### Response

**[V2ResetPipelineResponse](../../Models/Requests/V2ResetPipelineResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## StartPipeline

Start pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2StartPipeline" method="post" path="/api/ledger/v2/{ledger}/pipelines/{pipelineID}/start" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.StartPipelineAsync(
    ledger: "ledger001",
    pipelineID: "<id>"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `PipelineID`        | *string*            | :heavy_check_mark:  | The pipeline id     |                     |

### Response

**[V2StartPipelineResponse](../../Models/Requests/V2StartPipelineResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## StopPipeline

Stop pipeline

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v2StopPipeline" method="post" path="/api/ledger/v2/{ledger}/pipelines/{pipelineID}/stop" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.StopPipelineAsync(
    ledger: "ledger001",
    pipelineID: "<id>"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `PipelineID`        | *string*            | :heavy_check_mark:  | The pipeline id     |                     |

### Response

**[V2StopPipelineResponse](../../Models/Requests/V2StopPipelineResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V2ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |