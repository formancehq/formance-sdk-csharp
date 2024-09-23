# AccountWithVolumesAndBalances


## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    | Example                                                                                                        |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `Address`                                                                                                      | *string*                                                                                                       | :heavy_check_mark:                                                                                             | N/A                                                                                                            | users:001                                                                                                      |
| `Type`                                                                                                         | *string*                                                                                                       | :heavy_minus_sign:                                                                                             | N/A                                                                                                            | virtual                                                                                                        |
| `Metadata`                                                                                                     | Dictionary<String, *object*>                                                                                   | :heavy_minus_sign:                                                                                             | N/A                                                                                                            | {<br/>"admin": true,<br/>"a": {<br/>"nested": {<br/>"key": "value"<br/>}<br/>}<br/>}                           |
| `Volumes`                                                                                                      | Dictionary<String, [Volume](../../Models/Components/Volume.md)>                                                | :heavy_minus_sign:                                                                                             | N/A                                                                                                            | {<br/>"USD": {<br/>"input": 100,<br/>"output": 10,<br/>"balance": 90<br/>},<br/>"EUR": {<br/>"input": 100,<br/>"output": 10,<br/>"balance": 90<br/>}<br/>} |
| `Balances`                                                                                                     | Dictionary<String, *BigInteger*>                                                                               | :heavy_minus_sign:                                                                                             | N/A                                                                                                            | {<br/>"COIN": 100<br/>}                                                                                        |