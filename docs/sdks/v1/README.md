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

```csharp
using formance;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## GetServerInfo

Get server info

### Example Usage

```csharp
using formance;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ListClients

List clients

### Example Usage

```csharp
using formance;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## CreateClient

Create client

### Example Usage

```csharp
using formance;
using formance.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

CreateClientRequest req = new CreateClientRequest() {
    Name = "<value>",
};

var res = await sdk.Auth.V1.CreateClientAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [CreateClientRequest](../../Models/Components/CreateClientRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[Models.Requests.CreateClientResponse](../../Models/Requests/CreateClientResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ReadClient

Read client

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.ReadClientAsync(clientId: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ClientId`         | *string*           | :heavy_check_mark: | Client ID          |

### Response

**[Models.Requests.ReadClientResponse](../../Models/Requests/ReadClientResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## UpdateClient

Update client

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.UpdateClientAsync(
    clientId: "<value>",
    updateClientRequest: new Models.Components.UpdateClientRequest() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `ClientId`                                                                              | *string*                                                                                | :heavy_check_mark:                                                                      | Client ID                                                                               |
| `UpdateClientRequest`                                                                   | [Models.Components.UpdateClientRequest](../../Models/Components/UpdateClientRequest.md) | :heavy_minus_sign:                                                                      | N/A                                                                                     |

### Response

**[Models.Requests.UpdateClientResponse](../../Models/Requests/UpdateClientResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## DeleteClient

Delete client

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.DeleteClientAsync(clientId: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ClientId`         | *string*           | :heavy_check_mark: | Client ID          |

### Response

**[DeleteClientResponse](../../Models/Requests/DeleteClientResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## CreateSecret

Add a secret to a client

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.CreateSecretAsync(
    clientId: "<value>",
    createSecretRequest: new Models.Components.CreateSecretRequest() {
        Name = "<value>",
    }
);

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## DeleteSecret

Delete a secret from a client

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.DeleteSecretAsync(
    clientId: "<value>",
    secretId: "<value>"
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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ListUsers

List users

### Example Usage

```csharp
using formance;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ReadUser

Read user

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Auth.V1.ReadUserAsync(userId: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `UserId`           | *string*           | :heavy_check_mark: | User ID            |

### Response

**[Models.Requests.ReadUserResponse](../../Models/Requests/ReadUserResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |
