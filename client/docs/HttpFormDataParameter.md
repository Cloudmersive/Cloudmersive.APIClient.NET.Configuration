# Cloudmersive.APIClient.NET.Configuration.Model.HttpFormDataParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParameterName** | **string** | Name of the parameter | [optional] 
**ParameterTextValue** | **string** | Text value of the parameter; if set, do not set ParameterFileContents or UseOutputFromPreviousTask | [optional] 
**ParameterFileContents** | **byte[]** | Binary contents of the parameter; if set, do not set ParameterTextValue or UseOutputFromPreviousTask | [optional] 
**UseOutputFromPreviousTask** | [**TaskOutputReference**](TaskOutputReference.md) | Optional; use the output from a previous task as the input to this parameter.  Set to null (default) to ignore. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

