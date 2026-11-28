# StageDelay


## Fields

| Field                                                                                     | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Until`                                                                                   | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)     | :heavy_minus_sign:                                                                        | Wait until this absolute point in time. Mutually exclusive with duration                  |
| `Duration`                                                                                | *string*                                                                                  | :heavy_minus_sign:                                                                        | Wait for this long, expressed as a Go duration such as 10s. Mutually exclusive with until |