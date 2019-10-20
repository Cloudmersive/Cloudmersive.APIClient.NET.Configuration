/* 
 * configapi
 *
 * Config API lets you easily manage configuration at scale.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Cloudmersive.APIClient.NET.Configuration.Client;
using Cloudmersive.APIClient.NET.Configuration.Model;

namespace Cloudmersive.APIClient.NET.Configuration.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>CreateSettingResponse</returns>
        CreateSettingResponse SettingsCreateSetting (CreateSettingRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ApiResponse of CreateSettingResponse</returns>
        ApiResponse<CreateSettingResponse> SettingsCreateSettingWithHttpInfo (CreateSettingRequest request);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ListSettingsResponse</returns>
        ListSettingsResponse SettingsListSettings (ListSettingsRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ApiResponse of ListSettingsResponse</returns>
        ApiResponse<ListSettingsResponse> SettingsListSettingsWithHttpInfo (ListSettingsRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of CreateSettingResponse</returns>
        System.Threading.Tasks.Task<CreateSettingResponse> SettingsCreateSettingAsync (CreateSettingRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (CreateSettingResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateSettingResponse>> SettingsCreateSettingAsyncWithHttpInfo (CreateSettingRequest request);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of ListSettingsResponse</returns>
        System.Threading.Tasks.Task<ListSettingsResponse> SettingsListSettingsAsync (ListSettingsRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (ListSettingsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListSettingsResponse>> SettingsListSettingsAsyncWithHttpInfo (ListSettingsRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SettingsApi : ISettingsApi
    {
        private Cloudmersive.APIClient.NET.Configuration.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NET.Configuration.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NET.Configuration.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SettingsApi(Cloudmersive.APIClient.NET.Configuration.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Cloudmersive.APIClient.NET.Configuration.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NET.Configuration.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Cloudmersive.APIClient.NET.Configuration.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NET.Configuration.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>CreateSettingResponse</returns>
        public CreateSettingResponse SettingsCreateSetting (CreateSettingRequest request)
        {
             ApiResponse<CreateSettingResponse> localVarResponse = SettingsCreateSettingWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ApiResponse of CreateSettingResponse</returns>
        public ApiResponse< CreateSettingResponse > SettingsCreateSettingWithHttpInfo (CreateSettingRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling SettingsApi->SettingsCreateSetting");

            var localVarPath = "/config/settings/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SettingsCreateSetting", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateSettingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateSettingResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateSettingResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of CreateSettingResponse</returns>
        public async System.Threading.Tasks.Task<CreateSettingResponse> SettingsCreateSettingAsync (CreateSettingRequest request)
        {
             ApiResponse<CreateSettingResponse> localVarResponse = await SettingsCreateSettingAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (CreateSettingResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateSettingResponse>> SettingsCreateSettingAsyncWithHttpInfo (CreateSettingRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling SettingsApi->SettingsCreateSetting");

            var localVarPath = "/config/settings/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SettingsCreateSetting", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateSettingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateSettingResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateSettingResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ListSettingsResponse</returns>
        public ListSettingsResponse SettingsListSettings (ListSettingsRequest request)
        {
             ApiResponse<ListSettingsResponse> localVarResponse = SettingsListSettingsWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ApiResponse of ListSettingsResponse</returns>
        public ApiResponse< ListSettingsResponse > SettingsListSettingsWithHttpInfo (ListSettingsRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling SettingsApi->SettingsListSettings");

            var localVarPath = "/config/settings/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SettingsListSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListSettingsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListSettingsResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of ListSettingsResponse</returns>
        public async System.Threading.Tasks.Task<ListSettingsResponse> SettingsListSettingsAsync (ListSettingsRequest request)
        {
             ApiResponse<ListSettingsResponse> localVarResponse = await SettingsListSettingsAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Configuration.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (ListSettingsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListSettingsResponse>> SettingsListSettingsAsyncWithHttpInfo (ListSettingsRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling SettingsApi->SettingsListSettings");

            var localVarPath = "/config/settings/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SettingsListSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListSettingsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListSettingsResponse)));
        }

    }
}
