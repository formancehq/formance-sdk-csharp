# V2StageSendSource

Where a send stage takes the funds from


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `Wallet`                                                                           | [V2StageSendSourceWallet](../../Models/Orchestration/V2StageSendSourceWallet.md)   | :heavy_minus_sign:                                                                 | Take the funds from a wallet                                                       |
| `Account`                                                                          | [V2StageSendSourceAccount](../../Models/Orchestration/V2StageSendSourceAccount.md) | :heavy_minus_sign:                                                                 | Take the funds from a ledger account                                               |
| `Payment`                                                                          | [V2StageSendSourcePayment](../../Models/Orchestration/V2StageSendSourcePayment.md) | :heavy_minus_sign:                                                                 | Take the funds from a payment                                                      |