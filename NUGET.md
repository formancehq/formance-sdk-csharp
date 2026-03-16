# formance


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using FormanceSDK;

var sdk = new Formance();

var res = await sdk.GetVersionsAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`SDKBaseException`](./src/FormanceSDK/Models/Errors/SDKBaseException.cs) is the base exception class for all HTTP error responses. It has the following properties:

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
    var res = await sdk.Ledger.GetInfoAsync();

    // handle response
}
catch (SDKBaseException ex)  // all SDK exceptions inherit from SDKBaseException
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpRequestMessage request = ex.Request;
    HttpResponseMessage response = ex.Response;
    var statusCode = (int)response.StatusCode;
    var responseBody = ex.Body;

    if (ex is Models.Errors.V2ErrorResponse) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        Models.Errors.V2ErrorResponsePayload payload = ex.Payload;
        V2ErrorsEnum ErrorCode = payload.ErrorCode;
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
* [`SDKBaseException`](./src/FormanceSDK/Models/Errors/SDKBaseException.cs): The base class for HTTP error responses.

**Less common exceptions (11)**

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`SDKBaseException`](./src/FormanceSDK/Models/Errors/SDKBaseException.cs):
  * [`V3ErrorResponse`](./src/FormanceSDK/Models/Errors/V3ErrorResponse.cs): Error. Applicable to 57 of 249 methods.*
  * [`PaymentsErrorResponse`](./src/FormanceSDK/Models/Errors/PaymentsErrorResponse.cs): Error. Applicable to 46 of 249 methods.*
  * [`V2ErrorResponse`](./src/FormanceSDK/Models/Errors/V2ErrorResponse.cs): Applicable to 44 of 249 methods.*
  * [`ErrorResponse`](./src/FormanceSDK/Models/Errors/ErrorResponse.cs): Applicable to 19 of 249 methods.*
  * [`V2Error`](./src/FormanceSDK/Models/Errors/V2Error.cs): General error. Applicable to 18 of 249 methods.*
  * [`Error`](./src/FormanceSDK/Models/Errors/Error.cs): General error. Applicable to 17 of 249 methods.*
  * [`WalletsErrorResponse`](./src/FormanceSDK/Models/Errors/WalletsErrorResponse.cs): Applicable to 15 of 249 methods.*
  * [`WebhooksErrorResponse`](./src/FormanceSDK/Models/Errors/WebhooksErrorResponse.cs): Error. Applicable to 8 of 249 methods.*
  * [`ReconciliationErrorResponse`](./src/FormanceSDK/Models/Errors/ReconciliationErrorResponse.cs): Error response. Applicable to 8 of 249 methods.*
  * [`ResponseValidationError`](./src/FormanceSDK/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.

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

| Variable       | Parameter                                           | Supported Values                                         | Default           | Description                                                   |
| -------------- | --------------------------------------------------- | -------------------------------------------------------- | ----------------- | ------------------------------------------------------------- |
| `organization` | `organization: string`                              | string                                                   | `"orgID-stackID"` | The organization name. Defaults to a generic organization.    |
| `environment`  | `environment: FormanceSDK.Models.ServerEnvironment` | - `"eu.sandbox"`<br/>- `"eu-west-1"`<br/>- `"us-east-1"` | `"eu.sandbox"`    | The environment name. Defaults to the production environment. |

#### Example

```csharp
using FormanceSDK;

var sdk = new Formance(
    serverIndex: 1,
    organization: "orgID-stackID",
    environment: "us-east-1"
);

var res = await sdk.GetVersionsAsync();

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using FormanceSDK;

var sdk = new Formance(serverUrl: "https://orgID-stackID.eu.sandbox.formance.cloud");

var res = await sdk.GetVersionsAsync();

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name                                         | Type   | Scheme                         |
| -------------------------------------------- | ------ | ------------------------------ |
| `ClientID`<br/>`ClientSecret`<br/>`TokenURL` | oauth2 | OAuth2 Client Credentials Flow |

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

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The C# SDK makes API calls using an `ISpeakeasyHttpClient` that wraps the native
[HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient). This
client provides the ability to attach hooks around the request lifecycle that can be used to modify the request or handle
errors and response.

The `ISpeakeasyHttpClient` interface allows you to either use the default `SpeakeasyHttpClient` that comes with the SDK,
or provide your own custom implementation with customized configuration such as custom message handlers, timeouts,
connection pooling, and other HTTP client settings.

The following example shows how to create a custom HTTP client with request modification and error handling:

```csharp
using FormanceSDK;
using FormanceSDK.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Create a custom HTTP client
public class CustomHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _defaultClient;

    public CustomHttpClient()
    {
        _defaultClient = new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Add custom header and timeout
        request.Headers.Add("x-custom-header", "custom value");
        request.Headers.Add("x-request-timeout", "30");
        
        try
        {
            var response = await _defaultClient.SendAsync(request, cancellationToken);
            // Log successful response
            Console.WriteLine($"Request successful: {response.StatusCode}");
            return response;
        }
        catch (Exception error)
        {
            // Log error
            Console.WriteLine($"Request failed: {error.Message}");
            throw;
        }
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
        _defaultClient?.Dispose();
    }
}

// Use the custom HTTP client with the SDK
var customHttpClient = new CustomHttpClient();
var sdk = new Formance(client: customHttpClient);
```

**You can also provide a completely custom HTTP client with your own configuration:**

```csharp
using FormanceSDK.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Custom HTTP client with custom configuration
public class AdvancedHttpClient : ISpeakeasyHttpClient
{
    private readonly HttpClient _httpClient;

    public AdvancedHttpClient()
    {
        var handler = new HttpClientHandler()
        {
            MaxConnectionsPerServer = 10,
            // ServerCertificateCustomValidationCallback = customCertValidation, // Custom SSL validation if needed
        };

        _httpClient = new HttpClient(handler)
        {
            Timeout = TimeSpan.FromSeconds(30)
        };
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        return await _httpClient.SendAsync(request, cancellationToken ?? CancellationToken.None);
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}

var sdk = Formance.Builder()
    .WithClient(new AdvancedHttpClient())
    .Build();
```

**For simple debugging, you can enable request/response logging by implementing a custom client:**

```csharp
public class LoggingHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _innerClient;

    public LoggingHttpClient(ISpeakeasyHttpClient innerClient = null)
    {
        _innerClient = innerClient ?? new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Log request
        Console.WriteLine($"Sending {request.Method} request to {request.RequestUri}");
        
        var response = await _innerClient.SendAsync(request, cancellationToken);
        
        // Log response
        Console.WriteLine($"Received {response.StatusCode} response");
        
        return response;
    }

    public void Dispose() => _innerClient?.Dispose();
}

var sdk = new Formance(client: new LoggingHttpClient());
```

The SDK also provides built-in hook support through the `SDKConfiguration.Hooks` system, which automatically handles
`BeforeRequestAsync`, `AfterSuccessAsync`, and `AfterErrorAsync` hooks for advanced request lifecycle management.
<!-- End Custom HTTP Client [http-client] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->