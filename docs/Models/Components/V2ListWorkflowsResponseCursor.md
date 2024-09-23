# V2ListWorkflowsResponseCursor


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               | Example                                                   |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `PageSize`                                                | *long*                                                    | :heavy_check_mark:                                        | N/A                                                       | 15                                                        |
| `HasMore`                                                 | *bool*                                                    | :heavy_check_mark:                                        | N/A                                                       | false                                                     |
| `Previous`                                                | *string*                                                  | :heavy_minus_sign:                                        | N/A                                                       | YXVsdCBhbmQgYSBtYXhpbXVtIG1heF9yZXN1bHRzLol=              |
| `Next`                                                    | *string*                                                  | :heavy_minus_sign:                                        | N/A                                                       |                                                           |
| `Data`                                                    | List<[V2Workflow](../../Models/Components/V2Workflow.md)> | :heavy_check_mark:                                        | N/A                                                       |                                                           |