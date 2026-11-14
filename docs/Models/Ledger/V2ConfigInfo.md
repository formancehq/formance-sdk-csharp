# V2ConfigInfo


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `Server`                                              | *string*                                              | :heavy_check_mark:                                    | Name of the server serving the API                    |
| `Version`                                             | *string*                                              | :heavy_check_mark:                                    | Version of the ledger service                         |
| `ExperimentalFeatures`                                | List<*string*>                                        | :heavy_minus_sign:                                    | Experimental feature flags enabled on this deployment |