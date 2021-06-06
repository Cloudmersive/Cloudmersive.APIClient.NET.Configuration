# Cloudmersive.APIClient.NET.Configuration - the C# library for the configapi

Config API lets you easily manage configuration at scale.

This C# SDK is for the [Cloudmersive Document and Data Conversion API](https://www.cloudmersive.com/convert-api):

- API version: v1
- SDK version: 3.0.3
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NET.Configuration.Api;
using Cloudmersive.APIClient.NET.Configuration.Client;
using Cloudmersive.APIClient.NET.Configuration.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.Configuration.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Configuration.Api;
using Cloudmersive.APIClient.NET.Configuration.Client;
using Cloudmersive.APIClient.NET.Configuration.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new OrchestratorApi();
            var request = new HttpOrchestrationRequest(); // HttpOrchestrationRequest | 

            try
            {
                // Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task.
                HttpOrchestrationResponse result = apiInstance.OrchestratorHttpSimple(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrchestratorApi.OrchestratorHttpSimple: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*OrchestratorApi* | [**OrchestratorHttpSimple**](docs/OrchestratorApi.md#orchestratorhttpsimple) | **POST** /config/orchestrator/http/simple | Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task.
*SettingsApi* | [**SettingsCreateSetting**](docs/SettingsApi.md#settingscreatesetting) | **POST** /config/settings/create | Create a setting in the specified bucket
*SettingsApi* | [**SettingsListSettings**](docs/SettingsApi.md#settingslistsettings) | **POST** /config/settings/list | Enumerate the settings in a bucket
*SettingsApi* | [**SettingsUpdateSetting**](docs/SettingsApi.md#settingsupdatesetting) | **POST** /config/settings/update | Update a setting


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.CreateSettingRequest](docs/CreateSettingRequest.md)
 - [Model.CreateSettingResponse](docs/CreateSettingResponse.md)
 - [Model.HttpFormDataParameter](docs/HttpFormDataParameter.md)
 - [Model.HttpGetParameter](docs/HttpGetParameter.md)
 - [Model.HttpOrchestrationHeader](docs/HttpOrchestrationHeader.md)
 - [Model.HttpOrchestrationRequest](docs/HttpOrchestrationRequest.md)
 - [Model.HttpOrchestrationResponse](docs/HttpOrchestrationResponse.md)
 - [Model.HttpOrchestrationTask](docs/HttpOrchestrationTask.md)
 - [Model.HttpRawBinaryParameter](docs/HttpRawBinaryParameter.md)
 - [Model.HttpRawTextParameter](docs/HttpRawTextParameter.md)
 - [Model.HttpWwwFormUrlEncodedParameter](docs/HttpWwwFormUrlEncodedParameter.md)
 - [Model.ListSettingsRequest](docs/ListSettingsRequest.md)
 - [Model.ListSettingsResponse](docs/ListSettingsResponse.md)
 - [Model.SettingValue](docs/SettingValue.md)
 - [Model.TaskOutputReference](docs/TaskOutputReference.md)
 - [Model.UpdateSettingRequest](docs/UpdateSettingRequest.md)
 - [Model.UpdateSettingResponse](docs/UpdateSettingResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

