# V2
(*Ledger.V2*)

## Overview

### Available Operations

* [GetInfo](#getinfo) - Show server information
* [ListLedgers](#listledgers) - List ledgers
* [GetLedger](#getledger) - Get a ledger
* [CreateLedger](#createledger) - Create a ledger
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

## GetInfo

Show server information

### Example Usage

```csharp
using formance;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetInfoAsync();

// handle response
```

### Response

**[V2GetInfoResponse](../../Models/Requests/V2GetInfoResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## ListLedgers

List ledgers

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.ListLedgersAsync(
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

**[V2ListLedgersResponse](../../Models/Requests/V2ListLedgersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## GetLedger

Get a ledger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## CreateLedger

Create a ledger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.CreateLedgerAsync(
    ledger: "ledger001",
    v2CreateLedgerRequest: new Models.Components.V2CreateLedgerRequest() {
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
| `V2CreateLedgerRequest`                                                                     | [Models.Components.V2CreateLedgerRequest](../../Models/Components/V2CreateLedgerRequest.md) | :heavy_minus_sign:                                                                          | N/A                                                                                         |                                                                                             |

### Response

**[V2CreateLedgerResponse](../../Models/Requests/V2CreateLedgerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## UpdateLedgerMetadata

Update ledger metadata

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

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
| `RequestBody`                | Dictionary<String, *string*> | :heavy_minus_sign:           | N/A                          | {<br/>"admin": "true"<br/>}  |

### Response

**[V2UpdateLedgerMetadataResponse](../../Models/Requests/V2UpdateLedgerMetadataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## DeleteLedgerMetadata

Delete ledger metadata by key

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## GetLedgerInfo

Get information about a ledger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## CreateBulk

Bulk request

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.CreateBulkAsync(
    ledger: "ledger001",
    requestBody: new List<V2BulkElement>() {
        V2BulkElement.CreateV2BulkElementCreateTransaction(
            new V2BulkElementCreateTransaction() {
                Action = "<value>",
                Data = new V2PostTransaction() {
                    Postings = new List<V2Posting>() {
                        new V2Posting() {
                            Amount = 100,
                            Asset = "COIN",
                            Destination = "users:002",
                            Source = "users:001",
                        },
                    },
                    Script = new V2PostTransactionScript() {
                        Plain = "vars {
                        account $user
                        }
                        send [COIN 10] (
                        	source = @world
                        	destination = $user
                        )
                        ",
                        Vars = new Dictionary<string, object>() {
                            { "user", "users:042" },
                        },
                    },
                    Reference = "ref:001",
                    Metadata = new Dictionary<string, string>() {
                        { "admin", "true" },
                    },
                },
            }
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     | Example                                                         |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `Ledger`                                                        | *string*                                                        | :heavy_check_mark:                                              | Name of the ledger.                                             | ledger001                                                       |
| `RequestBody`                                                   | List<[V2BulkElement](../../Models/Components/V2BulkElement.md)> | :heavy_minus_sign:                                              | N/A                                                             |                                                                 |

### Response

**[V2CreateBulkResponse](../../Models/Requests/V2CreateBulkResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## CountAccounts

Count the accounts from a ledger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.CountAccountsAsync(
    ledger: "ledger001",
    pit: System.DateTime.Parse("2022-10-10T12:32:37.688Z"),
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Ledger`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | Name of the ledger.                                                                   | ledger001                                                                             |
| `Pit`                                                                                 | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `RequestBody`                                                                         | Dictionary<String, *object*>                                                          | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |

### Response

**[V2CountAccountsResponse](../../Models/Requests/V2CountAccountsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## ListAccounts

List accounts from a ledger, sorted by address in descending order.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2ListAccountsRequest req = new V2ListAccountsRequest() {
    Ledger = "ledger001",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## GetAccount

Get account by its address

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetAccountAsync(
    ledger: "ledger001",
    address: "users:001",
    expand: "<value>",
    pit: System.DateTime.Parse("2022-06-03T07:35:25.500Z")
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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## AddMetadataToAccount

Add metadata to an account

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2AddMetadataToAccountRequest req = new V2AddMetadataToAccountRequest() {
    Ledger = "ledger001",
    Address = "users:001",
    DryRun = true,
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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## DeleteAccountMetadata

Delete metadata by key

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.DeleteAccountMetadataAsync(
    ledger: "ledger001",
    address: "96609 Cummings Canyon",
    key: "foo"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `Address`           | *string*            | :heavy_check_mark:  | Account address     |                     |
| `Key`               | *string*            | :heavy_check_mark:  | The key to remove.  | foo                 |

### Response

**[V2DeleteAccountMetadataResponse](../../Models/Requests/V2DeleteAccountMetadataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## ReadStats

Get statistics from a ledger. (aggregate metrics on accounts and transactions)


### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## CountTransactions

Count the transactions from a ledger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.CountTransactionsAsync(
    ledger: "ledger001",
    pit: System.DateTime.Parse("2023-09-24T09:44:43.699Z"),
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Ledger`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | Name of the ledger.                                                                   | ledger001                                                                             |
| `Pit`                                                                                 | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `RequestBody`                                                                         | Dictionary<String, *object*>                                                          | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |

### Response

**[V2CountTransactionsResponse](../../Models/Requests/V2CountTransactionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## ListTransactions

List transactions from a ledger, sorted by id in descending order.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2ListTransactionsRequest req = new V2ListTransactionsRequest() {
    Ledger = "ledger001",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## CreateTransaction

Create a new transaction to a ledger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;
using System.Collections.Generic;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.CreateTransactionAsync(
    ledger: "ledger001",
    v2PostTransaction: new V2PostTransaction() {
        Postings = new List<V2Posting>() {
            new V2Posting() {
                Amount = 100,
                Asset = "COIN",
                Destination = "users:002",
                Source = "users:001",
            },
        },
        Script = new V2PostTransactionScript() {
            Plain = "vars {
            account $user
            }
            send [COIN 10] (
            	source = @world
            	destination = $user
            )
            ",
            Vars = new Dictionary<string, object>() {
                { "user", "users:042" },
            },
        },
        Reference = "ref:001",
        Metadata = new Dictionary<string, string>() {
            { "admin", "true" },
        },
    },
    dryRun: true,
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                              | Type                                                                                                                                                                                   | Required                                                                                                                                                                               | Description                                                                                                                                                                            | Example                                                                                                                                                                                |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Ledger`                                                                                                                                                                               | *string*                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                     | Name of the ledger.                                                                                                                                                                    | ledger001                                                                                                                                                                              |
| `V2PostTransaction`                                                                                                                                                                    | [V2PostTransaction](../../Models/Components/V2PostTransaction.md)                                                                                                                      | :heavy_check_mark:                                                                                                                                                                     | The request body must contain at least one of the following objects:<br/>  - `postings`: suitable for simple transactions<br/>  - `script`: enabling more complex transactions with Numscript<br/> |                                                                                                                                                                                        |
| `DryRun`                                                                                                                                                                               | *bool*                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                     | Set the dryRun mode. dry run mode doesn't add the logs to the database or publish a message to the message broker.                                                                     | true                                                                                                                                                                                   |
| `IdempotencyKey`                                                                                                                                                                       | *string*                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                     | Use an idempotency key                                                                                                                                                                 |                                                                                                                                                                                        |

### Response

**[Models.Requests.V2CreateTransactionResponse](../../Models/Requests/V2CreateTransactionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## GetTransaction

Get transaction from a ledger by its ID

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Numerics;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetTransactionAsync(
    ledger: "ledger001",
    id: 1234,
    expand: "<value>",
    pit: System.DateTime.Parse("2023-08-22T15:58:06.771Z")
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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## AddMetadataOnTransaction

Set the metadata of a transaction by its ID

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Numerics;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2AddMetadataOnTransactionRequest req = new V2AddMetadataOnTransactionRequest() {
    Ledger = "ledger001",
    Id = 1234,
    DryRun = true,
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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## DeleteTransactionMetadata

Delete metadata by key

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Numerics;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.DeleteTransactionMetadataAsync(
    ledger: "ledger001",
    id: 1234,
    key: "foo"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `Id`                | *BigInteger*        | :heavy_check_mark:  | Transaction ID.     | 1234                |
| `Key`               | *string*            | :heavy_check_mark:  | The key to remove.  | foo                 |

### Response

**[V2DeleteTransactionMetadataResponse](../../Models/Requests/V2DeleteTransactionMetadataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## RevertTransaction

Revert a ledger transaction by its ID

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Numerics;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.RevertTransactionAsync(
    ledger: "ledger001",
    id: 1234,
    force: false,
    atEffectiveDate: false
);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             | Example                                                 |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Ledger`                                                | *string*                                                | :heavy_check_mark:                                      | Name of the ledger.                                     | ledger001                                               |
| `Id`                                                    | *BigInteger*                                            | :heavy_check_mark:                                      | Transaction ID.                                         | 1234                                                    |
| `Force`                                                 | *bool*                                                  | :heavy_minus_sign:                                      | Force revert                                            |                                                         |
| `AtEffectiveDate`                                       | *bool*                                                  | :heavy_minus_sign:                                      | Revert transaction at effective date of the original tx |                                                         |

### Response

**[Models.Requests.V2RevertTransactionResponse](../../Models/Requests/V2RevertTransactionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## GetBalancesAggregated

Get the aggregated balances from selected accounts

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.GetBalancesAggregatedAsync(
    ledger: "ledger001",
    pit: System.DateTime.Parse("2023-02-24T06:23:10.848Z"),
    useInsertionDate: false,
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Ledger`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | Name of the ledger.                                                                   | ledger001                                                                             |
| `Pit`                                                                                 | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `UseInsertionDate`                                                                    | *bool*                                                                                | :heavy_minus_sign:                                                                    | Use insertion date instead of effective date                                          |                                                                                       |
| `RequestBody`                                                                         | Dictionary<String, *object*>                                                          | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |

### Response

**[V2GetBalancesAggregatedResponse](../../Models/Requests/V2GetBalancesAggregatedResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## GetVolumesWithBalances

Get list of volumes with balances for (account/asset)

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2GetVolumesWithBalancesRequest req = new V2GetVolumesWithBalancesRequest() {
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    Ledger = "ledger001",
    GroupBy = 3,
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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## ListLogs

List the logs from a ledger, sorted by ID in descending order.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V2ListLogsRequest req = new V2ListLogsRequest() {
    Ledger = "ledger001",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## ImportLogs

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V2.ImportLogsAsync(
    ledger: "ledger001",
    requestBody: "<value>"
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `RequestBody`       | *string*            | :heavy_minus_sign:  | N/A                 |                     |

### Response

**[V2ImportLogsResponse](../../Models/Requests/V2ImportLogsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| formance.Models.Errors.V2ErrorResponse | default                                | application/json                       |
| formance.Models.Errors.SDKException    | 4XX, 5XX                               | \*/\*                                  |

## ExportLogs

Export logs

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4XX, 5XX                            | \*/\*                               |