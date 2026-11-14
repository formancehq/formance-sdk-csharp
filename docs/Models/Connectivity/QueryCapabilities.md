# QueryCapabilities

The filterable keys per resource, serialized from the same allowlist
the server enforces -- it cannot drift from what queries accept.



## Fields

| Field                                                                                                             | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `Resources`                                                                                                       | Dictionary<String, Dictionary<String, [QueryFieldCapability](../../Models/Connectivity/QueryFieldCapability.md)>> | :heavy_check_mark:                                                                                                | N/A                                                                                                               |