# EvaluateRuleResponse


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `HttpMeta`                                                                          | [HTTPMetadata](../../Models/Components/HTTPMetadata.md)                             | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `EvaluationResponse`                                                                | [EvaluationResponse](../../Models/Reconciliation/EvaluationResponse.md)             | :heavy_minus_sign:                                                                  | OK                                                                                  |
| `ErrorResponse`                                                                     | [Models.Reconciliation.ErrorResponse](../../Models/Reconciliation/ErrorResponse.md) | :heavy_minus_sign:                                                                  | Error response                                                                      |