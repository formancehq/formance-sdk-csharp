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

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| formance.Models.Errors.ErrorResponse | default                              | application/json                     |
| formance.Models.Errors.SDKException  | 4xx-5xx                              | */*                                  |

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
    if (ex is ErrorResponse)
    {
        // Handle exception data
        throw;
    }
    else if (ex is Models.Errors.SDKException)
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

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `http://localhost` | None |
| 1 | `https://{stack}.sandbox.formance.cloud` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name                           | Type                           | Scheme                         |
| ------------------------------ | ------------------------------ | ------------------------------ |
| `ClientID` `ClientSecret`      | oauth2                         | OAuth2 Client Credentials Flow |

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