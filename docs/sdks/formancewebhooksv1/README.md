# Webhooks.V1

## Overview

### Available Operations

* [GetManyConfigs](#getmanyconfigs) - Get many configs
* [InsertConfig](#insertconfig) - Insert a new config
* [DeleteConfig](#deleteconfig) - Delete one config
* [UpdateConfig](#updateconfig) - Update one config
* [TestConfig](#testconfig) - Test one config
* [ActivateConfig](#activateconfig) - Activate one config
* [DeactivateConfig](#deactivateconfig) - Deactivate one config
* [ChangeConfigSecret](#changeconfigsecret) - Change the signing secret of a config
* [GetDeliveries](#getdeliveries) - List webhook deliveries
* [ReplayDeliveries](#replaydeliveries) - Replay a page of failed or pending deliveries
* [GetDelivery](#getdelivery) - Get a webhook delivery
* [GetDeliveryAttempts](#getdeliveryattempts) - List attempts for a webhook delivery
* [ReplayDelivery](#replaydelivery) - Replay one failed or pending delivery

## GetManyConfigs

Sorted by updated date descending

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getManyConfigs" method="get" path="/api/webhooks/configs" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.GetManyConfigsAsync(
    id: "4997257d-dfb6-445b-929c-cbe2ab182818",
    endpoint: "https://example.com"
);

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `Id`                                 | *string*                             | :heavy_minus_sign:                   | Optional filter by Config ID         | 4997257d-dfb6-445b-929c-cbe2ab182818 |
| `Endpoint`                           | *string*                             | :heavy_minus_sign:                   | Optional filter by endpoint URL      | https://example.com                  |

### Response

**[GetManyConfigsResponse](../../Models/Requests/GetManyConfigsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## InsertConfig

Insert a new webhooks config.

The endpoint should be a valid https URL and be unique.

The secret is the endpoint's verification secret.
If not passed or empty, a secret is automatically generated.
The format is a random string of bytes of size 24, base64 encoded. (larger size after encoding)

All eventTypes are converted to lower-case when inserted.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="insertConfig" method="post" path="/api/webhooks/configs" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Webhooks;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

ConfigUser req = new ConfigUser() {
    Endpoint = "https://example.com",
    Secret = "V0bivxRWveaoz08afqjU6Ko/jwO0Cb+3",
    EventTypes = new List<string>() {
        "TYPE1",
        "TYPE2",
    },
};

var res = await sdk.Webhooks.V1.InsertConfigAsync(req);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `request`                                         | [ConfigUser](../../Models/Webhooks/ConfigUser.md) | :heavy_check_mark:                                | The request object to use for the request.        |

### Response

**[InsertConfigResponse](../../Models/Requests/InsertConfigResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeleteConfig

Delete a webhooks config by ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteConfig" method="delete" path="/api/webhooks/configs/{id}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.DeleteConfigAsync(id: "4997257d-dfb6-445b-929c-cbe2ab182818");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `Id`                                 | *string*                             | :heavy_check_mark:                   | Config ID                            | 4997257d-dfb6-445b-929c-cbe2ab182818 |

### Response

**[DeleteConfigResponse](../../Models/Requests/DeleteConfigResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## UpdateConfig

Update a webhooks config by ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateConfig" method="put" path="/api/webhooks/configs/{id}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Webhooks;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.UpdateConfigAsync(
    id: "4997257d-dfb6-445b-929c-cbe2ab182818",
    configUser: new ConfigUser() {
        Endpoint = "https://example.com",
        Secret = "V0bivxRWveaoz08afqjU6Ko/jwO0Cb+3",
        EventTypes = new List<string>() {
            "TYPE1",
            "TYPE2",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | Config ID                                         | 4997257d-dfb6-445b-929c-cbe2ab182818              |
| `ConfigUser`                                      | [ConfigUser](../../Models/Webhooks/ConfigUser.md) | :heavy_check_mark:                                | N/A                                               |                                                   |

### Response

**[UpdateConfigResponse](../../Models/Requests/UpdateConfigResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## TestConfig

Test a config by sending a webhook to its endpoint.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="testConfig" method="get" path="/api/webhooks/configs/{id}/test" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.TestConfigAsync(id: "4997257d-dfb6-445b-929c-cbe2ab182818");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `Id`                                 | *string*                             | :heavy_check_mark:                   | Config ID                            | 4997257d-dfb6-445b-929c-cbe2ab182818 |

### Response

**[TestConfigResponse](../../Models/Requests/TestConfigResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ActivateConfig

Activate a webhooks config by ID, to start receiving webhooks to its endpoint.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="activateConfig" method="put" path="/api/webhooks/configs/{id}/activate" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.ActivateConfigAsync(id: "4997257d-dfb6-445b-929c-cbe2ab182818");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `Id`                                 | *string*                             | :heavy_check_mark:                   | Config ID                            | 4997257d-dfb6-445b-929c-cbe2ab182818 |

### Response

**[ActivateConfigResponse](../../Models/Requests/ActivateConfigResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## DeactivateConfig

Deactivate a webhooks config by ID, to stop receiving webhooks to its endpoint.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deactivateConfig" method="put" path="/api/webhooks/configs/{id}/deactivate" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.DeactivateConfigAsync(id: "4997257d-dfb6-445b-929c-cbe2ab182818");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `Id`                                 | *string*                             | :heavy_check_mark:                   | Config ID                            | 4997257d-dfb6-445b-929c-cbe2ab182818 |

### Response

**[DeactivateConfigResponse](../../Models/Requests/DeactivateConfigResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ChangeConfigSecret

Change the signing secret of the endpoint of a webhooks config.

If not passed or empty, a secret is automatically generated.
The format is a random string of bytes of size 24, base64 encoded. (larger size after encoding)


### Example Usage

<!-- UsageSnippet language="csharp" operationID="changeConfigSecret" method="put" path="/api/webhooks/configs/{id}/secret/change" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Webhooks;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.ChangeConfigSecretAsync(
    id: "4997257d-dfb6-445b-929c-cbe2ab182818",
    configChangeSecret: new ConfigChangeSecret() {
        Secret = "V0bivxRWveaoz08afqjU6Ko/jwO0Cb+3",
    }
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | Config ID                                                         | 4997257d-dfb6-445b-929c-cbe2ab182818                              |
| `ConfigChangeSecret`                                              | [ConfigChangeSecret](../../Models/Webhooks/ConfigChangeSecret.md) | :heavy_minus_sign:                                                | N/A                                                               |                                                                   |

### Response

**[ChangeConfigSecretResponse](../../Models/Requests/ChangeConfigSecretResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetDeliveries

List webhook deliveries

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDeliveries" method="get" path="/api/webhooks/deliveries" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Requests;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

GetDeliveriesRequest req = new GetDeliveriesRequest() {};

var res = await sdk.Webhooks.V1.GetDeliveriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetDeliveriesRequest](../../Models/Requests/GetDeliveriesRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GetDeliveriesResponse](../../Models/Requests/GetDeliveriesResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ReplayDeliveries

Replay a page of failed or pending deliveries

### Example Usage

<!-- UsageSnippet language="csharp" operationID="replayDeliveries" method="post" path="/api/webhooks/deliveries/replay" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.ReplayDeliveriesAsync(
    idempotencyKey: "<value>",
    replayDeliveriesRequest: new FormanceSDK.Models.Webhooks.ReplayDeliveriesRequest() {
        CreatedAtFrom = System.DateTime.Parse("2026-10-16T11:02:44.647Z").ToUniversalTime(),
    }
);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `IdempotencyKey`                                                                            | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `ReplayDeliveriesRequest`                                                                   | [Models.Webhooks.ReplayDeliveriesRequest](../../Models/Webhooks/ReplayDeliveriesRequest.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |

### Response

**[Models.Requests.ReplayDeliveriesResponse](../../Models/Requests/ReplayDeliveriesResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetDelivery

Get a webhook delivery

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDelivery" method="get" path="/api/webhooks/deliveries/{id}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.GetDeliveryAsync(id: "01e5cac6-75f1-4720-81ca-5563ce22d2e0");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetDeliveryResponse](../../Models/Requests/GetDeliveryResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## GetDeliveryAttempts

List attempts for a webhook delivery

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDeliveryAttempts" method="get" path="/api/webhooks/deliveries/{id}/attempts" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.GetDeliveryAttemptsAsync(
    id: "967e7a38-b11b-4809-92cf-6789e24dbe13",
    pageSize: 100
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |
| `Cursor`           | *string*           | :heavy_minus_sign: | N/A                |
| `PageSize`         | *long*             | :heavy_minus_sign: | N/A                |

### Response

**[GetDeliveryAttemptsResponse](../../Models/Requests/GetDeliveryAttemptsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |

## ReplayDelivery

Replay one failed or pending delivery

### Example Usage

<!-- UsageSnippet language="csharp" operationID="replayDelivery" method="post" path="/api/webhooks/deliveries/{id}/replay" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.ReplayDeliveryAsync(
    id: "06a0d0bb-48de-45f0-b12f-6458a3a41bbe",
    idempotencyKey: "<value>"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |
| `IdempotencyKey`   | *string*           | :heavy_check_mark: | N/A                |

### Response

**[ReplayDeliveryResponse](../../Models/Requests/ReplayDeliveryResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| FormanceSDK.Models.Webhooks.ErrorResponse | default                                   | application/json                          |
| FormanceSDK.Models.Errors.SDKException    | 4XX, 5XX                                  | \*/\*                                     |