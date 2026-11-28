# Cursor


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `PageSize`                                                                    | *int*                                                                         | :heavy_check_mark:                                                            | N/A                                                                           |
| `HasMore`                                                                     | *bool*                                                                        | :heavy_check_mark:                                                            | N/A                                                                           |
| `Next`                                                                        | *string*                                                                      | :heavy_minus_sign:                                                            | Cursor of the next page; absent on the last page                              |
| `Data`                                                                        | List<[Models.Connectivity.Connector](../../Models/Connectivity/Connector.md)> | :heavy_check_mark:                                                            | N/A                                                                           |