# ReplayDeliveryResponse


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `HttpMeta`                                                    | [HTTPMetadata](../../Models/Components/HTTPMetadata.md)       | :heavy_check_mark:                                            | N/A                                                           |
| `DeliveryResponse`                                            | [DeliveryResponse](../../Models/Webhooks/DeliveryResponse.md) | :heavy_minus_sign:                                            | Delivery synchronously placed back in the durable queue.      |