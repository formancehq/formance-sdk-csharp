# FormancePaymentsV1
(*Payments.V1*)

## Overview

### Available Operations

* [PaymentsgetServerInfo](#paymentsgetserverinfo) - Get server info
* [CreatePayment](#createpayment) - Create a payment
* [ListPayments](#listpayments) - List payments
* [GetPayment](#getpayment) - Get a payment
* [UpdateMetadata](#updatemetadata) - Update metadata
* [ListTransferInitiations](#listtransferinitiations) - List Transfer Initiations
* [CreateTransferInitiation](#createtransferinitiation) - Create a TransferInitiation
* [GetTransferInitiation](#gettransferinitiation) - Get a transfer initiation
* [DeleteTransferInitiation](#deletetransferinitiation) - Delete a transfer initiation
* [UpdateTransferInitiationStatus](#updatetransferinitiationstatus) - Update the status of a transfer initiation
* [ReverseTransferInitiation](#reversetransferinitiation) - Reverse a transfer initiation
* [RetryTransferInitiation](#retrytransferinitiation) - Retry a failed transfer initiation
* [ListPools](#listpools) - List Pools
* [CreatePool](#createpool) - Create a Pool
* [GetPool](#getpool) - Get a Pool
* [DeletePool](#deletepool) - Delete a Pool
* [AddAccountToPool](#addaccounttopool) - Add an account to a pool
* [RemoveAccountFromPool](#removeaccountfrompool) - Remove an account from a pool
* [GetPoolBalances](#getpoolbalances) - Get historical pool balances at a particular point in time
* [GetPoolBalancesLatest](#getpoolbalanceslatest) - Get latest pool balances
* [CreateAccount](#createaccount) - Create an account
* [PaymentslistAccounts](#paymentslistaccounts) - List accounts
* [PaymentsgetAccount](#paymentsgetaccount) - Get an account
* [GetAccountBalances](#getaccountbalances) - Get account balances
* [CreateBankAccount](#createbankaccount) - Create a BankAccount in Payments and on the PSP
* [ListBankAccounts](#listbankaccounts) - List bank accounts created by user on Formance
* [GetBankAccount](#getbankaccount) - Get a bank account created by user on Formance
* [ForwardBankAccount](#forwardbankaccount) - Forward a bank account to a connector
* [UpdateBankAccountMetadata](#updatebankaccountmetadata) - Update metadata of a bank account
* [ListAllConnectors](#listallconnectors) - List all installed connectors
* [ListConfigsAvailableConnectors](#listconfigsavailableconnectors) - List the configs of each available connector
* [InstallConnector](#installconnector) - Install a connector
* [~~UninstallConnector~~](#uninstallconnector) - Uninstall a connector :warning: **Deprecated**
* [UninstallConnectorV1](#uninstallconnectorv1) - Uninstall a connector
* [~~ReadConnectorConfig~~](#readconnectorconfig) - Read the config of a connector :warning: **Deprecated**
* [UpdateConnectorConfigV1](#updateconnectorconfigv1) - Update the config of a connector
* [ReadConnectorConfigV1](#readconnectorconfigv1) - Read the config of a connector
* [~~ResetConnector~~](#resetconnector) - Reset a connector :warning: **Deprecated**
* [ResetConnectorV1](#resetconnectorv1) - Reset a connector
* [~~ListConnectorTasks~~](#listconnectortasks) - List tasks from a connector :warning: **Deprecated**
* [ListConnectorTasksV1](#listconnectortasksv1) - List tasks from a connector
* [~~GetConnectorTask~~](#getconnectortask) - Read a specific task of the connector :warning: **Deprecated**
* [GetConnectorTaskV1](#getconnectortaskv1) - Read a specific task of the connector
* [ConnectorsTransfer](#connectorstransfer) - Transfer funds between Connector accounts

## PaymentsgetServerInfo

Get server info

### Example Usage

<!-- UsageSnippet language="csharp" operationID="paymentsgetServerInfo" method="get" path="/api/payments/_info" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.PaymentsgetServerInfoAsync();

// handle response
```

### Response

**[PaymentsgetServerInfoResponse](../../Models/Requests/PaymentsgetServerInfoResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## CreatePayment

Create a payment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPayment" method="post" path="/api/payments/payments" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

PaymentRequest req = new PaymentRequest() {
    Reference = "<value>",
    ConnectorID = "<id>",
    CreatedAt = System.DateTime.Parse("2025-08-26T06:29:11.777Z"),
    Amount = 100,
    Type = PaymentType.Other,
    Status = PaymentStatus.RefundedFailure,
    Scheme = PaymentScheme.Unionpay,
    Asset = "USD",
};

var res = await sdk.Payments.V1.CreatePaymentAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [PaymentRequest](../../Models/Components/PaymentRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[CreatePaymentResponse](../../Models/Requests/CreatePaymentResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ListPayments

List payments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPayments" method="get" path="/api/payments/payments" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListPaymentsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    sort: new List<string>() {
        "date:asc",
        "status:desc",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |
| `Sort`                                                                                                                                                                                                                                                   | List<*string*>                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                       | Fields used to sort payments (default is date:desc).                                                                                                                                                                                                     | [<br/>"date:asc",<br/>"status:desc"<br/>]                                                                                                                                                                                                                |
| `Query`                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Filters used to filter resources.<br/>                                                                                                                                                                                                                   |                                                                                                                                                                                                                                                          |

### Response

**[ListPaymentsResponse](../../Models/Requests/ListPaymentsResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## GetPayment

Get a payment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPayment" method="get" path="/api/payments/payments/{paymentId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetPaymentAsync(paymentId: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `PaymentId`        | *string*           | :heavy_check_mark: | The payment ID.    | XXX                |

### Response

**[GetPaymentResponse](../../Models/Requests/GetPaymentResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## UpdateMetadata

Update metadata

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMetadata" method="patch" path="/api/payments/payments/{paymentId}/metadata" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UpdateMetadataAsync(
    paymentId: "XXX",
    requestBody: new Dictionary<string, string>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  | Example                      |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `PaymentId`                  | *string*                     | :heavy_check_mark:           | The payment ID.              | XXX                          |
| `RequestBody`                | Dictionary<String, *string*> | :heavy_check_mark:           | N/A                          |                              |

### Response

**[UpdateMetadataResponse](../../Models/Requests/UpdateMetadataResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ListTransferInitiations

List Transfer Initiations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTransferInitiations" method="get" path="/api/payments/transfer-initiations" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListTransferInitiationsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    sort: new List<string>() {
        "date:asc",
        "status:desc",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |
| `Sort`                                                                                                                                                                                                                                                   | List<*string*>                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                       | Fields used to sort payments (default is date:desc).                                                                                                                                                                                                     | [<br/>"date:asc",<br/>"status:desc"<br/>]                                                                                                                                                                                                                |
| `Query`                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Filters used to filter resources.<br/>                                                                                                                                                                                                                   |                                                                                                                                                                                                                                                          |

### Response

**[ListTransferInitiationsResponse](../../Models/Requests/ListTransferInitiationsResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## CreateTransferInitiation

Create a transfer initiation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTransferInitiation" method="post" path="/api/payments/transfer-initiations" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

TransferInitiationRequest req = new TransferInitiationRequest() {
    Reference = "XXX",
    ScheduledAt = System.DateTime.Parse("2023-04-02T01:40:50.195Z"),
    Description = "flowery yum keenly operating knavishly commemorate recent apropos",
    SourceAccountID = "<id>",
    DestinationAccountID = "<id>",
    Type = TransferInitiationRequestType.Payout,
    Amount = 181752,
    Asset = "USD",
    Validated = false,
};

var res = await sdk.Payments.V1.CreateTransferInitiationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [TransferInitiationRequest](../../Models/Components/TransferInitiationRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CreateTransferInitiationResponse](../../Models/Requests/CreateTransferInitiationResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## GetTransferInitiation

Get a transfer initiation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTransferInitiation" method="get" path="/api/payments/transfer-initiations/{transferId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetTransferInitiationAsync(transferId: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `TransferId`       | *string*           | :heavy_check_mark: | The transfer ID.   | XXX                |

### Response

**[GetTransferInitiationResponse](../../Models/Requests/GetTransferInitiationResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## DeleteTransferInitiation

Delete a transfer initiation by its id.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteTransferInitiation" method="delete" path="/api/payments/transfer-initiations/{transferId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.DeleteTransferInitiationAsync(transferId: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `TransferId`       | *string*           | :heavy_check_mark: | The transfer ID.   | XXX                |

### Response

**[DeleteTransferInitiationResponse](../../Models/Requests/DeleteTransferInitiationResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## UpdateTransferInitiationStatus

Update a transfer initiation status

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTransferInitiationStatus" method="post" path="/api/payments/transfer-initiations/{transferId}/status" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UpdateTransferInitiationStatusAsync(
    transferId: "XXX",
    updateTransferInitiationStatusRequest: new FormanceSDK.Models.Components.UpdateTransferInitiationStatusRequest() {
        Status = Status.Validated,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 | Example                                                                                                                     |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `TransferId`                                                                                                                | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | The transfer ID.                                                                                                            | XXX                                                                                                                         |
| `UpdateTransferInitiationStatusRequest`                                                                                     | [Models.Components.UpdateTransferInitiationStatusRequest](../../Models/Components/UpdateTransferInitiationStatusRequest.md) | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |                                                                                                                             |

### Response

**[UpdateTransferInitiationStatusResponse](../../Models/Requests/UpdateTransferInitiationStatusResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ReverseTransferInitiation

Reverse transfer initiation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="reverseTransferInitiation" method="post" path="/api/payments/transfer-initiations/{transferId}/reverse" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ReverseTransferInitiationAsync(
    transferId: "XXX",
    reverseTransferInitiationRequest: new FormanceSDK.Models.Components.ReverseTransferInitiationRequest() {
        Reference = "XXX",
        Description = "keel caption frenetically ew given fencing scratch yearningly quickly know",
        Amount = 563034,
        Asset = "USD",
        Metadata = null,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `TransferId`                                                                                                      | *string*                                                                                                          | :heavy_check_mark:                                                                                                | The transfer ID.                                                                                                  | XXX                                                                                                               |
| `ReverseTransferInitiationRequest`                                                                                | [Models.Components.ReverseTransferInitiationRequest](../../Models/Components/ReverseTransferInitiationRequest.md) | :heavy_check_mark:                                                                                                | N/A                                                                                                               |                                                                                                                   |

### Response

**[ReverseTransferInitiationResponse](../../Models/Requests/ReverseTransferInitiationResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## RetryTransferInitiation

Retry a failed transfer initiation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="retryTransferInitiation" method="post" path="/api/payments/transfer-initiations/{transferId}/retry" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.RetryTransferInitiationAsync(transferId: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `TransferId`       | *string*           | :heavy_check_mark: | The transfer ID.   | XXX                |

### Response

**[RetryTransferInitiationResponse](../../Models/Requests/RetryTransferInitiationResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ListPools

List Pools

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPools" method="get" path="/api/payments/pools" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListPoolsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    sort: new List<string>() {
        "date:asc",
        "status:desc",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |
| `Sort`                                                                                                                                                                                                                                                   | List<*string*>                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                       | Fields used to sort payments (default is date:desc).                                                                                                                                                                                                     | [<br/>"date:asc",<br/>"status:desc"<br/>]                                                                                                                                                                                                                |
| `Query`                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Filters used to filter resources.<br/>                                                                                                                                                                                                                   |                                                                                                                                                                                                                                                          |

### Response

**[ListPoolsResponse](../../Models/Requests/ListPoolsResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## CreatePool

Create a Pool

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPool" method="post" path="/api/payments/pools" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

PoolRequest req = new PoolRequest() {
    Name = "<value>",
    AccountIDs = new List<string>() {
        "<value 1>",
        "<value 2>",
    },
};

var res = await sdk.Payments.V1.CreatePoolAsync(req);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `request`                                             | [PoolRequest](../../Models/Components/PoolRequest.md) | :heavy_check_mark:                                    | The request object to use for the request.            |

### Response

**[CreatePoolResponse](../../Models/Requests/CreatePoolResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## GetPool

Get a Pool

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPool" method="get" path="/api/payments/pools/{poolId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetPoolAsync(poolId: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `PoolId`           | *string*           | :heavy_check_mark: | The pool ID.       | XXX                |

### Response

**[GetPoolResponse](../../Models/Requests/GetPoolResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## DeletePool

Delete a pool by its id.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deletePool" method="delete" path="/api/payments/pools/{poolId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.DeletePoolAsync(poolId: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `PoolId`           | *string*           | :heavy_check_mark: | The pool ID.       | XXX                |

### Response

**[DeletePoolResponse](../../Models/Requests/DeletePoolResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## AddAccountToPool

Add an account to a pool

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addAccountToPool" method="post" path="/api/payments/pools/{poolId}/accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.AddAccountToPoolAsync(
    poolId: "XXX",
    addAccountToPoolRequest: new FormanceSDK.Models.Components.AddAccountToPoolRequest() {
        AccountID = "<id>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `PoolId`                                                                                        | *string*                                                                                        | :heavy_check_mark:                                                                              | The pool ID.                                                                                    | XXX                                                                                             |
| `AddAccountToPoolRequest`                                                                       | [Models.Components.AddAccountToPoolRequest](../../Models/Components/AddAccountToPoolRequest.md) | :heavy_check_mark:                                                                              | N/A                                                                                             |                                                                                                 |

### Response

**[AddAccountToPoolResponse](../../Models/Requests/AddAccountToPoolResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## RemoveAccountFromPool

Remove an account from a pool by its id.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAccountFromPool" method="delete" path="/api/payments/pools/{poolId}/accounts/{accountId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.RemoveAccountFromPoolAsync(
    poolId: "XXX",
    accountId: "XXX"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `PoolId`           | *string*           | :heavy_check_mark: | The pool ID.       | XXX                |
| `AccountId`        | *string*           | :heavy_check_mark: | The account ID.    | XXX                |

### Response

**[RemoveAccountFromPoolResponse](../../Models/Requests/RemoveAccountFromPoolResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## GetPoolBalances

Get historical pool balances at a particular point in time

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPoolBalances" method="get" path="/api/payments/pools/{poolId}/balances" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetPoolBalancesAsync(
    poolId: "XXX",
    at: System.DateTime.Parse("2024-11-27T10:59:51.663Z")
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `PoolId`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | The pool ID.                                                                          | XXX                                                                                   |
| `At`                                                                                  | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | Filter balances by date.<br/>                                                         |                                                                                       |

### Response

**[GetPoolBalancesResponse](../../Models/Requests/GetPoolBalancesResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## GetPoolBalancesLatest

Get latest pool balances

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPoolBalancesLatest" method="get" path="/api/payments/pools/{poolId}/balances/latest" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetPoolBalancesLatestAsync(poolId: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `PoolId`           | *string*           | :heavy_check_mark: | The pool ID.       | XXX                |

### Response

**[GetPoolBalancesLatestResponse](../../Models/Requests/GetPoolBalancesLatestResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## CreateAccount

Create an account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAccount" method="post" path="/api/payments/accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

AccountRequest req = new AccountRequest() {
    Reference = "<value>",
    ConnectorID = "<id>",
    CreatedAt = System.DateTime.Parse("2025-07-27T08:57:17.388Z"),
    Type = AccountType.Unknown,
};

var res = await sdk.Payments.V1.CreateAccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [AccountRequest](../../Models/Components/AccountRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[CreateAccountResponse](../../Models/Requests/CreateAccountResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## PaymentslistAccounts

List accounts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="paymentslistAccounts" method="get" path="/api/payments/accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

PaymentslistAccountsRequest req = new PaymentslistAccountsRequest() {
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    Sort = new List<string>() {
        "date:asc",
        "status:desc",
    },
};

var res = await sdk.Payments.V1.PaymentslistAccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PaymentslistAccountsRequest](../../Models/Requests/PaymentslistAccountsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PaymentslistAccountsResponse](../../Models/Requests/PaymentslistAccountsResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## PaymentsgetAccount

Get an account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="paymentsgetAccount" method="get" path="/api/payments/accounts/{accountId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.PaymentsgetAccountAsync(accountId: "XXX");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountId`        | *string*           | :heavy_check_mark: | The account ID.    | XXX                |

### Response

**[PaymentsgetAccountResponse](../../Models/Requests/PaymentsgetAccountResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## GetAccountBalances

Get account balances

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountBalances" method="get" path="/api/payments/accounts/{accountId}/balances" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

GetAccountBalancesRequest req = new GetAccountBalancesRequest() {
    AccountId = "XXX",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    Sort = new List<string>() {
        "date:asc",
        "status:desc",
    },
};

var res = await sdk.Payments.V1.GetAccountBalancesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetAccountBalancesRequest](../../Models/Requests/GetAccountBalancesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetAccountBalancesResponse](../../Models/Requests/GetAccountBalancesResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## CreateBankAccount

Create a bank account in Payments and on the PSP.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createBankAccount" method="post" path="/api/payments/bank-accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

BankAccountRequest req = new BankAccountRequest() {
    Country = "GB",
    Name = "My account",
};

var res = await sdk.Payments.V1.CreateBankAccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [BankAccountRequest](../../Models/Components/BankAccountRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[CreateBankAccountResponse](../../Models/Requests/CreateBankAccountResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ListBankAccounts

List all bank accounts created by user on Formance.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listBankAccounts" method="get" path="/api/payments/bank-accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListBankAccountsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    sort: new List<string>() {
        "date:asc",
        "status:desc",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |
| `Sort`                                                                                                                                                                                                                                                   | List<*string*>                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                       | Fields used to sort payments (default is date:desc).                                                                                                                                                                                                     | [<br/>"date:asc",<br/>"status:desc"<br/>]                                                                                                                                                                                                                |

### Response

**[ListBankAccountsResponse](../../Models/Requests/ListBankAccountsResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## GetBankAccount

Get a bank account created by user on Formance

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getBankAccount" method="get" path="/api/payments/bank-accounts/{bankAccountId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetBankAccountAsync(bankAccountId: "XXX");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          | Example              |
| -------------------- | -------------------- | -------------------- | -------------------- | -------------------- |
| `BankAccountId`      | *string*             | :heavy_check_mark:   | The bank account ID. | XXX                  |

### Response

**[GetBankAccountResponse](../../Models/Requests/GetBankAccountResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ForwardBankAccount

Forward a bank account to a connector

### Example Usage

<!-- UsageSnippet language="csharp" operationID="forwardBankAccount" method="post" path="/api/payments/bank-accounts/{bankAccountId}/forward" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ForwardBankAccountAsync(
    bankAccountId: "XXX",
    forwardBankAccountRequest: new FormanceSDK.Models.Components.ForwardBankAccountRequest() {
        ConnectorID = "<id>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         | Example                                                                                             |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `BankAccountId`                                                                                     | *string*                                                                                            | :heavy_check_mark:                                                                                  | The bank account ID.                                                                                | XXX                                                                                                 |
| `ForwardBankAccountRequest`                                                                         | [Models.Components.ForwardBankAccountRequest](../../Models/Components/ForwardBankAccountRequest.md) | :heavy_check_mark:                                                                                  | N/A                                                                                                 |                                                                                                     |

### Response

**[ForwardBankAccountResponse](../../Models/Requests/ForwardBankAccountResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## UpdateBankAccountMetadata

Update metadata of a bank account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateBankAccountMetadata" method="patch" path="/api/payments/bank-accounts/{bankAccountId}/metadata" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UpdateBankAccountMetadataAsync(
    bankAccountId: "XXX",
    updateBankAccountMetadataRequest: new FormanceSDK.Models.Components.UpdateBankAccountMetadataRequest() {
        Metadata = new Dictionary<string, string>() {
            { "key", "<value>" },
            { "key1", "<value>" },
            { "key2", "<value>" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `BankAccountId`                                                                                                   | *string*                                                                                                          | :heavy_check_mark:                                                                                                | The bank account ID.                                                                                              | XXX                                                                                                               |
| `UpdateBankAccountMetadataRequest`                                                                                | [Models.Components.UpdateBankAccountMetadataRequest](../../Models/Components/UpdateBankAccountMetadataRequest.md) | :heavy_check_mark:                                                                                                | N/A                                                                                                               |                                                                                                                   |

### Response

**[UpdateBankAccountMetadataResponse](../../Models/Requests/UpdateBankAccountMetadataResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ListAllConnectors

List all installed connectors.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAllConnectors" method="get" path="/api/payments/connectors" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListAllConnectorsAsync();

// handle response
```

### Response

**[ListAllConnectorsResponse](../../Models/Requests/ListAllConnectorsResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ListConfigsAvailableConnectors

List the configs of each available connector.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listConfigsAvailableConnectors" method="get" path="/api/payments/connectors/configs" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListConfigsAvailableConnectorsAsync();

// handle response
```

### Response

**[ListConfigsAvailableConnectorsResponse](../../Models/Requests/ListConfigsAvailableConnectorsResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## InstallConnector

Install a connector by its name and config.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="installConnector" method="post" path="/api/payments/connectors/{connector}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.InstallConnectorAsync(
    connector: Connector.Mangopay,
    connectorConfig: ConnectorConfig.CreateModulr(
        new ModulrConfig() {
            Name = "My Modulr Account",
            ApiKey = "XXX",
            ApiSecret = "XXX",
            PollingPeriod = "60s",
        }
    )
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Connector`                                                   | [Connector](../../Models/Components/Connector.md)             | :heavy_check_mark:                                            | The name of the connector.                                    |
| `ConnectorConfig`                                             | [ConnectorConfig](../../Models/Components/ConnectorConfig.md) | :heavy_check_mark:                                            | N/A                                                           |

### Response

**[InstallConnectorResponse](../../Models/Requests/InstallConnectorResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ~~UninstallConnector~~

Uninstall a connector by its name.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uninstallConnector" method="delete" path="/api/payments/connectors/{connector}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UninstallConnectorAsync(connector: Connector.Generic);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |

### Response

**[UninstallConnectorResponse](../../Models/Requests/UninstallConnectorResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## UninstallConnectorV1

Uninstall a connector by its name.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uninstallConnectorV1" method="delete" path="/api/payments/connectors/{connector}/{connectorId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UninstallConnectorV1Async(
    connector: Connector.BankingCircle,
    connectorId: "XXX"
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |                                                   |
| `ConnectorId`                                     | *string*                                          | :heavy_check_mark:                                | The connector ID.                                 | XXX                                               |

### Response

**[UninstallConnectorV1Response](../../Models/Requests/UninstallConnectorV1Response.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ~~ReadConnectorConfig~~

Read connector config

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="readConnectorConfig" method="get" path="/api/payments/connectors/{connector}/config" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ReadConnectorConfigAsync(connector: Connector.Modulr);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |

### Response

**[ReadConnectorConfigResponse](../../Models/Requests/ReadConnectorConfigResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## UpdateConnectorConfigV1

Update connector config

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateConnectorConfigV1" method="post" path="/api/payments/connectors/{connector}/{connectorId}/config" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UpdateConnectorConfigV1Async(
    connector: Connector.Mangopay,
    connectorId: "XXX",
    connectorConfig: ConnectorConfig.CreateMoneycorp(
        new MoneycorpConfig() {
            Name = "My Moneycorp Account",
            ClientID = "XXX",
            ApiKey = "XXX",
            Endpoint = "XXX",
            PollingPeriod = "60s",
        }
    )
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   | Example                                                       |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Connector`                                                   | [Connector](../../Models/Components/Connector.md)             | :heavy_check_mark:                                            | The name of the connector.                                    |                                                               |
| `ConnectorId`                                                 | *string*                                                      | :heavy_check_mark:                                            | The connector ID.                                             | XXX                                                           |
| `ConnectorConfig`                                             | [ConnectorConfig](../../Models/Components/ConnectorConfig.md) | :heavy_check_mark:                                            | N/A                                                           |                                                               |

### Response

**[UpdateConnectorConfigV1Response](../../Models/Requests/UpdateConnectorConfigV1Response.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ReadConnectorConfigV1

Read connector config

### Example Usage

<!-- UsageSnippet language="csharp" operationID="readConnectorConfigV1" method="get" path="/api/payments/connectors/{connector}/{connectorId}/config" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ReadConnectorConfigV1Async(
    connector: Connector.Mangopay,
    connectorId: "XXX"
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |                                                   |
| `ConnectorId`                                     | *string*                                          | :heavy_check_mark:                                | The connector ID.                                 | XXX                                               |

### Response

**[ReadConnectorConfigV1Response](../../Models/Requests/ReadConnectorConfigV1Response.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ~~ResetConnector~~

Reset a connector by its name.
It will remove the connector and ALL PAYMENTS generated with it.


> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="resetConnector" method="post" path="/api/payments/connectors/{connector}/reset" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ResetConnectorAsync(connector: Connector.Wise);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |

### Response

**[ResetConnectorResponse](../../Models/Requests/ResetConnectorResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ResetConnectorV1

Reset a connector by its name.
It will remove the connector and ALL PAYMENTS generated with it.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="resetConnectorV1" method="post" path="/api/payments/connectors/{connector}/{connectorId}/reset" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ResetConnectorV1Async(
    connector: Connector.Wise,
    connectorId: "XXX"
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |                                                   |
| `ConnectorId`                                     | *string*                                          | :heavy_check_mark:                                | The connector ID.                                 | XXX                                               |

### Response

**[ResetConnectorV1Response](../../Models/Requests/ResetConnectorV1Response.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ~~ListConnectorTasks~~

List all tasks associated with this connector.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listConnectorTasks" method="get" path="/api/payments/connectors/{connector}/tasks" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListConnectorTasksAsync(
    connector: Connector.Modulr,
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Connector`                                                                                                                                                                                                                                              | [Connector](../../Models/Components/Connector.md)                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                       | The name of the connector.                                                                                                                                                                                                                               |                                                                                                                                                                                                                                                          |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |

### Response

**[ListConnectorTasksResponse](../../Models/Requests/ListConnectorTasksResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ListConnectorTasksV1

List all tasks associated with this connector.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listConnectorTasksV1" method="get" path="/api/payments/connectors/{connector}/{connectorId}/tasks" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListConnectorTasksV1Async(
    connector: Connector.Wise,
    connectorId: "XXX",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Connector`                                                                                                                                                                                                                                              | [Connector](../../Models/Components/Connector.md)                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                       | The name of the connector.                                                                                                                                                                                                                               |                                                                                                                                                                                                                                                          |
| `ConnectorId`                                                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                                                       | The connector ID.                                                                                                                                                                                                                                        | XXX                                                                                                                                                                                                                                                      |
| `PageSize`                                                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                                                   | 100                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                       | Parameter used in pagination requests. Maximum page size is set to 15.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                                                             |

### Response

**[ListConnectorTasksV1Response](../../Models/Requests/ListConnectorTasksV1Response.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ~~GetConnectorTask~~

Get a specific task associated to the connector.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getConnectorTask" method="get" path="/api/payments/connectors/{connector}/tasks/{taskId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetConnectorTaskAsync(
    connector: Connector.Moneycorp,
    taskId: "task1"
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |                                                   |
| `TaskId`                                          | *string*                                          | :heavy_check_mark:                                | The task ID.                                      | task1                                             |

### Response

**[GetConnectorTaskResponse](../../Models/Requests/GetConnectorTaskResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## GetConnectorTaskV1

Get a specific task associated to the connector.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getConnectorTaskV1" method="get" path="/api/payments/connectors/{connector}/{connectorId}/tasks/{taskId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetConnectorTaskV1Async(
    connector: Connector.Modulr,
    connectorId: "XXX",
    taskId: "task1"
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |                                                   |
| `ConnectorId`                                     | *string*                                          | :heavy_check_mark:                                | The connector ID.                                 | XXX                                               |
| `TaskId`                                          | *string*                                          | :heavy_check_mark:                                | The task ID.                                      | task1                                             |

### Response

**[GetConnectorTaskV1Response](../../Models/Requests/GetConnectorTaskV1Response.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ConnectorsTransfer

Execute a transfer between two accounts.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="connectorsTransfer" method="post" path="/api/payments/connectors/{connector}/transfers" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ConnectorsTransferAsync(
    connector: Connector.Generic,
    transferRequest: new TransferRequest() {
        Amount = 100,
        Asset = "USD",
        Destination = "acct_1Gqj58KZcSIg2N2q",
        Source = "acct_1Gqj58KZcSIg2N2q",
    }
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Connector`                                                   | [Connector](../../Models/Components/Connector.md)             | :heavy_check_mark:                                            | The name of the connector.                                    |
| `TransferRequest`                                             | [TransferRequest](../../Models/Components/TransferRequest.md) | :heavy_check_mark:                                            | N/A                                                           |

### Response

**[ConnectorsTransferResponse](../../Models/Requests/ConnectorsTransferResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.PaymentsErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |