# AuditFailure

Stable reason, subcode, and facts for a failed proposal. Presentation text is rendered when read and is not stored in the audit chain.


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `Reason`                                                             | *string*                                                             | :heavy_minus_sign:                                                   | Typed error reason identifier (e.g. ERROR_REASON_INSUFFICIENT_FUNDS) |
| `Code`                                                               | *string*                                                             | :heavy_minus_sign:                                                   | Stable failure subcode                                               |
| `Facts`                                                              | Dictionary<String, *string*>                                         | :heavy_minus_sign:                                                   | Validated facts used to render the failure                           |