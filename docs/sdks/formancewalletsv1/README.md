# FormanceWalletsV1
(*Wallets.V1*)

## Overview

### Available Operations

* [WalletsgetServerInfo](#walletsgetserverinfo) - Get server info
* [GetTransactions](#gettransactions)
* [ListWallets](#listwallets) - List all wallets
* [CreateWallet](#createwallet) - Create a new wallet
* [GetWallet](#getwallet) - Get a wallet
* [UpdateWallet](#updatewallet) - Update a wallet
* [GetWalletSummary](#getwalletsummary) - Get wallet summary
* [ListBalances](#listbalances) - List balances of a wallet
* [CreateBalance](#createbalance) - Create a balance
* [GetBalance](#getbalance) - Get detailed balance
* [DebitWallet](#debitwallet) - Debit a wallet
* [CreditWallet](#creditwallet) - Credit a wallet
* [GetHolds](#getholds) - Get all holds for a wallet
* [GetHold](#gethold) - Get a hold
* [ConfirmHold](#confirmhold) - Confirm a hold
* [VoidHold](#voidhold) - Cancel a hold

## WalletsgetServerInfo

Get server info

### Example Usage

```csharp
using formance;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.WalletsgetServerInfoAsync();

// handle response
```

### Response

**[WalletsgetServerInfoResponse](../../Models/Requests/WalletsgetServerInfoResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## GetTransactions

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.GetTransactionsAsync(
    pageSize: 100,
    walletID: "wallet1",
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                            | Type                                                                                                                                                                                                                 | Required                                                                                                                                                                                                             | Description                                                                                                                                                                                                          | Example                                                                                                                                                                                                              |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PageSize`                                                                                                                                                                                                           | *long*                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                   | The maximum number of results to return per page                                                                                                                                                                     | 100                                                                                                                                                                                                                  |
| `WalletID`                                                                                                                                                                                                           | *string*                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                   | A wallet ID to filter on                                                                                                                                                                                             | wallet1                                                                                                                                                                                                              |
| `Cursor`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                   | Parameter used in pagination requests.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when the cursor is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                         |

### Response

**[Models.Requests.GetTransactionsResponse](../../Models/Requests/GetTransactionsResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## ListWallets

List all wallets

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

ListWalletsRequest req = new ListWalletsRequest() {
    Name = "wallet1",
    Metadata = new Dictionary<string, string>() {
        { "admin", "true" },
    },
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    Expand = "balances",
};

var res = await sdk.Wallets.V1.ListWalletsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListWalletsRequest](../../Models/Requests/ListWalletsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[Models.Requests.ListWalletsResponse](../../Models/Requests/ListWalletsResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## CreateWallet

Create a new wallet

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

var res = await sdk.Wallets.V1.CreateWalletAsync(
    idempotencyKey: "<value>",
    createWalletRequest: new Models.Components.CreateWalletRequest() {
        Metadata = new Dictionary<string, string>() {
            { "key", "<value>" },
        },
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `IdempotencyKey`                                                                        | *string*                                                                                | :heavy_minus_sign:                                                                      | Use an idempotency key                                                                  |
| `CreateWalletRequest`                                                                   | [Models.Components.CreateWalletRequest](../../Models/Components/CreateWalletRequest.md) | :heavy_minus_sign:                                                                      | N/A                                                                                     |

### Response

**[Models.Requests.CreateWalletResponse](../../Models/Requests/CreateWalletResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## GetWallet

Get a wallet

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.GetWalletAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |

### Response

**[Models.Requests.GetWalletResponse](../../Models/Requests/GetWalletResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## UpdateWallet

Update a wallet

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

var res = await sdk.Wallets.V1.UpdateWalletAsync(
    id: "<id>",
    idempotencyKey: "<value>",
    requestBody: new UpdateWalletRequestBody() {
        Metadata = new Dictionary<string, string>() {
            { "key", "<value>" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Id`                                                                        | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `IdempotencyKey`                                                            | *string*                                                                    | :heavy_minus_sign:                                                          | Use an idempotency key                                                      |
| `RequestBody`                                                               | [UpdateWalletRequestBody](../../Models/Requests/UpdateWalletRequestBody.md) | :heavy_minus_sign:                                                          | N/A                                                                         |

### Response

**[UpdateWalletResponse](../../Models/Requests/UpdateWalletResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## GetWalletSummary

Get wallet summary

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.GetWalletSummaryAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |

### Response

**[Models.Requests.GetWalletSummaryResponse](../../Models/Requests/GetWalletSummaryResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## ListBalances

List balances of a wallet

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.ListBalancesAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |

### Response

**[Models.Requests.ListBalancesResponse](../../Models/Requests/ListBalancesResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## CreateBalance

Create a balance

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.CreateBalanceAsync(
    id: "<id>",
    idempotencyKey: "<value>",
    createBalanceRequest: new Models.Components.CreateBalanceRequest() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Id`                                                                                      | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `IdempotencyKey`                                                                          | *string*                                                                                  | :heavy_minus_sign:                                                                        | Use an idempotency key                                                                    |
| `CreateBalanceRequest`                                                                    | [Models.Components.CreateBalanceRequest](../../Models/Components/CreateBalanceRequest.md) | :heavy_minus_sign:                                                                        | N/A                                                                                       |

### Response

**[Models.Requests.CreateBalanceResponse](../../Models/Requests/CreateBalanceResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## GetBalance

Get detailed balance

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.GetBalanceAsync(
    id: "<id>",
    balanceName: "<value>"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |
| `BalanceName`      | *string*           | :heavy_check_mark: | N/A                |

### Response

**[Models.Requests.GetBalanceResponse](../../Models/Requests/GetBalanceResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## DebitWallet

Debit a wallet

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;
using System.Numerics;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.DebitWalletAsync(
    id: "<id>",
    idempotencyKey: "<value>",
    debitWalletRequest: new Models.Components.DebitWalletRequest() {
        Amount = new Monetary() {
            Asset = "USD/2",
            Amount = 100,
        },
        Pending = true,
        Metadata = new Dictionary<string, string>() {
            { "key", "" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `Id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `IdempotencyKey`                                                                              | *string*                                                                                      | :heavy_minus_sign:                                                                            | Use an idempotency key                                                                        |                                                                                               |
| `DebitWalletRequest`                                                                          | [Models.Components.DebitWalletRequest](../../Models/Components/DebitWalletRequest.md)         | :heavy_minus_sign:                                                                            | N/A                                                                                           | {<br/>"amount": {<br/>"asset": "USD/2",<br/>"amount": 100<br/>},<br/>"metadata": {<br/>"key": ""<br/>},<br/>"pending": true<br/>} |

### Response

**[Models.Requests.DebitWalletResponse](../../Models/Requests/DebitWalletResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## CreditWallet

Credit a wallet

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;
using System.Numerics;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.CreditWalletAsync(
    id: "<id>",
    idempotencyKey: "<value>",
    creditWalletRequest: new Models.Components.CreditWalletRequest() {
        Amount = new Monetary() {
            Asset = "USD/2",
            Amount = 100,
        },
        Metadata = new Dictionary<string, string>() {
            { "key", "" },
        },
        Sources = new List<Subject>() {
            Subject.CreateLedgerAccountSubject(
                new LedgerAccountSubject() {
                    Type = "<value>",
                    Identifier = "<value>",
                }
            ),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 | Example                                                                                     |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Id`                                                                                        | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |                                                                                             |
| `IdempotencyKey`                                                                            | *string*                                                                                    | :heavy_minus_sign:                                                                          | Use an idempotency key                                                                      |                                                                                             |
| `CreditWalletRequest`                                                                       | [Models.Components.CreditWalletRequest](../../Models/Components/CreditWalletRequest.md)     | :heavy_minus_sign:                                                                          | N/A                                                                                         | {<br/>"amount": {<br/>"asset": "USD/2",<br/>"amount": 100<br/>},<br/>"metadata": {<br/>"key": ""<br/>},<br/>"sources": []<br/>} |

### Response

**[CreditWalletResponse](../../Models/Requests/CreditWalletResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## GetHolds

Get all holds for a wallet

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

var res = await sdk.Wallets.V1.GetHoldsAsync(
    pageSize: 100,
    walletID: "wallet1",
    metadata: new Dictionary<string, string>() {
        { "admin", "true" },
    },
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                      | Type                                                                                                                                                                                                                           | Required                                                                                                                                                                                                                       | Description                                                                                                                                                                                                                    | Example                                                                                                                                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                                     | *long*                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                             | The maximum number of results to return per page                                                                                                                                                                               | 100                                                                                                                                                                                                                            |
| `WalletID`                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                             | The wallet to filter on                                                                                                                                                                                                        | wallet1                                                                                                                                                                                                                        |
| `Metadata`                                                                                                                                                                                                                     | Dictionary<String, *string*>                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                             | Filter holds by metadata key value pairs. Nested objects can be used as seen in the example below.                                                                                                                             | {<br/>"admin": "true"<br/>}                                                                                                                                                                                                    |
| `Cursor`                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                             | Parameter used in pagination requests.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when the pagination token is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                   |

### Response

**[Models.Requests.GetHoldsResponse](../../Models/Requests/GetHoldsResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## GetHold

Get a hold

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.GetHoldAsync(holdID: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `HoldID`           | *string*           | :heavy_check_mark: | The hold ID        |

### Response

**[Models.Requests.GetHoldResponse](../../Models/Requests/GetHoldResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## ConfirmHold

Confirm a hold

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.ConfirmHoldAsync(
    holdId: "<value>",
    idempotencyKey: "<value>",
    confirmHoldRequest: new Models.Components.ConfirmHoldRequest() {
        Amount = 100,
        Final = true,
    }
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `HoldId`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | Use an idempotency key                                                                |
| `ConfirmHoldRequest`                                                                  | [Models.Components.ConfirmHoldRequest](../../Models/Components/ConfirmHoldRequest.md) | :heavy_minus_sign:                                                                    | N/A                                                                                   |

### Response

**[ConfirmHoldResponse](../../Models/Requests/ConfirmHoldResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |


## VoidHold

Cancel a hold

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.VoidHoldAsync(
    holdId: "<value>",
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `HoldId`               | *string*               | :heavy_check_mark:     | N/A                    |
| `IdempotencyKey`       | *string*               | :heavy_minus_sign:     | Use an idempotency key |

### Response

**[VoidHoldResponse](../../Models/Requests/VoidHoldResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| formance.Models.Errors.WalletsErrorResponse | default                                     | application/json                            |
| formance.Models.Errors.SDKException         | 4xx-5xx                                     | */*                                         |
