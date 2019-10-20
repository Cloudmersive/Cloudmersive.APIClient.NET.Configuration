# Cloudmersive.APIClient.NET.Configuration.Api.SettingsApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SettingsCreateSetting**](SettingsApi.md#settingscreatesetting) | **POST** /config/settings/create | 
[**SettingsListSettings**](SettingsApi.md#settingslistsettings) | **POST** /config/settings/list | 


<a name="settingscreatesetting"></a>
# **SettingsCreateSetting**
> CreateSettingResponse SettingsCreateSetting (CreateSettingRequest request)



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
            var request = new CreateSettingRequest(); // CreateSettingRequest | 

            try
            {
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
 **request** | [**CreateSettingRequest**](CreateSettingRequest.md)|  | 

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
            var request = new ListSettingsRequest(); // ListSettingsRequest | 

            try
            {
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
 **request** | [**ListSettingsRequest**](ListSettingsRequest.md)|  | 

### Return type

[**ListSettingsResponse**](ListSettingsResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

