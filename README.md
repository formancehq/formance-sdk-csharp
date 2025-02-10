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
dotnet add package FormanceSDK
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/FormanceSDK/FormanceSDK.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.GetVersionsAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Auth](docs/sdks/auth/README.md)


#### [Auth.V1](docs/sdks/v1/README.md)

* [GetOIDCWellKnowns](docs/sdks/v1/README.md#getoidcwellknowns) - Retrieve OpenID connect well-knowns.
* [GetServerInfo](docs/sdks/v1/README.md#getserverinfo) - Get server info
* [ListClients](docs/sdks/v1/README.md#listclients) - List clients
* [CreateClient](docs/sdks/v1/README.md#createclient) - Create client
* [ReadClient](docs/sdks/v1/README.md#readclient) - Read client
* [UpdateClient](docs/sdks/v1/README.md#updateclient) - Update client
* [DeleteClient](docs/sdks/v1/README.md#deleteclient) - Delete client
* [CreateSecret](docs/sdks/v1/README.md#createsecret) - Add a secret to a client
* [DeleteSecret](docs/sdks/v1/README.md#deletesecret) - Delete a secret from a client
* [ListUsers](docs/sdks/v1/README.md#listusers) - List users
* [ReadUser](docs/sdks/v1/README.md#readuser) - Read user

### [Formance SDK](docs/sdks/formance/README.md)

* [GetVersions](docs/sdks/formance/README.md#getversions) - Show stack version information

### [Ledger](docs/sdks/ledger/README.md)


#### [Ledger.V1](docs/sdks/formancev1/README.md)

* [GetInfo](docs/sdks/formancev1/README.md#getinfo) - Show server information
* [GetLedgerInfo](docs/sdks/formancev1/README.md#getledgerinfo) - Get information about a ledger
* [CountAccounts](docs/sdks/formancev1/README.md#countaccounts) - Count the accounts from a ledger
* [ListAccounts](docs/sdks/formancev1/README.md#listaccounts) - List accounts from a ledger
* [GetAccount](docs/sdks/formancev1/README.md#getaccount) - Get account by its address
* [AddMetadataToAccount](docs/sdks/formancev1/README.md#addmetadatatoaccount) - Add metadata to an account
* [GetMapping](docs/sdks/formancev1/README.md#getmapping) - Get the mapping of a ledger
* [UpdateMapping](docs/sdks/formancev1/README.md#updatemapping) - Update the mapping of a ledger
* [~~RunScript~~](docs/sdks/formancev1/README.md#runscript) - Execute a Numscript :warning: **Deprecated**
* [ReadStats](docs/sdks/formancev1/README.md#readstats) - Get statistics from a ledger
* [CountTransactions](docs/sdks/formancev1/README.md#counttransactions) - Count the transactions from a ledger
* [ListTransactions](docs/sdks/formancev1/README.md#listtransactions) - List transactions from a ledger
* [CreateTransaction](docs/sdks/formancev1/README.md#createtransaction) - Create a new transaction to a ledger
* [GetTransaction](docs/sdks/formancev1/README.md#gettransaction) - Get transaction from a ledger by its ID
* [AddMetadataOnTransaction](docs/sdks/formancev1/README.md#addmetadataontransaction) - Set the metadata of a transaction by its ID
* [RevertTransaction](docs/sdks/formancev1/README.md#reverttransaction) - Revert a ledger transaction by its ID
* [CreateTransactions](docs/sdks/formancev1/README.md#createtransactions) - Create a new batch of transactions to a ledger
* [GetBalances](docs/sdks/formancev1/README.md#getbalances) - Get the balances from a ledger's account
* [GetBalancesAggregated](docs/sdks/formancev1/README.md#getbalancesaggregated) - Get the aggregated balances from selected accounts
* [ListLogs](docs/sdks/formancev1/README.md#listlogs) - List the logs from a ledger

#### [Ledger.V2](docs/sdks/v2/README.md)

* [GetInfo](docs/sdks/v2/README.md#getinfo) - Show server information
* [GetMetrics](docs/sdks/v2/README.md#getmetrics) - Read in memory metrics
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


#### [Orchestration.V1](docs/sdks/formanceorchestrationv1/README.md)

* [OrchestrationgetServerInfo](docs/sdks/formanceorchestrationv1/README.md#orchestrationgetserverinfo) - Get server info
* [ListTriggers](docs/sdks/formanceorchestrationv1/README.md#listtriggers) - List triggers
* [CreateTrigger](docs/sdks/formanceorchestrationv1/README.md#createtrigger) - Create trigger
* [ReadTrigger](docs/sdks/formanceorchestrationv1/README.md#readtrigger) - Read trigger
* [DeleteTrigger](docs/sdks/formanceorchestrationv1/README.md#deletetrigger) - Delete trigger
* [ListTriggersOccurrences](docs/sdks/formanceorchestrationv1/README.md#listtriggersoccurrences) - List triggers occurrences
* [ListWorkflows](docs/sdks/formanceorchestrationv1/README.md#listworkflows) - List registered workflows
* [CreateWorkflow](docs/sdks/formanceorchestrationv1/README.md#createworkflow) - Create workflow
* [GetWorkflow](docs/sdks/formanceorchestrationv1/README.md#getworkflow) - Get a flow by id
* [DeleteWorkflow](docs/sdks/formanceorchestrationv1/README.md#deleteworkflow) - Delete a flow by id
* [RunWorkflow](docs/sdks/formanceorchestrationv1/README.md#runworkflow) - Run workflow
* [ListInstances](docs/sdks/formanceorchestrationv1/README.md#listinstances) - List instances of a workflow
* [GetInstance](docs/sdks/formanceorchestrationv1/README.md#getinstance) - Get a workflow instance by id
* [SendEvent](docs/sdks/formanceorchestrationv1/README.md#sendevent) - Send an event to a running workflow
* [CancelEvent](docs/sdks/formanceorchestrationv1/README.md#cancelevent) - Cancel a running workflow
* [GetInstanceHistory](docs/sdks/formanceorchestrationv1/README.md#getinstancehistory) - Get a workflow instance history by id
* [GetInstanceStageHistory](docs/sdks/formanceorchestrationv1/README.md#getinstancestagehistory) - Get a workflow instance stage history

#### [Orchestration.V2](docs/sdks/formancev2/README.md)

* [GetServerInfo](docs/sdks/formancev2/README.md#getserverinfo) - Get server info
* [ListTriggers](docs/sdks/formancev2/README.md#listtriggers) - List triggers
* [CreateTrigger](docs/sdks/formancev2/README.md#createtrigger) - Create trigger
* [ReadTrigger](docs/sdks/formancev2/README.md#readtrigger) - Read trigger
* [DeleteTrigger](docs/sdks/formancev2/README.md#deletetrigger) - Delete trigger
* [TestTrigger](docs/sdks/formancev2/README.md#testtrigger) - Test trigger
* [ListTriggersOccurrences](docs/sdks/formancev2/README.md#listtriggersoccurrences) - List triggers occurrences
* [ListWorkflows](docs/sdks/formancev2/README.md#listworkflows) - List registered workflows
* [CreateWorkflow](docs/sdks/formancev2/README.md#createworkflow) - Create workflow
* [GetWorkflow](docs/sdks/formancev2/README.md#getworkflow) - Get a flow by id
* [DeleteWorkflow](docs/sdks/formancev2/README.md#deleteworkflow) - Delete a flow by id
* [RunWorkflow](docs/sdks/formancev2/README.md#runworkflow) - Run workflow
* [ListInstances](docs/sdks/formancev2/README.md#listinstances) - List instances of a workflow
* [GetInstance](docs/sdks/formancev2/README.md#getinstance) - Get a workflow instance by id
* [SendEvent](docs/sdks/formancev2/README.md#sendevent) - Send an event to a running workflow
* [CancelEvent](docs/sdks/formancev2/README.md#cancelevent) - Cancel a running workflow
* [GetInstanceHistory](docs/sdks/formancev2/README.md#getinstancehistory) - Get a workflow instance history by id
* [GetInstanceStageHistory](docs/sdks/formancev2/README.md#getinstancestagehistory) - Get a workflow instance stage history

### [Payments](docs/sdks/payments/README.md)


#### [Payments.V1](docs/sdks/formancepaymentsv1/README.md)

* [PaymentsgetServerInfo](docs/sdks/formancepaymentsv1/README.md#paymentsgetserverinfo) - Get server info
* [CreatePayment](docs/sdks/formancepaymentsv1/README.md#createpayment) - Create a payment
* [ListPayments](docs/sdks/formancepaymentsv1/README.md#listpayments) - List payments
* [GetPayment](docs/sdks/formancepaymentsv1/README.md#getpayment) - Get a payment
* [UpdateMetadata](docs/sdks/formancepaymentsv1/README.md#updatemetadata) - Update metadata
* [ListTransferInitiations](docs/sdks/formancepaymentsv1/README.md#listtransferinitiations) - List Transfer Initiations
* [CreateTransferInitiation](docs/sdks/formancepaymentsv1/README.md#createtransferinitiation) - Create a TransferInitiation
* [GetTransferInitiation](docs/sdks/formancepaymentsv1/README.md#gettransferinitiation) - Get a transfer initiation
* [DeleteTransferInitiation](docs/sdks/formancepaymentsv1/README.md#deletetransferinitiation) - Delete a transfer initiation
* [UdpateTransferInitiationStatus](docs/sdks/formancepaymentsv1/README.md#udpatetransferinitiationstatus) - Update the status of a transfer initiation
* [ReverseTransferInitiation](docs/sdks/formancepaymentsv1/README.md#reversetransferinitiation) - Reverse a transfer initiation
* [RetryTransferInitiation](docs/sdks/formancepaymentsv1/README.md#retrytransferinitiation) - Retry a failed transfer initiation
* [ListPools](docs/sdks/formancepaymentsv1/README.md#listpools) - List Pools
* [CreatePool](docs/sdks/formancepaymentsv1/README.md#createpool) - Create a Pool
* [GetPool](docs/sdks/formancepaymentsv1/README.md#getpool) - Get a Pool
* [DeletePool](docs/sdks/formancepaymentsv1/README.md#deletepool) - Delete a Pool
* [AddAccountToPool](docs/sdks/formancepaymentsv1/README.md#addaccounttopool) - Add an account to a pool
* [RemoveAccountFromPool](docs/sdks/formancepaymentsv1/README.md#removeaccountfrompool) - Remove an account from a pool
* [GetPoolBalances](docs/sdks/formancepaymentsv1/README.md#getpoolbalances) - Get pool balances
* [CreateAccount](docs/sdks/formancepaymentsv1/README.md#createaccount) - Create an account
* [PaymentslistAccounts](docs/sdks/formancepaymentsv1/README.md#paymentslistaccounts) - List accounts
* [PaymentsgetAccount](docs/sdks/formancepaymentsv1/README.md#paymentsgetaccount) - Get an account
* [GetAccountBalances](docs/sdks/formancepaymentsv1/README.md#getaccountbalances) - Get account balances
* [CreateBankAccount](docs/sdks/formancepaymentsv1/README.md#createbankaccount) - Create a BankAccount in Payments and on the PSP
* [ListBankAccounts](docs/sdks/formancepaymentsv1/README.md#listbankaccounts) - List bank accounts created by user on Formance
* [GetBankAccount](docs/sdks/formancepaymentsv1/README.md#getbankaccount) - Get a bank account created by user on Formance
* [ForwardBankAccount](docs/sdks/formancepaymentsv1/README.md#forwardbankaccount) - Forward a bank account to a connector
* [UpdateBankAccountMetadata](docs/sdks/formancepaymentsv1/README.md#updatebankaccountmetadata) - Update metadata of a bank account
* [ListAllConnectors](docs/sdks/formancepaymentsv1/README.md#listallconnectors) - List all installed connectors
* [ListConfigsAvailableConnectors](docs/sdks/formancepaymentsv1/README.md#listconfigsavailableconnectors) - List the configs of each available connector
* [InstallConnector](docs/sdks/formancepaymentsv1/README.md#installconnector) - Install a connector
* [~~UninstallConnector~~](docs/sdks/formancepaymentsv1/README.md#uninstallconnector) - Uninstall a connector :warning: **Deprecated**
* [UninstallConnectorV1](docs/sdks/formancepaymentsv1/README.md#uninstallconnectorv1) - Uninstall a connector
* [~~ReadConnectorConfig~~](docs/sdks/formancepaymentsv1/README.md#readconnectorconfig) - Read the config of a connector :warning: **Deprecated**
* [UpdateConnectorConfigV1](docs/sdks/formancepaymentsv1/README.md#updateconnectorconfigv1) - Update the config of a connector
* [ReadConnectorConfigV1](docs/sdks/formancepaymentsv1/README.md#readconnectorconfigv1) - Read the config of a connector
* [~~ResetConnector~~](docs/sdks/formancepaymentsv1/README.md#resetconnector) - Reset a connector :warning: **Deprecated**
* [ResetConnectorV1](docs/sdks/formancepaymentsv1/README.md#resetconnectorv1) - Reset a connector
* [~~ListConnectorTasks~~](docs/sdks/formancepaymentsv1/README.md#listconnectortasks) - List tasks from a connector :warning: **Deprecated**
* [ListConnectorTasksV1](docs/sdks/formancepaymentsv1/README.md#listconnectortasksv1) - List tasks from a connector
* [~~GetConnectorTask~~](docs/sdks/formancepaymentsv1/README.md#getconnectortask) - Read a specific task of the connector :warning: **Deprecated**
* [GetConnectorTaskV1](docs/sdks/formancepaymentsv1/README.md#getconnectortaskv1) - Read a specific task of the connector
* [ConnectorsTransfer](docs/sdks/formancepaymentsv1/README.md#connectorstransfer) - Transfer funds between Connector accounts

#### [Payments.V3](docs/sdks/v3/README.md)

* [GetInfo](docs/sdks/v3/README.md#getinfo) - Show server information
* [CreateAccount](docs/sdks/v3/README.md#createaccount) - Create a formance account object. This object will not be forwarded to the connector. It is only used for internal purposes.

* [ListAccounts](docs/sdks/v3/README.md#listaccounts) - List all accounts
* [GetAccount](docs/sdks/v3/README.md#getaccount) - Get an account by ID
* [GetAccountBalances](docs/sdks/v3/README.md#getaccountbalances) - Get account balances
* [CreateBankAccount](docs/sdks/v3/README.md#createbankaccount) - Create a formance bank account object. This object will not be forwarded to the connector until you called the forwardBankAccount method.

* [ListBankAccounts](docs/sdks/v3/README.md#listbankaccounts) - List all bank accounts
* [GetBankAccount](docs/sdks/v3/README.md#getbankaccount) - Get a Bank Account by ID
* [UpdateBankAccountMetadata](docs/sdks/v3/README.md#updatebankaccountmetadata) - Update a bank account's metadata
* [ForwardBankAccount](docs/sdks/v3/README.md#forwardbankaccount) - Forward a Bank Account to a PSP for creation
* [ListConnectors](docs/sdks/v3/README.md#listconnectors) - List all connectors
* [InstallConnector](docs/sdks/v3/README.md#installconnector) - Install a connector
* [ListConnectorConfigs](docs/sdks/v3/README.md#listconnectorconfigs) - List all connector configurations
* [UninstallConnector](docs/sdks/v3/README.md#uninstallconnector) - Uninstall a connector
* [GetConnectorConfig](docs/sdks/v3/README.md#getconnectorconfig) - Get a connector configuration by ID
* [ResetConnector](docs/sdks/v3/README.md#resetconnector) - Reset a connector. Be aware that this will delete all data and stop all existing tasks like payment initiations and bank account creations.
* [ListConnectorSchedules](docs/sdks/v3/README.md#listconnectorschedules) - List all connector schedules
* [GetConnectorSchedule](docs/sdks/v3/README.md#getconnectorschedule) - Get a connector schedule by ID
* [ListConnectorScheduleInstances](docs/sdks/v3/README.md#listconnectorscheduleinstances) - List all connector schedule instances
* [CreatePayment](docs/sdks/v3/README.md#createpayment) - Create a formance payment object. This object will not be forwarded to the connector. It is only used for internal purposes.

* [ListPayments](docs/sdks/v3/README.md#listpayments) - List all payments
* [GetPayment](docs/sdks/v3/README.md#getpayment) - Get a payment by ID
* [UpdatePaymentMetadata](docs/sdks/v3/README.md#updatepaymentmetadata) - Update a payment's metadata
* [InitiatePayment](docs/sdks/v3/README.md#initiatepayment) - Initiate a payment
* [ListPaymentInitiations](docs/sdks/v3/README.md#listpaymentinitiations) - List all payment initiations
* [DeletePaymentInitiation](docs/sdks/v3/README.md#deletepaymentinitiation) - Delete a payment initiation by ID
* [GetPaymentInitiation](docs/sdks/v3/README.md#getpaymentinitiation) - Get a payment initiation by ID
* [RetryPaymentInitiation](docs/sdks/v3/README.md#retrypaymentinitiation) - Retry a payment initiation
* [ApprovePaymentInitiation](docs/sdks/v3/README.md#approvepaymentinitiation) - Approve a payment initiation
* [RejectPaymentInitiation](docs/sdks/v3/README.md#rejectpaymentinitiation) - Reject a payment initiation
* [ReversePaymentInitiation](docs/sdks/v3/README.md#reversepaymentinitiation) - Reverse a payment initiation
* [ListPaymentInitiationAdjustments](docs/sdks/v3/README.md#listpaymentinitiationadjustments) - List all payment initiation adjustments
* [ListPaymentInitiationRelatedPayments](docs/sdks/v3/README.md#listpaymentinitiationrelatedpayments) - List all payments related to a payment initiation
* [CreatePool](docs/sdks/v3/README.md#createpool) - Create a formance pool object
* [ListPools](docs/sdks/v3/README.md#listpools) - List all pools
* [GetPool](docs/sdks/v3/README.md#getpool) - Get a pool by ID
* [DeletePool](docs/sdks/v3/README.md#deletepool) - Delete a pool by ID
* [GetPoolBalances](docs/sdks/v3/README.md#getpoolbalances) - Get pool balances
* [AddAccountToPool](docs/sdks/v3/README.md#addaccounttopool) - Add an account to a pool
* [RemoveAccountFromPool](docs/sdks/v3/README.md#removeaccountfrompool) - Remove an account from a pool
* [GetTask](docs/sdks/v3/README.md#gettask) - Get a task and its result by ID

### [Reconciliation](docs/sdks/reconciliation/README.md)


#### [Reconciliation.V1](docs/sdks/formancereconciliationv1/README.md)

* [ReconciliationgetServerInfo](docs/sdks/formancereconciliationv1/README.md#reconciliationgetserverinfo) - Get server info
* [CreatePolicy](docs/sdks/formancereconciliationv1/README.md#createpolicy) - Create a policy
* [ListPolicies](docs/sdks/formancereconciliationv1/README.md#listpolicies) - List policies
* [DeletePolicy](docs/sdks/formancereconciliationv1/README.md#deletepolicy) - Delete a policy
* [GetPolicy](docs/sdks/formancereconciliationv1/README.md#getpolicy) - Get a policy
* [Reconcile](docs/sdks/formancereconciliationv1/README.md#reconcile) - Reconcile using a policy
* [ListReconciliations](docs/sdks/formancereconciliationv1/README.md#listreconciliations) - List reconciliations
* [GetReconciliation](docs/sdks/formancereconciliationv1/README.md#getreconciliation) - Get a reconciliation

### [~~Search~~](docs/sdks/search/README.md)


#### [~~Search.V1~~](docs/sdks/formancesearchv1/README.md)

* [~~SearchgetServerInfo~~](docs/sdks/formancesearchv1/README.md#searchgetserverinfo) - Get server info :warning: **Deprecated**
* [~~Search~~](docs/sdks/formancesearchv1/README.md#search) - search.v1 :warning: **Deprecated**

### [Wallets](docs/sdks/wallets/README.md)


#### [Wallets.V1](docs/sdks/formancewalletsv1/README.md)

* [WalletsgetServerInfo](docs/sdks/formancewalletsv1/README.md#walletsgetserverinfo) - Get server info
* [GetTransactions](docs/sdks/formancewalletsv1/README.md#gettransactions)
* [ListWallets](docs/sdks/formancewalletsv1/README.md#listwallets) - List all wallets
* [CreateWallet](docs/sdks/formancewalletsv1/README.md#createwallet) - Create a new wallet
* [GetWallet](docs/sdks/formancewalletsv1/README.md#getwallet) - Get a wallet
* [UpdateWallet](docs/sdks/formancewalletsv1/README.md#updatewallet) - Update a wallet
* [GetWalletSummary](docs/sdks/formancewalletsv1/README.md#getwalletsummary) - Get wallet summary
* [ListBalances](docs/sdks/formancewalletsv1/README.md#listbalances) - List balances of a wallet
* [CreateBalance](docs/sdks/formancewalletsv1/README.md#createbalance) - Create a balance
* [GetBalance](docs/sdks/formancewalletsv1/README.md#getbalance) - Get detailed balance
* [DebitWallet](docs/sdks/formancewalletsv1/README.md#debitwallet) - Debit a wallet
* [CreditWallet](docs/sdks/formancewalletsv1/README.md#creditwallet) - Credit a wallet
* [GetHolds](docs/sdks/formancewalletsv1/README.md#getholds) - Get all holds for a wallet
* [GetHold](docs/sdks/formancewalletsv1/README.md#gethold) - Get a hold
* [ConfirmHold](docs/sdks/formancewalletsv1/README.md#confirmhold) - Confirm a hold
* [VoidHold](docs/sdks/formancewalletsv1/README.md#voidhold) - Cancel a hold

### [Webhooks](docs/sdks/webhooks/README.md)


#### [Webhooks.V1](docs/sdks/formancewebhooksv1/README.md)

* [GetManyConfigs](docs/sdks/formancewebhooksv1/README.md#getmanyconfigs) - Get many configs
* [InsertConfig](docs/sdks/formancewebhooksv1/README.md#insertconfig) - Insert a new config
* [DeleteConfig](docs/sdks/formancewebhooksv1/README.md#deleteconfig) - Delete one config
* [UpdateConfig](docs/sdks/formancewebhooksv1/README.md#updateconfig) - Update one config
* [TestConfig](docs/sdks/formancewebhooksv1/README.md#testconfig) - Test one config
* [ActivateConfig](docs/sdks/formancewebhooksv1/README.md#activateconfig) - Activate one config
* [DeactivateConfig](docs/sdks/formancewebhooksv1/README.md#deactivateconfig) - Deactivate one config
* [ChangeConfigSecret](docs/sdks/formancewebhooksv1/README.md#changeconfigsecret) - Change the signing secret of a config

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `FormanceSDK.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `Request`     | *HttpRequestMessage*  | The HTTP request      |
| `Response`    | *HttpResponseMessage* | The HTTP response     |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `GetInfoAsync` method throws the following exceptions:

| Error Type                              | Status Code | Content Type     |
| --------------------------------------- | ----------- | ---------------- |
| FormanceSDK.Models.Errors.ErrorResponse | default     | application/json |
| FormanceSDK.Models.Errors.SDKException  | 4XX, 5XX    | \*/\*            |

### Example

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Errors;

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
    else if (ex is FormanceSDK.Models.Errors.SDKException)
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

| #   | Server                                                | Variables                                                   | Default values                       |
| --- | ----------------------------------------------------- | ----------------------------------------------------------- | ------------------------------------ |
| 0   | `http://localhost`                                    |                                                             |                                      |
| 1   | `https://{organization}.{environment}.formance.cloud` | `organization: string`<br/>`environment: ServerEnvironment` | `"orgID-stackID"`<br/>`"eu.sandbox"` |

If the selected server has variables, you may override their default values through the additional parameters made available in the SDK constructor.

#### Example

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(
    serverIndex: 1,
    security: new Security() {
        ClientID = "<YOUR_CLIENT_ID_HERE>",
        ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
    }
);

var res = await sdk.GetVersionsAsync();

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(
    serverUrl: "http://localhost",
    security: new Security() {
        ClientID = "<YOUR_CLIENT_ID_HERE>",
        ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
    }
);

var res = await sdk.GetVersionsAsync();

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
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.GetVersionsAsync();

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
