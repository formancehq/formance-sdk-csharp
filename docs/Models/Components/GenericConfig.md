# GenericConfig


## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          | Example                                                                                              |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `Name`                                                                                               | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  | My Generic Account                                                                                   |
| `ApiKey`                                                                                             | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  | XXX                                                                                                  |
| `Endpoint`                                                                                           | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  | XXX                                                                                                  |
| `PollingPeriod`                                                                                      | *string*                                                                                             | :heavy_minus_sign:                                                                                   | The frequency at which the connector will try to fetch new BalanceTransaction objects from the API.<br/> | 60s                                                                                                  |