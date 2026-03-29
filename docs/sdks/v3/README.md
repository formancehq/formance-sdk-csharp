# Payments.V3

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
* [V3UpdateConnectorConfig](#v3updateconnectorconfig) - Update the config of a connector
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
* [CreatePaymentServiceUser](#createpaymentserviceuser) - Create a formance payment service user object
* [ListPaymentServiceUsers](#listpaymentserviceusers) - List all payment service users
* [GetPaymentServiceUser](#getpaymentserviceuser) - Get a payment service user by ID
* [DeletePaymentServiceUser](#deletepaymentserviceuser) - Delete a payment service user by ID
* [ListPaymentServiceUserConnections](#listpaymentserviceuserconnections) - List all connections for a payment service user
* [DeletePaymentServiceUserConnector](#deletepaymentserviceuserconnector) - Remove a payment service user from a connector, the PSU will still exist in Formance
* [ForwardPaymentServiceUserToProvider](#forwardpaymentserviceusertoprovider) - Register/forward a payment service user on/to a connector
* [CreateLinkForPaymentServiceUser](#createlinkforpaymentserviceuser) - Create an authentication link for a payment service user on a connector, for oauth flow
* [ListPaymentServiceUserConnectionsFromConnectorID](#listpaymentserviceuserconnectionsfromconnectorid) - List enabled connections for a payment service user on a connector (i.e. the various banks PSUser has enabled on the connector)
* [ListPaymentServiceUserLinkAttemptsFromConnectorID](#listpaymentserviceuserlinkattemptsfromconnectorid) - List all link attempts for a payment service user on a connector.
Allows to check if users used the link and completed the oauth flow.

* [GetPaymentServiceUserLinkAttemptFromConnectorID](#getpaymentserviceuserlinkattemptfromconnectorid) - Get a link attempt for a payment service user on a connector
* [DeletePaymentServiceUserConnectionFromConnectorID](#deletepaymentserviceuserconnectionfromconnectorid) - Delete a connection for a payment service user on a connector
* [UpdateLinkForPaymentServiceUserOnConnector](#updatelinkforpaymentserviceuseronconnector) - Update/Regenerate a link for a payment service user on a connector
* [AddBankAccountToPaymentServiceUser](#addbankaccounttopaymentserviceuser) - Add a bank account to a payment service user
* [ForwardPaymentServiceUserBankAccount](#forwardpaymentserviceuserbankaccount) - Forward a payment service user's bank account to a connector
* [CreatePool](#createpool) - Create a formance pool object
* [ListPools](#listpools) - List all pools
* [GetPool](#getpool) - Get a pool by ID
* [DeletePool](#deletepool) - Delete a pool by ID
* [UpdatePoolQuery](#updatepoolquery) - Update the query of a pool
* [GetPoolBalances](#getpoolbalances) - Get historical pool balances from a particular point in time
* [GetPoolBalancesLatest](#getpoolbalanceslatest) - Get latest pool balances
* [AddAccountToPool](#addaccounttopool) - Add an account to a pool
* [RemoveAccountFromPool](#removeaccountfrompool) - Remove an account from a pool
* [GetTask](#gettask) - Get a task and its result by ID

## CreateAccount

Create a formance account object. This object will not be forwarded to the connector. It is only used for internal purposes.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreateAccount" method="post" path="/api/payments/v3/accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Payments;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3CreateAccountRequest? req = null;

var res = await sdk.Payments.V3.CreateAccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [V3CreateAccountRequest](../../Models/Payments/V3CreateAccountRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |
| `serverURL`                                                               | *string*                                                                  | :heavy_minus_sign:                                                        | An optional server URL to use.                                            |

### Response

**[Models.Requests.V3CreateAccountResponse](../../Models/Requests/V3CreateAccountResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListAccounts

List all accounts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListAccounts" method="get" path="/api/payments/v3/accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListAccountsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListAccountsResponse](../../Models/Requests/V3ListAccountsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetAccount

Get an account by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetAccount" method="get" path="/api/payments/v3/accounts/{accountID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `AccountID`                    | *string*                       | :heavy_check_mark:             | The account ID                 |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3GetAccountResponse](../../Models/Requests/V3GetAccountResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetAccountBalances

Get account balances

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetAccountBalances" method="get" path="/api/payments/v3/accounts/{accountID}/balances" -->
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
| `serverURL`                                                                         | *string*                                                                            | :heavy_minus_sign:                                                                  | An optional server URL to use.                                                      |

### Response

**[V3GetAccountBalancesResponse](../../Models/Requests/V3GetAccountBalancesResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## CreateBankAccount

Create a formance bank account object. This object will not be forwarded to the connector until you called the forwardBankAccount method.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreateBankAccount" method="post" path="/api/payments/v3/bank-accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Payments;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3CreateBankAccountRequest? req = null;

var res = await sdk.Payments.V3.CreateBankAccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [V3CreateBankAccountRequest](../../Models/Payments/V3CreateBankAccountRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `serverURL`                                                                       | *string*                                                                          | :heavy_minus_sign:                                                                | An optional server URL to use.                                                    |

### Response

**[Models.Requests.V3CreateBankAccountResponse](../../Models/Requests/V3CreateBankAccountResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListBankAccounts

List all bank accounts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListBankAccounts" method="get" path="/api/payments/v3/bank-accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListBankAccountsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListBankAccountsResponse](../../Models/Requests/V3ListBankAccountsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetBankAccount

Get a Bank Account by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetBankAccount" method="get" path="/api/payments/v3/bank-accounts/{bankAccountID}" -->
```csharp
using FormanceSDK;

var sdk = new Formance();

var res = await sdk.Payments.V3.GetBankAccountAsync(bankAccountID: "<id>");

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `BankAccountID`                | *string*                       | :heavy_check_mark:             | The bank account ID            |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3GetBankAccountResponse](../../Models/Requests/V3GetBankAccountResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## UpdateBankAccountMetadata

Update a bank account's metadata

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3UpdateBankAccountMetadata" method="patch" path="/api/payments/v3/bank-accounts/{bankAccountID}/metadata" -->
```csharp
using FormanceSDK;

var sdk = new Formance();

var res = await sdk.Payments.V3.UpdateBankAccountMetadataAsync(bankAccountID: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `BankAccountID`                                                                                                   | *string*                                                                                                          | :heavy_check_mark:                                                                                                | The bank account ID                                                                                               |
| `V3UpdateBankAccountMetadataRequest`                                                                              | [Models.Payments.V3UpdateBankAccountMetadataRequest](../../Models/Payments/V3UpdateBankAccountMetadataRequest.md) | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |
| `serverURL`                                                                                                       | *string*                                                                                                          | :heavy_minus_sign:                                                                                                | An optional server URL to use.                                                                                    |

### Response

**[V3UpdateBankAccountMetadataResponse](../../Models/Requests/V3UpdateBankAccountMetadataResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ForwardBankAccount

Forward a Bank Account to a PSP for creation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ForwardBankAccount" method="post" path="/api/payments/v3/bank-accounts/{bankAccountID}/forward" -->
```csharp
using FormanceSDK;

var sdk = new Formance();

var res = await sdk.Payments.V3.ForwardBankAccountAsync(bankAccountID: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `BankAccountID`                                                                                     | *string*                                                                                            | :heavy_check_mark:                                                                                  | The bank account ID                                                                                 |
| `V3ForwardBankAccountRequest`                                                                       | [Models.Payments.V3ForwardBankAccountRequest](../../Models/Payments/V3ForwardBankAccountRequest.md) | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |
| `serverURL`                                                                                         | *string*                                                                                            | :heavy_minus_sign:                                                                                  | An optional server URL to use.                                                                      |

### Response

**[Models.Requests.V3ForwardBankAccountResponse](../../Models/Requests/V3ForwardBankAccountResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListConnectors

List all connectors

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListConnectors" method="get" path="/api/payments/v3/connectors" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListConnectorsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListConnectorsResponse](../../Models/Requests/V3ListConnectorsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## InstallConnector

Install a connector

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3InstallConnector" method="post" path="/api/payments/v3/connectors/install/{connector}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.InstallConnectorAsync(connector: "<value>");

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `Connector`                                                     | *string*                                                        | :heavy_check_mark:                                              | The connector to filter by                                      |
| `V3ConnectorConfig`                                             | [V3ConnectorConfig](../../Models/Payments/V3ConnectorConfig.md) | :heavy_minus_sign:                                              | N/A                                                             |
| `serverURL`                                                     | *string*                                                        | :heavy_minus_sign:                                              | An optional server URL to use.                                  |

### Response

**[Models.Requests.V3InstallConnectorResponse](../../Models/Requests/V3InstallConnectorResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListConnectorConfigs

List all connector configurations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListConnectorConfigs" method="get" path="/api/payments/v3/connectors/configs" -->
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

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3ListConnectorConfigsResponse](../../Models/Requests/V3ListConnectorConfigsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## UninstallConnector

Uninstall a connector

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3UninstallConnector" method="delete" path="/api/payments/v3/connectors/{connectorID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `ConnectorID`                  | *string*                       | :heavy_check_mark:             | The connector ID               |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3UninstallConnectorResponse](../../Models/Requests/V3UninstallConnectorResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetConnectorConfig

Get a connector configuration by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetConnectorConfig" method="get" path="/api/payments/v3/connectors/{connectorID}/config" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `ConnectorID`                  | *string*                       | :heavy_check_mark:             | The connector ID               |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3GetConnectorConfigResponse](../../Models/Requests/V3GetConnectorConfigResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## V3UpdateConnectorConfig

Update connector config

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3UpdateConnectorConfig" method="patch" path="/api/payments/v3/connectors/{connectorID}/config" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.V3UpdateConnectorConfigAsync(connectorID: "<id>");

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectorID`                                                   | *string*                                                        | :heavy_check_mark:                                              | The connector ID                                                |
| `V3ConnectorConfig`                                             | [V3ConnectorConfig](../../Models/Payments/V3ConnectorConfig.md) | :heavy_minus_sign:                                              | N/A                                                             |
| `serverURL`                                                     | *string*                                                        | :heavy_minus_sign:                                              | An optional server URL to use.                                  |

### Response

**[V3UpdateConnectorConfigResponse](../../Models/Requests/V3UpdateConnectorConfigResponse.md)**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| FormanceSDK.Models.Payments.PaymentsErrorResponse | default                                           | application/json                                  |
| FormanceSDK.Models.Errors.SDKException            | 4XX, 5XX                                          | \*/\*                                             |

## ResetConnector

Reset a connector. Be aware that this will delete all data and stop all existing tasks like payment initiations and bank account creations.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ResetConnector" method="post" path="/api/payments/v3/connectors/{connectorID}/reset" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `ConnectorID`                  | *string*                       | :heavy_check_mark:             | The connector ID               |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3ResetConnectorResponse](../../Models/Requests/V3ResetConnectorResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListConnectorSchedules

List all connector schedules

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListConnectorSchedules" method="get" path="/api/payments/v3/connectors/{connectorID}/schedules" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListConnectorSchedulesAsync(
    connectorID: "<id>",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
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
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListConnectorSchedulesResponse](../../Models/Requests/V3ListConnectorSchedulesResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetConnectorSchedule

Get a connector schedule by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetConnectorSchedule" method="get" path="/api/payments/v3/connectors/{connectorID}/schedules/{scheduleID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `ConnectorID`                  | *string*                       | :heavy_check_mark:             | The connector ID               |
| `ScheduleID`                   | *string*                       | :heavy_check_mark:             | The schedule ID                |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3GetConnectorScheduleResponse](../../Models/Requests/V3GetConnectorScheduleResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListConnectorScheduleInstances

List all connector schedule instances

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListConnectorScheduleInstances" method="get" path="/api/payments/v3/connectors/{connectorID}/schedules/{scheduleID}/instances" -->
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
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListConnectorScheduleInstancesResponse](../../Models/Requests/V3ListConnectorScheduleInstancesResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## CreatePayment

Create a formance payment object. This object will not be forwarded to the connector. It is only used for internal purposes.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreatePayment" method="post" path="/api/payments/v3/payments" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Payments;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3CreatePaymentRequest? req = null;

var res = await sdk.Payments.V3.CreatePaymentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [V3CreatePaymentRequest](../../Models/Payments/V3CreatePaymentRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |
| `serverURL`                                                               | *string*                                                                  | :heavy_minus_sign:                                                        | An optional server URL to use.                                            |

### Response

**[Models.Requests.V3CreatePaymentResponse](../../Models/Requests/V3CreatePaymentResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListPayments

List all payments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPayments" method="get" path="/api/payments/v3/payments" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListPaymentsResponse](../../Models/Requests/V3ListPaymentsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetPayment

Get a payment by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetPayment" method="get" path="/api/payments/v3/payments/{paymentID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentID`                    | *string*                       | :heavy_check_mark:             | The payment ID                 |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3GetPaymentResponse](../../Models/Requests/V3GetPaymentResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## UpdatePaymentMetadata

Update a payment's metadata

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3UpdatePaymentMetadata" method="patch" path="/api/payments/v3/payments/{paymentID}/metadata" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.UpdatePaymentMetadataAsync(paymentID: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `PaymentID`                                                                                               | *string*                                                                                                  | :heavy_check_mark:                                                                                        | The payment ID                                                                                            |
| `V3UpdatePaymentMetadataRequest`                                                                          | [Models.Payments.V3UpdatePaymentMetadataRequest](../../Models/Payments/V3UpdatePaymentMetadataRequest.md) | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |
| `serverURL`                                                                                               | *string*                                                                                                  | :heavy_minus_sign:                                                                                        | An optional server URL to use.                                                                            |

### Response

**[V3UpdatePaymentMetadataResponse](../../Models/Requests/V3UpdatePaymentMetadataResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## InitiatePayment

Initiate a payment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3InitiatePayment" method="post" path="/api/payments/v3/payment-initiations" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.InitiatePaymentAsync(noValidation: false);

// handle response
```

### Parameters

| Parameter                                                                                                                         | Type                                                                                                                              | Required                                                                                                                          | Description                                                                                                                       |
| --------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| `NoValidation`                                                                                                                    | *bool*                                                                                                                            | :heavy_minus_sign:                                                                                                                | If set to true, the request will not have to be validated. This is useful if we want to directly forward the request to the PSP.<br/> |
| `V3InitiatePaymentRequest`                                                                                                        | [Models.Payments.V3InitiatePaymentRequest](../../Models/Payments/V3InitiatePaymentRequest.md)                                     | :heavy_minus_sign:                                                                                                                | N/A                                                                                                                               |
| `serverURL`                                                                                                                       | *string*                                                                                                                          | :heavy_minus_sign:                                                                                                                | An optional server URL to use.                                                                                                    |

### Response

**[Models.Requests.V3InitiatePaymentResponse](../../Models/Requests/V3InitiatePaymentResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListPaymentInitiations

List all payment initiations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPaymentInitiations" method="get" path="/api/payments/v3/payment-initiations" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentInitiationsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListPaymentInitiationsResponse](../../Models/Requests/V3ListPaymentInitiationsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## DeletePaymentInitiation

Delete a payment initiation by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeletePaymentInitiation" method="delete" path="/api/payments/v3/payment-initiations/{paymentInitiationID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentInitiationID`          | *string*                       | :heavy_check_mark:             | The payment initiation ID      |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3DeletePaymentInitiationResponse](../../Models/Requests/V3DeletePaymentInitiationResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetPaymentInitiation

Get a payment initiation by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetPaymentInitiation" method="get" path="/api/payments/v3/payment-initiations/{paymentInitiationID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentInitiationID`          | *string*                       | :heavy_check_mark:             | The payment initiation ID      |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3GetPaymentInitiationResponse](../../Models/Requests/V3GetPaymentInitiationResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## RetryPaymentInitiation

Retry a payment initiation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3RetryPaymentInitiation" method="post" path="/api/payments/v3/payment-initiations/{paymentInitiationID}/retry" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentInitiationID`          | *string*                       | :heavy_check_mark:             | The payment initiation ID      |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3RetryPaymentInitiationResponse](../../Models/Requests/V3RetryPaymentInitiationResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ApprovePaymentInitiation

Approve a payment initiation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ApprovePaymentInitiation" method="post" path="/api/payments/v3/payment-initiations/{paymentInitiationID}/approve" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentInitiationID`          | *string*                       | :heavy_check_mark:             | The payment initiation ID      |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3ApprovePaymentInitiationResponse](../../Models/Requests/V3ApprovePaymentInitiationResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## RejectPaymentInitiation

Reject a payment initiation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3RejectPaymentInitiation" method="post" path="/api/payments/v3/payment-initiations/{paymentInitiationID}/reject" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentInitiationID`          | *string*                       | :heavy_check_mark:             | The payment initiation ID      |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3RejectPaymentInitiationResponse](../../Models/Requests/V3RejectPaymentInitiationResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ReversePaymentInitiation

Reverse a payment initiation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ReversePaymentInitiation" method="post" path="/api/payments/v3/payment-initiations/{paymentInitiationID}/reverse" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ReversePaymentInitiationAsync(paymentInitiationID: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `PaymentInitiationID`                                                                                           | *string*                                                                                                        | :heavy_check_mark:                                                                                              | The payment initiation ID                                                                                       |
| `V3ReversePaymentInitiationRequest`                                                                             | [Models.Payments.V3ReversePaymentInitiationRequest](../../Models/Payments/V3ReversePaymentInitiationRequest.md) | :heavy_minus_sign:                                                                                              | N/A                                                                                                             |
| `serverURL`                                                                                                     | *string*                                                                                                        | :heavy_minus_sign:                                                                                              | An optional server URL to use.                                                                                  |

### Response

**[Models.Requests.V3ReversePaymentInitiationResponse](../../Models/Requests/V3ReversePaymentInitiationResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListPaymentInitiationAdjustments

List all payment initiation adjustments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPaymentInitiationAdjustments" method="get" path="/api/payments/v3/payment-initiations/{paymentInitiationID}/adjustments" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentInitiationAdjustmentsAsync(
    paymentInitiationID: "<id>",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
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
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListPaymentInitiationAdjustmentsResponse](../../Models/Requests/V3ListPaymentInitiationAdjustmentsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListPaymentInitiationRelatedPayments

List all payments related to a payment initiation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPaymentInitiationRelatedPayments" method="get" path="/api/payments/v3/payment-initiations/{paymentInitiationID}/payments" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentInitiationRelatedPaymentsAsync(
    paymentInitiationID: "<id>",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
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
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListPaymentInitiationRelatedPaymentsResponse](../../Models/Requests/V3ListPaymentInitiationRelatedPaymentsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## CreatePaymentServiceUser

Create a formance payment service user object

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreatePaymentServiceUser" method="post" path="/api/payments/v3/payment-service-users" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Payments;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3CreatePaymentServiceUserRequest? req = null;

var res = await sdk.Payments.V3.CreatePaymentServiceUserAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [V3CreatePaymentServiceUserRequest](../../Models/Payments/V3CreatePaymentServiceUserRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |
| `serverURL`                                                                                     | *string*                                                                                        | :heavy_minus_sign:                                                                              | An optional server URL to use.                                                                  |

### Response

**[Models.Requests.V3CreatePaymentServiceUserResponse](../../Models/Requests/V3CreatePaymentServiceUserResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListPaymentServiceUsers

List all payment service users

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPaymentServiceUsers" method="get" path="/api/payments/v3/payment-service-users" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentServiceUsersAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListPaymentServiceUsersResponse](../../Models/Requests/V3ListPaymentServiceUsersResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetPaymentServiceUser

Get a payment service user by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetPaymentServiceUser" method="get" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetPaymentServiceUserAsync(paymentServiceUserID: "<id>");

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentServiceUserID`         | *string*                       | :heavy_check_mark:             | The payment service user ID    |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3GetPaymentServiceUserResponse](../../Models/Requests/V3GetPaymentServiceUserResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## DeletePaymentServiceUser

Delete a payment service user by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeletePaymentServiceUser" method="delete" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.DeletePaymentServiceUserAsync(paymentServiceUserID: "<id>");

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentServiceUserID`         | *string*                       | :heavy_check_mark:             | The payment service user ID    |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3DeletePaymentServiceUserResponse](../../Models/Requests/V3DeletePaymentServiceUserResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListPaymentServiceUserConnections

List all connections for a payment service user

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPaymentServiceUserConnections" method="get" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/connections" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPaymentServiceUserConnectionsAsync(
    paymentServiceUserID: "<id>",
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PaymentServiceUserID`                                                                                                                                                                                                   | *string*                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                       | The payment service user ID                                                                                                                                                                                              |                                                                                                                                                                                                                          |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListPaymentServiceUserConnectionsResponse](../../Models/Requests/V3ListPaymentServiceUserConnectionsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## DeletePaymentServiceUserConnector

Remove a payment service user from a connector, the PSU will still exist in Formance

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeletePaymentServiceUserConnector" method="delete" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/connectors/{connectorID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.DeletePaymentServiceUserConnectorAsync(
    paymentServiceUserID: "<id>",
    connectorID: "<id>"
);

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentServiceUserID`         | *string*                       | :heavy_check_mark:             | The payment service user ID    |
| `ConnectorID`                  | *string*                       | :heavy_check_mark:             | The connector ID               |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3DeletePaymentServiceUserConnectorResponse](../../Models/Requests/V3DeletePaymentServiceUserConnectorResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ForwardPaymentServiceUserToProvider

Register/forward a payment service user on/to a connector

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ForwardPaymentServiceUserToProvider" method="post" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/connectors/{connectorID}/forward" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ForwardPaymentServiceUserToProviderAsync(
    paymentServiceUserID: "<id>",
    connectorID: "<id>"
);

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentServiceUserID`         | *string*                       | :heavy_check_mark:             | The payment service user ID    |
| `ConnectorID`                  | *string*                       | :heavy_check_mark:             | The connector ID               |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3ForwardPaymentServiceUserToProviderResponse](../../Models/Requests/V3ForwardPaymentServiceUserToProviderResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## CreateLinkForPaymentServiceUser

Create an authentication link for a payment service user on a connector, for oauth flow

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreateLinkForPaymentServiceUser" method="post" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/connectors/{connectorID}/create-link" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.CreateLinkForPaymentServiceUserAsync(
    paymentServiceUserID: "<id>",
    connectorID: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `PaymentServiceUserID`                                                                                  | *string*                                                                                                | :heavy_check_mark:                                                                                      | The payment service user ID                                                                             |
| `ConnectorID`                                                                                           | *string*                                                                                                | :heavy_check_mark:                                                                                      | The connector ID                                                                                        |
| `V3PaymentServiceUserCreateLinkRequest`                                                                 | [V3PaymentServiceUserCreateLinkRequest](../../Models/Payments/V3PaymentServiceUserCreateLinkRequest.md) | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |
| `serverURL`                                                                                             | *string*                                                                                                | :heavy_minus_sign:                                                                                      | An optional server URL to use.                                                                          |

### Response

**[V3CreateLinkForPaymentServiceUserResponse](../../Models/Requests/V3CreateLinkForPaymentServiceUserResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListPaymentServiceUserConnectionsFromConnectorID

List enabled connections for a payment service user on a connector (i.e. the various banks PSUser has enabled on the connector)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPaymentServiceUserConnectionsFromConnectorID" method="get" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/connectors/{connectorID}/connections" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3ListPaymentServiceUserConnectionsFromConnectorIDRequest req = new V3ListPaymentServiceUserConnectionsFromConnectorIDRequest() {
    PaymentServiceUserID = "<id>",
    ConnectorID = "<id>",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
};

var res = await sdk.Payments.V3.ListPaymentServiceUserConnectionsFromConnectorIDAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                                       | Type                                                                                                                                            | Required                                                                                                                                        | Description                                                                                                                                     |
| ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                                       | [V3ListPaymentServiceUserConnectionsFromConnectorIDRequest](../../Models/Requests/V3ListPaymentServiceUserConnectionsFromConnectorIDRequest.md) | :heavy_check_mark:                                                                                                                              | The request object to use for the request.                                                                                                      |
| `serverURL`                                                                                                                                     | *string*                                                                                                                                        | :heavy_minus_sign:                                                                                                                              | An optional server URL to use.                                                                                                                  |

### Response

**[V3ListPaymentServiceUserConnectionsFromConnectorIDResponse](../../Models/Requests/V3ListPaymentServiceUserConnectionsFromConnectorIDResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListPaymentServiceUserLinkAttemptsFromConnectorID

List all link attempts for a payment service user on a connector.
Allows to check if users used the link and completed the oauth flow.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPaymentServiceUserLinkAttemptsFromConnectorID" method="get" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/connectors/{connectorID}/link-attempts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3ListPaymentServiceUserLinkAttemptsFromConnectorIDRequest req = new V3ListPaymentServiceUserLinkAttemptsFromConnectorIDRequest() {
    PaymentServiceUserID = "<id>",
    ConnectorID = "<id>",
    PageSize = 100,
    Cursor = "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
};

var res = await sdk.Payments.V3.ListPaymentServiceUserLinkAttemptsFromConnectorIDAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                                         | Type                                                                                                                                              | Required                                                                                                                                          | Description                                                                                                                                       |
| ------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                                         | [V3ListPaymentServiceUserLinkAttemptsFromConnectorIDRequest](../../Models/Requests/V3ListPaymentServiceUserLinkAttemptsFromConnectorIDRequest.md) | :heavy_check_mark:                                                                                                                                | The request object to use for the request.                                                                                                        |
| `serverURL`                                                                                                                                       | *string*                                                                                                                                          | :heavy_minus_sign:                                                                                                                                | An optional server URL to use.                                                                                                                    |

### Response

**[V3ListPaymentServiceUserLinkAttemptsFromConnectorIDResponse](../../Models/Requests/V3ListPaymentServiceUserLinkAttemptsFromConnectorIDResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetPaymentServiceUserLinkAttemptFromConnectorID

Get a link attempt for a payment service user on a connector

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetPaymentServiceUserLinkAttemptFromConnectorID" method="get" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/connectors/{connectorID}/link-attempts/{attemptID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetPaymentServiceUserLinkAttemptFromConnectorIDAsync(
    paymentServiceUserID: "<id>",
    connectorID: "<id>",
    attemptID: "<id>"
);

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentServiceUserID`         | *string*                       | :heavy_check_mark:             | The payment service user ID    |
| `ConnectorID`                  | *string*                       | :heavy_check_mark:             | The connector ID               |
| `AttemptID`                    | *string*                       | :heavy_check_mark:             | The attempt ID                 |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3GetPaymentServiceUserLinkAttemptFromConnectorIDResponse](../../Models/Requests/V3GetPaymentServiceUserLinkAttemptFromConnectorIDResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## DeletePaymentServiceUserConnectionFromConnectorID

Delete a connection for a payment service user on a connector

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeletePaymentServiceUserConnectionFromConnectorID" method="delete" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/connectors/{connectorID}/connections/{connectionID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.DeletePaymentServiceUserConnectionFromConnectorIDAsync(
    paymentServiceUserID: "<id>",
    connectorID: "<id>",
    connectionID: "<id>"
);

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentServiceUserID`         | *string*                       | :heavy_check_mark:             | The payment service user ID    |
| `ConnectorID`                  | *string*                       | :heavy_check_mark:             | The connector ID               |
| `ConnectionID`                 | *string*                       | :heavy_check_mark:             | The connection ID              |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3DeletePaymentServiceUserConnectionFromConnectorIDResponse](../../Models/Requests/V3DeletePaymentServiceUserConnectionFromConnectorIDResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## UpdateLinkForPaymentServiceUserOnConnector

Update/Regenerate a link for a payment service user on a connector

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3UpdateLinkForPaymentServiceUserOnConnector" method="post" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/connectors/{connectorID}/connections/{connectionID}/update-link" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.UpdateLinkForPaymentServiceUserOnConnectorAsync(
    paymentServiceUserID: "<id>",
    connectorID: "<id>",
    connectionID: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `PaymentServiceUserID`                                                                                  | *string*                                                                                                | :heavy_check_mark:                                                                                      | The payment service user ID                                                                             |
| `ConnectorID`                                                                                           | *string*                                                                                                | :heavy_check_mark:                                                                                      | The connector ID                                                                                        |
| `ConnectionID`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | The connection ID                                                                                       |
| `V3PaymentServiceUserUpdateLinkRequest`                                                                 | [V3PaymentServiceUserUpdateLinkRequest](../../Models/Payments/V3PaymentServiceUserUpdateLinkRequest.md) | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |
| `serverURL`                                                                                             | *string*                                                                                                | :heavy_minus_sign:                                                                                      | An optional server URL to use.                                                                          |

### Response

**[V3UpdateLinkForPaymentServiceUserOnConnectorResponse](../../Models/Requests/V3UpdateLinkForPaymentServiceUserOnConnectorResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## AddBankAccountToPaymentServiceUser

Add a bank account to a payment service user

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3AddBankAccountToPaymentServiceUser" method="post" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/bank-accounts/{bankAccountID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.AddBankAccountToPaymentServiceUserAsync(
    paymentServiceUserID: "<id>",
    bankAccountID: "<id>"
);

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PaymentServiceUserID`         | *string*                       | :heavy_check_mark:             | The payment service user ID    |
| `BankAccountID`                | *string*                       | :heavy_check_mark:             | The bank account ID            |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3AddBankAccountToPaymentServiceUserResponse](../../Models/Requests/V3AddBankAccountToPaymentServiceUserResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ForwardPaymentServiceUserBankAccount

Forward a payment service user's bank account to a connector

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ForwardPaymentServiceUserBankAccount" method="post" path="/api/payments/v3/payment-service-users/{paymentServiceUserID}/bank-accounts/{bankAccountID}/forward" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ForwardPaymentServiceUserBankAccountAsync(
    paymentServiceUserID: "<id>",
    bankAccountID: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                               | Type                                                                                                                                    | Required                                                                                                                                | Description                                                                                                                             |
| --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| `PaymentServiceUserID`                                                                                                                  | *string*                                                                                                                                | :heavy_check_mark:                                                                                                                      | The payment service user ID                                                                                                             |
| `BankAccountID`                                                                                                                         | *string*                                                                                                                                | :heavy_check_mark:                                                                                                                      | The bank account ID                                                                                                                     |
| `V3ForwardPaymentServiceUserBankAccountRequest`                                                                                         | [Models.Payments.V3ForwardPaymentServiceUserBankAccountRequest](../../Models/Payments/V3ForwardPaymentServiceUserBankAccountRequest.md) | :heavy_minus_sign:                                                                                                                      | N/A                                                                                                                                     |
| `serverURL`                                                                                                                             | *string*                                                                                                                                | :heavy_minus_sign:                                                                                                                      | An optional server URL to use.                                                                                                          |

### Response

**[Models.Requests.V3ForwardPaymentServiceUserBankAccountResponse](../../Models/Requests/V3ForwardPaymentServiceUserBankAccountResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## CreatePool

Create a formance pool object

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreatePool" method="post" path="/api/payments/v3/pools" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Payments;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

V3CreatePoolRequest? req = null;

var res = await sdk.Payments.V3.CreatePoolAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [V3CreatePoolRequest](../../Models/Payments/V3CreatePoolRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |
| `serverURL`                                                         | *string*                                                            | :heavy_minus_sign:                                                  | An optional server URL to use.                                      |

### Response

**[Models.Requests.V3CreatePoolResponse](../../Models/Requests/V3CreatePoolResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## ListPools

List all pools

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPools" method="get" path="/api/payments/v3/pools" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.ListPoolsAsync(
    pageSize: 100,
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ=="
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The number of items to return                                                                                                                                                                                            | 100                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests. Set to the value of next for the next page of results. Set to the value of previous for the previous page of results. No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `RequestBody`                                                                                                                                                                                                            | Dictionary<String, *object*>                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                      |                                                                                                                                                                                                                          |
| `serverURL`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | An optional server URL to use.                                                                                                                                                                                           | http://localhost:8080                                                                                                                                                                                                    |

### Response

**[V3ListPoolsResponse](../../Models/Requests/V3ListPoolsResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetPool

Get a pool by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetPool" method="get" path="/api/payments/v3/pools/{poolID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PoolID`                       | *string*                       | :heavy_check_mark:             | The pool ID                    |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3GetPoolResponse](../../Models/Requests/V3GetPoolResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## DeletePool

Delete a pool by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeletePool" method="delete" path="/api/payments/v3/pools/{poolID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PoolID`                       | *string*                       | :heavy_check_mark:             | The pool ID                    |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3DeletePoolResponse](../../Models/Requests/V3DeletePoolResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## UpdatePoolQuery

Update the query of a pool

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3UpdatePoolQuery" method="patch" path="/api/payments/v3/pools/{poolID}/query" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.UpdatePoolQueryAsync(poolID: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `PoolID`                                                                                      | *string*                                                                                      | :heavy_check_mark:                                                                            | The pool ID                                                                                   |
| `V3UpdatePoolQueryRequest`                                                                    | [Models.Payments.V3UpdatePoolQueryRequest](../../Models/Payments/V3UpdatePoolQueryRequest.md) | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `serverURL`                                                                                   | *string*                                                                                      | :heavy_minus_sign:                                                                            | An optional server URL to use.                                                                |

### Response

**[V3UpdatePoolQueryResponse](../../Models/Requests/V3UpdatePoolQueryResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetPoolBalances

Get historical pool balances from a particular point in time

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetPoolBalances" method="get" path="/api/payments/v3/pools/{poolID}/balances" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetPoolBalancesAsync(poolID: "<id>");

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `PoolID`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | The pool ID                                                                           |
| `At`                                                                                  | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | The time to filter by                                                                 |
| `serverURL`                                                                           | *string*                                                                              | :heavy_minus_sign:                                                                    | An optional server URL to use.                                                        |

### Response

**[V3GetPoolBalancesResponse](../../Models/Requests/V3GetPoolBalancesResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetPoolBalancesLatest

Get latest pool balances

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetPoolBalancesLatest" method="get" path="/api/payments/v3/pools/{poolID}/balances/latest" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Payments.V3.GetPoolBalancesLatestAsync(poolID: "<id>");

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PoolID`                       | *string*                       | :heavy_check_mark:             | The pool ID                    |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3GetPoolBalancesLatestResponse](../../Models/Requests/V3GetPoolBalancesLatestResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## AddAccountToPool

Add an account to a pool

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3AddAccountToPool" method="post" path="/api/payments/v3/pools/{poolID}/accounts/{accountID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PoolID`                       | *string*                       | :heavy_check_mark:             | The pool ID                    |
| `AccountID`                    | *string*                       | :heavy_check_mark:             | The account ID                 |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3AddAccountToPoolResponse](../../Models/Requests/V3AddAccountToPoolResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## RemoveAccountFromPool

Remove an account from a pool

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3RemoveAccountFromPool" method="delete" path="/api/payments/v3/pools/{poolID}/accounts/{accountID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `PoolID`                       | *string*                       | :heavy_check_mark:             | The pool ID                    |
| `AccountID`                    | *string*                       | :heavy_check_mark:             | The account ID                 |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[V3RemoveAccountFromPoolResponse](../../Models/Requests/V3RemoveAccountFromPoolResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |

## GetTask

Get a task and its result by ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetTask" method="get" path="/api/payments/v3/tasks/{taskID}" -->
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

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `TaskID`                       | *string*                       | :heavy_check_mark:             | The task ID                    |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[Models.Requests.V3GetTaskResponse](../../Models/Requests/V3GetTaskResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Payments.V3ErrorResponse | default                                     | application/json                            |
| FormanceSDK.Models.Errors.SDKException      | 4XX, 5XX                                    | \*/\*                                       |