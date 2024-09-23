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
* [UdpateTransferInitiationStatus](#udpatetransferinitiationstatus) - Update the status of a transfer initiation
* [ReverseTransferInitiation](#reversetransferinitiation) - Reverse a transfer initiation
* [RetryTransferInitiation](#retrytransferinitiation) - Retry a failed transfer initiation
* [ListPools](#listpools) - List Pools
* [CreatePool](#createpool) - Create a Pool
* [GetPool](#getpool) - Get a Pool
* [DeletePool](#deletepool) - Delete a Pool
* [AddAccountToPool](#addaccounttopool) - Add an account to a pool
* [RemoveAccountFromPool](#removeaccountfrompool) - Remove an account from a pool
* [GetPoolBalances](#getpoolbalances) - Get pool balances
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

```csharp
using formance;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## CreatePayment

Create a payment

### Example Usage

```csharp
using formance;
using formance.Models.Components;
using System.Numerics;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

PaymentRequest req = new PaymentRequest() {
    Reference = "<value>",
    ConnectorID = "<value>",
    CreatedAt = System.DateTime.Parse("2024-11-09T01:03:21.011Z"),
    Amount = 100,
    Type = formance.Models.Components.PaymentType.Other,
    Status = formance.Models.Components.PaymentStatus.RefundedFailure,
    Scheme = formance.Models.Components.PaymentScheme.SepaDebit,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ListPayments

List payments

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

var res = await sdk.Payments.V1.ListPaymentsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    sort: new List<string>() {
        "date:asc",
        "status:desc",
    },
    query: "<value>"
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## GetPayment

Get a payment

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## UpdateMetadata

Update metadata

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ListTransferInitiations

List Transfer Initiations

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

var res = await sdk.Payments.V1.ListTransferInitiationsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    sort: new List<string>() {
        "date:asc",
        "status:desc",
    },
    query: "<value>"
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## CreateTransferInitiation

Create a transfer initiation

### Example Usage

```csharp
using formance;
using formance.Models.Components;
using System.Numerics;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

TransferInitiationRequest req = new TransferInitiationRequest() {
    Reference = "XXX",
    ScheduledAt = System.DateTime.Parse("2022-10-09T08:11:40.585Z"),
    Description = "Open-architected heuristic knowledge user",
    SourceAccountID = "<value>",
    DestinationAccountID = "<value>",
    Type = formance.Models.Components.TransferInitiationRequestType.Payout,
    Amount = 658256,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## GetTransferInitiation

Get a transfer initiation

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## DeleteTransferInitiation

Delete a transfer initiation by its id.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## UdpateTransferInitiationStatus

Update a transfer initiation status

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UdpateTransferInitiationStatusAsync(
    transferId: "XXX",
    updateTransferInitiationStatusRequest: new UpdateTransferInitiationStatusRequest() {
        Status = formance.Models.Components.Status.Validated,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               | Example                                                                                                   |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `TransferId`                                                                                              | *string*                                                                                                  | :heavy_check_mark:                                                                                        | The transfer ID.                                                                                          | XXX                                                                                                       |
| `UpdateTransferInitiationStatusRequest`                                                                   | [UpdateTransferInitiationStatusRequest](../../Models/Components/UpdateTransferInitiationStatusRequest.md) | :heavy_check_mark:                                                                                        | N/A                                                                                                       |                                                                                                           |

### Response

**[UdpateTransferInitiationStatusResponse](../../Models/Requests/UdpateTransferInitiationStatusResponse.md)**

### Errors

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ReverseTransferInitiation

Reverse transfer initiation

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

var res = await sdk.Payments.V1.ReverseTransferInitiationAsync(
    transferId: "XXX",
    reverseTransferInitiationRequest: new Models.Components.ReverseTransferInitiationRequest() {
        Reference = "XXX",
        Description = "Function-based high-level project",
        Amount = 170849,
        Asset = "USD",
        Metadata = new Dictionary<string, string>() {
            { "key", "<value>" },
        },
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## RetryTransferInitiation

Retry a failed transfer initiation

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ListPools

List Pools

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

var res = await sdk.Payments.V1.ListPoolsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    sort: new List<string>() {
        "date:asc",
        "status:desc",
    },
    query: "<value>"
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## CreatePool

Create a Pool

### Example Usage

```csharp
using formance;
using formance.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

PoolRequest req = new PoolRequest() {
    Name = "<value>",
    AccountIDs = new List<string>() {
        "<value>",
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## GetPool

Get a Pool

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## DeletePool

Delete a pool by its id.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## AddAccountToPool

Add an account to a pool

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.AddAccountToPoolAsync(
    poolId: "XXX",
    addAccountToPoolRequest: new Models.Components.AddAccountToPoolRequest() {
        AccountID = "<value>",
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## RemoveAccountFromPool

Remove an account from a pool by its id.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## GetPoolBalances

Get pool balances

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetPoolBalancesAsync(
    poolId: "XXX",
    at: System.DateTime.Parse("2023-05-05T06:40:23.119Z")
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## CreateAccount

Create an account

### Example Usage

```csharp
using formance;
using formance.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

AccountRequest req = new AccountRequest() {
    Reference = "<value>",
    ConnectorID = "<value>",
    CreatedAt = System.DateTime.Parse("2024-08-19T02:15:08.152Z"),
    Type = formance.Models.Components.AccountType.Internal,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## PaymentslistAccounts

List accounts

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## PaymentsgetAccount

Get an account

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## GetAccountBalances

Get account balances

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## CreateBankAccount

Create a bank account in Payments and on the PSP.

### Example Usage

```csharp
using formance;
using formance.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

BankAccountRequest req = new BankAccountRequest() {
    Country = "GB",
    ConnectorID = "<value>",
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ListBankAccounts

List all bank accounts created by user on Formance.

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## GetBankAccount

Get a bank account created by user on Formance

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ForwardBankAccount

Forward a bank account to a connector

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ForwardBankAccountAsync(
    bankAccountId: "XXX",
    forwardBankAccountRequest: new Models.Components.ForwardBankAccountRequest() {
        ConnectorID = "<value>",
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## UpdateBankAccountMetadata

Update metadata of a bank account

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

var res = await sdk.Payments.V1.UpdateBankAccountMetadataAsync(
    bankAccountId: "XXX",
    updateBankAccountMetadataRequest: new Models.Components.UpdateBankAccountMetadataRequest() {
        Metadata = new Dictionary<string, string>() {
            { "key", "<value>" },
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ListAllConnectors

List all installed connectors.

### Example Usage

```csharp
using formance;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ListConfigsAvailableConnectors

List the configs of each available connector.

### Example Usage

```csharp
using formance;
using formance.Models.Components;

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## InstallConnector

Install a connector by its name and config.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.InstallConnectorAsync(
    connector: formance.Models.Components.Connector.Wise,
    connectorConfig: ConnectorConfig.CreateAtlarConfig(
        new AtlarConfig() {
            Name = "My Atlar Account",
            BaseUrl = "https://api.example.com",
            PollingPeriod = "60s",
            TransferInitiationStatusPollingPeriod = "60s",
            AccessKey = "XXX",
            Secret = "XXX",
            PageSize = 50,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ~~UninstallConnector~~

Uninstall a connector by its name.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UninstallConnectorAsync(connector: formance.Models.Components.Connector.Modulr);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |

### Response

**[UninstallConnectorResponse](../../Models/Requests/UninstallConnectorResponse.md)**

### Errors

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## UninstallConnectorV1

Uninstall a connector by its name.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UninstallConnectorV1Async(
    connector: formance.Models.Components.Connector.Generic,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ~~ReadConnectorConfig~~

Read connector config

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ReadConnectorConfigAsync(connector: formance.Models.Components.Connector.Generic);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |

### Response

**[ReadConnectorConfigResponse](../../Models/Requests/ReadConnectorConfigResponse.md)**

### Errors

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## UpdateConnectorConfigV1

Update connector config

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.UpdateConnectorConfigV1Async(
    connector: formance.Models.Components.Connector.Stripe,
    connectorId: "XXX",
    connectorConfig: ConnectorConfig.CreateAdyenConfig(
        new AdyenConfig() {
            Name = "My Adyen Account",
            ApiKey = "XXX",
            HmacKey = "XXX",
            LiveEndpointPrefix = "XXX",
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ReadConnectorConfigV1

Read connector config

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ReadConnectorConfigV1Async(
    connector: formance.Models.Components.Connector.CurrencyCloud,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ~~ResetConnector~~

Reset a connector by its name.
It will remove the connector and ALL PAYMENTS generated with it.


> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ResetConnectorAsync(connector: formance.Models.Components.Connector.Atlar);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Connector`                                       | [Connector](../../Models/Components/Connector.md) | :heavy_check_mark:                                | The name of the connector.                        |

### Response

**[ResetConnectorResponse](../../Models/Requests/ResetConnectorResponse.md)**

### Errors

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ResetConnectorV1

Reset a connector by its name.
It will remove the connector and ALL PAYMENTS generated with it.


### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ResetConnectorV1Async(
    connector: formance.Models.Components.Connector.Generic,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ~~ListConnectorTasks~~

List all tasks associated with this connector.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListConnectorTasksAsync(
    connector: formance.Models.Components.Connector.Modulr,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ListConnectorTasksV1

List all tasks associated with this connector.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.ListConnectorTasksV1Async(
    connector: formance.Models.Components.Connector.BankingCircle,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ~~GetConnectorTask~~

Get a specific task associated to the connector.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetConnectorTaskAsync(
    connector: formance.Models.Components.Connector.Adyen,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## GetConnectorTaskV1

Get a specific task associated to the connector.

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V1.GetConnectorTaskV1Async(
    connector: formance.Models.Components.Connector.BankingCircle,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |


## ConnectorsTransfer

Execute a transfer between two accounts.

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

var res = await sdk.Payments.V1.ConnectorsTransferAsync(
    connector: formance.Models.Components.Connector.BankingCircle,
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| formance.Models.Errors.PaymentsErrorResponse | default                                      | application/json                             |
| formance.Models.Errors.SDKException          | 4xx-5xx                                      | */*                                          |
