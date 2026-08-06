# Snooze

A time-boxed, operator-initiated mute of an alert's notifications. While
`until` is in the future the alert keeps failing and keeps counting
against period-green — only its notifications are suppressed.



## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Until`                                                                               | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | N/A                                                                                   |                                                                                       |
| `By`                                                                                  | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   | ops@buildr.com                                                                        |
| `At`                                                                                  | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | N/A                                                                                   |                                                                                       |
| `Note`                                                                                | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |