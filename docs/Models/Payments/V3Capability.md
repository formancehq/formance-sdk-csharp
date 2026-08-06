# V3Capability

Plugin capability advertised by a connector. Distinct from the Formance gateway "module capabilities" (which are version-gated); these reflect what the underlying PSP integration actually exposes.


## Example Usage

```csharp
using FormanceSDK.Models.Payments;

var value = V3Capability.FetchAccounts;
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `FetchAccounts`                 | FETCH_ACCOUNTS                  |
| `FetchBalances`                 | FETCH_BALANCES                  |
| `FetchExternalAccounts`         | FETCH_EXTERNAL_ACCOUNTS         |
| `FetchPayments`                 | FETCH_PAYMENTS                  |
| `FetchOthers`                   | FETCH_OTHERS                    |
| `FetchOrders`                   | FETCH_ORDERS                    |
| `FetchConversions`              | FETCH_CONVERSIONS               |
| `CreateWebhooks`                | CREATE_WEBHOOKS                 |
| `TranslateWebhooks`             | TRANSLATE_WEBHOOKS              |
| `CreateBankAccount`             | CREATE_BANK_ACCOUNT             |
| `CreateTransfer`                | CREATE_TRANSFER                 |
| `CreatePayout`                  | CREATE_PAYOUT                   |
| `AllowFormanceAccountCreation`  | ALLOW_FORMANCE_ACCOUNT_CREATION |
| `AllowFormancePaymentCreation`  | ALLOW_FORMANCE_PAYMENT_CREATION |