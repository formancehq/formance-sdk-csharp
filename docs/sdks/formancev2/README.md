# FormanceV2
(*Orchestration.V2*)

## Overview

### Available Operations

* [GetServerInfo](#getserverinfo) - Get server info
* [ListTriggers](#listtriggers) - List triggers
* [CreateTrigger](#createtrigger) - Create trigger
* [ReadTrigger](#readtrigger) - Read trigger
* [DeleteTrigger](#deletetrigger) - Delete trigger
* [TestTrigger](#testtrigger) - Test trigger
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

var res = await sdk.Orchestration.V2.GetServerInfoAsync();

// handle response
```

### Response

**[V2GetServerInfoResponse](../../Models/Requests/V2GetServerInfoResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.ListTriggersAsync(
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    pageSize: 100,
    name: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                   | 100                                                                                                                                                                                                                      |
| `Name`                                                                                                                                                                                                                   | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | search by name                                                                                                                                                                                                           |                                                                                                                                                                                                                          |

### Response

**[Models.Requests.V2ListTriggersResponse](../../Models/Requests/V2ListTriggersResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

V2TriggerData req = new V2TriggerData() {
    Event = "<value>",
    WorkflowID = "<value>",
};

var res = await sdk.Orchestration.V2.CreateTriggerAsync(req);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [V2TriggerData](../../Models/Components/V2TriggerData.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[Models.Requests.V2CreateTriggerResponse](../../Models/Requests/V2CreateTriggerResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.ReadTriggerAsync(triggerID: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `TriggerID`        | *string*           | :heavy_check_mark: | The trigger id     |

### Response

**[Models.Requests.V2ReadTriggerResponse](../../Models/Requests/V2ReadTriggerResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.DeleteTriggerAsync(triggerID: "<value>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `TriggerID`        | *string*           | :heavy_check_mark: | The trigger id     |

### Response

**[V2DeleteTriggerResponse](../../Models/Requests/V2DeleteTriggerResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## TestTrigger

Test trigger

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

var res = await sdk.Orchestration.V2.TestTriggerAsync(
    triggerID: "<value>",
    requestBody: new Dictionary<string, object>() {
        { "key", "<value>" },
    }
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `TriggerID`                  | *string*                     | :heavy_check_mark:           | The trigger id               |
| `RequestBody`                | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |

### Response

**[TestTriggerResponse](../../Models/Requests/TestTriggerResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.ListTriggersOccurrencesAsync(
    triggerID: "<value>",
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    pageSize: 100
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `TriggerID`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                       | The trigger id                                                                                                                                                                                                           |                                                                                                                                                                                                                          |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                   | 100                                                                                                                                                                                                                      |

### Response

**[Models.Requests.V2ListTriggersOccurrencesResponse](../../Models/Requests/V2ListTriggersOccurrencesResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |


## ListWorkflows

List registered workflows

### Example Usage

```csharp
using formance;
using formance.Models.Requests;
using formance.Models.Components;

var sdk = new Formance(security: new Security() {
    ClientID = "<YOUR_CLIENT_ID_HERE>",
    ClientSecret = "<YOUR_CLIENT_SECRET_HERE>",
});

var res = await sdk.Orchestration.V2.ListWorkflowsAsync(
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    pageSize: 100
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                   | 100                                                                                                                                                                                                                      |

### Response

**[Models.Requests.V2ListWorkflowsResponse](../../Models/Requests/V2ListWorkflowsResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

V2CreateWorkflowRequest req = new V2CreateWorkflowRequest() {
    Stages = new List<Dictionary<string, object>>() {
        new Dictionary<string, object>() {
            { "key", "<value>" },
        },
    },
};

var res = await sdk.Orchestration.V2.CreateWorkflowAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [V2CreateWorkflowRequest](../../Models/Components/V2CreateWorkflowRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[Models.Requests.V2CreateWorkflowResponse](../../Models/Requests/V2CreateWorkflowResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.GetWorkflowAsync(flowId: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `FlowId`           | *string*           | :heavy_check_mark: | The flow id        | xxx                |

### Response

**[Models.Requests.V2GetWorkflowResponse](../../Models/Requests/V2GetWorkflowResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.DeleteWorkflowAsync(flowId: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `FlowId`           | *string*           | :heavy_check_mark: | The flow id        | xxx                |

### Response

**[V2DeleteWorkflowResponse](../../Models/Requests/V2DeleteWorkflowResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.RunWorkflowAsync(
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

**[Models.Requests.V2RunWorkflowResponse](../../Models/Requests/V2RunWorkflowResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.ListInstancesAsync(
    cursor: "aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==",
    pageSize: 100,
    workflowID: "xxx",
    running: true
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                | Type                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                 | Description                                                                                                                                                                                                              | Example                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Cursor`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | Parameter used in pagination requests.<br/>Set to the value of next for the next page of results.<br/>Set to the value of previous for the previous page of results.<br/>No other parameters can be set when this parameter is set.<br/> | aHR0cHM6Ly9nLnBhZ2UvTmVrby1SYW1lbj9zaGFyZQ==                                                                                                                                                                             |
| `PageSize`                                                                                                                                                                                                               | *long*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | The maximum number of results to return per page.<br/>                                                                                                                                                                   | 100                                                                                                                                                                                                                      |
| `WorkflowID`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                       | A workflow id                                                                                                                                                                                                            | xxx                                                                                                                                                                                                                      |
| `Running`                                                                                                                                                                                                                | *bool*                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                       | Filter running instances                                                                                                                                                                                                 | true                                                                                                                                                                                                                     |

### Response

**[V2ListInstancesResponse](../../Models/Requests/V2ListInstancesResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.GetInstanceAsync(instanceID: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `InstanceID`       | *string*           | :heavy_check_mark: | The instance id    | xxx                |

### Response

**[V2GetInstanceResponse](../../Models/Requests/V2GetInstanceResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.SendEventAsync(
    instanceID: "xxx",
    requestBody: new V2SendEventRequestBody() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `InstanceID`                                                              | *string*                                                                  | :heavy_check_mark:                                                        | The instance id                                                           | xxx                                                                       |
| `RequestBody`                                                             | [V2SendEventRequestBody](../../Models/Requests/V2SendEventRequestBody.md) | :heavy_minus_sign:                                                        | N/A                                                                       |                                                                           |

### Response

**[V2SendEventResponse](../../Models/Requests/V2SendEventResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.CancelEventAsync(instanceID: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `InstanceID`       | *string*           | :heavy_check_mark: | The instance id    | xxx                |

### Response

**[V2CancelEventResponse](../../Models/Requests/V2CancelEventResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.GetInstanceHistoryAsync(instanceID: "xxx");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `InstanceID`       | *string*           | :heavy_check_mark: | The instance id    | xxx                |

### Response

**[V2GetInstanceHistoryResponse](../../Models/Requests/V2GetInstanceHistoryResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
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

var res = await sdk.Orchestration.V2.GetInstanceStageHistoryAsync(
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

**[V2GetInstanceStageHistoryResponse](../../Models/Requests/V2GetInstanceStageHistoryResponse.md)**

### Errors

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| formance.Models.Errors.V2Error      | default                             | application/json                    |
| formance.Models.Errors.SDKException | 4xx-5xx                             | */*                                 |
