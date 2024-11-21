# FormanceV1
(*Ledger.V1*)

## Overview

### Available Operations

* [GetInfo](#getinfo) - Show server information
* [GetLedgerInfo](#getledgerinfo) - Get information about a ledger
* [CountAccounts](#countaccounts) - Count the accounts from a ledger
* [ListAccounts](#listaccounts) - List accounts from a ledger
* [GetAccount](#getaccount) - Get account by its address
* [AddMetadataToAccount](#addmetadatatoaccount) - Add metadata to an account
* [GetMapping](#getmapping) - Get the mapping of a ledger
* [UpdateMapping](#updatemapping) - Update the mapping of a ledger
* [~~RunScript~~](#runscript) - Execute a Numscript :warning: **Deprecated**
* [ReadStats](#readstats) - Get statistics from a ledger
* [CountTransactions](#counttransactions) - Count the transactions from a ledger
* [ListTransactions](#listtransactions) - List transactions from a ledger
* [CreateTransaction](#createtransaction) - Create a new transaction to a ledger
* [GetTransaction](#gettransaction) - Get transaction from a ledger by its ID
* [AddMetadataOnTransaction](#addmetadataontransaction) - Set the metadata of a transaction by its ID
* [RevertTransaction](#reverttransaction) - Revert a ledger transaction by its ID
* [CreateTransactions](#createtransactions) - Create a new batch of transactions to a ledger
* [GetBalances](#getbalances) - Get the balances from a ledger's account
* [GetBalancesAggregated](#getbalancesaggregated) - Get the aggregated balances from selected accounts
* [ListLogs](#listlogs) - List the logs from a ledger

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

var res = await sdk.Ledger.V1.GetInfoAsync();

// handle response
```

### Response

**[GetInfoResponse](../../Models/Requests/GetInfoResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ledger.V1.GetLedgerInfoAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |

### Response

**[GetLedgerInfoResponse](../../Models/Requests/GetLedgerInfoResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ledger.V1.CountAccountsAsync(
    ledger: "ledger001",
    address: "users:.+",
    metadata: new Dictionary<string, object>() {
        { "0", "m" },
        { "1", "e" },
        { "2", "t" },
        { "3", "a" },
        { "4", "d" },
        { "5", "a" },
        { "6", "t" },
        { "7", "a" },
        { "8", "[" },
        { "9", "k" },
        { "10", "e" },
        { "11", "y" },
        { "12", "]" },
        { "13", "=" },
        { "14", "v" },
        { "15", "a" },
        { "16", "l" },
        { "17", "u" },
        { "18", "e" },
        { "19", "1" },
        { "20", "&" },
        { "21", "m" },
        { "22", "e" },
        { "23", "t" },
        { "24", "a" },
        { "25", "d" },
        { "26", "a" },
        { "27", "t" },
        { "28", "a" },
        { "29", "[" },
        { "30", "a" },
        { "31", "." },
        { "32", "n" },
        { "33", "e" },
        { "34", "s" },
        { "35", "t" },
        { "36", "e" },
        { "37", "d" },
        { "38", "." },
        { "39", "k" },
        { "40", "e" },
        { "41", "y" },
        { "42", "]" },
        { "43", "=" },
        { "44", "v" },
        { "45", "a" },
        { "46", "l" },
        { "47", "u" },
        { "48", "e" },
        { "49", "2" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                        | Type                                                                                                                             | Required                                                                                                                         | Description                                                                                                                      | Example                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- |
| `Ledger`                                                                                                                         | *string*                                                                                                                         | :heavy_check_mark:                                                                                                               | Name of the ledger.                                                                                                              | ledger001                                                                                                                        |
| `Address`                                                                                                                        | *string*                                                                                                                         | :heavy_minus_sign:                                                                                                               | Filter accounts by address pattern (regular expression placed between ^ and $).                                                  | users:.+                                                                                                                         |
| `Metadata`                                                                                                                       | Dictionary<String, *object*>                                                                                                     | :heavy_minus_sign:                                                                                                               | Filter accounts by metadata key value pairs. The filter can be used like this metadata[key]=value1&metadata[a.nested.key]=value2 | metadata[key]=value1&metadata[a.nested.key]=value2                                                                               |

### Response

**[CountAccountsResponse](../../Models/Requests/CountAccountsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

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

ListAccountsRequest req = new ListAccountsRequest() {
    Ledger = "ledger001",
    PageSize = 100,
    After = "users:003",
    Address = "users:.+",
    Metadata = new Dictionary<string, object>() {
        { "0", "m" },
        { "1", "e" },
        { "2", "t" },
        { "3", "a" },
        { "4", "d" },
        { "5", "a" },
        { "6", "t" },
        { "7", "a" },
        { "8", "[" },
        { "9", "k" },
        { "10", "e" },
        { "11", "y" },
        { "12", "]" },
        { "13", "=" },
        { "14", "v" },
        { "15", "a" },
        { "16", "l" },
        { "17", "u" },
        { "18", "e" },
        { "19", "1" },
        { "20", "&" },
        { "21", "m" },
        { "22", "e" },
        { "23", "t" },
        { "24", "a" },
        { "25", "d" },
        { "26", "a" },
        { "27", "t" },
        { "28", "a" },
        { "29", "[" },
        { "30", "a" },
        { "31", "." },
        { "32", "n" },
        { "33", "e" },
        { "34", "s" },
        { "35", "t" },
        { "36", "e" },
        { "37", "d" },
        { "38", "." },
        { "39", "k" },
        { "40", "e" },
        { "41", "y" },
        { "42", "]" },
        { "43", "=" },
        { "44", "v" },
        { "45", "a" },
        { "46", "l" },
        { "47", "u" },
        { "48", "e" },
        { "49", "2" },
    },
    Balance = 2400,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
};

var res = await sdk.Ledger.V1.ListAccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListAccountsRequest](../../Models/Requests/ListAccountsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListAccountsResponse](../../Models/Requests/ListAccountsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ledger.V1.GetAccountAsync(
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

### Response

**[GetAccountResponse](../../Models/Requests/GetAccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ledger.V1.AddMetadataToAccountAsync(
    ledger: "ledger001",
    address: "users:001",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  | Example                                                                                                      |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `Ledger`                                                                                                     | *string*                                                                                                     | :heavy_check_mark:                                                                                           | Name of the ledger.                                                                                          | ledger001                                                                                                    |
| `Address`                                                                                                    | *string*                                                                                                     | :heavy_check_mark:                                                                                           | Exact address of the account. It must match the following regular expressions pattern:<br/>```<br/>^\w+(:\w+)*$<br/>```<br/> | users:001                                                                                                    |
| `RequestBody`                                                                                                | Dictionary<String, *object*>                                                                                 | :heavy_check_mark:                                                                                           | metadata                                                                                                     |                                                                                                              |

### Response

**[AddMetadataToAccountResponse](../../Models/Requests/AddMetadataToAccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

## GetMapping

Get the mapping of a ledger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V1.GetMappingAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |

### Response

**[GetMappingResponse](../../Models/Requests/GetMappingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

## UpdateMapping

Update the mapping of a ledger

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

var res = await sdk.Ledger.V1.UpdateMappingAsync(
    ledger: "ledger001",
    mapping: new Mapping() {
        Contracts = new List<Contract>() {
            new Contract() {
                Account = "users:001",
                Expr = new Expr() {},
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   | Example                                       |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `Ledger`                                      | *string*                                      | :heavy_check_mark:                            | Name of the ledger.                           | ledger001                                     |
| `Mapping`                                     | [Mapping](../../Models/Components/Mapping.md) | :heavy_check_mark:                            | N/A                                           |                                               |

### Response

**[UpdateMappingResponse](../../Models/Requests/UpdateMappingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

## ~~RunScript~~

This route is deprecated, and has been merged into `POST /{ledger}/transactions`.


> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

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

var res = await sdk.Ledger.V1.RunScriptAsync(
    ledger: "ledger001",
    script: new Script() {
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
        Reference = "order_1234",
    },
    preview: true
);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         | Example                                                                                                             |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `Ledger`                                                                                                            | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | Name of the ledger.                                                                                                 | ledger001                                                                                                           |
| `Script`                                                                                                            | [Script](../../Models/Components/Script.md)                                                                         | :heavy_check_mark:                                                                                                  | N/A                                                                                                                 |                                                                                                                     |
| `Preview`                                                                                                           | *bool*                                                                                                              | :heavy_minus_sign:                                                                                                  | Set the preview mode. Preview mode doesn't add the logs to the database or publish a message to the message broker. | true                                                                                                                |

### Response

**[RunScriptResponse](../../Models/Requests/RunScriptResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4XX, 5XX                            | \*/\*                               |

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

var res = await sdk.Ledger.V1.ReadStatsAsync(ledger: "ledger001");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `Ledger`           | *string*           | :heavy_check_mark: | name of the ledger | ledger001          |

### Response

**[ReadStatsResponse](../../Models/Requests/ReadStatsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

## CountTransactions

Count the transactions from a ledger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

CountTransactionsRequest req = new CountTransactionsRequest() {
    Ledger = "ledger001",
    Reference = "ref:001",
    Account = "users:001",
    Source = "users:001",
    Destination = "users:001",
    Metadata = new Models.Requests.Metadata() {},
};

var res = await sdk.Ledger.V1.CountTransactionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CountTransactionsRequest](../../Models/Requests/CountTransactionsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[CountTransactionsResponse](../../Models/Requests/CountTransactionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

## ListTransactions

List transactions from a ledger, sorted by txid in descending order.

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

ListTransactionsRequest req = new ListTransactionsRequest() {
    Ledger = "ledger001",
    PageSize = 100,
    After = "1234",
    Reference = "ref:001",
    Account = "users:001",
    Source = "users:001",
    Destination = "users:001",
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
};

var res = await sdk.Ledger.V1.ListTransactionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListTransactionsRequest](../../Models/Requests/ListTransactionsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListTransactionsResponse](../../Models/Requests/ListTransactionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ledger.V1.CreateTransactionAsync(
    ledger: "ledger001",
    postTransaction: new PostTransaction() {
        Postings = new List<Posting>() {
            new Posting() {
                Amount = 100,
                Asset = "COIN",
                Destination = "users:002",
                Source = "users:001",
            },
        },
        Script = new PostTransactionScript() {
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
    },
    preview: true
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                              | Type                                                                                                                                                                                   | Required                                                                                                                                                                               | Description                                                                                                                                                                            | Example                                                                                                                                                                                |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Ledger`                                                                                                                                                                               | *string*                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                     | Name of the ledger.                                                                                                                                                                    | ledger001                                                                                                                                                                              |
| `PostTransaction`                                                                                                                                                                      | [PostTransaction](../../Models/Components/PostTransaction.md)                                                                                                                          | :heavy_check_mark:                                                                                                                                                                     | The request body must contain at least one of the following objects:<br/>  - `postings`: suitable for simple transactions<br/>  - `script`: enabling more complex transactions with Numscript<br/> |                                                                                                                                                                                        |
| `Preview`                                                                                                                                                                              | *bool*                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                     | Set the preview mode. Preview mode doesn't add the logs to the database or publish a message to the message broker.                                                                    | true                                                                                                                                                                                   |

### Response

**[CreateTransactionResponse](../../Models/Requests/CreateTransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ledger.V1.GetTransactionAsync(
    ledger: "ledger001",
    txid: 1234
);

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         | Example             |
| ------------------- | ------------------- | ------------------- | ------------------- | ------------------- |
| `Ledger`            | *string*            | :heavy_check_mark:  | Name of the ledger. | ledger001           |
| `Txid`              | *BigInteger*        | :heavy_check_mark:  | Transaction ID.     | 1234                |

### Response

**[GetTransactionResponse](../../Models/Requests/GetTransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ledger.V1.AddMetadataOnTransactionAsync(
    ledger: "ledger001",
    txid: 1234,
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  | Example                      |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `Ledger`                     | *string*                     | :heavy_check_mark:           | Name of the ledger.          | ledger001                    |
| `Txid`                       | *BigInteger*                 | :heavy_check_mark:           | Transaction ID.              | 1234                         |
| `RequestBody`                | Dictionary<String, *object*> | :heavy_minus_sign:           | metadata                     |                              |

### Response

**[AddMetadataOnTransactionResponse](../../Models/Requests/AddMetadataOnTransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Ledger.V1.RevertTransactionAsync(
    ledger: "ledger001",
    txid: 1234,
    disableChecks: false
);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      | Example                          |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `Ledger`                         | *string*                         | :heavy_check_mark:               | Name of the ledger.              | ledger001                        |
| `Txid`                           | *BigInteger*                     | :heavy_check_mark:               | Transaction ID.                  | 1234                             |
| `DisableChecks`                  | *bool*                           | :heavy_minus_sign:               | Allow to disable balances checks |                                  |

### Response

**[RevertTransactionResponse](../../Models/Requests/RevertTransactionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

## CreateTransactions

Create a new batch of transactions to a ledger

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

var res = await sdk.Ledger.V1.CreateTransactionsAsync(
    ledger: "ledger001",
    transactions: new Transactions() {
        Transactions = new List<TransactionData>() {
            new TransactionData() {
                Postings = new List<Posting>() {
                    new Posting() {
                        Amount = 100,
                        Asset = "COIN",
                        Destination = "users:002",
                        Source = "users:001",
                    },
                },
                Reference = "ref:001",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             | Example                                                 |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Ledger`                                                | *string*                                                | :heavy_check_mark:                                      | Name of the ledger.                                     | ledger001                                               |
| `Transactions`                                          | [Transactions](../../Models/Components/Transactions.md) | :heavy_check_mark:                                      | N/A                                                     |                                                         |

### Response

**[CreateTransactionsResponse](../../Models/Requests/CreateTransactionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

## GetBalances

Get the balances from a ledger's account

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

GetBalancesRequest req = new GetBalancesRequest() {
    Ledger = "ledger001",
    Address = "users:001",
    After = "users:003",
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
};

var res = await sdk.Ledger.V1.GetBalancesAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetBalancesRequest](../../Models/Requests/GetBalancesRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetBalancesResponse](../../Models/Requests/GetBalancesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

## GetBalancesAggregated

Get the aggregated balances from selected accounts

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Ledger.V1.GetBalancesAggregatedAsync(
    ledger: "ledger001",
    address: "users:001",
    useInsertionDate: false
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Ledger`                                                                  | *string*                                                                  | :heavy_check_mark:                                                        | Name of the ledger.                                                       | ledger001                                                                 |
| `Address`                                                                 | *string*                                                                  | :heavy_minus_sign:                                                        | Filter balances involving given account, either as source or destination. | users:001                                                                 |
| `UseInsertionDate`                                                        | *bool*                                                                    | :heavy_minus_sign:                                                        | Use insertion date instead of effective date                              |                                                                           |

### Response

**[GetBalancesAggregatedResponse](../../Models/Requests/GetBalancesAggregatedResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |

## ListLogs

List the logs from a ledger, sorted by ID in descending order.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

ListLogsRequest req = new ListLogsRequest() {
    Ledger = "ledger001",
    PageSize = 100,
    After = "1234",
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
};

var res = await sdk.Ledger.V1.ListLogsAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [ListLogsRequest](../../Models/Requests/ListLogsRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[ListLogsResponse](../../Models/Requests/ListLogsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4XX, 5XX                             | \*/\*                                |