# formance

Developer-friendly & type-safe Csharp SDK specifically catered to leverage *formance* API.

<div align="left">
    <a href="https://www.speakeasy.com/?utm_source=formance&utm_campaign=csharp"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>


## 🏗 **Welcome to your new SDK!** 🏗

It has been generated successfully based on your OpenAPI spec. However, it is not yet ready for production use. Here are some next steps:
- [ ] 🛠 Make your SDK feel handcrafted by [customizing it](https://www.speakeasy.com/docs/customize-sdks)
- [ ] ♻️ Refine your SDK quickly by iterating locally with the [Speakeasy CLI](https://github.com/speakeasy-api/speakeasy)
- [ ] 🎁 Publish your SDK to package managers by [configuring automatic publishing](https://www.speakeasy.com/docs/advanced-setup/publish-sdks)
- [ ] ✨ When ready to productionize, delete this section from the README

<!-- Start Summary [summary] -->
## Summary

Formance Stack API: Open, modular foundation for unique payments flows

# Introduction
This API is documented in **OpenAPI format**.

# Authentication
Formance Stack offers one forms of authentication:
  - OAuth2
OAuth2 - an open protocol to allow secure authorization in a simple
and standard method from web, mobile and desktop applications.
<SecurityDefinitions />
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [formance](#formance)
  * [🏗 **Welcome to your new SDK!** 🏗](#welcome-to-your-new-sdk)
* [Introduction](#introduction)
* [Authentication](#authentication)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
  * [Authentication](#authentication-1)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package formance
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/formance/formance.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using formance;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.GetOIDCWellKnownsAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Auth](docs/sdks/auth/README.md)

* [GetServerInfo](docs/sdks/auth/README.md#getserverinfo) - Get server info
* [ListClients](docs/sdks/auth/README.md#listclients) - List clients
* [CreateClient](docs/sdks/auth/README.md#createclient) - Create client
* [ReadClient](docs/sdks/auth/README.md#readclient) - Read client
* [UpdateClient](docs/sdks/auth/README.md#updateclient) - Update client
* [DeleteClient](docs/sdks/auth/README.md#deleteclient) - Delete client
* [CreateSecret](docs/sdks/auth/README.md#createsecret) - Add a secret to a client
* [DeleteSecret](docs/sdks/auth/README.md#deletesecret) - Delete a secret from a client
* [ListUsers](docs/sdks/auth/README.md#listusers) - List users
* [ReadUser](docs/sdks/auth/README.md#readuser) - Read user

### [Formance SDK](docs/sdks/formance/README.md)

* [GetOIDCWellKnowns](docs/sdks/formance/README.md#getoidcwellknowns) - Retrieve OpenID connect well-knowns.
* [GetVersions](docs/sdks/formance/README.md#getversions) - Show stack version information

### [Ledger](docs/sdks/ledger/README.md)


#### [Ledger.V1](docs/sdks/v1/README.md)

* [GetInfo](docs/sdks/v1/README.md#getinfo) - Show server information
* [GetLedgerInfo](docs/sdks/v1/README.md#getledgerinfo) - Get information about a ledger
* [CountAccounts](docs/sdks/v1/README.md#countaccounts) - Count the accounts from a ledger
* [ListAccounts](docs/sdks/v1/README.md#listaccounts) - List accounts from a ledger
* [GetAccount](docs/sdks/v1/README.md#getaccount) - Get account by its address
* [AddMetadataToAccount](docs/sdks/v1/README.md#addmetadatatoaccount) - Add metadata to an account
* [GetMapping](docs/sdks/v1/README.md#getmapping) - Get the mapping of a ledger
* [UpdateMapping](docs/sdks/v1/README.md#updatemapping) - Update the mapping of a ledger
* [~~RunScript~~](docs/sdks/v1/README.md#runscript) - Execute a Numscript :warning: **Deprecated**
* [ReadStats](docs/sdks/v1/README.md#readstats) - Get statistics from a ledger
* [CountTransactions](docs/sdks/v1/README.md#counttransactions) - Count the transactions from a ledger
* [ListTransactions](docs/sdks/v1/README.md#listtransactions) - List transactions from a ledger
* [CreateTransaction](docs/sdks/v1/README.md#createtransaction) - Create a new transaction to a ledger
* [GetTransaction](docs/sdks/v1/README.md#gettransaction) - Get transaction from a ledger by its ID
* [AddMetadataOnTransaction](docs/sdks/v1/README.md#addmetadataontransaction) - Set the metadata of a transaction by its ID
* [RevertTransaction](docs/sdks/v1/README.md#reverttransaction) - Revert a ledger transaction by its ID
* [CreateTransactions](docs/sdks/v1/README.md#createtransactions) - Create a new batch of transactions to a ledger
* [GetBalances](docs/sdks/v1/README.md#getbalances) - Get the balances from a ledger's account
* [GetBalancesAggregated](docs/sdks/v1/README.md#getbalancesaggregated) - Get the aggregated balances from selected accounts
* [ListLogs](docs/sdks/v1/README.md#listlogs) - List the logs from a ledger

#### [Ledger.V2](docs/sdks/v2/README.md)

* [GetInfo](docs/sdks/v2/README.md#getinfo) - Show server information
* [ListLedgers](docs/sdks/v2/README.md#listledgers) - List ledgers
* [GetLedger](docs/sdks/v2/README.md#getledger) - Get a ledger
* [CreateLedger](docs/sdks/v2/README.md#createledger) - Create a ledger
* [UpdateLedgerMetadata](docs/sdks/v2/README.md#updateledgermetadata) - Update ledger metadata
* [DeleteLedgerMetadata](docs/sdks/v2/README.md#deleteledgermetadata) - Delete ledger metadata by key
* [GetLedgerInfo](docs/sdks/v2/README.md#getledgerinfo) - Get information about a ledger
* [CreateBulk](docs/sdks/v2/README.md#createbulk) - Bulk request
* [CountAccounts](docs/sdks/v2/README.md#countaccounts) - Count the accounts from a ledger
* [ListAccounts](docs/sdks/v2/README.md#listaccounts) - List accounts from a ledger
* [GetAccount](docs/sdks/v2/README.md#getaccount) - Get account by its address
* [AddMetadataToAccount](docs/sdks/v2/README.md#addmetadatatoaccount) - Add metadata to an account
* [DeleteAccountMetadata](docs/sdks/v2/README.md#deleteaccountmetadata) - Delete metadata by key
* [ReadStats](docs/sdks/v2/README.md#readstats) - Get statistics from a ledger
* [CountTransactions](docs/sdks/v2/README.md#counttransactions) - Count the transactions from a ledger
* [ListTransactions](docs/sdks/v2/README.md#listtransactions) - List transactions from a ledger
* [CreateTransaction](docs/sdks/v2/README.md#createtransaction) - Create a new transaction to a ledger
* [GetTransaction](docs/sdks/v2/README.md#gettransaction) - Get transaction from a ledger by its ID
* [AddMetadataOnTransaction](docs/sdks/v2/README.md#addmetadataontransaction) - Set the metadata of a transaction by its ID
* [DeleteTransactionMetadata](docs/sdks/v2/README.md#deletetransactionmetadata) - Delete metadata by key
* [RevertTransaction](docs/sdks/v2/README.md#reverttransaction) - Revert a ledger transaction by its ID
* [GetBalancesAggregated](docs/sdks/v2/README.md#getbalancesaggregated) - Get the aggregated balances from selected accounts
* [GetVolumesWithBalances](docs/sdks/v2/README.md#getvolumeswithbalances) - Get list of volumes with balances for (account/asset)
* [ListLogs](docs/sdks/v2/README.md#listlogs) - List the logs from a ledger
* [ImportLogs](docs/sdks/v2/README.md#importlogs)
* [ExportLogs](docs/sdks/v2/README.md#exportlogs) - Export logs

### [Orchestration](docs/sdks/orchestration/README.md)

* [OrchestrationgetServerInfo](docs/sdks/orchestration/README.md#orchestrationgetserverinfo) - Get server info
* [ListTriggers](docs/sdks/orchestration/README.md#listtriggers) - List triggers
* [CreateTrigger](docs/sdks/orchestration/README.md#createtrigger) - Create trigger
* [ReadTrigger](docs/sdks/orchestration/README.md#readtrigger) - Read trigger
* [DeleteTrigger](docs/sdks/orchestration/README.md#deletetrigger) - Delete trigger
* [ListTriggersOccurrences](docs/sdks/orchestration/README.md#listtriggersoccurrences) - List triggers occurrences
* [ListWorkflows](docs/sdks/orchestration/README.md#listworkflows) - List registered workflows
* [CreateWorkflow](docs/sdks/orchestration/README.md#createworkflow) - Create workflow
* [GetWorkflow](docs/sdks/orchestration/README.md#getworkflow) - Get a flow by id
* [DeleteWorkflow](docs/sdks/orchestration/README.md#deleteworkflow) - Delete a flow by id
* [RunWorkflow](docs/sdks/orchestration/README.md#runworkflow) - Run workflow
* [ListInstances](docs/sdks/orchestration/README.md#listinstances) - List instances of a workflow
* [GetInstance](docs/sdks/orchestration/README.md#getinstance) - Get a workflow instance by id
* [SendEvent](docs/sdks/orchestration/README.md#sendevent) - Send an event to a running workflow
* [CancelEvent](docs/sdks/orchestration/README.md#cancelevent) - Cancel a running workflow
* [GetInstanceHistory](docs/sdks/orchestration/README.md#getinstancehistory) - Get a workflow instance history by id
* [GetInstanceStageHistory](docs/sdks/orchestration/README.md#getinstancestagehistory) - Get a workflow instance stage history
* [V2GetServerInfo](docs/sdks/orchestration/README.md#v2getserverinfo) - Get server info
* [V2ListTriggers](docs/sdks/orchestration/README.md#v2listtriggers) - List triggers
* [V2CreateTrigger](docs/sdks/orchestration/README.md#v2createtrigger) - Create trigger
* [V2ReadTrigger](docs/sdks/orchestration/README.md#v2readtrigger) - Read trigger
* [V2DeleteTrigger](docs/sdks/orchestration/README.md#v2deletetrigger) - Delete trigger
* [TestTrigger](docs/sdks/orchestration/README.md#testtrigger) - Test trigger
* [V2ListTriggersOccurrences](docs/sdks/orchestration/README.md#v2listtriggersoccurrences) - List triggers occurrences
* [V2ListWorkflows](docs/sdks/orchestration/README.md#v2listworkflows) - List registered workflows
* [V2CreateWorkflow](docs/sdks/orchestration/README.md#v2createworkflow) - Create workflow
* [V2GetWorkflow](docs/sdks/orchestration/README.md#v2getworkflow) - Get a flow by id
* [V2DeleteWorkflow](docs/sdks/orchestration/README.md#v2deleteworkflow) - Delete a flow by id
* [V2RunWorkflow](docs/sdks/orchestration/README.md#v2runworkflow) - Run workflow
* [V2ListInstances](docs/sdks/orchestration/README.md#v2listinstances) - List instances of a workflow
* [V2GetInstance](docs/sdks/orchestration/README.md#v2getinstance) - Get a workflow instance by id
* [V2SendEvent](docs/sdks/orchestration/README.md#v2sendevent) - Send an event to a running workflow
* [V2CancelEvent](docs/sdks/orchestration/README.md#v2cancelevent) - Cancel a running workflow
* [V2GetInstanceHistory](docs/sdks/orchestration/README.md#v2getinstancehistory) - Get a workflow instance history by id
* [V2GetInstanceStageHistory](docs/sdks/orchestration/README.md#v2getinstancestagehistory) - Get a workflow instance stage history

### [Payments](docs/sdks/payments/README.md)

* [PaymentsgetServerInfo](docs/sdks/payments/README.md#paymentsgetserverinfo) - Get server info
* [CreatePayment](docs/sdks/payments/README.md#createpayment) - Create a payment
* [ListPayments](docs/sdks/payments/README.md#listpayments) - List payments
* [GetPayment](docs/sdks/payments/README.md#getpayment) - Get a payment
* [UpdateMetadata](docs/sdks/payments/README.md#updatemetadata) - Update metadata
* [ListTransferInitiations](docs/sdks/payments/README.md#listtransferinitiations) - List Transfer Initiations
* [CreateTransferInitiation](docs/sdks/payments/README.md#createtransferinitiation) - Create a TransferInitiation
* [GetTransferInitiation](docs/sdks/payments/README.md#gettransferinitiation) - Get a transfer initiation
* [DeleteTransferInitiation](docs/sdks/payments/README.md#deletetransferinitiation) - Delete a transfer initiation
* [UdpateTransferInitiationStatus](docs/sdks/payments/README.md#udpatetransferinitiationstatus) - Update the status of a transfer initiation
* [ReverseTransferInitiation](docs/sdks/payments/README.md#reversetransferinitiation) - Reverse a transfer initiation
* [RetryTransferInitiation](docs/sdks/payments/README.md#retrytransferinitiation) - Retry a failed transfer initiation
* [ListPools](docs/sdks/payments/README.md#listpools) - List Pools
* [CreatePool](docs/sdks/payments/README.md#createpool) - Create a Pool
* [GetPool](docs/sdks/payments/README.md#getpool) - Get a Pool
* [DeletePool](docs/sdks/payments/README.md#deletepool) - Delete a Pool
* [AddAccountToPool](docs/sdks/payments/README.md#addaccounttopool) - Add an account to a pool
* [RemoveAccountFromPool](docs/sdks/payments/README.md#removeaccountfrompool) - Remove an account from a pool
* [GetPoolBalances](docs/sdks/payments/README.md#getpoolbalances) - Get pool balances
* [CreateAccount](docs/sdks/payments/README.md#createaccount) - Create an account
* [PaymentslistAccounts](docs/sdks/payments/README.md#paymentslistaccounts) - List accounts
* [PaymentsgetAccount](docs/sdks/payments/README.md#paymentsgetaccount) - Get an account
* [GetAccountBalances](docs/sdks/payments/README.md#getaccountbalances) - Get account balances
* [CreateBankAccount](docs/sdks/payments/README.md#createbankaccount) - Create a BankAccount in Payments and on the PSP
* [ListBankAccounts](docs/sdks/payments/README.md#listbankaccounts) - List bank accounts created by user on Formance
* [GetBankAccount](docs/sdks/payments/README.md#getbankaccount) - Get a bank account created by user on Formance
* [ForwardBankAccount](docs/sdks/payments/README.md#forwardbankaccount) - Forward a bank account to a connector
* [UpdateBankAccountMetadata](docs/sdks/payments/README.md#updatebankaccountmetadata) - Update metadata of a bank account
* [ListAllConnectors](docs/sdks/payments/README.md#listallconnectors) - List all installed connectors
* [ListConfigsAvailableConnectors](docs/sdks/payments/README.md#listconfigsavailableconnectors) - List the configs of each available connector
* [InstallConnector](docs/sdks/payments/README.md#installconnector) - Install a connector
* [~~UninstallConnector~~](docs/sdks/payments/README.md#uninstallconnector) - Uninstall a connector :warning: **Deprecated**
* [UninstallConnectorV1](docs/sdks/payments/README.md#uninstallconnectorv1) - Uninstall a connector
* [~~ReadConnectorConfig~~](docs/sdks/payments/README.md#readconnectorconfig) - Read the config of a connector :warning: **Deprecated**
* [UpdateConnectorConfigV1](docs/sdks/payments/README.md#updateconnectorconfigv1) - Update the config of a connector
* [ReadConnectorConfigV1](docs/sdks/payments/README.md#readconnectorconfigv1) - Read the config of a connector
* [~~ResetConnector~~](docs/sdks/payments/README.md#resetconnector) - Reset a connector :warning: **Deprecated**
* [ResetConnectorV1](docs/sdks/payments/README.md#resetconnectorv1) - Reset a connector
* [~~ListConnectorTasks~~](docs/sdks/payments/README.md#listconnectortasks) - List tasks from a connector :warning: **Deprecated**
* [ListConnectorTasksV1](docs/sdks/payments/README.md#listconnectortasksv1) - List tasks from a connector
* [~~GetConnectorTask~~](docs/sdks/payments/README.md#getconnectortask) - Read a specific task of the connector :warning: **Deprecated**
* [GetConnectorTaskV1](docs/sdks/payments/README.md#getconnectortaskv1) - Read a specific task of the connector
* [ConnectorsTransfer](docs/sdks/payments/README.md#connectorstransfer) - Transfer funds between Connector accounts

### [Reconciliation](docs/sdks/reconciliation/README.md)

* [ReconciliationgetServerInfo](docs/sdks/reconciliation/README.md#reconciliationgetserverinfo) - Get server info
* [CreatePolicy](docs/sdks/reconciliation/README.md#createpolicy) - Create a policy
* [ListPolicies](docs/sdks/reconciliation/README.md#listpolicies) - List policies
* [DeletePolicy](docs/sdks/reconciliation/README.md#deletepolicy) - Delete a policy
* [GetPolicy](docs/sdks/reconciliation/README.md#getpolicy) - Get a policy
* [Reconcile](docs/sdks/reconciliation/README.md#reconcile) - Reconcile using a policy
* [ListReconciliations](docs/sdks/reconciliation/README.md#listreconciliations) - List reconciliations
* [GetReconciliation](docs/sdks/reconciliation/README.md#getreconciliation) - Get a reconciliation

### [Search](docs/sdks/search/README.md)

* [SearchgetServerInfo](docs/sdks/search/README.md#searchgetserverinfo) - Get server info
* [Search](docs/sdks/search/README.md#search) - Search

### [Wallets](docs/sdks/wallets/README.md)


#### [Wallets.V1](docs/sdks/formancev1/README.md)

* [WalletsgetServerInfo](docs/sdks/formancev1/README.md#walletsgetserverinfo) - Get server info
* [GetTransactions](docs/sdks/formancev1/README.md#gettransactions)
* [ListWallets](docs/sdks/formancev1/README.md#listwallets) - List all wallets
* [CreateWallet](docs/sdks/formancev1/README.md#createwallet) - Create a new wallet
* [GetWallet](docs/sdks/formancev1/README.md#getwallet) - Get a wallet
* [UpdateWallet](docs/sdks/formancev1/README.md#updatewallet) - Update a wallet
* [GetWalletSummary](docs/sdks/formancev1/README.md#getwalletsummary) - Get wallet summary
* [ListBalances](docs/sdks/formancev1/README.md#listbalances) - List balances of a wallet
* [CreateBalance](docs/sdks/formancev1/README.md#createbalance) - Create a balance
* [GetBalance](docs/sdks/formancev1/README.md#getbalance) - Get detailed balance
* [DebitWallet](docs/sdks/formancev1/README.md#debitwallet) - Debit a wallet
* [CreditWallet](docs/sdks/formancev1/README.md#creditwallet) - Credit a wallet
* [GetHolds](docs/sdks/formancev1/README.md#getholds) - Get all holds for a wallet
* [GetHold](docs/sdks/formancev1/README.md#gethold) - Get a hold
* [ConfirmHold](docs/sdks/formancev1/README.md#confirmhold) - Confirm a hold
* [VoidHold](docs/sdks/formancev1/README.md#voidhold) - Cancel a hold

### [Webhooks](docs/sdks/webhooks/README.md)

* [GetManyConfigs](docs/sdks/webhooks/README.md#getmanyconfigs) - Get many configs
* [InsertConfig](docs/sdks/webhooks/README.md#insertconfig) - Insert a new config
* [DeleteConfig](docs/sdks/webhooks/README.md#deleteconfig) - Delete one config
* [TestConfig](docs/sdks/webhooks/README.md#testconfig) - Test one config
* [ActivateConfig](docs/sdks/webhooks/README.md#activateconfig) - Activate one config
* [DeactivateConfig](docs/sdks/webhooks/README.md#deactivateconfig) - Deactivate one config
* [ChangeConfigSecret](docs/sdks/webhooks/README.md#changeconfigsecret) - Change the signing secret of a config

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `formance.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `Request`     | *HttpRequestMessage*  | The HTTP request      |
| `Response`    | *HttpResponseMessage* | The HTTP response     |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `GetInfoAsync` method throws the following exceptions:

| Error Type                           | Status Code | Content Type     |
| ------------------------------------ | ----------- | ---------------- |
| formance.Models.Errors.ErrorResponse | default     | application/json |
| formance.Models.Errors.SDKException  | 4XX, 5XX    | \*/\*            |

### Example

```csharp
using formance;
using formance.Models.Components;
using formance.Models.Errors;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

try
{
    var res = await sdk.Ledger.V1.GetInfoAsync();

    // handle response
}
catch (Exception ex)
{
    if (ex is Models.Errors.ErrorResponse)
    {
        // Handle exception data
        throw;
    }
    else if (ex is formance.Models.Errors.SDKException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: int` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                                                | Variables                                                   | Default values                    |
| --- | ----------------------------------------------------- | ----------------------------------------------------------- | --------------------------------- |
| 0   | `http://localhost`                                    |                                                             |                                   |
| 1   | `https://{organization}.{environment}.formance.cloud` | `organization: string`<br/>`environment: ServerEnvironment` | `"orgID-stackID"`<br/>`"sandbox"` |

If the selected server has variables, you may override their default values through the additional parameters made available in the SDK constructor.

#### Example

```csharp
using formance;
using formance.Models.Components;

var sdk = new Formance(
    serverIndex: 1,
    security: new Security() {
        ClientID = "<YOUR_CLIENT_ID_HERE>",
        ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
    }
);

var res = await sdk.GetOIDCWellKnownsAsync();

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using formance;
using formance.Models.Components;

var sdk = new Formance(
    serverUrl: "http://localhost",
    security: new Security() {
        ClientID = "<YOUR_CLIENT_ID_HERE>",
        ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
    }
);

var res = await sdk.GetOIDCWellKnownsAsync();

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name                          | Type   | Scheme                         |
| ----------------------------- | ------ | ------------------------------ |
| `ClientID`<br/>`ClientSecret` | oauth2 | OAuth2 Client Credentials Flow |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using formance;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.GetOIDCWellKnownsAsync();

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 
We look forward to hearing your feedback. Feel free to open a PR or an issue with a proof of concept and we'll do our best to include it in a future release. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=formance&utm_campaign=csharp)
