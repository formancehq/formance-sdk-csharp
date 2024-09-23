# CurrencyCloudConfig


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   | Example                                                                       |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Name`                                                                        | *string*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           | My CurrencyCloud Account                                                      |
| `ApiKey`                                                                      | *string*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           | XXX                                                                           |
| `LoginID`                                                                     | *string*                                                                      | :heavy_check_mark:                                                            | Username of the API Key holder                                                | XXX                                                                           |
| `PollingPeriod`                                                               | *string*                                                                      | :heavy_minus_sign:                                                            | The frequency at which the connector will fetch transactions                  | 60s                                                                           |
| `Endpoint`                                                                    | *string*                                                                      | :heavy_minus_sign:                                                            | The endpoint to use for the API. Defaults to https://devapi.currencycloud.com | XXX                                                                           |