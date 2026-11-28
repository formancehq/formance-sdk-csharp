# DeletedMetadataActionRead


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `RewriteAddress`                                                              | [RewriteAddressActionRead](../../Models/LedgerV3/RewriteAddressActionRead.md) | :heavy_minus_sign:                                                            | N/A                                                                           |
| `Drop`                                                                        | [DropAction](../../Models/LedgerV3/DropAction.md)                             | :heavy_minus_sign:                                                            | Turns the entry into a fill-gap that preserves log-ID and tx-ID continuity.   |