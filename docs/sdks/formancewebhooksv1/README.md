# FormanceWebhooksV1
(*Webhooks.V1*)

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

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.WebhooksErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

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
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

ConfigUser req = new ConfigUser() {
    Name = "customer_payment",
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

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `request`                                           | [ConfigUser](../../Models/Components/ConfigUser.md) | :heavy_check_mark:                                  | The request object to use for the request.          |

### Response

**[InsertConfigResponse](../../Models/Requests/InsertConfigResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.WebhooksErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

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

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.WebhooksErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## UpdateConfig

Update a webhooks config by ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateConfig" method="put" path="/api/webhooks/configs/{id}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Webhooks.V1.UpdateConfigAsync(
    id: "4997257d-dfb6-445b-929c-cbe2ab182818",
    configUser: new ConfigUser() {
        Name = "customer_payment",
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

| Parameter                                           | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `Id`                                                | *string*                                            | :heavy_check_mark:                                  | Config ID                                           | 4997257d-dfb6-445b-929c-cbe2ab182818                |
| `ConfigUser`                                        | [ConfigUser](../../Models/Components/ConfigUser.md) | :heavy_check_mark:                                  | N/A                                                 |                                                     |

### Response

**[UpdateConfigResponse](../../Models/Requests/UpdateConfigResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.WebhooksErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

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

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.WebhooksErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

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

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.WebhooksErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

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

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.WebhooksErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |

## ChangeConfigSecret

Change the signing secret of the endpoint of a webhooks config.

If not passed or empty, a secret is automatically generated.
The format is a random string of bytes of size 24, base64 encoded. (larger size after encoding)


### Example Usage

<!-- UsageSnippet language="csharp" operationID="changeConfigSecret" method="put" path="/api/webhooks/configs/{id}/secret/change" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

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

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | Config ID                                                           | 4997257d-dfb6-445b-929c-cbe2ab182818                                |
| `ConfigChangeSecret`                                                | [ConfigChangeSecret](../../Models/Components/ConfigChangeSecret.md) | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |

### Response

**[ChangeConfigSecretResponse](../../Models/Requests/ChangeConfigSecretResponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| FormanceSDK.Models.Errors.WebhooksErrorResponse | default                                         | application/json                                |
| FormanceSDK.Models.Errors.SDKException          | 4XX, 5XX                                        | \*/\*                                           |