# FormanceOrchestrationV1
(*Orchestration.V1*)

## Overview

### Available Operations

* [OrchestrationgetServerInfo](#orchestrationgetserverinfo) - Get server info
* [ListTriggers](#listtriggers) - List triggers
* [CreateTrigger](#createtrigger) - Create trigger
* [ReadTrigger](#readtrigger) - Read trigger
* [DeleteTrigger](#deletetrigger) - Delete trigger
* [ListTriggersOccurrences](#listtriggersoccurrences) - List triggers occurrences
* [ListWorkflows](#listworkflows) - List registered workflows
* [CreateWorkflow](#createworkflow) - Create workflow
* [GetWorkflow](#getworkflow) - Get a flow by id
* [DeleteWorkflow](#deleteworkflow) - Delete a flow by id
* [RunWorkflow](#runworkflow) - Run workflow
* [ListInstances](#listinstances) - List instances of a workflow
* [GetInstance](#getinstance) - Get a workflow instance by id
* [SendEvent](#sendevent) - Send an event to a running workflow
* [CancelEvent](#cancelevent) - Cancel a running workflow
* [GetInstanceHistory](#getinstancehistory) - Get a workflow instance history by id
* [GetInstanceStageHistory](#getinstancestagehistory) - Get a workflow instance stage history

## OrchestrationgetServerInfo

Get server info

### Example Usage

<!-- UsageSnippet language="csharp" operationID="orchestrationgetServerInfo" method="get" path="/api/orchestration/_info" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.OrchestrationgetServerInfoAsync();

// handle response
```

### Response

**[OrchestrationgetServerInfoResponse](../../Models/Requests/OrchestrationgetServerInfoResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListTriggers

List triggers

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTriggers" method="get" path="/api/orchestration/triggers" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.ListTriggersAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Name`             | *string*           | :heavy_minus_sign: | search by name     |

### Response

**[Models.Requests.ListTriggersResponse](../../Models/Requests/ListTriggersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CreateTrigger

Create trigger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTrigger" method="post" path="/api/orchestration/triggers" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

TriggerData? req = null;

var res = await sdk.Orchestration.V1.CreateTriggerAsync(req);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `request`                                             | [TriggerData](../../Models/Components/TriggerData.md) | :heavy_check_mark:                                    | The request object to use for the request.            |

### Response

**[Models.Requests.CreateTriggerResponse](../../Models/Requests/CreateTriggerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ReadTrigger

Read trigger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="readTrigger" method="get" path="/api/orchestration/triggers/{triggerID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.ReadTriggerAsync(triggerID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `TriggerID`        | *string*           | :heavy_check_mark: | The trigger id     |

### Response

**[Models.Requests.ReadTriggerResponse](../../Models/Requests/ReadTriggerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DeleteTrigger

Read trigger

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteTrigger" method="delete" path="/api/orchestration/triggers/{triggerID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.DeleteTriggerAsync(triggerID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `TriggerID`        | *string*           | :heavy_check_mark: | The trigger id     |

### Response

**[DeleteTriggerResponse](../../Models/Requests/DeleteTriggerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListTriggersOccurrences

List triggers occurrences

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTriggersOccurrences" method="get" path="/api/orchestration/triggers/{triggerID}/occurrences" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.ListTriggersOccurrencesAsync(triggerID: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `TriggerID`        | *string*           | :heavy_check_mark: | The trigger id     |

### Response

**[Models.Requests.ListTriggersOccurrencesResponse](../../Models/Requests/ListTriggersOccurrencesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListWorkflows

List registered workflows

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listWorkflows" method="get" path="/api/orchestration/workflows" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.ListWorkflowsAsync();

// handle response
```

### Response

**[Models.Requests.ListWorkflowsResponse](../../Models/Requests/ListWorkflowsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CreateWorkflow

Create a workflow

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createWorkflow" method="post" path="/api/orchestration/workflows" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

WorkflowConfig? req = null;

var res = await sdk.Orchestration.V1.CreateWorkflowAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [WorkflowConfig](../../Models/Components/WorkflowConfig.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[Models.Requests.CreateWorkflowResponse](../../Models/Requests/CreateWorkflowResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetWorkflow

Get a flow by id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getWorkflow" method="get" path="/api/orchestration/workflows/{flowId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.GetWorkflowAsync(flowId: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `FlowId`           | *string*           | :heavy_check_mark: | The flow id        | xxx                |

### Response

**[Models.Requests.GetWorkflowResponse](../../Models/Requests/GetWorkflowResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## DeleteWorkflow

Delete a flow by id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteWorkflow" method="delete" path="/api/orchestration/workflows/{flowId}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.DeleteWorkflowAsync(flowId: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `FlowId`           | *string*           | :heavy_check_mark: | The flow id        | xxx                |

### Response

**[DeleteWorkflowResponse](../../Models/Requests/DeleteWorkflowResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## RunWorkflow

Run workflow

### Example Usage

<!-- UsageSnippet language="csharp" operationID="runWorkflow" method="post" path="/api/orchestration/workflows/{workflowID}/instances" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.RunWorkflowAsync(workflowID: "xxx");

// handle response
```

### Parameters

| Parameter                              | Type                                   | Required                               | Description                            | Example                                |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `WorkflowID`                           | *string*                               | :heavy_check_mark:                     | The flow id                            | xxx                                    |
| `Wait`                                 | *bool*                                 | :heavy_minus_sign:                     | Wait end of the workflow before return |                                        |
| `RequestBody`                          | Dictionary<String, *string*>           | :heavy_minus_sign:                     | N/A                                    |                                        |

### Response

**[Models.Requests.RunWorkflowResponse](../../Models/Requests/RunWorkflowResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## ListInstances

List instances of a workflow

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listInstances" method="get" path="/api/orchestration/instances" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.ListInstancesAsync(
    workflowID: "xxx",
    running: true
);

// handle response
```

### Parameters

| Parameter                | Type                     | Required                 | Description              | Example                  |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `WorkflowID`             | *string*                 | :heavy_minus_sign:       | A workflow id            | xxx                      |
| `Running`                | *bool*                   | :heavy_minus_sign:       | Filter running instances | true                     |

### Response

**[ListInstancesResponse](../../Models/Requests/ListInstancesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetInstance

Get a workflow instance by id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getInstance" method="get" path="/api/orchestration/instances/{instanceID}" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.GetInstanceAsync(instanceID: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `InstanceID`       | *string*           | :heavy_check_mark: | The instance id    | xxx                |

### Response

**[GetInstanceResponse](../../Models/Requests/GetInstanceResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## SendEvent

Send an event to a running workflow

### Example Usage

<!-- UsageSnippet language="csharp" operationID="sendEvent" method="post" path="/api/orchestration/instances/{instanceID}/events" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.SendEventAsync(instanceID: "xxx");

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           | Example                                                               |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `InstanceID`                                                          | *string*                                                              | :heavy_check_mark:                                                    | The instance id                                                       | xxx                                                                   |
| `RequestBody`                                                         | [SendEventRequestBody](../../Models/Requests/SendEventRequestBody.md) | :heavy_minus_sign:                                                    | N/A                                                                   |                                                                       |

### Response

**[SendEventResponse](../../Models/Requests/SendEventResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## CancelEvent

Cancel a running workflow

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancelEvent" method="put" path="/api/orchestration/instances/{instanceID}/abort" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.CancelEventAsync(instanceID: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `InstanceID`       | *string*           | :heavy_check_mark: | The instance id    | xxx                |

### Response

**[CancelEventResponse](../../Models/Requests/CancelEventResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetInstanceHistory

Get a workflow instance history by id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getInstanceHistory" method="get" path="/api/orchestration/instances/{instanceID}/history" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.GetInstanceHistoryAsync(instanceID: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `InstanceID`       | *string*           | :heavy_check_mark: | The instance id    | xxx                |

### Response

**[GetInstanceHistoryResponse](../../Models/Requests/GetInstanceHistoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |

## GetInstanceStageHistory

Get a workflow instance stage history

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getInstanceStageHistory" method="get" path="/api/orchestration/instances/{instanceID}/stages/{number}/history" -->
```csharp
using FormanceSDK;
using FormanceSDK.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.GetInstanceStageHistoryAsync(
    instanceID: "xxx",
    number: 0
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `InstanceID`       | *string*           | :heavy_check_mark: | The instance id    | xxx                |
| `Number`           | *long*             | :heavy_check_mark: | The stage number   | 0                  |

### Response

**[GetInstanceStageHistoryResponse](../../Models/Requests/GetInstanceStageHistoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| FormanceSDK.Models.Errors.Error        | default                                | application/json                       |
| FormanceSDK.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*                                  |