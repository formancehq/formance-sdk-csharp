# V2LogDataSetMetadata

Payload for SET_METADATA log entries. Contains the target entity and the metadata that was set.


## Fields

| Field                                           | Type                                            | Required                                        | Description                                     | Example                                         |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `TargetType`                                    | [TargetType](../../Models/Ledger/TargetType.md) | :heavy_check_mark:                              | Type of the target entity                       |                                                 |
| `TargetId`                                      | [TargetId](../../Models/Ledger/TargetId.md)     | :heavy_check_mark:                              | N/A                                             |                                                 |
| `V2Metadata`                                    | Dictionary<String, *string*>                    | :heavy_check_mark:                              | N/A                                             | {<br/>"admin": "true"<br/>}                     |