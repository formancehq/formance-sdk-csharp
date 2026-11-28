# Workflow

A workflow definition and the stages it runs


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Config`                                                                              | [WorkflowConfig](../../Models/Orchestration/WorkflowConfig.md)                        | :heavy_check_mark:                                                                    | The stages a workflow runs, in order                                                  |
| `CreatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | When the workflow was created                                                         |
| `UpdatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | When the workflow was last modified                                                   |
| `Id`                                                                                  | *string*                                                                              | :heavy_check_mark:                                                                    | Unique identifier of the workflow                                                     |