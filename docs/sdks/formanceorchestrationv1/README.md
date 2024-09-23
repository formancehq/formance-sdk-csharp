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

```csharp
using formance;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ListTriggers

List triggers

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.ListTriggersAsync(name: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Name`             | *string*           | :heavy_minus_sign: | search by name     |

### Response

**[Models.Requests.ListTriggersResponse](../../Models/Requests/ListTriggersResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## CreateTrigger

Create trigger

### Example Usage

```csharp
using formance;
using formance.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

TriggerData req = new TriggerData() {
    Event = "<value>",
    WorkflowID = "<value>",
};

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ReadTrigger

Read trigger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.ReadTriggerAsync(triggerID: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `TriggerID`        | *string*           | :heavy_check_mark: | The trigger id     |

### Response

**[Models.Requests.ReadTriggerResponse](../../Models/Requests/ReadTriggerResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## DeleteTrigger

Read trigger

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.DeleteTriggerAsync(triggerID: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `TriggerID`        | *string*           | :heavy_check_mark: | The trigger id     |

### Response

**[DeleteTriggerResponse](../../Models/Requests/DeleteTriggerResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ListTriggersOccurrences

List triggers occurrences

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.ListTriggersOccurrencesAsync(triggerID: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `TriggerID`        | *string*           | :heavy_check_mark: | The trigger id     |

### Response

**[Models.Requests.ListTriggersOccurrencesResponse](../../Models/Requests/ListTriggersOccurrencesResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ListWorkflows

List registered workflows

### Example Usage

```csharp
using formance;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## CreateWorkflow

Create a workflow

### Example Usage

```csharp
using formance;
using formance.Models.Components;
using System.Collections.Generic;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

CreateWorkflowRequest req = new CreateWorkflowRequest() {
    Stages = new List<Dictionary<string, object>>() {
        new Dictionary<string, object>() {
            { "key", "<value>" },
        },
    },
};

var res = await sdk.Orchestration.V1.CreateWorkflowAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateWorkflowRequest](../../Models/Components/CreateWorkflowRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[Models.Requests.CreateWorkflowResponse](../../Models/Requests/CreateWorkflowResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## GetWorkflow

Get a flow by id

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## DeleteWorkflow

Delete a flow by id

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## RunWorkflow

Run workflow

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using System.Collections.Generic;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.RunWorkflowAsync(
    workflowID: "xxx",
    wait: false,
    requestBody: new Dictionary<string, string>() {
        { "key", "<value>" },
    }
);

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ListInstances

List instances of a workflow

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## GetInstance

Get a workflow instance by id

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## SendEvent

Send an event to a running workflow

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V1.SendEventAsync(
    instanceID: "xxx",
    requestBody: new SendEventRequestBody() {
        Name = "<value>",
    }
);

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## CancelEvent

Cancel a running workflow

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## GetInstanceHistory

Get a workflow instance history by id

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## GetInstanceStageHistory

Get a workflow instance stage history

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.Error        | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |
