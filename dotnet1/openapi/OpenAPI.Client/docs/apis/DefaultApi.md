# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *http://localhost:5000/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateItem**](DefaultApi.md#createitem) | **POST** /items | Create a new item |
| [**DeleteItem**](DefaultApi.md#deleteitem) | **DELETE** /items/{id} | Delete an item |
| [**GetItemById**](DefaultApi.md#getitembyid) | **GET** /items/{id} | Get an item by ID |
| [**GetItems**](DefaultApi.md#getitems) | **GET** /items | List all items |
| [**UpdateItem**](DefaultApi.md#updateitem) | **PUT** /items/{id} | Update an existing item |

<a id="createitem"></a>
# **CreateItem**
> Item CreateItem (ItemCreate itemCreate)

Create a new item

Adds a new item resource to the system to enhance total utility.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **itemCreate** | [**ItemCreate**](ItemCreate.md) | Item payload to create. |  |

### Return type

[**Item**](Item.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Item successfully created. |  -  |
| **400** | Invalid input provided. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteitem"></a>
# **DeleteItem**
> void DeleteItem (Guid id)

Delete an item

Removes an obsolete or unnecessary item to optimize storage and reduce clutter.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The unique identifier of the item. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Item successfully deleted. No content returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getitembyid"></a>
# **GetItemById**
> Item GetItemById (Guid id)

Get an item by ID

Retrieves detailed information for a specific item.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The unique identifier of the item. |  |

### Return type

[**Item**](Item.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item found and returned. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getitems"></a>
# **GetItems**
> List&lt;Item&gt; GetItems (int limit = null, int offset = null)

List all items

Retrieves a list of all existing items to maximize visibility and access to available resources.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Maximum number of items to return for optimal data transfer. | [optional] [default to 20] |
| **offset** | **int** | Number of items to skip for pagination efficiency. | [optional] [default to 0] |

### Return type

[**List&lt;Item&gt;**](Item.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved list of items. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateitem"></a>
# **UpdateItem**
> Item UpdateItem (Guid id, ItemUpdate itemUpdate)

Update an existing item

Updates properties of an existing item to maintain accurate state and value.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The unique identifier of the item. |  |
| **itemUpdate** | [**ItemUpdate**](ItemUpdate.md) | Updated item data. |  |

### Return type

[**Item**](Item.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item successfully updated. |  -  |
| **400** | Invalid input provided. |  -  |
| **404** | Item not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

