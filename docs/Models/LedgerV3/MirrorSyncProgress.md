# MirrorSyncProgress

Sync progress for MIRROR ledgers (populated at read time)


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `State`                                                            | [Models.LedgerV3.State](../../Models/LedgerV3/State.md)            | :heavy_check_mark:                                                 | Current sync state (SYNCING = catching up, FOLLOWING = up to date) |
| `Cursor`                                                           | *long*                                                             | :heavy_check_mark:                                                 | Last ingested v2 log ID                                            |
| `SourceLogCount`                                                   | *long*                                                             | :heavy_check_mark:                                                 | Latest known log ID in the v2 source                               |
| `RemainingLogs`                                                    | *long*                                                             | :heavy_check_mark:                                                 | Number of remaining logs to sync (sourceLogCount - cursor)         |
| `Error`                                                            | [MirrorSyncError](../../Models/LedgerV3/MirrorSyncError.md)        | :heavy_minus_sign:                                                 | Most recent mirror sync error (null if healthy)                    |