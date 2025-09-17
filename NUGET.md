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

[`FormanceError`](./src/FormanceSDK/Models/Errors/FormanceError.cs) is the base exception class for all HTTP error responses. It has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | Error message         |
| `Request`     | *HttpRequestMessage*  | HTTP request object   |
| `Response`    | *HttpResponseMessage* | HTTP response object  |

Some exceptions in this SDK include an additional `Payload` field, which will contain deserialized custom error data when present. Possible exceptions are listed in the [Error Classes](#error-classes) section.

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
catch (FormanceError ex)  // all SDK exceptions inherit from FormanceError
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpRequestMessage request = ex.Request;
    HttpResponseMessage response = ex.Response;
    var statusCode = (int)response.StatusCode;
    var responseBody = ex.Body;

    if (ex is Models.Errors.ErrorResponse) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        Models.Errors.ErrorResponsePayload payload = ex.Payload;
        ErrorsEnum ErrorCode = payload.ErrorCode;
        string ErrorMessage = payload.ErrorMessage;
        // ...
    }

    // An underlying cause may be provided
    if (ex.InnerException != null)
    {
        Exception cause = ex.InnerException;
    }
}
catch (System.Net.Http.HttpRequestException ex)
{
    // Check ex.InnerException for Network connectivity errors
}
```

### Error Classes

**Primary exception:**
* [`FormanceError`](./src/FormanceSDK/Models/Errors/FormanceError.cs): The base class for HTTP error responses.

<details><summary>Less common exceptions (11)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`FormanceError`](./src/FormanceSDK/Models/Errors/FormanceError.cs):
  * [`V3ErrorResponse`](./src/FormanceSDK/Models/Errors/V3ErrorResponse.cs): Error. Applicable to 46 of 219 methods.*
  * [`PaymentsErrorResponse`](./src/FormanceSDK/Models/Errors/PaymentsErrorResponse.cs): Error. Applicable to 45 of 219 methods.*
  * [`V2ErrorResponse`](./src/FormanceSDK/Models/Errors/V2ErrorResponse.cs): Error. Applicable to 26 of 219 methods.*
  * [`ErrorResponse`](./src/FormanceSDK/Models/Errors/ErrorResponse.cs): Applicable to 19 of 219 methods.*
  * [`V2Error`](./src/FormanceSDK/Models/Errors/V2Error.cs): General error. Applicable to 18 of 219 methods.*
  * [`Error`](./src/FormanceSDK/Models/Errors/Error.cs): General error. Applicable to 17 of 219 methods.*
  * [`WalletsErrorResponse`](./src/FormanceSDK/Models/Errors/WalletsErrorResponse.cs): Applicable to 15 of 219 methods.*
  * [`WebhooksErrorResponse`](./src/FormanceSDK/Models/Errors/WebhooksErrorResponse.cs): Error. Applicable to 8 of 219 methods.*
  * [`ReconciliationErrorResponse`](./src/FormanceSDK/Models/Errors/ReconciliationErrorResponse.cs): Error response. Applicable to 8 of 219 methods.*
  * [`ResponseValidationError`](./src/FormanceSDK/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

\* Refer to the [relevant documentation](#available-resources-and-operations) to determine whether an exception applies to a specific operation.
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