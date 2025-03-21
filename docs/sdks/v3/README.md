# V3
(*Payments.V3*)

## Overview

### Available Operations

* [CreateAccount](#createaccount) - Create a formance account object. This object will not be forwarded to the connector. It is only used for internal purposes.

* [ListAccounts](#listaccounts) - List all accounts
* [GetAccount](#getaccount) - Get an account by ID
* [GetAccountBalances](#getaccountbalances) - Get account balances
* [CreateBankAccount](#createbankaccount) - Create a formance bank account object. This object will not be forwarded to the connector until you called the forwardBankAccount method.

* [ListBankAccounts](#listbankaccounts) - List all bank accounts
* [GetBankAccount](#getbankaccount) - Get a Bank Account by ID
* [UpdateBankAccountMetadata](#updatebankaccountmetadata) - Update a bank account's metadata
* [ForwardBankAccount](#forwardbankaccount) - Forward a Bank Account to a PSP for creation
* [ListConnectors](#listconnectors) - List all connectors
* [InstallConnector](#installconnector) - Install a connector
* [ListConnectorConfigs](#listconnectorconfigs) - List all connector configurations
* [UninstallConnector](#uninstallconnector) - Uninstall a connector
* [GetConnectorConfig](#getconnectorconfig) - Get a connector configuration by ID
* [ResetConnector](#resetconnector) - Reset a connector. Be aware that this will delete all data and stop all existing tasks like payment initiations and bank account creations.
* [ListConnectorSchedules](#listconnectorschedules) - List all connector schedules
* [GetConnectorSchedule](#getconnectorschedule) - Get a connector schedule by ID
* [ListConnectorScheduleInstances](#listconnectorscheduleinstances) - List all connector schedule instances
* [CreatePayment](#createpayment) - Create a formance payment object. This object will not be forwarded to the connector. It is only used for internal purposes.

* [ListPayments](#listpayments) - List all payments
* [GetPayment](#getpayment) - Get a payment by ID
* [UpdatePaymentMetadata](#updatepaymentmetadata) - Update a payment's metadata
* [InitiatePayment](#initiatepayment) - Initiate a payment
* [ListPaymentInitiations](#listpaymentinitiations) - List all payment initiations
* [DeletePaymentInitiation](#deletepaymentinitiation) - Delete a payment initiation by ID
* [GetPaymentInitiation](#getpaymentinitiation) - Get a payment initiation by ID
* [RetryPaymentInitiation](#retrypaymentinitiation) - Retry a payment initiation
* [ApprovePaymentInitiation](#approvepaymentinitiation) - Approve a payment initiation
* [RejectPaymentInitiation](#rejectpaymentinitiation) - Reject a payment initiation
* [ReversePaymentInitiation](#reversepaymentinitiation) - Reverse a payment initiation
* [ListPaymentInitiationAdjustments](#listpaymentinitiationadjustments) - List all payment initiation adjustments
* [ListPaymentInitiationRelatedPayments](#listpaymentinitiationrelatedpayments) - List all payments related to a payment initiation
* [CreatePool](#createpool) - Create a formance pool object
* [ListPools](#listpools) - List all pools
* [GetPool](#getpool) - Get a pool by ID
* [DeletePool](#deletepool) - Delete a pool by ID
* [GetPoolBalances](#getpoolbalances) - Get pool balances
* [AddAccountToPool](#addaccounttopool) - Add an account to a pool
* [RemoveAccountFromPool](#removeaccountfrompool) - Remove an account from a pool
* [GetTask](#gettask) - Get a task and its result by ID

## CreateAccount

Create a formance account object. This object will not be forwarded to the connector. It is only used for internal purposes.


### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3CreateAccountRequest req = new V3CreateAccountRequest() {
    Reference = "<value>",
    ConnectorID = "<value>",
    CreatedAt = System.DateTime.Parse("2023-08-09T11:34:36.410Z"),
    AccountName = "<value>",
    Type = V3AccountTypeEnum.Unknown,
};

var res = await sdk.Payments.V3.CreateAccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [V3CreateAccountRequest](../../Models/Components/V3CreateAccountRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[Models.Requests.V3CreateAccountResponse](../../Models/Requests/V3CreateAccountResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListAccounts

List all accounts

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListAccountsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |

### Response

**[V3ListAccountsResponse](../../Models/Requests/V3ListAccountsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetAccount

Get an account by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetAccountAsync(accountID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AccountID`        | *string*           | :heavy_check_mark: | The account ID     |

### Response

**[Models.Requests.V3GetAccountResponse](../../Models/Requests/V3GetAccountResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetAccountBalances

Get account balances

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3GetAccountBalancesRequest req = new V3GetAccountBalancesRequest() {
    AccountID = "<id>",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
};

var res = await sdk.Payments.V3.GetAccountBalancesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [V3GetAccountBalancesRequest](../../Models/Requests/V3GetAccountBalancesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[V3GetAccountBalancesResponse](../../Models/Requests/V3GetAccountBalancesResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CreateBankAccount

Create a formance bank account object. This object will not be forwarded to the connector until you called the forwardBankAccount method.


### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3CreateBankAccountRequest req = new V3CreateBankAccountRequest() {
    Name = "<value>",
};

var res = await sdk.Payments.V3.CreateBankAccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [V3CreateBankAccountRequest](../../Models/Components/V3CreateBankAccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[Models.Requests.V3CreateBankAccountResponse](../../Models/Requests/V3CreateBankAccountResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListBankAccounts

List all bank accounts

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListBankAccountsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |

### Response

**[V3ListBankAccountsResponse](../../Models/Requests/V3ListBankAccountsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetBankAccount

Get a Bank Account by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetBankAccountAsync(bankAccountID: "<id>");

// handle response
```

### Parameters

| Parameter           | Type                | Required            | Description         |
| ------------------- | ------------------- | ------------------- | ------------------- |
| `BankAccountID`     | *string*            | :heavy_check_mark:  | The bank account ID |

### Response

**[Models.Requests.V3GetBankAccountResponse](../../Models/Requests/V3GetBankAccountResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## UpdateBankAccountMetadata

Update a bank account's metadata

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.UpdateBankAccountMetadataAsync(
    bankAccountID: "<id>",
    v3UpdateBankAccountMetadataRequest: new Models.Components.V3UpdateBankAccountMetadataRequest() {
        Metadata = new Dictionary<string, string>() {
            { "key", "<value>" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `BankAccountID`                                                                                                       | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | The bank account ID                                                                                                   |
| `V3UpdateBankAccountMetadataRequest`                                                                                  | [Models.Components.V3UpdateBankAccountMetadataRequest](../../Models/Components/V3UpdateBankAccountMetadataRequest.md) | :heavy_minus_sign:                                                                                                    | N/A                                                                                                                   |

### Response

**[V3UpdateBankAccountMetadataResponse](../../Models/Requests/V3UpdateBankAccountMetadataResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ForwardBankAccount

Forward a Bank Account to a PSP for creation

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ForwardBankAccountAsync(
    bankAccountID: "<id>",
    v3ForwardBankAccountRequest: new Models.Components.V3ForwardBankAccountRequest() {
        ConnectorID = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `BankAccountID`                                                                                         | *string*                                                                                                | :heavy_check_mark:                                                                                      | The bank account ID                                                                                     |
| `V3ForwardBankAccountRequest`                                                                           | [Models.Components.V3ForwardBankAccountRequest](../../Models/Components/V3ForwardBankAccountRequest.md) | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |

### Response

**[Models.Requests.V3ForwardBankAccountResponse](../../Models/Requests/V3ForwardBankAccountResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListConnectors

List all connectors

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListConnectorsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |

### Response

**[V3ListConnectorsResponse](../../Models/Requests/V3ListConnectorsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## InstallConnector

Install a connector

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.InstallConnectorAsync(
    connector: "<value>",
    v3InstallConnectorRequest: V3InstallConnectorRequest.CreateDummypay(
        new V3DummypayConfig() {
            Directory = "/private/tmp",
            Name = "<value>",
        }
    )
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `Connector`                                                                                         | *string*                                                                                            | :heavy_check_mark:                                                                                  | The connector to filter by                                                                          |
| `V3InstallConnectorRequest`                                                                         | [Models.Components.V3InstallConnectorRequest](../../Models/Components/V3InstallConnectorRequest.md) | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |

### Response

**[Models.Requests.V3InstallConnectorResponse](../../Models/Requests/V3InstallConnectorResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListConnectorConfigs

List all connector configurations

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListConnectorConfigsAsync();

// handle response
```

### Response

**[V3ListConnectorConfigsResponse](../../Models/Requests/V3ListConnectorConfigsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## UninstallConnector

Uninstall a connector

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.UninstallConnectorAsync(connectorID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ConnectorID`      | *string*           | :heavy_check_mark: | The connector ID   |

### Response

**[Models.Requests.V3UninstallConnectorResponse](../../Models/Requests/V3UninstallConnectorResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetConnectorConfig

Get a connector configuration by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetConnectorConfigAsync(connectorID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ConnectorID`      | *string*           | :heavy_check_mark: | The connector ID   |

### Response

**[Models.Requests.V3GetConnectorConfigResponse](../../Models/Requests/V3GetConnectorConfigResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ResetConnector

Reset a connector. Be aware that this will delete all data and stop all existing tasks like payment initiations and bank account creations.

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ResetConnectorAsync(connectorID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ConnectorID`      | *string*           | :heavy_check_mark: | The connector ID   |

### Response

**[Models.Requests.V3ResetConnectorResponse](../../Models/Requests/V3ResetConnectorResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListConnectorSchedules

List all connector schedules

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListConnectorSchedulesAsync(
    connectorID: "<id>",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectorID`                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                       | The connector ID                                                                                                                                                                                                         |                                                                                                                                                                                                                          |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |

### Response

**[V3ListConnectorSchedulesResponse](../../Models/Requests/V3ListConnectorSchedulesResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetConnectorSchedule

Get a connector schedule by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetConnectorScheduleAsync(
    connectorID: "<id>",
    scheduleID: "<id>"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ConnectorID`      | *string*           | :heavy_check_mark: | The connector ID   |
| `ScheduleID`       | *string*           | :heavy_check_mark: | The schedule ID    |

### Response

**[V3GetConnectorScheduleResponse](../../Models/Requests/V3GetConnectorScheduleResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListConnectorScheduleInstances

List all connector schedule instances

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListConnectorScheduleInstancesAsync(
    connectorID: "<id>",
    scheduleID: "<id>",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectorID`                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                       | The connector ID                                                                                                                                                                                                         |                                                                                                                                                                                                                          |
| `ScheduleID`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                       | The schedule ID                                                                                                                                                                                                          |                                                                                                                                                                                                                          |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |

### Response

**[V3ListConnectorScheduleInstancesResponse](../../Models/Requests/V3ListConnectorScheduleInstancesResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CreatePayment

Create a formance payment object. This object will not be forwarded to the connector. It is only used for internal purposes.


### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3CreatePaymentRequest req = new V3CreatePaymentRequest() {
    Reference = "<value>",
    ConnectorID = "<value>",
    CreatedAt = System.DateTime.Parse("2023-10-04T19:11:41.956Z"),
    Type = V3PaymentTypeEnum.Transfer,
    InitialAmount = 581056,
    Amount = 444061,
    Asset = "<value>",
    Scheme = "<value>",
};

var res = await sdk.Payments.V3.CreatePaymentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [V3CreatePaymentRequest](../../Models/Components/V3CreatePaymentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[Models.Requests.V3CreatePaymentResponse](../../Models/Requests/V3CreatePaymentResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListPayments

List all payments

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |

### Response

**[V3ListPaymentsResponse](../../Models/Requests/V3ListPaymentsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetPayment

Get a payment by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetPaymentAsync(paymentID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `PaymentID`        | *string*           | :heavy_check_mark: | The payment ID     |

### Response

**[Models.Requests.V3GetPaymentResponse](../../Models/Requests/V3GetPaymentResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## UpdatePaymentMetadata

Update a payment's metadata

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.UpdatePaymentMetadataAsync(
    paymentID: "<id>",
    v3UpdatePaymentMetadataRequest: new Models.Components.V3UpdatePaymentMetadataRequest() {
        Metadata = new Dictionary<string, string>() {
            { "key", "<value>" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `PaymentID`                                                                                                   | *string*                                                                                                      | :heavy_check_mark:                                                                                            | The payment ID                                                                                                |
| `V3UpdatePaymentMetadataRequest`                                                                              | [Models.Components.V3UpdatePaymentMetadataRequest](../../Models/Components/V3UpdatePaymentMetadataRequest.md) | :heavy_minus_sign:                                                                                            | N/A                                                                                                           |

### Response

**[V3UpdatePaymentMetadataResponse](../../Models/Requests/V3UpdatePaymentMetadataResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## InitiatePayment

Initiate a payment

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.InitiatePaymentAsync(
    noValidation: false,
    v3InitiatePaymentRequest: new Models.Components.V3InitiatePaymentRequest() {
        Reference = "<value>",
        ScheduledAt = System.DateTime.Parse("2024-12-23T02:07:00.778Z"),
        ConnectorID = "<value>",
        Description = "decent uh-huh inject angrily",
        Type = V3PaymentInitiationTypeEnum.Payout,
        Amount = 645913,
        Asset = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                         | Type                                                                                                                              | Required                                                                                                                          | Description                                                                                                                       |
| --------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| `NoValidation`                                                                                                                    | *bool*                                                                                                                            | :heavy_minus_sign:                                                                                                                | If set to true, the request will not have to be validated. This is useful if we want to directly forward the request to the PSP.<br/> |
| `V3InitiatePaymentRequest`                                                                                                        | [Models.Components.V3InitiatePaymentRequest](../../Models/Components/V3InitiatePaymentRequest.md)                                 | :heavy_minus_sign:                                                                                                                | N/A                                                                                                                               |

### Response

**[Models.Requests.V3InitiatePaymentResponse](../../Models/Requests/V3InitiatePaymentResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListPaymentInitiations

List all payment initiations

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentInitiationsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |

### Response

**[V3ListPaymentInitiationsResponse](../../Models/Requests/V3ListPaymentInitiationsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeletePaymentInitiation

Delete a payment initiation by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.DeletePaymentInitiationAsync(paymentInitiationID: "<id>");

// handle response
```

### Parameters

| Parameter                 | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `PaymentInitiationID`     | *string*                  | :heavy_check_mark:        | The payment initiation ID |

### Response

**[V3DeletePaymentInitiationResponse](../../Models/Requests/V3DeletePaymentInitiationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetPaymentInitiation

Get a payment initiation by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetPaymentInitiationAsync(paymentInitiationID: "<id>");

// handle response
```

### Parameters

| Parameter                 | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `PaymentInitiationID`     | *string*                  | :heavy_check_mark:        | The payment initiation ID |

### Response

**[Models.Requests.V3GetPaymentInitiationResponse](../../Models/Requests/V3GetPaymentInitiationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## RetryPaymentInitiation

Retry a payment initiation

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.RetryPaymentInitiationAsync(paymentInitiationID: "<id>");

// handle response
```

### Parameters

| Parameter                 | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `PaymentInitiationID`     | *string*                  | :heavy_check_mark:        | The payment initiation ID |

### Response

**[Models.Requests.V3RetryPaymentInitiationResponse](../../Models/Requests/V3RetryPaymentInitiationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ApprovePaymentInitiation

Approve a payment initiation

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ApprovePaymentInitiationAsync(paymentInitiationID: "<id>");

// handle response
```

### Parameters

| Parameter                 | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `PaymentInitiationID`     | *string*                  | :heavy_check_mark:        | The payment initiation ID |

### Response

**[Models.Requests.V3ApprovePaymentInitiationResponse](../../Models/Requests/V3ApprovePaymentInitiationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## RejectPaymentInitiation

Reject a payment initiation

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.RejectPaymentInitiationAsync(paymentInitiationID: "<id>");

// handle response
```

### Parameters

| Parameter                 | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `PaymentInitiationID`     | *string*                  | :heavy_check_mark:        | The payment initiation ID |

### Response

**[V3RejectPaymentInitiationResponse](../../Models/Requests/V3RejectPaymentInitiationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ReversePaymentInitiation

Reverse a payment initiation

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ReversePaymentInitiationAsync(
    paymentInitiationID: "<id>",
    v3ReversePaymentInitiationRequest: new Models.Components.V3ReversePaymentInitiationRequest() {
        Reference = "<value>",
        Description = "than juicy slowly faint so yum seldom",
        Amount = 383763,
        Asset = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `PaymentInitiationID`                                                                                               | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | The payment initiation ID                                                                                           |
| `V3ReversePaymentInitiationRequest`                                                                                 | [Models.Components.V3ReversePaymentInitiationRequest](../../Models/Components/V3ReversePaymentInitiationRequest.md) | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |

### Response

**[Models.Requests.V3ReversePaymentInitiationResponse](../../Models/Requests/V3ReversePaymentInitiationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListPaymentInitiationAdjustments

List all payment initiation adjustments

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentInitiationAdjustmentsAsync(
    paymentInitiationID: "<id>",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PaymentInitiationID`                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                       | The payment initiation ID                                                                                                                                                                                                |                                                                                                                                                                                                                          |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |

### Response

**[V3ListPaymentInitiationAdjustmentsResponse](../../Models/Requests/V3ListPaymentInitiationAdjustmentsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListPaymentInitiationRelatedPayments

List all payments related to a payment initiation

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentInitiationRelatedPaymentsAsync(
    paymentInitiationID: "<id>",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PaymentInitiationID`                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                       | The payment initiation ID                                                                                                                                                                                                |                                                                                                                                                                                                                          |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |

### Response

**[V3ListPaymentInitiationRelatedPaymentsResponse](../../Models/Requests/V3ListPaymentInitiationRelatedPaymentsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## CreatePool

Create a formance pool object

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3CreatePoolRequest req = new V3CreatePoolRequest() {
    Name = "<value>",
    AccountIDs = new List<string>() {
        "<value>",
    },
};

var res = await sdk.Payments.V3.CreatePoolAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [V3CreatePoolRequest](../../Models/Components/V3CreatePoolRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[Models.Requests.V3CreatePoolResponse](../../Models/Requests/V3CreatePoolResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ListPools

List all pools

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPoolsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |

### Response

**[V3ListPoolsResponse](../../Models/Requests/V3ListPoolsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetPool

Get a pool by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetPoolAsync(poolID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `PoolID`           | *string*           | :heavy_check_mark: | The pool ID        |

### Response

**[Models.Requests.V3GetPoolResponse](../../Models/Requests/V3GetPoolResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeletePool

Delete a pool by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.DeletePoolAsync(poolID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `PoolID`           | *string*           | :heavy_check_mark: | The pool ID        |

### Response

**[V3DeletePoolResponse](../../Models/Requests/V3DeletePoolResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetPoolBalances

Get pool balances

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetPoolBalancesAsync(
    poolID: "<id>",
    at: System.DateTime.Parse("2023-10-09T22:18:42.179Z")
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `PoolID`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | The pool ID                                                                           |
| `At`                                                                                  | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | The time to filter by                                                                 |

### Response

**[V3GetPoolBalancesResponse](../../Models/Requests/V3GetPoolBalancesResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## AddAccountToPool

Add an account to a pool

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.AddAccountToPoolAsync(
    poolID: "<id>",
    accountID: "<id>"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `PoolID`           | *string*           | :heavy_check_mark: | The pool ID        |
| `AccountID`        | *string*           | :heavy_check_mark: | The account ID     |

### Response

**[V3AddAccountToPoolResponse](../../Models/Requests/V3AddAccountToPoolResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## RemoveAccountFromPool

Remove an account from a pool

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.RemoveAccountFromPoolAsync(
    poolID: "<id>",
    accountID: "<id>"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `PoolID`           | *string*           | :heavy_check_mark: | The pool ID        |
| `AccountID`        | *string*           | :heavy_check_mark: | The account ID     |

### Response

**[V3RemoveAccountFromPoolResponse](../../Models/Requests/V3RemoveAccountFromPoolResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetTask

Get a task and its result by ID

### Example Usage

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetTaskAsync(taskID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `TaskID`           | *string*           | :heavy_check_mark: | The task ID        |

### Response

**[Models.Requests.V3GetTaskResponse](../../Models/Requests/V3GetTaskResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Errors.V3ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |