# StageSendSource

Where a send stage takes the funds from


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Wallet`                                                                       | [StageSendSourceWallet](../../Models/Orchestration/StageSendSourceWallet.md)   | :heavy_minus_sign:                                                             | Take the funds from a wallet                                                   |
| `Account`                                                                      | [StageSendSourceAccount](../../Models/Orchestration/StageSendSourceAccount.md) | :heavy_minus_sign:                                                             | Take the funds from a ledger account                                           |
| `Payment`                                                                      | [StageSendSourcePayment](../../Models/Orchestration/StageSendSourcePayment.md) | :heavy_minus_sign:                                                             | Take the funds from a payment                                                  |