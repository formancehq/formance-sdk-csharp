# formance


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using formance;
using formance.Models.Components;

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

By default, an API error will raise a `formance.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `Request`     | *HttpRequestMessage*  | The HTTP request      |
| `Response`    | *HttpResponseMessage* | The HTTP response     |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `GetInfoAsync` method throws the following exceptions:

| Error Type                           | Status Code | Content Type     |
| ------------------------------------ | ----------- | ---------------- |
| formance.Models.Errors.ErrorResponse | default     | application/json |
| formance.Models.Errors.SDKException  | 4XX, 5XX    | \*/\*            |

### Example

```csharp
using formance;
using formance.Models.Components;
using System;
using formance.Models.Errors;

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
    else if (ex is formance.Models.Errors.SDKException)
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

| #   | Server                                                | Variables                                                   | Default values                    |
| --- | ----------------------------------------------------- | ----------------------------------------------------------- | --------------------------------- |
| 0   | `http://localhost`                                    |                                                             |                                   |
| 1   | `https://{organization}.{environment}.formance.cloud` | `organization: string`<br/>`environment: ServerEnvironment` | `"orgID-stackID"`<br/>`"sandbox"` |

If the selected server has variables, you may override their default values through the additional parameters made available in the SDK constructor.

#### Example

```csharp
using formance;
using formance.Models.Components;

var sdk = new Formance(
    serverIndex: 1,
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
using formance;
using formance.Models.Components;

var sdk = new Formance(
    serverUrl: "http://localhost",
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
using formance;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.GetVersionsAsync();

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->