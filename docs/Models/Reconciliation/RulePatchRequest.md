# RulePatchRequest

Partial update — only fields supplied are applied.


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Name`                                                      | *string*                                                    | :heavy_minus_sign:                                          | N/A                                                         |
| `TemplateKind`                                              | [TemplateKind](../../Models/Reconciliation/TemplateKind.md) | :heavy_minus_sign:                                          | N/A                                                         |
| `TemplateSpec`                                              | Dictionary<String, *object*>                                | :heavy_minus_sign:                                          | N/A                                                         |
| `Enabled`                                                   | *bool*                                                      | :heavy_minus_sign:                                          | N/A                                                         |
| `Severity`                                                  | [Severity](../../Models/Reconciliation/Severity.md)         | :heavy_minus_sign:                                          | N/A                                                         |
| `Schedule`                                                  | [Schedule](../../Models/Reconciliation/Schedule.md)         | :heavy_minus_sign:                                          | N/A                                                         |
| `Notifications`                                             | List<*string*>                                              | :heavy_minus_sign:                                          | N/A                                                         |
| `Labels`                                                    | Dictionary<String, *string*>                                | :heavy_minus_sign:                                          | N/A                                                         |