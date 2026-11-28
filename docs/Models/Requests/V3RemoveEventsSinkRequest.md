# V3RemoveEventsSinkRequest


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `SinkName`                                                    | *string*                                                      | :heavy_check_mark:                                            | Name of the event sink to remove                              |
| `ControllerId`                                                | *string*                                                      | :heavy_minus_sign:                                            | Optional opaque owner identity used as a removal precondition |
| `IdempotencyKey`                                              | *string*                                                      | :heavy_minus_sign:                                            | Idempotency key for the request                               |