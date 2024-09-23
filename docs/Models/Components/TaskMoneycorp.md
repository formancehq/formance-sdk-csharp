# TaskMoneycorp


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Id`                                                                                  | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `ConnectorID`                                                                         | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `CreatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `UpdatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Status`                                                                              | [PaymentStatus](../../Models/Components/PaymentStatus.md)                             | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `State`                                                                               | [TaskMoneycorpState](../../Models/Components/TaskMoneycorpState.md)                   | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Error`                                                                               | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Descriptor`                                                                          | [TaskMoneycorpDescriptor](../../Models/Components/TaskMoneycorpDescriptor.md)         | :heavy_check_mark:                                                                    | N/A                                                                                   |