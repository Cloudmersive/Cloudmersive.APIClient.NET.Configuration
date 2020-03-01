# Cloudmersive.APIClient.NET.Configuration.Api.SettingsApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SettingsCreateSetting**](SettingsApi.md#settingscreatesetting) | **POST** /config/settings/create | Create a setting in the specified bucket
[**SettingsListSettings**](SettingsApi.md#settingslistsettings) | **POST** /config/settings/list | Enumerate the settings in a bucket
[**SettingsUpdateSetting**](SettingsApi.md#settingsupdatesetting) | **POST** /config/settings/update | Update a setting


<a name="settingscreatesetting"></a>
# **SettingsCreateSetting**
> CreateSettingResponse SettingsCreateSetting (CreateSettingRequest request)

Create a setting in the specified bucket

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Configuration.Api;
using Cloudmersive.APIClient.NET.Configuration.Client;
using Cloudmersive.APIClient.NET.Configuration.Model;

namespace Example
{
    public class SettingsCreateSettingExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SettingsApi();
            var request = new CreateSettingRequest(); // CreateSettingRequest | Request to perform the operation on

            try
            {
                // Create a setting in the specified bucket
                CreateSettingResponse result = apiInstance.SettingsCreateSetting(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.SettingsCreateSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateSettingRequest**](CreateSettingRequest.md)| Request to perform the operation on | 

### Return type

[**CreateSettingResponse**](CreateSettingResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settingslistsettings"></a>
# **SettingsListSettings**
> ListSettingsResponse SettingsListSettings (ListSettingsRequest request)

Enumerate the settings in a bucket

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Configuration.Api;
using Cloudmersive.APIClient.NET.Configuration.Client;
using Cloudmersive.APIClient.NET.Configuration.Model;

namespace Example
{
    public class SettingsListSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SettingsApi();
            var request = new ListSettingsRequest(); // ListSettingsRequest | Request to perform the operation on

            try
            {
                // Enumerate the settings in a bucket
                ListSettingsResponse result = apiInstance.SettingsListSettings(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.SettingsListSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ListSettingsRequest**](ListSettingsRequest.md)| Request to perform the operation on | 

### Return type

[**ListSettingsResponse**](ListSettingsResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settingsupdatesetting"></a>
# **SettingsUpdateSetting**
> UpdateSettingResponse SettingsUpdateSetting (UpdateSettingRequest request)

Update a setting

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Configuration.Api;
using Cloudmersive.APIClient.NET.Configuration.Client;
using Cloudmersive.APIClient.NET.Configuration.Model;

namespace Example
{
    public class SettingsUpdateSettingExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SettingsApi();
            var request = new UpdateSettingRequest(); // UpdateSettingRequest | Request to perform the operation on

            try
            {
                // Update a setting
                UpdateSettingResponse result = apiInstance.SettingsUpdateSetting(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.SettingsUpdateSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UpdateSettingRequest**](UpdateSettingRequest.md)| Request to perform the operation on | 

### Return type

[**UpdateSettingResponse**](UpdateSettingResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

