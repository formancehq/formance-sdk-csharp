# formance


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.GetVersionsAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `FormanceSDK.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `Request`     | *HttpRequestMessage*  | The HTTP request      |
| `Response`    | *HttpResponseMessage* | The HTTP response     |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `GetInfoAsync` method throws the following exceptions:

| Error Type                              | Status Code | Content Type     |
| --------------------------------------- | ----------- | ---------------- |
| FormanceSDK.Models.Errors.ErrorResponse | default     | application/json |
| FormanceSDK.Models.Errors.SDKException  | 4XX, 5XX    | \*/\*            |

### Example

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;
using FormanceSDK.Models.Errors;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

try
{
    var res = await sdk.Ledger.V1.GetInfoAsync();

    // handle response
}
catch (Exception ex)
{
    if (ex is Models.Errors.ErrorResponse)
    {
        // Handle exception data
        throw;
    }
    else if (ex is FormanceSDK.Models.Errors.SDKException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: int` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                                                | Variables                        | Description                                |
| --- | ----------------------------------------------------- | -------------------------------- | ------------------------------------------ |
| 0   | `http://localhost`                                    |                                  | local server                               |
| 1   | `https://{organization}.{environment}.formance.cloud` | `organization`<br/>`environment` | A per-organization and per-environment API |

If the selected server has variables, you may override its default values through the additional parameters made available in the SDK constructor:

| Variable       | Parameter                                           | Supported Values                                                           | Default           | Description                                                   |
| -------------- | --------------------------------------------------- | -------------------------------------------------------------------------- | ----------------- | ------------------------------------------------------------- |
| `organization` | `organization: string`                              | string                                                                     | `"orgID-stackID"` | The organization name. Defaults to a generic organization.    |
| `environment`  | `environment: FormanceSDK.Models.ServerEnvironment` | - `"eu.sandbox"`<br/>- `"sandbox"`<br/>- `"eu-west-1"`<br/>- `"us-east-1"` | `"eu.sandbox"`    | The environment name. Defaults to the production environment. |

#### Example

```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(
    serverIndex: 1,
    organization: "<value>",
    environment: "us-east-1",
    security: new Security() {
        ClientID = "<YOUR_CLIENT_ID_HERE>",
        ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
    }
);

var res = await sdk.GetVersionsAsync();

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(
    serverUrl: "https://orgID-stackID.eu.sandbox.formance.cloud",
    security: new Security() {
        ClientID = "<YOUR_CLIENT_ID_HERE>",
        ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
    }
);

var res = await sdk.GetVersionsAsync();

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name                          | Type   | Scheme                         |
| ----------------------------- | ------ | ------------------------------ |
| `ClientID`<br/>`ClientSecret` | oauth2 | OAuth2 Client Credentials Flow |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.GetVersionsAsync();

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->