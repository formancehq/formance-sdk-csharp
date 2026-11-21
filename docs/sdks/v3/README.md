# Ledger.V3

## Overview

### Available Operations

* [ListAllLedgers](#listallledgers) - List all ledgers
* [Health](#health) - Health check
* [Livez](#livez) - Liveness probe
* [Readyz](#readyz) - Readiness probe
* [Clusterz](#clusterz) - Cluster-availability probe
* [GetLedger](#getledger) - Get a ledger
* [CreateLedger](#createledger) - Create a new ledger
* [DeleteLedger](#deleteledger) - Delete a ledger
* [GetLedgerStats](#getledgerstats) - Get ledger statistics
* [ListLedgerLogs](#listledgerlogs) - List logs for a ledger
* [ListAuditEntries](#listauditentries) - List audit entries
* [GetAuditEntry](#getauditentry) - Get an audit entry
* [PromoteLedger](#promoteledger) - Promote a mirror ledger
* [CreateTransaction](#createtransaction) - Create a new transaction
* [ListLedgerTransactions](#listledgertransactions) - List transactions for a ledger
* [GetTransaction](#gettransaction) - Get a transaction
* [ListAccounts](#listaccounts) - List accounts
* [GetAccount](#getaccount) - Get an account
* [AggregateVolumes](#aggregatevolumes) - Aggregate volumes
* [SaveLedgerMetadata](#saveledgermetadata) - Save ledger metadata
* [DeleteLedgerMetadata](#deleteledgermetadata) - Delete ledger metadata
* [SaveAccountMetadata](#saveaccountmetadata) - Save account metadata
* [SaveTransactionMetadata](#savetransactionmetadata) - Save transaction metadata
* [DeleteAccountMetadata](#deleteaccountmetadata) - Delete account metadata
* [DeleteTransactionMetadata](#deletetransactionmetadata) - Delete transaction metadata
* [RevertTransaction](#reverttransaction) - Revert a transaction
* [GetMetadataSchemaStatus](#getmetadataschemastatus) - Get metadata schema
* [InspectIndex](#inspectindex) - Inspect a metadata index
* [AnalyzeAccounts](#analyzeaccounts) - Analyze accounts and suggest a Chart of Accounts
* [AnalyzeTransactions](#analyzetransactions) - Analyze transaction flow patterns
* [SetMetadataFieldType](#setmetadatafieldtype) - Set metadata field type
* [RemoveMetadataFieldType](#removemetadatafieldtype) - Remove metadata field type
* [AnalyzeNumscript](#analyzenumscript) - Analyze Numscript source
* [ListNumscripts](#listnumscripts) - List all numscripts
* [GetNumscript](#getnumscript) - Get a numscript
* [SaveNumscript](#savenumscript) - Save a numscript
* [ListNumscriptVersions](#listnumscriptversions) - List numscript versions
* [GetNumscriptUsage](#getnumscriptusage) - Get template usage
* [BulkOperations](#bulkoperations) - Bulk operations
* [CreatePreparedQuery](#createpreparedquery) - Create a prepared query
* [ListPreparedQueries](#listpreparedqueries) - List prepared queries
* [UpdatePreparedQuery](#updatepreparedquery) - Update a prepared query
* [DeletePreparedQuery](#deletepreparedquery) - Delete a prepared query
* [ExecutePreparedQuery](#executepreparedquery) - Execute a prepared query
* [AddAccountType](#addaccounttype) - Add an account type
* [ListAccountTypes](#listaccounttypes) - List account types
* [SetDefaultEnforcementMode](#setdefaultenforcementmode) - Set default enforcement mode
* [GetAccountType](#getaccounttype) - Get an account type
* [RemoveAccountType](#removeaccounttype) - Remove an account type
* [GetLog](#getlog) - Get a single system log by bucket-wide sequence
* [GetEventsSinks](#geteventssinks) - List configured event sinks
* [RemoveEventsSink](#removeeventssink) - Remove an event sink
* [ListSigningKeys](#listsigningkeys) - List registered Ed25519 signing keys
* [ListBucketIndexes](#listbucketindexes) - List bucket-wide indexes
* [GetBucketIndex](#getbucketindex) - Get a single bucket-scoped index registry entry
* [GetBucketIndexEntryStatus](#getbucketindexentrystatus) - Get the per-replica status of a single bucket-scoped index
* [GetIndexStatus](#getindexstatus) - Get aggregated index registry status
* [ListLedgerIndexes](#listledgerindexes) - List indexes for a ledger
* [CreateIndex](#createindex) - Create an index on a ledger
* [GetIndex](#getindex) - Get a single index registry entry
* [DropIndex](#dropindex) - Drop an index from a ledger
* [GetIndexEntryStatus](#getindexentrystatus) - Get the per-replica status of a single index
* [Info](#info) - Get server build information

## ListAllLedgers

Lists the ledgers in the cluster, paged by name (ascending unless
`reverse=true`). Requires `ledger:read` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListAllLedgers" method="get" path="/api/ledger/v3/" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.ListAllLedgersAsync(
    security: new V3ListAllLedgersSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    xConsistency: Consistency.Linearizable,
    pageSize: 100,
    reverse: false
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3ListAllLedgersSecurity](../../Models/Requests/V3ListAllLedgersSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |
| `PageSize`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | *long*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Maximum number of items per page. 0 or absent means 100; values above 1000 are clamped to 1000.                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Page token from a previous response's `next` or `previous` field (see<br/>the `PageToken` schema). Omit for the first page. Pass the same<br/>`reverse` and `filter` on every page of a walk.<br/>                                                                                                                                                                                                                                                                                                                                                                   |
| `Reverse`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | *bool*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | List in descending name order when true.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |

### Response

**[V3ListAllLedgersResponse](../../Models/Requests/V3ListAllLedgersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## Health

Returns the health status of the node. Returns 503 if the node is not connected to the cluster.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3Health" method="get" path="/api/ledger/health" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.HealthAsync(security: new V3HealthSecurity() {
    BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `security`                                                    | [V3HealthSecurity](../../Models/Requests/V3HealthSecurity.md) | :heavy_check_mark:                                            | The security requirements to use for the request.             |

### Response

**[V3HealthResponse](../../Models/Requests/V3HealthResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## Livez

Returns 200 as long as the process is alive. Suitable for Kubernetes liveness probes.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3Livez" method="get" path="/api/ledger/livez" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.LivezAsync(security: new V3LivezSecurity() {
    BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `security`                                                  | [V3LivezSecurity](../../Models/Requests/V3LivezSecurity.md) | :heavy_check_mark:                                          | The security requirements to use for the request.           |

### Response

**[V3LivezResponse](../../Models/Requests/V3LivezResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## Readyz

Returns 200 once the local Raft loop has started, regardless of whether
a leader has been elected. Suitable for Kubernetes readiness probes and
StatefulSet `OrderedReady` ordering: it is intentionally permissive so
peer pods can be brought up during a cold start where quorum cannot
form until they exist. Use `/clusterz` for the stricter
cluster-availability signal.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3Readyz" method="get" path="/api/ledger/readyz" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.ReadyzAsync(security: new V3ReadyzSecurity() {
    BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `security`                                                    | [V3ReadyzSecurity](../../Models/Requests/V3ReadyzSecurity.md) | :heavy_check_mark:                                            | The security requirements to use for the request.             |

### Response

**[V3ReadyzResponse](../../Models/Requests/V3ReadyzResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## Clusterz

Returns 200 only when the node is part of a healthy cluster (Raft state
healthy and a leader elected). Disk and clock skew gate writes (see
admission), not cluster readiness. Returns 503 otherwise. Use this
for external monitoring or any client that needs to wait until the node
can actually serve cluster-dependent traffic. Kubernetes readiness
probes should target `/readyz` instead — this endpoint MUST NOT gate
StatefulSet ordering, otherwise the cluster cannot recover from a
full-kill cold start.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3Clusterz" method="get" path="/api/ledger/clusterz" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.ClusterzAsync(security: new V3ClusterzSecurity() {
    BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `security`                                                        | [V3ClusterzSecurity](../../Models/Requests/V3ClusterzSecurity.md) | :heavy_check_mark:                                                | The security requirements to use for the request.                 |

### Response

**[V3ClusterzResponse](../../Models/Requests/V3ClusterzResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetLedger

Retrieves a ledger by its name. Requires `ledger:read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetLedger" method="get" path="/api/ledger/v3/{ledgerName}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetLedgerAsync(
    security: new V3GetLedgerSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetLedgerSecurity](../../Models/Requests/V3GetLedgerSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetLedgerResponse](../../Models/Requests/V3GetLedgerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CreateLedger

Creates a new ledger with the specified name. Storage is configured at the server level.
Each ledger has its own Raft group for data consistency. Requires `ledger:write` scope.

The ledger name `_` is reserved: all system / non-ledger routes live
under the `/v3/_/…` segment (e.g. `/v3/_/audit-entries`), so a ledger
named `_` would be unreachable over REST. Creating it is rejected with a
validation error. The exact name `_system` is also reserved for system
events and rejected. Other underscore-prefixed names remain valid.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreateLedger" method="post" path="/api/ledger/v3/{ledgerName}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance();

var res = await sdk.Ledger.V3.CreateLedgerAsync(
    security: new V3CreateLedgerSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    createLedgerRequest: new CreateLedgerRequest() {
        InitialSchema = new List<MetadataFieldTypeCommand>() {
            new MetadataFieldTypeCommand() {
                TargetType = MetadataFieldTypeCommandTargetType.Account,
                Key = "color",
                Type = MetadataFieldTypeCommandType.String,
            },
        },
        AccountTypes = new Dictionary<string, AddAccountTypeRequest>() {
            { "user-checking", new AddAccountTypeRequest() {
                Name = "user-checking",
                Pattern = "users:{id}:checking",
                Persistence = AddAccountTypeRequestPersistence.Ephemeral,
                SegmentTypes = new Dictionary<string, SegmentType?>() {
                    { "id", new SegmentType() {
                        Type = SegmentTypeType.Uuid,
                    } },
                },
            } },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `security`                                                                | [V3CreateLedgerSecurity](../../Models/Requests/V3CreateLedgerSecurity.md) | :heavy_check_mark:                                                        | The security requirements to use for the request.                         |
| `LedgerName`                                                              | *string*                                                                  | :heavy_check_mark:                                                        | Name of the ledger                                                        |
| `CreateLedgerRequest`                                                     | [CreateLedgerRequest](../../Models/LedgerV3/CreateLedgerRequest.md)       | :heavy_check_mark:                                                        | N/A                                                                       |
| `IdempotencyKey`                                                          | *string*                                                                  | :heavy_minus_sign:                                                        | Idempotency key for the request                                           |

### Response

**[V3CreateLedgerResponse](../../Models/Requests/V3CreateLedgerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DeleteLedger

Deletes a ledger by its name. This operation removes the ledger and its associated Raft group from the cluster. Requires `ledger:write` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeleteLedger" method="delete" path="/api/ledger/v3/{ledgerName}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.DeleteLedgerAsync(
    security: new V3DeleteLedgerSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `security`                                                                | [V3DeleteLedgerSecurity](../../Models/Requests/V3DeleteLedgerSecurity.md) | :heavy_check_mark:                                                        | The security requirements to use for the request.                         |
| `LedgerName`                                                              | *string*                                                                  | :heavy_check_mark:                                                        | Name of the ledger                                                        |
| `IdempotencyKey`                                                          | *string*                                                                  | :heavy_minus_sign:                                                        | Idempotency key for the request                                           |

### Response

**[V3DeleteLedgerResponse](../../Models/Requests/V3DeleteLedgerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetLedgerStats

Returns aggregate usage statistics (transaction, volume, reference, posting, log, revert and Numscript-execution counts, plus ephemeral-evicted and transient-used volume tallies) for a ledger. Requires `ledger:read` scope. On live reads, `transactionCount` and `logCount` are FSM-backed. The seven usage-derived counters (`postingCount`, `revertCount`, `numscriptExecutionCount`, `referenceCount`, `ephemeralEvictedCount`, `transientUsedCount`, `volumeCount`) are materialised asynchronously in the serving replica's usagestore and may lag committed state even after the request's ReadIndex barrier. Note: for checkpoint-scoped (historical) reads, only `transactionCount` and `logCount` are checkpoint-consistent; the usage-derived counters (`postingCount`, `revertCount`, `numscriptExecutionCount`, `referenceCount`, `ephemeralEvictedCount`, `transientUsedCount`, `volumeCount`) are sourced from the live usagestore projection, which is not checkpoint-aware, and are returned as `0` at a checkpoint rather than a live value — treat `0` on a checkpoint read as "not available at this checkpoint".

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetLedgerStats" method="get" path="/api/ledger/v3/{ledgerName}/stats" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetLedgerStatsAsync(
    security: new V3GetLedgerStatsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetLedgerStatsSecurity](../../Models/Requests/V3GetLedgerStatsSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetLedgerStatsResponse](../../Models/Requests/V3GetLedgerStatsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListLedgerLogs

Lists log entries for a specific ledger, paged by ledger-local log ID
(ascending unless `reverse=true`).
Requires the builtin `LOG` index to be enabled on the ledger via `CreateIndex`.
Requires `ledger:read` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListLedgerLogs" method="get" path="/api/ledger/v3/{ledgerName}/logs" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3ListLedgerLogsRequest req = new V3ListLedgerLogsRequest() {
    FormanceBigintAsString = "true",
    LedgerName = "<value>",
};

var res = await sdk.Ledger.V3.ListLedgerLogsAsync(
    security: new V3ListLedgerLogsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [V3ListLedgerLogsRequest](../../Models/Requests/V3ListLedgerLogsRequest.md)   | :heavy_check_mark:                                                            | The request object to use for the request.                                    |
| `security`                                                                    | [V3ListLedgerLogsSecurity](../../Models/Requests/V3ListLedgerLogsSecurity.md) | :heavy_check_mark:                                                            | The security requirements to use for the request.                             |

### Response

**[V3ListLedgerLogsResponse](../../Models/Requests/V3ListLedgerLogsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListAuditEntries

Lists audit trail entries (one per proposal, success or failure) across
the whole bucket, paged by audit sequence (ascending unless
`reverse=true`). Audit reads are
not ledger-scoped in the path — a single proposal can touch several
ledgers — so ledger scope, outcome and other dimensions are expressed
through the `filter` query parameter.

This endpoint always performs a live read and does not expose pinned
checkpoint reads. Filters containing indexed audit conditions wait for
the audit projection to certify the request's fixed main-store horizon;
matching entries are loaded from that same main snapshot. Unfiltered
reads and sequence-only bounds scan the audit zone directly without
waiting for the audit projection.

Requires `ledger:ReadAudit` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListAuditEntries" method="get" path="/api/ledger/v3/_/audit-entries" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3ListAuditEntriesRequest req = new V3ListAuditEntriesRequest() {};

var res = await sdk.Ledger.V3.ListAuditEntriesAsync(
    security: new V3ListAuditEntriesSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [V3ListAuditEntriesRequest](../../Models/Requests/V3ListAuditEntriesRequest.md)   | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `security`                                                                        | [V3ListAuditEntriesSecurity](../../Models/Requests/V3ListAuditEntriesSecurity.md) | :heavy_check_mark:                                                                | The security requirements to use for the request.                                 |

### Response

**[V3ListAuditEntriesResponse](../../Models/Requests/V3ListAuditEntriesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetAuditEntry

Returns a single audit entry by its global sequence, with per-order
`items` populated (the list endpoint omits `items` for compactness).
Requires `ledger:ReadAudit` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetAuditEntry" method="get" path="/api/ledger/v3/_/audit-entries/{sequence}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetAuditEntryAsync(
    security: new V3GetAuditEntrySecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    sequence: 98403,
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetAuditEntrySecurity](../../Models/Requests/V3GetAuditEntrySecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `Sequence`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | *long*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Audit entry sequence                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetAuditEntryResponse](../../Models/Requests/V3GetAuditEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## PromoteLedger

Promotes a mirror-mode ledger to normal mode. After promotion, the mirror sync
worker is stopped and the ledger accepts direct write operations. Requires `ledger:write` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3PromoteLedger" method="post" path="/api/ledger/v3/{ledgerName}/promote" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.PromoteLedgerAsync(
    security: new V3PromoteLedgerSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `security`                                                                  | [V3PromoteLedgerSecurity](../../Models/Requests/V3PromoteLedgerSecurity.md) | :heavy_check_mark:                                                          | The security requirements to use for the request.                           |
| `LedgerName`                                                                | *string*                                                                    | :heavy_check_mark:                                                          | Name of the ledger                                                          |

### Response

**[V3PromoteLedgerResponse](../../Models/Requests/V3PromoteLedgerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CreateTransaction

Creates a new transaction in the specified ledger with the specified postings. Requires `ledger:write` scope.
Signed requests use `application/json` (including MIME parameters) with
`request` and standard-base64 `payload`. Either signing header, even if
empty, selects this wrapper; with neither header present, the ordinary REST body applies.
Runtime headers choose the representation from the documented anyOf.
The signed protobuf batch must
equal the route/body/Idempotency-Key-derived batch in full. Supply exactly
one nonempty Formance-Signing-Key-Id and Formance-Signature header; the
latter is a standard-base64 Ed25519 signature of 64 decoded bytes. Missing,
empty or repeated signing headers, invalid base64 and wrong signature
length return 400. Signing headers with a non-JSON or missing content type return 415.
Signature enforcement
returns 401 `UNAUTHENTICATED` when required but absent and 403
`PERMISSION_DENIED` for invalid, unknown/revoked-key or mismatched
signatures. Malformed signed envelopes return 400. The complete
wrapper counts toward the 4 MiB body limit. JWT scopes still apply.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreateTransaction" method="post" path="/api/ledger/v3/{ledgerName}/transactions" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3CreateTransactionRequest req = new V3CreateTransactionRequest() {
    FormanceBigintAsString = "true",
    LedgerName = "<value>",
    RequestBody = V3CreateTransactionRequestBody.CreateCreateTransactionRequest(
        new FormanceSDK.Models.LedgerV3.CreateTransactionRequest() {}
    ),
};

var res = await sdk.Ledger.V3.CreateTransactionAsync(
    security: new V3CreateTransactionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [V3CreateTransactionRequest](../../Models/Requests/V3CreateTransactionRequest.md)   | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |
| `security`                                                                          | [V3CreateTransactionSecurity](../../Models/Requests/V3CreateTransactionSecurity.md) | :heavy_check_mark:                                                                  | The security requirements to use for the request.                                   |

### Response

**[V3CreateTransactionResponse](../../Models/Requests/V3CreateTransactionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListLedgerTransactions

Lists transactions for a specific ledger. The default order is
newest-first (descending transaction id); pass `reverse=true` to
get oldest-first (ascending). Supports cursor pagination (`pageSize`,
`cursor`), an optional date range (`startDate`/`endDate`),
and the generic `filter` parameter (e.g. reference selection via
`filter={"$match":{"reference":"..."}}`, URL-encoded). Requires
`ledger:ReadTransaction` scope.

This is a live read, linearizable by default. `X-Consistency: stale`
reads the receiving node's local state, which may lag the leader. Every
projection used by the filter is automatically aligned. Unlike the
gRPC API, it does not accept the `checkpointId` option to pin the read
to a specific historical snapshot — use gRPC for checkpoint-pinned
reads. (Tracked follow-up, same carve-out as the audit reads.)


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListLedgerTransactions" method="get" path="/api/ledger/v3/{ledgerName}/transactions" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3ListLedgerTransactionsRequest req = new V3ListLedgerTransactionsRequest() {
    FormanceBigintAsString = "true",
    LedgerName = "<value>",
};

var res = await sdk.Ledger.V3.ListLedgerTransactionsAsync(
    security: new V3ListLedgerTransactionsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [V3ListLedgerTransactionsRequest](../../Models/Requests/V3ListLedgerTransactionsRequest.md)   | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |
| `security`                                                                                    | [V3ListLedgerTransactionsSecurity](../../Models/Requests/V3ListLedgerTransactionsSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |

### Response

**[V3ListLedgerTransactionsResponse](../../Models/Requests/V3ListLedgerTransactionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetTransaction

Retrieves a transaction by its ID from the specified ledger. Requires `ledger:read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetTransaction" method="get" path="/api/ledger/v3/{ledgerName}/transactions/{transactionId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetTransactionAsync(
    security: new V3GetTransactionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    transactionId: 431503,
    xConsistency: Consistency.Linearizable,
    formanceBigintAsString: "true"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Example                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | [V3GetTransactionSecurity](../../Models/Requests/V3GetTransactionSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `TransactionId`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | *long*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Transaction ID                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/>                        |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `FormanceBigintAsString`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Render all response Uint256, BigUint and SignedBigInt values as canonical<br/>decimal strings, regardless of business meaning, including posting<br/>amounts, volume input/output and balances. Ordinary integer IDs/counts,<br/>metadata and explicitly string-encoded counters keep their existing<br/>representation. Case-insensitive true, yes, y and 1 enable<br/>this option, matching Ledger v2. Whitespace is not trimmed. Omission and<br/>every other value retain JSON number tokens. This affects only this<br/>response, including nested objects, maps, arrays, transaction/log/cursor<br/>and bulk results. Request decoding is unchanged.<br/> | true                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |

### Response

**[V3GetTransactionResponse](../../Models/Requests/V3GetTransactionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListAccounts

Lists accounts in a ledger in alphabetical order with cursor
pagination and an optional generic `filter` (e.g. address-prefix
selection via `filter=address ^= "users:"`). Requires `ledger:read`
scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListAccounts_ledgerV3" method="get" path="/api/ledger/v3/{ledgerName}/accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3ListAccountsLedgerV3Request req = new V3ListAccountsLedgerV3Request() {
    FormanceBigintAsString = "true",
    LedgerName = "<value>",
};

var res = await sdk.Ledger.V3.ListAccountsAsync(
    security: new V3ListAccountsLedgerV3Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [V3ListAccountsLedgerV3Request](../../Models/Requests/V3ListAccountsLedgerV3Request.md)   | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |
| `security`                                                                                | [V3ListAccountsLedgerV3Security](../../Models/Requests/V3ListAccountsLedgerV3Security.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |

### Response

**[V3ListAccountsLedgerV3Response](../../Models/Requests/V3ListAccountsLedgerV3Response.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetAccount

Retrieves account information including metadata for a specific account address. Requires `ledger:read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetAccount_ledgerV3" method="get" path="/api/ledger/v3/{ledgerName}/accounts/{address}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3GetAccountLedgerV3Request req = new V3GetAccountLedgerV3Request() {
    FormanceBigintAsString = "true",
    LedgerName = "<value>",
    Address = "users:001",
};

var res = await sdk.Ledger.V3.GetAccountAsync(
    security: new V3GetAccountLedgerV3Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [V3GetAccountLedgerV3Request](../../Models/Requests/V3GetAccountLedgerV3Request.md)   | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |
| `security`                                                                            | [V3GetAccountLedgerV3Security](../../Models/Requests/V3GetAccountLedgerV3Security.md) | :heavy_check_mark:                                                                    | The security requirements to use for the request.                                     |

### Response

**[V3GetAccountLedgerV3Response](../../Models/Requests/V3GetAccountLedgerV3Response.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## AggregateVolumes

Returns aggregated volumes (input/output/balance per asset) across all accounts in the ledger.
Supports filtering accounts with the generic `filter` parameter, grouping by account prefixes,
and max-precision merging.
Requires `ledger:ReadAccount` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3AggregateVolumes" method="get" path="/api/ledger/v3/{ledgerName}/volumes" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3AggregateVolumesRequest req = new V3AggregateVolumesRequest() {
    FormanceBigintAsString = "true",
    LedgerName = "<value>",
};

var res = await sdk.Ledger.V3.AggregateVolumesAsync(
    security: new V3AggregateVolumesSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [V3AggregateVolumesRequest](../../Models/Requests/V3AggregateVolumesRequest.md)   | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `security`                                                                        | [V3AggregateVolumesSecurity](../../Models/Requests/V3AggregateVolumesSecurity.md) | :heavy_check_mark:                                                                | The security requirements to use for the request.                                 |

### Response

**[V3AggregateVolumesResponse](../../Models/Requests/V3AggregateVolumesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## SaveLedgerMetadata

Saves metadata key-value pairs on the ledger itself. Requires `ledger:WriteMetadata`; `ledger:write` grants it under the default scope mapping. Custom scope mappings can differ.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3SaveLedgerMetadata" method="post" path="/api/ledger/v3/{ledgerName}/metadata" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance();

var res = await sdk.Ledger.V3.SaveLedgerMetadataAsync(
    security: new V3SaveLedgerMetadataSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    requestBody: new Dictionary<string, MetadataValue?>() {
        { "environment", MetadataValue.CreateStr(
            "production"
        ) },
        { "team", MetadataValue.CreateStr(
            "payments"
        ) },
        { "region", MetadataValue.CreateStr(
            "eu-west-1"
        ) },
    }
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `security`                                                                            | [V3SaveLedgerMetadataSecurity](../../Models/Requests/V3SaveLedgerMetadataSecurity.md) | :heavy_check_mark:                                                                    | The security requirements to use for the request.                                     |                                                                                       |
| `LedgerName`                                                                          | *string*                                                                              | :heavy_check_mark:                                                                    | Name of the ledger                                                                    |                                                                                       |
| `RequestBody`                                                                         | Dictionary<String, [MetadataValue](../../Models/LedgerV3/MetadataValue.md)>           | :heavy_check_mark:                                                                    | N/A                                                                                   | {<br/>"environment": "production",<br/>"team": "payments",<br/>"region": "eu-west-1"<br/>} |
| `IdempotencyKey`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | Idempotency key for the request                                                       |                                                                                       |

### Response

**[V3SaveLedgerMetadataResponse](../../Models/Requests/V3SaveLedgerMetadataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DeleteLedgerMetadata

Deletes a metadata key from the ledger. Requires `ledger:WriteMetadata` scope (included in the default `ledger:write` mapping).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeleteLedgerMetadata" method="delete" path="/api/ledger/v3/{ledgerName}/metadata/{key}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.DeleteLedgerMetadataAsync(
    security: new V3DeleteLedgerMetadataSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    key: "formance.com/reviewed"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                         | Type                                                                                                                                                                                                                                                                                                                                                              | Required                                                                                                                                                                                                                                                                                                                                                          | Description                                                                                                                                                                                                                                                                                                                                                       | Example                                                                                                                                                                                                                                                                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                        | [V3DeleteLedgerMetadataSecurity](../../Models/Requests/V3DeleteLedgerMetadataSecurity.md)                                                                                                                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                                                                   |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Name of the ledger                                                                                                                                                                                                                                                                                                                                                |                                                                                                                                                                                                                                                                                                                                                                   |
| `Key`                                                                                                                                                                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Raw metadata key, for example formance.com/reviewed. SDK callers pass<br/>the raw key and let the SDK encode it. Direct HTTP clients URL-encode<br/>the key as one path segment, encoding slashes as %2F.<br/>Decoded exactly once; percent<br/>characters remaining after decoding, including double-encoded slashes,<br/>are invalid metadata keys and are rejected with HTTP 400.<br/> | formance.com/reviewed                                                                                                                                                                                                                                                                                                                                             |
| `IdempotencyKey`                                                                                                                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                | Idempotency key for the request                                                                                                                                                                                                                                                                                                                                   |                                                                                                                                                                                                                                                                                                                                                                   |

### Response

**[V3DeleteLedgerMetadataResponse](../../Models/Requests/V3DeleteLedgerMetadataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## SaveAccountMetadata

Saves metadata for a specific account in the ledger. Requires `ledger:WriteMetadata` scope (included in the default `ledger:write` mapping).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3SaveAccountMetadata" method="post" path="/api/ledger/v3/{ledgerName}/accounts/{address}/metadata" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance();

var res = await sdk.Ledger.V3.SaveAccountMetadataAsync(
    security: new V3SaveAccountMetadataSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    address: "users:001",
    requestBody: new Dictionary<string, MetadataValue?>() {
        { "account_type", MetadataValue.CreateStr(
            "asset"
        ) },
        { "label", MetadataValue.CreateStr(
            "Bank Account"
        ) },
        { "active", MetadataValue.CreateBoolean(
            true
        ) },
        { "balance_threshold", MetadataValue.CreateInteger(
            1000
        ) },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                   | Type                                                                                                                                        | Required                                                                                                                                    | Description                                                                                                                                 | Example                                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                  | [V3SaveAccountMetadataSecurity](../../Models/Requests/V3SaveAccountMetadataSecurity.md)                                                     | :heavy_check_mark:                                                                                                                          | The security requirements to use for the request.                                                                                           |                                                                                                                                             |
| `LedgerName`                                                                                                                                | *string*                                                                                                                                    | :heavy_check_mark:                                                                                                                          | Name of the ledger                                                                                                                          |                                                                                                                                             |
| `Address`                                                                                                                                   | *string*                                                                                                                                    | :heavy_check_mark:                                                                                                                          | Raw account address, for example users:001. Direct HTTP clients may<br/>URL-encode it as one path segment (users%3A001). Decoded exactly once.<br/> | users:001                                                                                                                                   |
| `RequestBody`                                                                                                                               | Dictionary<String, [MetadataValue](../../Models/LedgerV3/MetadataValue.md)>                                                                 | :heavy_check_mark:                                                                                                                          | N/A                                                                                                                                         | {<br/>"account_type": "asset",<br/>"label": "Bank Account",<br/>"active": true,<br/>"balance_threshold": 1000<br/>}                         |
| `IdempotencyKey`                                                                                                                            | *string*                                                                                                                                    | :heavy_minus_sign:                                                                                                                          | Idempotency key for the request                                                                                                             |                                                                                                                                             |

### Response

**[V3SaveAccountMetadataResponse](../../Models/Requests/V3SaveAccountMetadataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## SaveTransactionMetadata

Saves metadata for a specific transaction in the ledger. Requires `ledger:WriteMetadata` scope (included in the default `ledger:write` mapping).
Signed requests use `application/json` (including MIME parameters) with
`request` and standard-base64 `payload`. Either signing header, even if
empty, selects this wrapper; with neither header present, the ordinary REST body applies.
Runtime headers choose the representation from the documented anyOf.
The signed protobuf batch must
equal the route/body/Idempotency-Key-derived batch in full. Supply exactly
one nonempty Formance-Signing-Key-Id and Formance-Signature header; the
latter is a standard-base64 Ed25519 signature of 64 decoded bytes. Missing,
empty or repeated signing headers, invalid base64 and wrong signature
length return 400. Signing headers with a non-JSON or missing content type return 415.
Signature enforcement
returns 401 `UNAUTHENTICATED` when required but absent and 403
`PERMISSION_DENIED` for invalid, unknown/revoked-key or mismatched
signatures. Malformed signed envelopes return 400. The complete
wrapper counts toward the 4 MiB body limit. JWT scopes still apply.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3SaveTransactionMetadata" method="post" path="/api/ledger/v3/{ledgerName}/transactions/{transactionId}/metadata" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance();

V3SaveTransactionMetadataRequest req = new V3SaveTransactionMetadataRequest() {
    LedgerName = "<value>",
    TransactionId = 736514,
    RequestBody = V3SaveTransactionMetadataRequestBody.CreateMapOfMetadataValue(
        new Dictionary<string, MetadataValue?>() {
            { "reason", MetadataValue.CreateStr(
                "correction"
            ) },
            { "source", MetadataValue.CreateStr(
                "support"
            ) },
            { "priority", MetadataValue.CreateInteger(
                1
            ) },
        }
    ),
};

var res = await sdk.Ledger.V3.SaveTransactionMetadataAsync(
    security: new V3SaveTransactionMetadataSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [V3SaveTransactionMetadataRequest](../../Models/Requests/V3SaveTransactionMetadataRequest.md)   | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |
| `security`                                                                                      | [V3SaveTransactionMetadataSecurity](../../Models/Requests/V3SaveTransactionMetadataSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |

### Response

**[V3SaveTransactionMetadataResponse](../../Models/Requests/V3SaveTransactionMetadataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DeleteAccountMetadata

Deletes a metadata key for a specific account in the ledger. Requires `ledger:WriteMetadata` scope (included in the default `ledger:write` mapping).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeleteAccountMetadata" method="delete" path="/api/ledger/v3/{ledgerName}/accounts/{address}/metadata/{key}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.DeleteAccountMetadataAsync(
    security: new V3DeleteAccountMetadataSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    address: "users:001",
    key: "formance.com/reviewed"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                         | Type                                                                                                                                                                                                                                                                                                                                                              | Required                                                                                                                                                                                                                                                                                                                                                          | Description                                                                                                                                                                                                                                                                                                                                                       | Example                                                                                                                                                                                                                                                                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                        | [V3DeleteAccountMetadataSecurity](../../Models/Requests/V3DeleteAccountMetadataSecurity.md)                                                                                                                                                                                                                                                                       | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                                                                   |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Name of the ledger                                                                                                                                                                                                                                                                                                                                                |                                                                                                                                                                                                                                                                                                                                                                   |
| `Address`                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Raw account address, for example users:001. Direct HTTP clients may<br/>URL-encode it as one path segment (users%3A001). Decoded exactly once.<br/>                                                                                                                                                                                                               | users:001                                                                                                                                                                                                                                                                                                                                                         |
| `Key`                                                                                                                                                                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Raw metadata key, for example formance.com/reviewed. SDK callers pass<br/>the raw key and let the SDK encode it. Direct HTTP clients URL-encode<br/>the key as one path segment, encoding slashes as %2F.<br/>Decoded exactly once; percent<br/>characters remaining after decoding, including double-encoded slashes,<br/>are invalid metadata keys and are rejected with HTTP 400.<br/> | formance.com/reviewed                                                                                                                                                                                                                                                                                                                                             |
| `IdempotencyKey`                                                                                                                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                | Idempotency key for the request                                                                                                                                                                                                                                                                                                                                   |                                                                                                                                                                                                                                                                                                                                                                   |

### Response

**[V3DeleteAccountMetadataResponse](../../Models/Requests/V3DeleteAccountMetadataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DeleteTransactionMetadata

Deletes a metadata key for a specific transaction in the ledger. Requires `ledger:WriteMetadata` scope (included in the default `ledger:write` mapping).
Signed requests use `application/json` (including MIME parameters) with
`request` and standard-base64 `payload`. Either signing header, even if
empty, selects this wrapper; with neither header present, the ordinary REST body applies.
Runtime headers choose the representation from the documented anyOf.
The signed protobuf batch must
equal the route/body/Idempotency-Key-derived batch in full. Supply exactly
one nonempty Formance-Signing-Key-Id and Formance-Signature header; the
latter is a standard-base64 Ed25519 signature of 64 decoded bytes. Missing,
empty or repeated signing headers, invalid base64 and wrong signature
length return 400. Signing headers with a non-JSON or missing content type return 415.
Signature enforcement
returns 401 `UNAUTHENTICATED` when required but absent and 403
`PERMISSION_DENIED` for invalid, unknown/revoked-key or mismatched
signatures. Malformed signed envelopes return 400. The complete
wrapper counts toward the 4 MiB body limit. JWT scopes still apply.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeleteTransactionMetadata" method="delete" path="/api/ledger/v3/{ledgerName}/transactions/{transactionId}/metadata/{key}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3DeleteTransactionMetadataRequest req = new V3DeleteTransactionMetadataRequest() {
    LedgerName = "<value>",
    TransactionId = 831017,
    Key = "formance.com/reviewed",
};

var res = await sdk.Ledger.V3.DeleteTransactionMetadataAsync(
    security: new V3DeleteTransactionMetadataSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [V3DeleteTransactionMetadataRequest](../../Models/Requests/V3DeleteTransactionMetadataRequest.md)   | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |
| `security`                                                                                          | [V3DeleteTransactionMetadataSecurity](../../Models/Requests/V3DeleteTransactionMetadataSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |

### Response

**[V3DeleteTransactionMetadataResponse](../../Models/Requests/V3DeleteTransactionMetadataResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## RevertTransaction

Reverts a transaction by creating a reverse transaction that undoes its effects. Requires `ledger:write` scope.
The body is optional; an absent or empty body uses default options. Supplied
options and metadata are decoded for both known-length and HTTP/1.1 chunked
requests. Malformed or truncated JSON, extra values, trailing non-whitespace
and options of the wrong JSON type (for example `"atEffectiveDate": "true"`
or a non-object `metadata`) return 400 before applying the revert. A JSON
`null` option uses its default. The complete body, including trailing
whitespace, counts towards the 4 MiB limit; exceeding it returns 413.
Signed requests use `application/json` (including MIME parameters) with
`request` and standard-base64 `payload`. Either signing header, even if
empty, selects this wrapper; with neither header present, the ordinary REST body applies.
Runtime headers choose the representation from the documented anyOf.
The signed protobuf batch must
equal the route/body/Idempotency-Key-derived batch in full. Supply exactly
one nonempty Formance-Signing-Key-Id and Formance-Signature header; the
latter is a standard-base64 Ed25519 signature of 64 decoded bytes. Missing,
empty or repeated signing headers, invalid base64 and wrong signature
length return 400. Signing headers with a non-JSON or missing content type return 415.
Signature enforcement
returns 401 `UNAUTHENTICATED` when required but absent and 403
`PERMISSION_DENIED` for invalid, unknown/revoked-key or mismatched
signatures. Malformed signed envelopes return 400. The complete
wrapper counts toward the 4 MiB body limit. JWT scopes still apply.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3RevertTransaction" method="post" path="/api/ledger/v3/{ledgerName}/transactions/{transactionId}/revert" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3RevertTransactionRequest req = new V3RevertTransactionRequest() {
    FormanceBigintAsString = "true",
    LedgerName = "<value>",
    TransactionId = 541831,
};

var res = await sdk.Ledger.V3.RevertTransactionAsync(
    security: new V3RevertTransactionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [V3RevertTransactionRequest](../../Models/Requests/V3RevertTransactionRequest.md)   | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |
| `security`                                                                          | [V3RevertTransactionSecurity](../../Models/Requests/V3RevertTransactionSecurity.md) | :heavy_check_mark:                                                                  | The security requirements to use for the request.                                   |

### Response

**[V3RevertTransactionResponse](../../Models/Requests/V3RevertTransactionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetMetadataSchemaStatus

Returns the declared type of every metadata field on a ledger. Requires `ledger:read` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetMetadataSchemaStatus" method="get" path="/api/ledger/v3/{ledgerName}/metadata-schema" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetMetadataSchemaStatusAsync(
    security: new V3GetMetadataSchemaStatusSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetMetadataSchemaStatusSecurity](../../Models/Requests/V3GetMetadataSchemaStatusSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetMetadataSchemaStatusResponse](../../Models/Requests/V3GetMetadataSchemaStatusResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## InspectIndex

Scans a metadata index and returns distinct values, facets (value + count),
or a summary (cardinality, min/max, existence counts). The index must be
in READY state. Only metadata indexes are inspectable (builtin indexes
return 400). Requires `ledger:read` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3InspectIndex" method="get" path="/api/ledger/v3/{ledgerName}/indexes/{canonicalId}/inspect" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3InspectIndexRequest req = new V3InspectIndexRequest() {
    LedgerName = "<value>",
    CanonicalId = "<id>",
};

var res = await sdk.Ledger.V3.InspectIndexAsync(
    security: new V3InspectIndexSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [V3InspectIndexRequest](../../Models/Requests/V3InspectIndexRequest.md)   | :heavy_check_mark:                                                        | The request object to use for the request.                                |
| `security`                                                                | [V3InspectIndexSecurity](../../Models/Requests/V3InspectIndexSecurity.md) | :heavy_check_mark:                                                        | The security requirements to use for the request.                         |

### Response

**[V3InspectIndexResponse](../../Models/Requests/V3InspectIndexResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## AnalyzeAccounts

Scans all accounts in a ledger, discovers address patterns, and returns a
suggested Chart of Accounts. Useful after a mirror import to understand
account structure. Requires `ledger:read` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3AnalyzeAccounts" method="get" path="/api/ledger/v3/{ledgerName}/analyze-accounts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.AnalyzeAccountsAsync(
    security: new V3AnalyzeAccountsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    xConsistency: Consistency.Linearizable,
    variableThreshold: 0
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3AnalyzeAccountsSecurity](../../Models/Requests/V3AnalyzeAccountsSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |
| `VariableThreshold`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | *int*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Max distinct children before classifying as variable (0 = default 10)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |

### Response

**[V3AnalyzeAccountsResponse](../../Models/Requests/V3AnalyzeAccountsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## AnalyzeTransactions

Scans all transactions in a ledger, discovers flow patterns by normalizing
account addresses, and returns statistics per flow type including temporal
distribution and volume metrics. Requires `ledger:read` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3AnalyzeTransactions" method="get" path="/api/ledger/v3/{ledgerName}/analyze-transactions" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.AnalyzeTransactionsAsync(
    security: new V3AnalyzeTransactionsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    xConsistency: Consistency.Linearizable,
    formanceBigintAsString: "true",
    variableThreshold: 0
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Example                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | [V3AnalyzeTransactionsSecurity](../../Models/Requests/V3AnalyzeTransactionsSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/>                        |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `FormanceBigintAsString`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Render all response Uint256, BigUint and SignedBigInt values as canonical<br/>decimal strings, regardless of business meaning, including posting<br/>amounts, volume input/output and balances. Ordinary integer IDs/counts,<br/>metadata and explicitly string-encoded counters keep their existing<br/>representation. Case-insensitive true, yes, y and 1 enable<br/>this option, matching Ledger v2. Whitespace is not trimmed. Omission and<br/>every other value retain JSON number tokens. This affects only this<br/>response, including nested objects, maps, arrays, transaction/log/cursor<br/>and bulk results. Request decoding is unchanged.<br/> | true                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| `VariableThreshold`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *int*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Max distinct children before classifying as variable (0 = default 10)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |

### Response

**[V3AnalyzeTransactionsResponse](../../Models/Requests/V3AnalyzeTransactionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## SetMetadataFieldType

Declares or changes the type used to encode a metadata key in an attached query index.
Metadata values are neither validated nor converted by this declaration, and existing primary values remain unchanged.
Any attached index is rewritten asynchronously. Requires `ledger:WriteMetadata` scope (included in the default `ledger:write` mapping).


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3SetMetadataFieldType" method="put" path="/api/ledger/v3/{ledgerName}/metadata-schema/{targetType}/{key}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.SetMetadataFieldTypeAsync(
    security: new V3SetMetadataFieldTypeSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    targetType: FormanceSDK.Models.LedgerV3.TargetType.Ledger,
    key: "formance.com/reviewed",
    setMetadataTypeRequest: new SetMetadataTypeRequest() {
        Type = SetMetadataTypeRequestType.Bool,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                         | Type                                                                                                                                                                                                                                                                                                                                                              | Required                                                                                                                                                                                                                                                                                                                                                          | Description                                                                                                                                                                                                                                                                                                                                                       | Example                                                                                                                                                                                                                                                                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                        | [V3SetMetadataFieldTypeSecurity](../../Models/Requests/V3SetMetadataFieldTypeSecurity.md)                                                                                                                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                                                                   |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Name of the ledger                                                                                                                                                                                                                                                                                                                                                |                                                                                                                                                                                                                                                                                                                                                                   |
| `TargetType`                                                                                                                                                                                                                                                                                                                                                      | [Models.LedgerV3.TargetType](../../Models/LedgerV3/TargetType.md)                                                                                                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Target type (account, transaction, or ledger)                                                                                                                                                                                                                                                                                                                     |                                                                                                                                                                                                                                                                                                                                                                   |
| `Key`                                                                                                                                                                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Raw metadata key, for example formance.com/reviewed. SDK callers pass<br/>the raw key and let the SDK encode it. Direct HTTP clients URL-encode<br/>the key as one path segment, encoding slashes as %2F.<br/>Decoded exactly once; percent<br/>characters remaining after decoding, including double-encoded slashes,<br/>are invalid metadata keys and are rejected with HTTP 400.<br/> | formance.com/reviewed                                                                                                                                                                                                                                                                                                                                             |
| `SetMetadataTypeRequest`                                                                                                                                                                                                                                                                                                                                          | [SetMetadataTypeRequest](../../Models/LedgerV3/SetMetadataTypeRequest.md)                                                                                                                                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | N/A                                                                                                                                                                                                                                                                                                                                                               |                                                                                                                                                                                                                                                                                                                                                                   |

### Response

**[V3SetMetadataFieldTypeResponse](../../Models/Requests/V3SetMetadataFieldTypeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## RemoveMetadataFieldType

Removes the type declaration for a metadata key on a ledger.
Existing metadata values remain unchanged and any attached index is dropped. Requires `ledger:WriteMetadata` scope (included in the default `ledger:write` mapping).


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3RemoveMetadataFieldType" method="delete" path="/api/ledger/v3/{ledgerName}/metadata-schema/{targetType}/{key}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.RemoveMetadataFieldTypeAsync(
    security: new V3RemoveMetadataFieldTypeSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    targetType: FormanceSDK.Models.LedgerV3.TargetType.Ledger,
    key: "formance.com/reviewed"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                         | Type                                                                                                                                                                                                                                                                                                                                                              | Required                                                                                                                                                                                                                                                                                                                                                          | Description                                                                                                                                                                                                                                                                                                                                                       | Example                                                                                                                                                                                                                                                                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                        | [V3RemoveMetadataFieldTypeSecurity](../../Models/Requests/V3RemoveMetadataFieldTypeSecurity.md)                                                                                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                                                                   |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Name of the ledger                                                                                                                                                                                                                                                                                                                                                |                                                                                                                                                                                                                                                                                                                                                                   |
| `TargetType`                                                                                                                                                                                                                                                                                                                                                      | [Models.LedgerV3.TargetType](../../Models/LedgerV3/TargetType.md)                                                                                                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Target type (account, transaction, or ledger)                                                                                                                                                                                                                                                                                                                     |                                                                                                                                                                                                                                                                                                                                                                   |
| `Key`                                                                                                                                                                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                | Raw metadata key, for example formance.com/reviewed. SDK callers pass<br/>the raw key and let the SDK encode it. Direct HTTP clients URL-encode<br/>the key as one path segment, encoding slashes as %2F.<br/>Decoded exactly once; percent<br/>characters remaining after decoding, including double-encoded slashes,<br/>are invalid metadata keys and are rejected with HTTP 400.<br/> | formance.com/reviewed                                                                                                                                                                                                                                                                                                                                             |

### Response

**[V3RemoveMetadataFieldTypeResponse](../../Models/Requests/V3RemoveMetadataFieldTypeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## AnalyzeNumscript

Validates Numscript v1 and returns the external input schema without reading or changing ledger state. Recognized source failures are returned as diagnostics with an empty input list. Sources over 64 KiB or with more than 32 block-comment open markers receive a syntax diagnostic; internal failures return a server error.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3AnalyzeNumscript" method="post" path="/api/ledger/v3/numscripts/analyze" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

AnalyzeNumscriptRequest req = new AnalyzeNumscriptRequest() {
    Source = "<value>",
    Version = "v1",
};

var res = await sdk.Ledger.V3.AnalyzeNumscriptAsync(
    security: new V3AnalyzeNumscriptSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [AnalyzeNumscriptRequest](../../Models/LedgerV3/AnalyzeNumscriptRequest.md)       | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `security`                                                                        | [V3AnalyzeNumscriptSecurity](../../Models/Requests/V3AnalyzeNumscriptSecurity.md) | :heavy_check_mark:                                                                | The security requirements to use for the request.                                 |

### Response

**[V3AnalyzeNumscriptResponse](../../Models/Requests/V3AnalyzeNumscriptResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListNumscripts

Lists every numscript of a ledger at its greatest stored version, paged
by name (ascending unless `reverse=true`).


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListNumscripts" method="get" path="/api/ledger/v3/{ledgerName}/numscripts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3ListNumscriptsRequest req = new V3ListNumscriptsRequest() {
    LedgerName = "<value>",
};

var res = await sdk.Ledger.V3.ListNumscriptsAsync(
    security: new V3ListNumscriptsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [V3ListNumscriptsRequest](../../Models/Requests/V3ListNumscriptsRequest.md)   | :heavy_check_mark:                                                            | The request object to use for the request.                                    |
| `security`                                                                    | [V3ListNumscriptsSecurity](../../Models/Requests/V3ListNumscriptsSecurity.md) | :heavy_check_mark:                                                            | The security requirements to use for the request.                             |

### Response

**[V3ListNumscriptsResponse](../../Models/Requests/V3ListNumscriptsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetNumscript

Retrieves a numscript by name from a ledger. Use the `version` query parameter to get a specific
semver version. If omitted or empty, the latest version is returned.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetNumscript" method="get" path="/api/ledger/v3/{ledgerName}/numscripts/{name}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetNumscriptAsync(
    security: new V3GetNumscriptSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    name: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetNumscriptSecurity](../../Models/Requests/V3GetNumscriptSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `Name`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the numscript, URL-encoded as one path segment. Decoded exactly once.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |
| `Version`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Semver version to retrieve (e.g. "1.0.0"). If omitted or empty, the latest version is returned.<br/>                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |

### Response

**[V3GetNumscriptResponse](../../Models/Requests/V3GetNumscriptResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## SaveNumscript

Appends an immutable version to a ledger's numscript library. The `version`
field must be an explicit full semver (e.g. "1.0.0"); it creates a new
version and fails if that version already exists. The per-name latest is
always the greatest stored semver.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3SaveNumscript" method="put" path="/api/ledger/v3/{ledgerName}/numscripts/{name}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.SaveNumscriptAsync(
    security: new V3SaveNumscriptSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    name: "<value>",
    saveNumscriptRequest: new SaveNumscriptRequest() {
        Content = "<value>",
        Version = "1.0.0",
    }
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `security`                                                                    | [V3SaveNumscriptSecurity](../../Models/Requests/V3SaveNumscriptSecurity.md)   | :heavy_check_mark:                                                            | The security requirements to use for the request.                             |
| `LedgerName`                                                                  | *string*                                                                      | :heavy_check_mark:                                                            | Name of the ledger                                                            |
| `Name`                                                                        | *string*                                                                      | :heavy_check_mark:                                                            | Name of the numscript, URL-encoded as one path segment. Decoded exactly once. |
| `SaveNumscriptRequest`                                                        | [SaveNumscriptRequest](../../Models/LedgerV3/SaveNumscriptRequest.md)         | :heavy_check_mark:                                                            | N/A                                                                           |

### Response

**[V3SaveNumscriptResponse](../../Models/Requests/V3SaveNumscriptResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListNumscriptVersions

Returns the numscript's history: its current latest (greatest stored
semver) and every stored version, highest-first.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListNumscriptVersions" method="get" path="/api/ledger/v3/{ledgerName}/numscripts/{name}/versions" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.ListNumscriptVersionsAsync(
    security: new V3ListNumscriptVersionsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    name: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3ListNumscriptVersionsSecurity](../../Models/Requests/V3ListNumscriptVersionsSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `Name`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the numscript, URL-encoded as one path segment. Decoded exactly once.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3ListNumscriptVersionsResponse](../../Models/Requests/V3ListNumscriptVersionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetNumscriptUsage

Returns the invocation counter and last-used timestamp for a Numscript template. Values are
materialised asynchronously by the `usagebuilder` subsystem from the FSM audit chain and may
lag the live FSM while the worker drains pending batches. A never-invoked template returns a
zero-valued response (not 404), so clients handle "never used" uniformly.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetNumscriptUsage" method="get" path="/api/ledger/v3/{ledgerName}/numscripts/{name}/usage" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetNumscriptUsageAsync(
    security: new V3GetNumscriptUsageSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    name: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetNumscriptUsageSecurity](../../Models/Requests/V3GetNumscriptUsageSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `Name`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the numscript template, URL-encoded as one path segment. Decoded exactly once.                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetNumscriptUsageResponse](../../Models/Requests/V3GetNumscriptUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## BulkOperations

Execute multiple operations (create transactions, add metadata,
revert transactions, delete metadata) in a single request. Requires
`ledger:write` scope.

With `atomic=true`, all elements target the URL's ledger and are
submitted as one batch. `Idempotency-Key` identifies that whole batch;
per-element `ik` values are ignored. With `atomic=false`
(default), each element is submitted separately under its own
`ik`; the header is ignored.

`continueOnFailure` controls sequential continuation and business-error
status rollup. It does not allow partial application of an atomic
batch. Non-atomic failures can follow already committed elements:
inspect every result and preserve the original identities when retrying.
A timeout or infrastructure failure does not prove that work was not
committed. This contract does not enable automatic SDK retries.

The response status is decided in three tiers:

1. **Request-level failures** (before per-element processing):
   malformed body → `400`, missing/insufficient scope → `401` or
   `403`, too many elements → `413`. Exceeding the byte limit while
   decoding the body currently returns `400`.
   Returned unconditionally, `continueOnFailure` does not apply.
2. **Infrastructure failures during processing** (transport
   timeout, cache-horizon exceeded, storage error): the overall
   status is `503` for retryable failures and `500` otherwise,
   regardless of `continueOnFailure`. Callers
   must inspect the element outcomes before deciding what to retry.
3. **Per-element errors during processing**: each element's error
   carries the HTTP status it would surface as a single request
   (via the same mapping `handleError` uses). The top-level
   status is the "worst" of them, with `continueOnFailure`
   applying only to per-element business failures (4xx):
   - Business failures (validation, not-found, conflict,
     precondition — 4xx, except authentication/permission): rolled up per
     `continueOnFailure`. `true` → `200`; `false` (default) →
     the highest 4xx among failing elements (typically `400`).
   - Authentication and permission failures: `401`/`403`, regardless
     of `continueOnFailure`, with all processing outcomes retained.
   - Resource exhaustion (`KindResourceExhausted`, `429`), including
     rate limits and permanent authoritative-sequence exhaustion:
     surface unconditionally as `429`.
   - Retryable infrastructure failures (leader loss,
     cache-horizon exceeded, `KindUnavailable`): surface as
     `503` with `Retry-After: 1`, regardless of
     `continueOnFailure`.
   - Non-retryable infrastructure failures (transport / storage
     errors, `KindInternal`, unclassified): surface as `500`.
   - Aborted elements (`context.Canceled` from the sequential
     runner after a prior failure): contribute nothing — the
     originating error drives the rollup.
Signed requests use `application/json` (including MIME parameters) with
`request` and standard-base64 `payload`. Either signing header, even if
empty, selects this wrapper; with neither header present, the ordinary REST body applies.
Runtime headers choose the representation from the documented anyOf.
The signed protobuf batch must
equal the route/body/Idempotency-Key-derived batch in full. Supply exactly
one nonempty Formance-Signing-Key-Id and Formance-Signature header; the
latter is a standard-base64 Ed25519 signature of 64 decoded bytes. Missing,
empty or repeated signing headers, invalid base64 and wrong signature
length return 400. Signing headers with a non-JSON or missing content type return 415.
Signature enforcement
returns 401 `UNAUTHENTICATED` when required but absent and 403
`PERMISSION_DENIED` for invalid, unknown/revoked-key or mismatched
signatures. Malformed signed envelopes return 400. The complete
wrapper counts toward the 4 MiB body limit. JWT scopes still apply.
Signing requires a nonempty array and `atomic=true` (otherwise 400).
The header key applies; per-element `ik` is ignored. Authentication
and permission failures remain 401/403 even with continueOnFailure;
processing errors preserve every element outcome.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3BulkOperations" method="post" path="/api/ledger/v3/{ledgerName}/bulk" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance();

V3BulkOperationsRequest req = new V3BulkOperationsRequest() {
    FormanceBigintAsString = "true",
    LedgerName = "<value>",
    RequestBody = V3BulkOperationsRequestBody.CreateArrayOfBulkElement(
        new List<BulkElement>() {
            new BulkElement() {
                Action = Action.RevertTransaction,
                Data = BulkElementData.CreateRevertTransactionRequest(
                    new FormanceSDK.Models.LedgerV3.RevertTransactionRequest() {
                        Id = 725647,
                    }
                ),
            },
        }
    ),
};

var res = await sdk.Ledger.V3.BulkOperationsAsync(
    security: new V3BulkOperationsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [V3BulkOperationsRequest](../../Models/Requests/V3BulkOperationsRequest.md)   | :heavy_check_mark:                                                            | The request object to use for the request.                                    |
| `security`                                                                    | [V3BulkOperationsSecurity](../../Models/Requests/V3BulkOperationsSecurity.md) | :heavy_check_mark:                                                            | The security requirements to use for the request.                             |

### Response

**[V3BulkOperationsResponse](../../Models/Requests/V3BulkOperationsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CreatePreparedQuery

Creates a new prepared query for a ledger. A prepared query defines a reusable
filter that can be executed later with parameter substitution. Requires `ledger:WriteQuery` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreatePreparedQuery" method="post" path="/api/ledger/v3/{ledgerName}/prepared-queries" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.CreatePreparedQueryAsync(
    security: new V3CreatePreparedQuerySecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    createPreparedQueryRequest: new CreatePreparedQueryRequest() {
        Name = "<value>",
        Target = Target.Accounts,
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `security`                                                                              | [V3CreatePreparedQuerySecurity](../../Models/Requests/V3CreatePreparedQuerySecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |
| `LedgerName`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | Name of the ledger                                                                      |
| `CreatePreparedQueryRequest`                                                            | [CreatePreparedQueryRequest](../../Models/LedgerV3/CreatePreparedQueryRequest.md)       | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `IdempotencyKey`                                                                        | *string*                                                                                | :heavy_minus_sign:                                                                      | Idempotency key for the request                                                         |

### Response

**[V3CreatePreparedQueryResponse](../../Models/Requests/V3CreatePreparedQueryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListPreparedQueries

Returns a list of all prepared queries for a ledger. Requires `ledger:ReadQuery` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListPreparedQueries" method="get" path="/api/ledger/v3/{ledgerName}/prepared-queries" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.ListPreparedQueriesAsync(
    security: new V3ListPreparedQueriesSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3ListPreparedQueriesSecurity](../../Models/Requests/V3ListPreparedQueriesSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3ListPreparedQueriesResponse](../../Models/Requests/V3ListPreparedQueriesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## UpdatePreparedQuery

Updates the filter of an existing prepared query. Requires `ledger:WriteQuery` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3UpdatePreparedQuery" method="put" path="/api/ledger/v3/{ledgerName}/prepared-queries/{queryName}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.UpdatePreparedQueryAsync(
    security: new V3UpdatePreparedQuerySecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    queryName: "<value>",
    updatePreparedQueryRequest: new UpdatePreparedQueryRequest() {}
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `security`                                                                              | [V3UpdatePreparedQuerySecurity](../../Models/Requests/V3UpdatePreparedQuerySecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |
| `LedgerName`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | Name of the ledger                                                                      |
| `QueryName`                                                                             | *string*                                                                                | :heavy_check_mark:                                                                      | Prepared query name, URL-encoded as one path segment. Decoded exactly once.             |
| `UpdatePreparedQueryRequest`                                                            | [UpdatePreparedQueryRequest](../../Models/LedgerV3/UpdatePreparedQueryRequest.md)       | :heavy_check_mark:                                                                      | N/A                                                                                     |

### Response

**[V3UpdatePreparedQueryResponse](../../Models/Requests/V3UpdatePreparedQueryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DeletePreparedQuery

Deletes a prepared query from a ledger. Requires `ledger:WriteQuery` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DeletePreparedQuery" method="delete" path="/api/ledger/v3/{ledgerName}/prepared-queries/{queryName}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.DeletePreparedQueryAsync(
    security: new V3DeletePreparedQuerySecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    queryName: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `security`                                                                              | [V3DeletePreparedQuerySecurity](../../Models/Requests/V3DeletePreparedQuerySecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |
| `LedgerName`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | Name of the ledger                                                                      |
| `QueryName`                                                                             | *string*                                                                                | :heavy_check_mark:                                                                      | Prepared query name, URL-encoded as one path segment. Decoded exactly once.             |

### Response

**[V3DeletePreparedQueryResponse](../../Models/Requests/V3DeletePreparedQueryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ExecutePreparedQuery

Executes a prepared query with optional parameter substitution. Supports LIST and
AGGREGATE_VOLUMES modes. LIST uses cursor pagination with an effective page size
of 100 when omitted or zero, capped at 1000 before collecting and enriching rows.
AGGREGATE_VOLUMES ignores pageSize and aggregates all matching accounts. Also
accepts pageSize, cursor and reverse as query parameters. Supplied pageSize and
reverse values, and nonempty cursor values, override the body. Requires `ledger:ReadQuery` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ExecutePreparedQuery" method="post" path="/api/ledger/v3/{ledgerName}/prepared-queries/{queryName}/execute" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

V3ExecutePreparedQueryRequest req = new V3ExecutePreparedQueryRequest() {
    FormanceBigintAsString = "true",
    LedgerName = "<value>",
    QueryName = "<value>",
};

var res = await sdk.Ledger.V3.ExecutePreparedQueryAsync(
    security: new V3ExecutePreparedQuerySecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [V3ExecutePreparedQueryRequest](../../Models/Requests/V3ExecutePreparedQueryRequest.md)   | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |
| `security`                                                                                | [V3ExecutePreparedQuerySecurity](../../Models/Requests/V3ExecutePreparedQuerySecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |

### Response

**[V3ExecutePreparedQueryResponse](../../Models/Requests/V3ExecutePreparedQueryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## AddAccountType

Adds a new account type to a ledger's chart of accounts. Account types define
address patterns for account validation. Requires `ledger:WriteMetadata` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3AddAccountType" method="post" path="/api/ledger/v3/{ledgerName}/account-types" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance();

var res = await sdk.Ledger.V3.AddAccountTypeAsync(
    security: new V3AddAccountTypeSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    addAccountTypeRequest: new AddAccountTypeRequest() {
        Name = "user-checking",
        Pattern = "users:{id}:checking",
        Persistence = AddAccountTypeRequestPersistence.Ephemeral,
        SegmentTypes = new Dictionary<string, SegmentType?>() {
            { "id", new SegmentType() {
                Type = SegmentTypeType.Uuid,
            } },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `security`                                                                    | [V3AddAccountTypeSecurity](../../Models/Requests/V3AddAccountTypeSecurity.md) | :heavy_check_mark:                                                            | The security requirements to use for the request.                             |
| `LedgerName`                                                                  | *string*                                                                      | :heavy_check_mark:                                                            | Name of the ledger                                                            |
| `AddAccountTypeRequest`                                                       | [AddAccountTypeRequest](../../Models/LedgerV3/AddAccountTypeRequest.md)       | :heavy_check_mark:                                                            | N/A                                                                           |

### Response

**[V3AddAccountTypeResponse](../../Models/Requests/V3AddAccountTypeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListAccountTypes

Returns all account types defined on a ledger, sorted by name.
Requires `ledger:ReadAccount` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListAccountTypes" method="get" path="/api/ledger/v3/{ledgerName}/account-types" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.ListAccountTypesAsync(
    security: new V3ListAccountTypesSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3ListAccountTypesSecurity](../../Models/Requests/V3ListAccountTypesSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3ListAccountTypesResponse](../../Models/Requests/V3ListAccountTypesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## SetDefaultEnforcementMode

Sets the default enforcement mode for accounts that do not match any defined
account type. Must be STRICT or AUDIT. STRICT rejects an order that uses an
unmatched account with `400 ACCOUNT_NOT_MATCHING_TYPE`. AUDIT accepts the
order and does not report the unmatched account: the response carries no
warning. Requires `ledger:WriteMetadata` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3SetDefaultEnforcementMode" method="put" path="/api/ledger/v3/{ledgerName}/account-types/default-enforcement-mode" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.SetDefaultEnforcementModeAsync(
    security: new V3SetDefaultEnforcementModeSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    setDefaultEnforcementModeRequest: new SetDefaultEnforcementModeRequest() {
        EnforcementMode = EnforcementMode.Audit,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [V3SetDefaultEnforcementModeSecurity](../../Models/Requests/V3SetDefaultEnforcementModeSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `LedgerName`                                                                                        | *string*                                                                                            | :heavy_check_mark:                                                                                  | Name of the ledger                                                                                  |
| `SetDefaultEnforcementModeRequest`                                                                  | [SetDefaultEnforcementModeRequest](../../Models/LedgerV3/SetDefaultEnforcementModeRequest.md)       | :heavy_check_mark:                                                                                  | N/A                                                                                                 |

### Response

**[V3SetDefaultEnforcementModeResponse](../../Models/Requests/V3SetDefaultEnforcementModeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetAccountType

Retrieves a specific account type by name from a ledger. Requires `ledger:ReadAccount` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetAccountType" method="get" path="/api/ledger/v3/{ledgerName}/account-types/{typeName}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetAccountTypeAsync(
    security: new V3GetAccountTypeSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    typeName: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetAccountTypeSecurity](../../Models/Requests/V3GetAccountTypeSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `TypeName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Account type name, URL-encoded as one path segment. Decoded exactly once.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetAccountTypeResponse](../../Models/Requests/V3GetAccountTypeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## RemoveAccountType

Removes an account type from a ledger's chart of accounts. Requires `ledger:WriteMetadata` scope.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3RemoveAccountType" method="delete" path="/api/ledger/v3/{ledgerName}/account-types/{typeName}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.RemoveAccountTypeAsync(
    security: new V3RemoveAccountTypeSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    typeName: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `security`                                                                          | [V3RemoveAccountTypeSecurity](../../Models/Requests/V3RemoveAccountTypeSecurity.md) | :heavy_check_mark:                                                                  | The security requirements to use for the request.                                   |
| `LedgerName`                                                                        | *string*                                                                            | :heavy_check_mark:                                                                  | Name of the ledger                                                                  |
| `TypeName`                                                                          | *string*                                                                            | :heavy_check_mark:                                                                  | Account type name, URL-encoded as one path segment. Decoded exactly once.           |

### Response

**[V3RemoveAccountTypeResponse](../../Models/Requests/V3RemoveAccountTypeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetLog

Returns the system log entry with the given bucket-wide sequence number.
Requires `ledger:ReadOps` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetLog" method="get" path="/api/ledger/v3/_/logs/{sequence}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetLogAsync(
    security: new V3GetLogSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    sequence: 593519,
    xConsistency: Consistency.Linearizable,
    formanceBigintAsString: "true"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Example                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | [V3GetLogSecurity](../../Models/Requests/V3GetLogSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `Sequence`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | *long*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/>                        |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| `FormanceBigintAsString`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Render all response Uint256, BigUint and SignedBigInt values as canonical<br/>decimal strings, regardless of business meaning, including posting<br/>amounts, volume input/output and balances. Ordinary integer IDs/counts,<br/>metadata and explicitly string-encoded counters keep their existing<br/>representation. Case-insensitive true, yes, y and 1 enable<br/>this option, matching Ledger v2. Whitespace is not trimmed. Omission and<br/>every other value retain JSON number tokens. This affects only this<br/>response, including nested objects, maps, arrays, transaction/log/cursor<br/>and bulk results. Request decoding is unchanged.<br/> | true                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |

### Response

**[V3GetLogResponse](../../Models/Requests/V3GetLogResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetEventsSinks

Returns every event sink configured on the cluster. Requires
`ledger:ReadOps` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetEventsSinks" method="get" path="/api/ledger/v3/_/events-sinks" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetEventsSinksAsync(
    security: new V3GetEventsSinksSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetEventsSinksSecurity](../../Models/Requests/V3GetEventsSinksSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetEventsSinksResponse](../../Models/Requests/V3GetEventsSinksResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## RemoveEventsSink

Removes a named event sink from the cluster. Requires `ledger:WriteOps`
scope. A non-empty controllerId must match the sink's controllerId;
a mismatch returns `SINK_CONTROLLER_MISMATCH` (409). An omitted or empty
controllerId removes the sink without an ownership precondition.
A missing sink returns `SINK_NOT_FOUND` (404). Malformed query encoding
or repeated controllerId parameters return `INVALID_REQUEST` (400)
before Apply, instead of becoming unconditional removal.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3RemoveEventsSink" method="delete" path="/api/ledger/v3/_/events-sinks/{sinkName}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.RemoveEventsSinkAsync(
    security: new V3RemoveEventsSinkSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    sinkName: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `security`                                                                        | [V3RemoveEventsSinkSecurity](../../Models/Requests/V3RemoveEventsSinkSecurity.md) | :heavy_check_mark:                                                                | The security requirements to use for the request.                                 |
| `SinkName`                                                                        | *string*                                                                          | :heavy_check_mark:                                                                | Name of the event sink to remove                                                  |
| `ControllerId`                                                                    | *string*                                                                          | :heavy_minus_sign:                                                                | Optional opaque owner identity used as a removal precondition                     |
| `IdempotencyKey`                                                                  | *string*                                                                          | :heavy_minus_sign:                                                                | Idempotency key for the request                                                   |

### Response

**[V3RemoveEventsSinkResponse](../../Models/Requests/V3RemoveEventsSinkResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListSigningKeys

Lists the Ed25519 signing keys registered on the cluster, paged by key
id (ascending unless `reverse=true`). Requires `ledger:ReadOps` scope.

This route performs a live read, linearizable by default.
`X-Consistency: stale` reads the receiving node's local state, which
may lag the leader. Signing-key reads are live-only on both transports.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListSigningKeys" method="get" path="/api/ledger/v3/_/signing-keys" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.ListSigningKeysAsync(
    security: new V3ListSigningKeysSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    xConsistency: Consistency.Linearizable,
    pageSize: 100,
    reverse: false
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3ListSigningKeysSecurity](../../Models/Requests/V3ListSigningKeysSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |
| `PageSize`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | *long*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Maximum number of items per page. 0 or absent means 100; values above 1000 are clamped to 1000.                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| `Cursor`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Page token from a previous response's `next` or `previous` field (see<br/>the `PageToken` schema). Omit for the first page. Pass the same<br/>`reverse` and `filter` on every page of a walk.<br/>                                                                                                                                                                                                                                                                                                                                                                   |
| `Reverse`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | *bool*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | List in descending key id order when true.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |

### Response

**[V3ListSigningKeysResponse](../../Models/Requests/V3ListSigningKeysResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListBucketIndexes

Streams the bucket-scoped index registry. The `scope` query parameter
selects the flavor: `all` (default, matches the ListIndexesRequest
proto default) streams every entry across ledgers, skipping orphan
entries whose owning ledger no longer exists; `bucket` surfaces only
bucket-scoped entries (empty ledger, e.g. audit indexes). Use
`GET /v3/{ledgerName}/indexes` for the per-ledger view. Requires
`ledger:ReadOps` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListBucketIndexes" method="get" path="/api/ledger/v3/_/indexes" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.ListBucketIndexesAsync(
    security: new V3ListBucketIndexesSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    xConsistency: Consistency.Linearizable,
    scope: Scope.All
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3ListBucketIndexesSecurity](../../Models/Requests/V3ListBucketIndexesSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |
| `Scope`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | [Scope](../../Models/Requests/Scope.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |

### Response

**[V3ListBucketIndexesResponse](../../Models/Requests/V3ListBucketIndexesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetBucketIndex

Returns the `Index` registry entry for a bucket-scoped index
(`Ledger == ""`, e.g. audit indexes). Ledger-scoped lookups go
through `GET /v3/{ledgerName}/indexes/{canonicalId}` — the two
keyspaces are distinct so a bucket-scoped lookup with the same
canonical will NotFound if only the ledger-scoped entry exists.
Requires `ledger:ReadOps` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetBucketIndex" method="get" path="/api/ledger/v3/_/indexes/{canonicalId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetBucketIndexAsync(
    security: new V3GetBucketIndexSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    canonicalId: "<id>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetBucketIndexSecurity](../../Models/Requests/V3GetBucketIndexSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `CanonicalId`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Canonical form of the target IndexID.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetBucketIndexResponse](../../Models/Requests/V3GetBucketIndexResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetBucketIndexEntryStatus

Returns the `IndexEntry` (registry entry + backfill cursor +
per-replica IndexVersionState) for a bucket-scoped index.
Requires `ledger:ReadOps` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetBucketIndexEntryStatus" method="get" path="/api/ledger/v3/_/indexes/{canonicalId}/status" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetBucketIndexEntryStatusAsync(
    security: new V3GetBucketIndexEntryStatusSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    canonicalId: "<id>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetBucketIndexEntryStatusSecurity](../../Models/Requests/V3GetBucketIndexEntryStatusSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `CanonicalId`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Canonical form of the target IndexID.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetBucketIndexEntryStatusResponse](../../Models/Requests/V3GetBucketIndexEntryStatusResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetIndexStatus

Returns the aggregated index registry status: per-index backfill cursor,
per-replica IndexVersionState (current/pending), and cluster-wide
counters (LastIndexedSequence, LastLogSequence, Lag, IndexFileSize).
The optional `ledger` query parameter narrows the per-index entries to
a single ledger; the aggregated counters always cover the bucket.
Requires `ledger:ReadOps` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetIndexStatus" method="get" path="/api/ledger/v3/_/indexes/status" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetIndexStatusAsync(
    security: new V3GetIndexStatusSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetIndexStatusSecurity](../../Models/Requests/V3GetIndexStatusSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |
| `Ledger`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | N/A                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |

### Response

**[V3GetIndexStatusResponse](../../Models/Requests/V3GetIndexStatusResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListLedgerIndexes

Streams the indexes registered on a specific ledger. Requires
`ledger:ReadLedger` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3ListLedgerIndexes" method="get" path="/api/ledger/v3/{ledgerName}/indexes" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.ListLedgerIndexesAsync(
    security: new V3ListLedgerIndexesSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3ListLedgerIndexesSecurity](../../Models/Requests/V3ListLedgerIndexesSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3ListLedgerIndexesResponse](../../Models/Requests/V3ListLedgerIndexesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CreateIndex

Registers a new index on the ledger. An existing canonical index on
this ledger is rejected with `INDEX_ALREADY_EXISTS` (HTTP 409), even
while building or retyping, without changing its definition or progress.
Replaying an identical batch with its retained `Idempotency-Key` returns
the original result. The indexbuilder processes the accepted creation.
The request body carries the target `IndexID` in
canonical form (see `DELETE /v3/{ledgerName}/indexes/{canonicalId}`
for the format). Requires `ledger:WriteLedger` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3CreateIndex" method="post" path="/api/ledger/v3/{ledgerName}/indexes" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.CreateIndexAsync(
    security: new V3CreateIndexSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    requestBody: new V3CreateIndexRequestBody() {
        Id = "metadata:TARGET_TYPE_ACCOUNT:color",
    }
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `security`                                                                    | [V3CreateIndexSecurity](../../Models/Requests/V3CreateIndexSecurity.md)       | :heavy_check_mark:                                                            | The security requirements to use for the request.                             |
| `LedgerName`                                                                  | *string*                                                                      | :heavy_check_mark:                                                            | Name of the ledger                                                            |
| `RequestBody`                                                                 | [V3CreateIndexRequestBody](../../Models/Requests/V3CreateIndexRequestBody.md) | :heavy_check_mark:                                                            | N/A                                                                           |
| `IdempotencyKey`                                                              | *string*                                                                      | :heavy_minus_sign:                                                            | N/A                                                                           |

### Response

**[V3CreateIndexResponse](../../Models/Requests/V3CreateIndexResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetIndex

Returns the `Index` registry entry (id, ledger, createdAt,
forwardEncodingVersion) for a single index, serialized in
protobuf-JSON camelCase. Requires `ledger:ReadLedger` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetIndex" method="get" path="/api/ledger/v3/{ledgerName}/indexes/{canonicalId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetIndexAsync(
    security: new V3GetIndexSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    canonicalId: "<id>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetIndexSecurity](../../Models/Requests/V3GetIndexSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `CanonicalId`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Canonical form of the target IndexID.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetIndexResponse](../../Models/Requests/V3GetIndexResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DropIndex

Removes an index from a ledger. The path parameter carries the target
`IndexID` in canonical form (e.g. `metadata:TARGET_TYPE_ACCOUNT:color`,
`tx_builtin:TX_BUILTIN_INDEX_TIMESTAMP`). Requires `ledger:WriteLedger` scope.

The drop is idempotent. An `IndexID` that has no registry entry on the
ledger (never created, or already dropped) also answers `204`, and each
committed drop appends a `DROP_INDEX` entry to the ledger log. A
mistyped canonical id is therefore not reported; read the index with
`GET /v3/{ledgerName}/indexes/{canonicalId}` first when the caller must
know that it exists. `404` means that the ledger does not exist.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3DropIndex" method="delete" path="/api/ledger/v3/{ledgerName}/indexes/{canonicalId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.DropIndexAsync(
    security: new V3DropIndexSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    canonicalId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `security`                                                          | [V3DropIndexSecurity](../../Models/Requests/V3DropIndexSecurity.md) | :heavy_check_mark:                                                  | The security requirements to use for the request.                   |
| `LedgerName`                                                        | *string*                                                            | :heavy_check_mark:                                                  | Name of the ledger                                                  |
| `CanonicalId`                                                       | *string*                                                            | :heavy_check_mark:                                                  | Canonical form of the target IndexID.                               |
| `IdempotencyKey`                                                    | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |

### Response

**[V3DropIndexResponse](../../Models/Requests/V3DropIndexResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetIndexEntryStatus

Returns the `IndexEntry` for a single index — the registry entry
joined with the backfill cursor and the per-replica
IndexVersionState (current + pending version). Use this to poll
for backfill completion after a `POST /v3/{ledgerName}/indexes`.
Requires `ledger:ReadLedger` scope.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3GetIndexEntryStatus" method="get" path="/api/ledger/v3/{ledgerName}/indexes/{canonicalId}/status" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.LedgerV3;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.GetIndexEntryStatusAsync(
    security: new V3GetIndexEntryStatusSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    ledgerName: "<value>",
    canonicalId: "<id>",
    xConsistency: Consistency.Linearizable
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | [V3GetIndexEntryStatusSecurity](../../Models/Requests/V3GetIndexEntryStatusSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `LedgerName`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Name of the ledger                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `CanonicalId`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Canonical form of the target IndexID.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `XConsistency`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | [Consistency](../../Models/LedgerV3/Consistency.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Read consistency. `linearizable` (the default) runs a Raft ReadIndex<br/>barrier and waits for the receiving node to apply up to it. `stale`<br/>serves the read from the receiving node's own store, with no barrier<br/>and no forwarding to the leader, so the answer may lag the leader.<br/>Matching ignores case and surrounding whitespace. An unknown value, or a<br/>repeated or comma-joined header, returns `400 INVALID_REQUEST` on every<br/>`/v3` route, writes included; a valid value has no effect on writes. The<br/>gRPC equivalent is the `x-consistency` request metadata.<br/> |

### Response

**[V3GetIndexEntryStatusResponse](../../Models/Requests/V3GetIndexEntryStatusResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## Info

Returns the server build metadata (version, commit, build date, Go runtime version). Unauthenticated.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="v3Info" method="get" path="/api/ledger/_info#ledgerV3" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Ledger.V3.InfoAsync(security: new V3InfoSecurity() {
    BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
});

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `security`                                                | [V3InfoSecurity](../../Models/Requests/V3InfoSecurity.md) | :heavy_check_mark:                                        | The security requirements to use for the request.         |

### Response

**[V3InfoResponse](../../Models/Requests/V3InfoResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |