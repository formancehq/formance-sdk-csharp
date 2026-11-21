# Connectivity.V1

## Overview

### Available Operations

* [GetQueryCapabilities](#getquerycapabilities) - The filterable keys, operators and value enums per resource
* [Healthcheck](#healthcheck) - Health probe
* [ConnectivityInfo](#connectivityinfo) - Build information
* [ListConnectors](#listconnectors) - List published Connectors with their catalogue identity
* [GetConnectorFacets](#getconnectorfacets) - Facet-value distribution over the published catalogue
* [GetConnector](#getconnector) - Get a Connector (lean connector metadata)
* [ListConnectorVersions](#listconnectorversions) - List the installable versions of a Connector
* [GetConnectorVersion](#getconnectorversion) - Get one Connector version (including its configSchema and additionalMetadata)
* [ListConnections](#listconnections) - List connector instances for this tenant
* [CreateConnection](#createconnection) - Create a Connection
* [GetConnection](#getconnection) - Get a Connection
* [ReplaceConnection](#replaceconnection) - Replace a connector instance configuration
* [PatchConnection](#patchconnection) - Merge-patch a connector instance configuration
* [DeleteConnection](#deleteconnection) - Delete a Connection

## GetQueryCapabilities

Serialized from the same allowlist the server enforces on `?query=`,
so a UI can build its filter bar dynamically and never drift from
what the API accepts.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="getQueryCapabilities" method="get" path="/api/connectivity/_query/capabilities" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.GetQueryCapabilitiesAsync(security: new GetQueryCapabilitiesSecurity() {
    BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `security`                                                                            | [GetQueryCapabilitiesSecurity](../../Models/Requests/GetQueryCapabilitiesSecurity.md) | :heavy_check_mark:                                                                    | The security requirements to use for the request.                                     |

### Response

**[GetQueryCapabilitiesResponse](../../Models/Requests/GetQueryCapabilitiesResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## Healthcheck

Single health endpoint, probed by the stack gateway for the `/versions`
aggregation and by service readiness/liveness probes. Ready
means the service can reach its storage dependency.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="healthcheck" method="get" path="/api/connectivity/_healthcheck" -->
```csharp
using FormanceSDK;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.HealthcheckAsync();

// handle response
```

### Response

**[HealthcheckResponse](../../Models/Requests/HealthcheckResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| FormanceSDK.Models.Connectivity.HealthError | 500                                         | application/json                            |
| FormanceSDK.Models.Connectivity.Error       | 4XX                                         | application/json                            |
| FormanceSDK.Models.Connectivity.Error       | 5XX                                         | application/json                            |

## ConnectivityInfo

Version probe used by the stack gateway to report this module in the
`/versions` aggregation. Response shape follows the platform-wide
ServiceInfo contract.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="connectivityInfo" method="get" path="/api/connectivity/_info" -->
```csharp
using FormanceSDK;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.ConnectivityInfoAsync();

// handle response
```

### Response

**[ConnectivityInfoResponse](../../Models/Requests/ConnectivityInfoResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## ListConnectors

Returns the published `Connector`s, each carrying the identity of its
newest Validated version (branding, tagline, tags, `latestVersion`) so
a catalogue UI renders and filters from this single request.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="listConnectors" method="get" path="/api/connectivity/connectors" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.ListConnectorsAsync(
    security: new ListConnectorsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    pageSize: 15
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | [ListConnectorsSecurity](../../Models/Requests/ListConnectorsSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| `Query`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | JSON-encoded filter in the go-libs query dialect: boolean nodes<br/>`$and`/`$or`/`$not` over leaves `$match`/`$in`/`$exists`/`$like`/<br/>`$gt`/`$gte`/`$lt`/`$lte`, each leaf `{"$op": {"key": value}}`.<br/>The filterable keys, their operators and value enums are exactly the<br/>ones served by `GET /_query/capabilities` for the queried resource;<br/>anything else is rejected with `400 invalid_query`. `$like` uses SQL<br/>wildcards (`%`, `_`). Beware negation over absent fields: `$not` on a<br/>`$match` also selects objects where the key is absent -- conjoin with<br/>`$exists` when that matters.<br/>Examples by collection: `/connectors` accepts `{"$match":{"catalog":"ee"}}`;<br/>`/connectors/{name}/versions` accepts `{"$match":{"version":"v1.0.0"}}`;<br/>`/connections` accepts `{"$match":{"connector":"bitcoin"}}`.<br/> |
| `PageSize`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | *int*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Page size (1-100, default 15)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `Cursor`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Opaque cursor from a previous response's `cursor.next`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |

### Response

**[ListConnectorsResponse](../../Models/Requests/ListConnectorsResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## GetConnectorFacets

Counts distinct published `Connector`s per `facet:value` tag (split on
the first `:`; flat tags carry no facet and are excluded), narrowed by
the same `query` filter as the list. `_facets` can never collide with
a connector: names are DNS labels, which cannot contain `_`.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="getConnectorFacets" method="get" path="/api/connectivity/connectors/_facets" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.GetConnectorFacetsAsync(security: new GetConnectorFacetsSecurity() {
    BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | [GetConnectorFacetsSecurity](../../Models/Requests/GetConnectorFacetsSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| `Query`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | JSON-encoded filter in the go-libs query dialect: boolean nodes<br/>`$and`/`$or`/`$not` over leaves `$match`/`$in`/`$exists`/`$like`/<br/>`$gt`/`$gte`/`$lt`/`$lte`, each leaf `{"$op": {"key": value}}`.<br/>The filterable keys, their operators and value enums are exactly the<br/>ones served by `GET /_query/capabilities` for the queried resource;<br/>anything else is rejected with `400 invalid_query`. `$like` uses SQL<br/>wildcards (`%`, `_`). Beware negation over absent fields: `$not` on a<br/>`$match` also selects objects where the key is absent -- conjoin with<br/>`$exists` when that matters.<br/>Examples by collection: `/connectors` accepts `{"$match":{"catalog":"ee"}}`;<br/>`/connectors/{name}/versions` accepts `{"$match":{"version":"v1.0.0"}}`;<br/>`/connections` accepts `{"$match":{"connector":"bitcoin"}}`.<br/> |

### Response

**[GetConnectorFacetsResponse](../../Models/Requests/GetConnectorFacetsResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## GetConnector

Get a Connector (lean connector metadata)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getConnector" method="get" path="/api/connectivity/connectors/{name}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.GetConnectorAsync(
    security: new GetConnectorSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    name: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `security`                                                            | [GetConnectorSecurity](../../Models/Requests/GetConnectorSecurity.md) | :heavy_check_mark:                                                    | The security requirements to use for the request.                     |
| `Name`                                                                | *string*                                                              | :heavy_check_mark:                                                    | Published connector name                                              |

### Response

**[GetConnectorResponse](../../Models/Requests/GetConnectorResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## ListConnectorVersions

Returns the `ConnectorVersion`s published for this Connector, sorted
ascending by semantic version. Use `configuration.version` to pin a Connection,
or `configuration.channel` to track a maturity channel.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="listConnectorVersions" method="get" path="/api/connectivity/connectors/{name}/versions" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.ListConnectorVersionsAsync(
    security: new ListConnectorVersionsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    name: "<value>",
    pageSize: 15
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | [ListConnectorVersionsSecurity](../../Models/Requests/ListConnectorVersionsSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| `Name`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Published connector name                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| `Query`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | JSON-encoded filter in the go-libs query dialect: boolean nodes<br/>`$and`/`$or`/`$not` over leaves `$match`/`$in`/`$exists`/`$like`/<br/>`$gt`/`$gte`/`$lt`/`$lte`, each leaf `{"$op": {"key": value}}`.<br/>The filterable keys, their operators and value enums are exactly the<br/>ones served by `GET /_query/capabilities` for the queried resource;<br/>anything else is rejected with `400 invalid_query`. `$like` uses SQL<br/>wildcards (`%`, `_`). Beware negation over absent fields: `$not` on a<br/>`$match` also selects objects where the key is absent -- conjoin with<br/>`$exists` when that matters.<br/>Examples by collection: `/connectors` accepts `{"$match":{"catalog":"ee"}}`;<br/>`/connectors/{name}/versions` accepts `{"$match":{"version":"v1.0.0"}}`;<br/>`/connections` accepts `{"$match":{"connector":"bitcoin"}}`.<br/> |
| `PageSize`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | *int*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Page size (1-100, default 15)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `Cursor`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Opaque cursor from a previous response's `cursor.next`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |

### Response

**[ListConnectorVersionsResponse](../../Models/Requests/ListConnectorVersionsResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## GetConnectorVersion

Get one Connector version (including its configSchema and additionalMetadata)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getConnectorVersion" method="get" path="/api/connectivity/connectors/{name}/versions/{version}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.GetConnectorVersionAsync(
    security: new GetConnectorVersionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    name: "<value>",
    version: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                                                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                                                                                                                                                                                   | [GetConnectorVersionSecurity](../../Models/Requests/GetConnectorVersionSecurity.md)                                                                                                                                                                                                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                            |
| `Name`                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                           | Published connector name                                                                                                                                                                                                                                                                                                                                                                     |
| `Version`                                                                                                                                                                                                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                           | Version string of a ConnectorVersion (e.g. `v1.4.2`), or one of the<br/>reserved aliases -- never valid semver, so they cannot collide:<br/>`latest` (the newest Validated version across all channels) or<br/>`stable`/`rc`/`beta`/`alpha` (that channel's head, resolved with<br/>exactly the rules installation uses). An empty channel answers<br/>`404 channel_empty` naming the newest Validated version.<br/> |

### Response

**[GetConnectorVersionResponse](../../Models/Requests/GetConnectorVersionResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## ListConnections

List connector instances for this tenant

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listConnections" method="get" path="/api/connectivity/connections" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.ListConnectionsAsync(
    security: new ListConnectionsSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    pageSize: 15
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `security`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | [ListConnectionsSecurity](../../Models/Requests/ListConnectionsSecurity.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| `Query`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | JSON-encoded filter in the go-libs query dialect: boolean nodes<br/>`$and`/`$or`/`$not` over leaves `$match`/`$in`/`$exists`/`$like`/<br/>`$gt`/`$gte`/`$lt`/`$lte`, each leaf `{"$op": {"key": value}}`.<br/>The filterable keys, their operators and value enums are exactly the<br/>ones served by `GET /_query/capabilities` for the queried resource;<br/>anything else is rejected with `400 invalid_query`. `$like` uses SQL<br/>wildcards (`%`, `_`). Beware negation over absent fields: `$not` on a<br/>`$match` also selects objects where the key is absent -- conjoin with<br/>`$exists` when that matters.<br/>Examples by collection: `/connectors` accepts `{"$match":{"catalog":"ee"}}`;<br/>`/connectors/{name}/versions` accepts `{"$match":{"version":"v1.0.0"}}`;<br/>`/connections` accepts `{"$match":{"connector":"bitcoin"}}`.<br/> |
| `PageSize`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | *int*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Page size (1-100, default 15)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| `Cursor`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Opaque cursor from a previous response's `cursor.next`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |

### Response

**[ListConnectionsResponse](../../Models/Requests/ListConnectionsResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## CreateConnection

Creates a new `Connection` in the caller's environment.
`configuration.connector`, `configuration.ledger` and exactly one of `configuration.version` or
`configuration.channel` are required. `env` and `files` are string key/value maps;
properties marked `format: password` by the selected connector schema
are stored confidentially and omitted from read responses.
Storage metadata and configuration references are rejected on input.
A field outside the tenant contract,
including unsupported instance fields such as `image`, `additionalEnv`,
`additionalFiles` or `replicas`, is rejected with
`400 unsupported_field`.


### Example Usage: channel

<!-- UsageSnippet language="csharp" operationID="createConnection" method="post" path="/api/connectivity/connections" example="channel" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Connectivity;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance();

ConnectionCreate req = new ConnectionCreate() {
    Name = "stripe-main",
    Configuration = new Configuration() {
        Connector = "stripe",
        Channel = ConnectionCreateChannel.Stable,
        Ledger = "main",
        PollInterval = "30s",
        Env = new Dictionary<string, string>() {
            { "STRIPE_API_KEY", "<your-api-key>" },
        },
    },
};

var res = await sdk.Connectivity.V1.CreateConnectionAsync(
    security: new CreateConnectionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```
### Example Usage: version

<!-- UsageSnippet language="csharp" operationID="createConnection" method="post" path="/api/connectivity/connections" example="version" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Connectivity;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance();

ConnectionCreate req = new ConnectionCreate() {
    Name = "bitcoin-main",
    Configuration = new Configuration() {
        Connector = "bitcoin",
        Version = "v1.4.2",
        Ledger = "btc",
        InitialCursor = "AAAAAAAAA+g=",
        Env = new Dictionary<string, string>() {
            { "RPC_URL", "http://bitcoind:8332" },
        },
        Files = new Dictionary<string, string>() {
            { "/etc/bitcoin/ca.pem", "<PEM certificate content>" },
        },
    },
};

var res = await sdk.Connectivity.V1.CreateConnectionAsync(
    security: new CreateConnectionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ConnectionCreate](../../Models/Connectivity/ConnectionCreate.md)             | :heavy_check_mark:                                                            | The request object to use for the request.                                    |
| `security`                                                                    | [CreateConnectionSecurity](../../Models/Requests/CreateConnectionSecurity.md) | :heavy_check_mark:                                                            | The security requirements to use for the request.                             |

### Response

**[CreateConnectionResponse](../../Models/Requests/CreateConnectionResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## GetConnection

Get a Connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getConnection" method="get" path="/api/connectivity/connections/{name}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.GetConnectionAsync(
    security: new GetConnectionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    name: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `security`                                                              | [GetConnectionSecurity](../../Models/Requests/GetConnectionSecurity.md) | :heavy_check_mark:                                                      | The security requirements to use for the request.                       |
| `Name`                                                                  | *string*                                                                | :heavy_check_mark:                                                      | Instance name within this tenant                                        |

### Response

**[GetConnectionResponse](../../Models/Requests/GetConnectionResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## ReplaceConnection

Full-replace semantics on mutable tenant `configuration`: omitted mutable
fields are cleared. The API does not write fields outside its tenant scope.
`status` is preserved. `connector` and `ledger` are immutable once set:
omission preserves them, first assignment and unchanged values are accepted,
and changes or null return `422 connector_immutable` or `422 ledger_immutable`. Read responses omit reference-backed entries,
so PUT must supply the complete configuration, including required secrets.
Use PATCH to preserve omitted configuration. Fields outside the tenant contract are rejected with
`400 unsupported_field`.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="replaceConnection" method="put" path="/api/connectivity/connections/{name}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Connectivity;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.ReplaceConnectionAsync(
    security: new ReplaceConnectionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    name: "<value>",
    connectionUpdate: new ConnectionUpdate() {
        Configuration = new ConnectionConfiguration() {},
    }
);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `security`                                                                      | [ReplaceConnectionSecurity](../../Models/Requests/ReplaceConnectionSecurity.md) | :heavy_check_mark:                                                              | The security requirements to use for the request.                               |
| `Name`                                                                          | *string*                                                                        | :heavy_check_mark:                                                              | Instance name within this tenant                                                |
| `ConnectionUpdate`                                                              | [ConnectionUpdate](../../Models/Connectivity/ConnectionUpdate.md)               | :heavy_check_mark:                                                              | Encoded request body must not exceed 1 MiB (1,048,576 bytes).                   |

### Response

**[ReplaceConnectionResponse](../../Models/Requests/ReplaceConnectionResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## PatchConnection

JSON merge patch (RFC 7396) over tenant `configuration` fields only. Other fields
are rejected with `400 unsupported_field`. `env` and `files` are string
maps: omitted entries are preserved, including secret-backed values;
`null` deletes a field or map entry. A supplied literal replaces the
stored source. `connector` and `ledger` are not PATCH fields: any presence, including
unchanged values and null, returns `400 unsupported_field`. The merged
result must retain exactly one of `version` and `channel`, so
switching selectors sends `null` for the other one.


### Example Usage: rotatePassword

<!-- UsageSnippet language="csharp" operationID="patchConnection" method="patch" path="/api/connectivity/connections/{name}" example="rotatePassword" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Connectivity;
using FormanceSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.PatchConnectionAsync(
    security: new PatchConnectionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    name: "<value>",
    connectionPatch: new ConnectionPatch() {
        Configuration = new ConnectionPatchConfiguration() {
            Env = new Dictionary<string, string?>() {
                { "STRIPE_API_KEY", "<new-api-key>" },
            },
        },
    }
);

// handle response
```
### Example Usage: suspend

<!-- UsageSnippet language="csharp" operationID="patchConnection" method="patch" path="/api/connectivity/connections/{name}" example="suspend" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Connectivity;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.PatchConnectionAsync(
    security: new PatchConnectionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    name: "<value>",
    connectionPatch: new ConnectionPatch() {
        Configuration = new ConnectionPatchConfiguration() {
            Suspend = true,
        },
    }
);

// handle response
```
### Example Usage: switchToChannel

<!-- UsageSnippet language="csharp" operationID="patchConnection" method="patch" path="/api/connectivity/connections/{name}" example="switchToChannel" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Connectivity;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.PatchConnectionAsync(
    security: new PatchConnectionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    name: "<value>",
    connectionPatch: new ConnectionPatch() {
        Configuration = new ConnectionPatchConfiguration() {
            Version = null,
            Channel = ConnectionPatchChannel.Stable,
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `security`                                                                  | [PatchConnectionSecurity](../../Models/Requests/PatchConnectionSecurity.md) | :heavy_check_mark:                                                          | The security requirements to use for the request.                           |
| `Name`                                                                      | *string*                                                                    | :heavy_check_mark:                                                          | Instance name within this tenant                                            |
| `ConnectionPatch`                                                           | [ConnectionPatch](../../Models/Connectivity/ConnectionPatch.md)             | :heavy_check_mark:                                                          | Encoded request body must not exceed 1 MiB (1,048,576 bytes).               |

### Response

**[PatchConnectionResponse](../../Models/Requests/PatchConnectionResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |

## DeleteConnection

Delete a Connection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteConnection" method="delete" path="/api/connectivity/connections/{name}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Requests;

var sdk = new Formance();

var res = await sdk.Connectivity.V1.DeleteConnectionAsync(
    security: new DeleteConnectionSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    name: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `security`                                                                    | [DeleteConnectionSecurity](../../Models/Requests/DeleteConnectionSecurity.md) | :heavy_check_mark:                                                            | The security requirements to use for the request.                             |
| `Name`                                                                        | *string*                                                                      | :heavy_check_mark:                                                            | Instance name within this tenant                                              |

### Response

**[DeleteConnectionResponse](../../Models/Requests/DeleteConnectionResponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| FormanceSDK.Models.Connectivity.Error | 4XX                                   | application/json                      |
| FormanceSDK.Models.Connectivity.Error | 5XX                                   | application/json                      |