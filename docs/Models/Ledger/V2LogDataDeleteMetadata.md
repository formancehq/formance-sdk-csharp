# V2LogDataDeleteMetadata

Payload for DELETE_METADATA log entries. Contains the target entity and the metadata key that was deleted.


## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `TargetType`                                                                                  | [V2LogDataDeleteMetadataTargetType](../../Models/Ledger/V2LogDataDeleteMetadataTargetType.md) | :heavy_check_mark:                                                                            | Type of the target entity                                                                     |
| `TargetId`                                                                                    | [V2LogDataDeleteMetadataTargetId](../../Models/Ledger/V2LogDataDeleteMetadataTargetId.md)     | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `Key`                                                                                         | *string*                                                                                      | :heavy_check_mark:                                                                            | The metadata key that was deleted                                                             |