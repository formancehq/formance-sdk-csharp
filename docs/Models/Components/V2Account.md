# V2Account


## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    | Example                                                                                                        |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `Address`                                                                                                      | *string*                                                                                                       | :heavy_check_mark:                                                                                             | N/A                                                                                                            | users:001                                                                                                      |
| `Metadata`                                                                                                     | Dictionary<String, *string*>                                                                                   | :heavy_check_mark:                                                                                             | N/A                                                                                                            | {<br/>"admin": "true"<br/>}                                                                                    |
| `Volumes`                                                                                                      | Dictionary<String, [V2Volume](../../Models/Components/V2Volume.md)>                                            | :heavy_minus_sign:                                                                                             | N/A                                                                                                            | {<br/>"USD": {<br/>"input": 100,<br/>"output": 10,<br/>"balance": 90<br/>},<br/>"EUR": {<br/>"input": 100,<br/>"output": 10,<br/>"balance": 90<br/>}<br/>} |
| `EffectiveVolumes`                                                                                             | Dictionary<String, [V2Volume](../../Models/Components/V2Volume.md)>                                            | :heavy_minus_sign:                                                                                             | N/A                                                                                                            | {<br/>"USD": {<br/>"input": 100,<br/>"output": 10,<br/>"balance": 90<br/>},<br/>"EUR": {<br/>"input": 100,<br/>"output": 10,<br/>"balance": 90<br/>}<br/>} |