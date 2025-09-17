# V1
(*Auth.V1*)

## Overview

### Available Operations

* [GetOIDCWellKnowns](#getoidcwellknowns) - Retrieve OpenID connect well-knowns.
* [GetServerInfo](#getserverinfo) - Get server info
* [ListClients](#listclients) - List clients
* [CreateClient](#createclient) - Create client
* [ReadClient](#readclient) - Read client
* [UpdateClient](#updateclient) - Update client
* [DeleteClient](#deleteclient) - Delete client
* [CreateSecret](#createsecret) - Add a secret to a client
* [DeleteSecret](#deletesecret) - Delete a secret from a client
* [ListUsers](#listusers) - List users
* [ReadUser](#readuser) - Read user

## GetOIDCWellKnowns

Retrieve OpenID connect well-knowns.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOIDCWellKnowns" method="get" path="/api/auth/.well-known/openid-configuration" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.GetOIDCWellKnownsAsync();

// handle response
```

### Response

**[GetOIDCWellKnownsResponse](../../Models/Requests/GetOIDCWellKnownsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetServerInfo

Get server info

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getServerInfo" method="get" path="/api/auth/_info" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.GetServerInfoAsync();

// handle response
```

### Response

**[GetServerInfoResponse](../../Models/Requests/GetServerInfoResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListClients

List clients

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listClients" method="get" path="/api/auth/clients" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.ListClientsAsync();

// handle response
```

### Response

**[Models.Requests.ListClientsResponse](../../Models/Requests/ListClientsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CreateClient

Create client

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createClient" method="post" path="/api/auth/clients" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

ClientOptions? req = null;

var res = await sdk.Auth.V1.CreateClientAsync(req);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [ClientOptions](../../Models/Components/ClientOptions.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[Models.Requests.CreateClientResponse](../../Models/Requests/CreateClientResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ReadClient

Read client

### Example Usage

<!-- UsageSnippet language="csharp" operationID="readClient" method="get" path="/api/auth/clients/{clientId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.ReadClientAsync(clientId: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ClientId`         | *string*           | :heavy_check_mark: | Client ID          |

### Response

**[Models.Requests.ReadClientResponse](../../Models/Requests/ReadClientResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## UpdateClient

Update client

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateClient" method="put" path="/api/auth/clients/{clientId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.UpdateClientAsync(clientId: "<id>");

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `ClientId`                                                | *string*                                                  | :heavy_check_mark:                                        | Client ID                                                 |
| `ClientOptions`                                           | [ClientOptions](../../Models/Components/ClientOptions.md) | :heavy_minus_sign:                                        | N/A                                                       |

### Response

**[UpdateClientResponse](../../Models/Requests/UpdateClientResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DeleteClient

Delete client

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteClient" method="delete" path="/api/auth/clients/{clientId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.DeleteClientAsync(clientId: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ClientId`         | *string*           | :heavy_check_mark: | Client ID          |

### Response

**[DeleteClientResponse](../../Models/Requests/DeleteClientResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CreateSecret

Add a secret to a client

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSecret" method="post" path="/api/auth/clients/{clientId}/secrets" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.CreateSecretAsync(clientId: "<id>");

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `ClientId`                                                                              | *string*                                                                                | :heavy_check_mark:                                                                      | Client ID                                                                               |
| `CreateSecretRequest`                                                                   | [Models.Components.CreateSecretRequest](../../Models/Components/CreateSecretRequest.md) | :heavy_minus_sign:                                                                      | N/A                                                                                     |

### Response

**[Models.Requests.CreateSecretResponse](../../Models/Requests/CreateSecretResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DeleteSecret

Delete a secret from a client

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteSecret" method="delete" path="/api/auth/clients/{clientId}/secrets/{secretId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.DeleteSecretAsync(
    clientId: "<id>",
    secretId: "<id>"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ClientId`         | *string*           | :heavy_check_mark: | Client ID          |
| `SecretId`         | *string*           | :heavy_check_mark: | Secret ID          |

### Response

**[DeleteSecretResponse](../../Models/Requests/DeleteSecretResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListUsers

List users

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUsers" method="get" path="/api/auth/users" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.ListUsersAsync();

// handle response
```

### Response

**[Models.Requests.ListUsersResponse](../../Models/Requests/ListUsersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ReadUser

Read user

### Example Usage

<!-- UsageSnippet language="csharp" operationID="readUser" method="get" path="/api/auth/users/{userId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.ReadUserAsync(userId: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `UserId`           | *string*           | :heavy_check_mark: | User ID            |

### Response

**[Models.Requests.ReadUserResponse](../../Models/Requests/ReadUserResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |