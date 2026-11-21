# GetVersionsResponse


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `Region`                                                        | *string*                                                        | :heavy_check_mark:                                              | Region the stack is deployed in                                 |
| `Env`                                                           | *string*                                                        | :heavy_check_mark:                                              | Environment the stack is deployed in                            |
| `Versions`                                                      | List<[Models.Gateway.Version](../../Models/Gateway/Version.md)> | :heavy_check_mark:                                              | Version and health of each component in the stack               |