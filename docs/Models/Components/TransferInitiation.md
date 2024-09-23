# TransferInitiation


## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `Id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           | XXX                                                                                           |
| `Reference`                                                                                   | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `CreatedAt`                                                                                   | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)         | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `ScheduledAt`                                                                                 | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)         | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `Description`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `SourceAccountID`                                                                             | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `DestinationAccountID`                                                                        | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `ConnectorID`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `Type`                                                                                        | [TransferInitiationType](../../Models/Components/TransferInitiationType.md)                   | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `Amount`                                                                                      | *BigInteger*                                                                                  | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `InitialAmount`                                                                               | *BigInteger*                                                                                  | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `Asset`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           | USD                                                                                           |
| `Status`                                                                                      | [TransferInitiationStatus](../../Models/Components/TransferInitiationStatus.md)               | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `Error`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `Metadata`                                                                                    | Dictionary<String, *string*>                                                                  | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `RelatedPayments`                                                                             | List<[TransferInitiationPayments](../../Models/Components/TransferInitiationPayments.md)>     | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `RelatedAdjustments`                                                                          | List<[TransferInitiationAdjusments](../../Models/Components/TransferInitiationAdjusments.md)> | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |