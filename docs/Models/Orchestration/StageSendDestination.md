# StageSendDestination

Where a send stage puts the funds


## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `Wallet`                                                                                 | [StageSendDestinationWallet](../../Models/Orchestration/StageSendDestinationWallet.md)   | :heavy_minus_sign:                                                                       | Send the funds to a wallet                                                               |
| `Account`                                                                                | [StageSendDestinationAccount](../../Models/Orchestration/StageSendDestinationAccount.md) | :heavy_minus_sign:                                                                       | Send the funds to a ledger account                                                       |
| `Payment`                                                                                | [StageSendDestinationPayment](../../Models/Orchestration/StageSendDestinationPayment.md) | :heavy_minus_sign:                                                                       | Send the funds to a payment                                                              |