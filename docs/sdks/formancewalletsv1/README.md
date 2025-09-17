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

<!-- UsageSnippet language="csharp" operationID="walletsgetServerInfo" method="get" path="/api/wallets/_info" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## GetTransactions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTransactions" method="get" path="/api/wallets/transactions" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## ListWallets

List all wallets

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listWallets" method="get" path="/api/wallets/wallets" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## CreateWallet

Create a new wallet

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createWallet" method="post" path="/api/wallets/wallets" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.CreateWalletAsync();

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## GetWallet

Get a wallet

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getWallet" method="get" path="/api/wallets/wallets/{id}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## UpdateWallet

Update a wallet

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateWallet" method="patch" path="/api/wallets/wallets/{id}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.UpdateWalletAsync(id: "<id>");

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## GetWalletSummary

Get wallet summary

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getWalletSummary" method="get" path="/api/wallets/wallets/{id}/summary" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## ListBalances

List balances of a wallet

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listBalances" method="get" path="/api/wallets/wallets/{id}/balances" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

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

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CreateBalance

Create a balance

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createBalance" method="post" path="/api/wallets/wallets/{id}/balances" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.CreateBalanceAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | N/A                                           |
| `IdempotencyKey`                              | *string*                                      | :heavy_minus_sign:                            | Use an idempotency key                        |
| `Balance`                                     | [Balance](../../Models/Components/Balance.md) | :heavy_minus_sign:                            | N/A                                           |

### Response

**[Models.Requests.CreateBalanceResponse](../../Models/Requests/CreateBalanceResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## GetBalance

Get detailed balance

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getBalance" method="get" path="/api/wallets/wallets/{id}/balances/{balanceName}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## DebitWallet

Debit a wallet

### Example Usage

<!-- UsageSnippet language="csharp" operationID="debitWallet" method="post" path="/api/wallets/wallets/{id}/debit" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.DebitWalletAsync(
    id: "<id>",
    debitWalletRequest: new FormanceSDK.Models.Components.DebitWalletRequest() {
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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## CreditWallet

Credit a wallet

### Example Usage

<!-- UsageSnippet language="csharp" operationID="creditWallet" method="post" path="/api/wallets/wallets/{id}/credit" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.CreditWalletAsync(
    id: "<id>",
    creditWalletRequest: new FormanceSDK.Models.Components.CreditWalletRequest() {
        Amount = new Monetary() {
            Asset = "USD/2",
            Amount = 100,
        },
        Metadata = new Dictionary<string, string>() {
            { "key", "" },
        },
        Sources = new List<Subject>() {},
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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## GetHolds

Get all holds for a wallet

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHolds" method="get" path="/api/wallets/holds" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## GetHold

Get a hold

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHold" method="get" path="/api/wallets/holds/{holdID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.GetHoldAsync(holdID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `HoldID`           | *string*           | :heavy_check_mark: | The hold ID        |

### Response

**[Models.Requests.GetHoldResponse](../../Models/Requests/GetHoldResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## ConfirmHold

Confirm a hold

### Example Usage

<!-- UsageSnippet language="csharp" operationID="confirmHold" method="post" path="/api/wallets/holds/{hold_id}/confirm" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.ConfirmHoldAsync(
    holdId: "<id>",
    confirmHoldRequest: new FormanceSDK.Models.Components.ConfirmHoldRequest() {
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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |

## VoidHold

Cancel a hold

### Example Usage

<!-- UsageSnippet language="csharp" operationID="voidHold" method="post" path="/api/wallets/holds/{hold_id}/void" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Wallets.V1.VoidHoldAsync(holdId: "<id>");

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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| FormanceSDK.Models.Errors.WalletsErrorResponse | default                                        | application/json                               |
| FormanceSDK.Models.Errors.SDKException         | 4XX, 5XX                                       | \*/\*                                          |