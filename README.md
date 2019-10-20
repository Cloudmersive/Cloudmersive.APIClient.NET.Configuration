# Cloudmersive.APIClient.NET.DocumentAndDataConvert - the C# library for the convertapi

Convert API lets you effortlessly convert file formats and types.

This C# SDK is for the [Cloudmersive Document and Data Conversion API](https://www.cloudmersive.com/convert-api):

- API version: v1
- SDK version: 2.0.9
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
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.DocumentAndDataConvert.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

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

            var apiInstance = new CompareDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).

            try
            {
                // Compare Two Word DOCX
                byte[] result = apiInstance.CompareDocumentDocx(inputFile1, inputFile2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompareDocumentApi.CompareDocumentDocx: " + e.Message );
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
*CompareDocumentApi* | [**CompareDocumentDocx**](docs/CompareDocumentApi.md#comparedocumentdocx) | **POST** /convert/compare/docx | Compare Two Word DOCX
*ConvertDataApi* | [**ConvertDataCsvToJson**](docs/ConvertDataApi.md#convertdatacsvtojson) | **POST** /convert/csv/to/json | CSV to JSON conversion
*ConvertDataApi* | [**ConvertDataXlsToJson**](docs/ConvertDataApi.md#convertdataxlstojson) | **POST** /convert/xls/to/json | Excel (97-2003) XLS to JSON conversion
*ConvertDataApi* | [**ConvertDataXlsxToJson**](docs/ConvertDataApi.md#convertdataxlsxtojson) | **POST** /convert/xlsx/to/json | Excel XLSX to JSON conversion
*ConvertDataApi* | [**ConvertDataXmlToJson**](docs/ConvertDataApi.md#convertdataxmltojson) | **POST** /convert/xml/to/json | XML to JSON conversion
*ConvertDocumentApi* | [**ConvertDocumentAutodetectGetInfo**](docs/ConvertDocumentApi.md#convertdocumentautodetectgetinfo) | **POST** /convert/autodetect/get-info | Get document type information
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToPdf**](docs/ConvertDocumentApi.md#convertdocumentautodetecttopdf) | **POST** /convert/autodetect/to/pdf | Convert Document to PDF
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToPngArray**](docs/ConvertDocumentApi.md#convertdocumentautodetecttopngarray) | **POST** /convert/autodetect/to/png | Convert Document to PNG array
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToTxt**](docs/ConvertDocumentApi.md#convertdocumentautodetecttotxt) | **POST** /convert/autodetect/to/txt | Convert Document to Text
*ConvertDocumentApi* | [**ConvertDocumentCsvToXlsx**](docs/ConvertDocumentApi.md#convertdocumentcsvtoxlsx) | **POST** /convert/csv/to/xlsx | CSV to Excel XLSX
*ConvertDocumentApi* | [**ConvertDocumentDocToDocx**](docs/ConvertDocumentApi.md#convertdocumentdoctodocx) | **POST** /convert/doc/to/docx | Word DOC (97-03) to DOCX
*ConvertDocumentApi* | [**ConvertDocumentDocToPdf**](docs/ConvertDocumentApi.md#convertdocumentdoctopdf) | **POST** /convert/doc/to/pdf | Word DOC (97-03) to PDF
*ConvertDocumentApi* | [**ConvertDocumentDocxToPdf**](docs/ConvertDocumentApi.md#convertdocumentdocxtopdf) | **POST** /convert/docx/to/pdf | Word DOCX to PDF
*ConvertDocumentApi* | [**ConvertDocumentDocxToTxt**](docs/ConvertDocumentApi.md#convertdocumentdocxtotxt) | **POST** /convert/docx/to/txt | Word DOCX to Text
*ConvertDocumentApi* | [**ConvertDocumentHtmlToPdf**](docs/ConvertDocumentApi.md#convertdocumenthtmltopdf) | **POST** /convert/html/to/pdf | HTML to PDF
*ConvertDocumentApi* | [**ConvertDocumentHtmlToPng**](docs/ConvertDocumentApi.md#convertdocumenthtmltopng) | **POST** /convert/html/to/png | HTML to PNG array
*ConvertDocumentApi* | [**ConvertDocumentPdfToDocx**](docs/ConvertDocumentApi.md#convertdocumentpdftodocx) | **POST** /convert/pdf/to/docx | PDF to Word DOCX
*ConvertDocumentApi* | [**ConvertDocumentPdfToPngArray**](docs/ConvertDocumentApi.md#convertdocumentpdftopngarray) | **POST** /convert/pdf/to/png | PDF to PNG Array
*ConvertDocumentApi* | [**ConvertDocumentPdfToPptx**](docs/ConvertDocumentApi.md#convertdocumentpdftopptx) | **POST** /convert/pdf/to/pptx | PDF to PowerPoint PPTX
*ConvertDocumentApi* | [**ConvertDocumentPdfToTxt**](docs/ConvertDocumentApi.md#convertdocumentpdftotxt) | **POST** /convert/pdf/to/txt | PDF to Text
*ConvertDocumentApi* | [**ConvertDocumentPptToPdf**](docs/ConvertDocumentApi.md#convertdocumentppttopdf) | **POST** /convert/ppt/to/pdf | PowerPoint PPT (97-03) to PDF
*ConvertDocumentApi* | [**ConvertDocumentPptToPptx**](docs/ConvertDocumentApi.md#convertdocumentppttopptx) | **POST** /convert/ppt/to/pptx | PowerPoint PPT (97-03) to PPTX
*ConvertDocumentApi* | [**ConvertDocumentPptxToPdf**](docs/ConvertDocumentApi.md#convertdocumentpptxtopdf) | **POST** /convert/pptx/to/pdf | PowerPoint PPTX to PDF
*ConvertDocumentApi* | [**ConvertDocumentPptxToTxt**](docs/ConvertDocumentApi.md#convertdocumentpptxtotxt) | **POST** /convert/pptx/to/txt | PowerPoint PPTX to Text
*ConvertDocumentApi* | [**ConvertDocumentXlsToCsv**](docs/ConvertDocumentApi.md#convertdocumentxlstocsv) | **POST** /convert/xls/to/csv | Excel XLS (97-03) to CSV
*ConvertDocumentApi* | [**ConvertDocumentXlsToPdf**](docs/ConvertDocumentApi.md#convertdocumentxlstopdf) | **POST** /convert/xls/to/pdf | Excel XLS (97-03) to PDF
*ConvertDocumentApi* | [**ConvertDocumentXlsToXlsx**](docs/ConvertDocumentApi.md#convertdocumentxlstoxlsx) | **POST** /convert/xls/to/xlsx | Excel XLS (97-03) to XLSX
*ConvertDocumentApi* | [**ConvertDocumentXlsxToCsv**](docs/ConvertDocumentApi.md#convertdocumentxlsxtocsv) | **POST** /convert/xlsx/to/csv | Excel XLSX to CSV
*ConvertDocumentApi* | [**ConvertDocumentXlsxToPdf**](docs/ConvertDocumentApi.md#convertdocumentxlsxtopdf) | **POST** /convert/xlsx/to/pdf | Excel XLSX to PDF
*ConvertDocumentApi* | [**ConvertDocumentXlsxToTxt**](docs/ConvertDocumentApi.md#convertdocumentxlsxtotxt) | **POST** /convert/xlsx/to/txt | Excel XLSX to Text
*ConvertImageApi* | [**ConvertImageGetImageInfo**](docs/ConvertImageApi.md#convertimagegetimageinfo) | **POST** /convert/image/get-info | Get information about an image
*ConvertImageApi* | [**ConvertImageImageFormatConvert**](docs/ConvertImageApi.md#convertimageimageformatconvert) | **POST** /convert/image/{format1}/to/{format2} | Image format conversion
*ConvertImageApi* | [**ConvertImageImageSetDPI**](docs/ConvertImageApi.md#convertimageimagesetdpi) | **POST** /convert/image/set-dpi/{dpi} | Change image DPI
*ConvertImageApi* | [**ConvertImageMultipageImageFormatConvert**](docs/ConvertImageApi.md#convertimagemultipageimageformatconvert) | **POST** /convert/image-multipage/{format1}/to/{format2} | Multi-page format conversion
*ConvertTemplateApi* | [**ConvertTemplateApplyDocxTemplate**](docs/ConvertTemplateApi.md#converttemplateapplydocxtemplate) | **POST** /convert/template/docx/apply | Apply Word DOCX template
*ConvertTemplateApi* | [**ConvertTemplateApplyHtmlTemplate**](docs/ConvertTemplateApi.md#converttemplateapplyhtmltemplate) | **POST** /convert/template/html/apply | Apply HTML template
*ConvertWebApi* | [**ConvertWebHtmlToDocx**](docs/ConvertWebApi.md#convertwebhtmltodocx) | **POST** /convert/html/to/docx | HTML to DOCX
*ConvertWebApi* | [**ConvertWebHtmlToPdf**](docs/ConvertWebApi.md#convertwebhtmltopdf) | **POST** /convert/web/html/to/pdf | Convert HTML string to PDF
*ConvertWebApi* | [**ConvertWebMdToHtml**](docs/ConvertWebApi.md#convertwebmdtohtml) | **POST** /convert/web/md/to/html | Convert Markdown to HTML
*ConvertWebApi* | [**ConvertWebUrlToPdf**](docs/ConvertWebApi.md#convertweburltopdf) | **POST** /convert/web/url/to/pdf | Convert a URL to PDF
*ConvertWebApi* | [**ConvertWebUrlToScreenshot**](docs/ConvertWebApi.md#convertweburltoscreenshot) | **POST** /convert/web/url/to/screenshot | Take screenshot of URL
*EditDocumentApi* | [**EditDocumentBeginEditing**](docs/EditDocumentApi.md#editdocumentbeginediting) | **POST** /convert/edit/begin-editing | Begin editing a document
*EditDocumentApi* | [**EditDocumentDocxBody**](docs/EditDocumentApi.md#editdocumentdocxbody) | **POST** /convert/edit/docx/get-body | Get body from a DOCX
*EditDocumentApi* | [**EditDocumentDocxGetHeadersAndFooters**](docs/EditDocumentApi.md#editdocumentdocxgetheadersandfooters) | **POST** /convert/edit/docx/get-headers-and-footers | Get content of a footer from a DOCX
*EditDocumentApi* | [**EditDocumentDocxGetImages**](docs/EditDocumentApi.md#editdocumentdocxgetimages) | **POST** /convert/edit/docx/get-images | Get images from a DOCX
*EditDocumentApi* | [**EditDocumentDocxGetSections**](docs/EditDocumentApi.md#editdocumentdocxgetsections) | **POST** /convert/edit/docx/get-sections | Get sections from a DOCX
*EditDocumentApi* | [**EditDocumentDocxGetStyles**](docs/EditDocumentApi.md#editdocumentdocxgetstyles) | **POST** /convert/edit/docx/get-styles | Get styles from a DOCX
*EditDocumentApi* | [**EditDocumentDocxGetTables**](docs/EditDocumentApi.md#editdocumentdocxgettables) | **POST** /convert/edit/docx/get-tables | Get tables in DOCX
*EditDocumentApi* | [**EditDocumentDocxInsertImage**](docs/EditDocumentApi.md#editdocumentdocxinsertimage) | **POST** /convert/edit/docx/insert-image | Insert image into a DOCX
*EditDocumentApi* | [**EditDocumentDocxInsertParagraph**](docs/EditDocumentApi.md#editdocumentdocxinsertparagraph) | **POST** /convert/edit/docx/insert-paragraph | Insert a new paragraph into a DOCX
*EditDocumentApi* | [**EditDocumentDocxInsertTable**](docs/EditDocumentApi.md#editdocumentdocxinserttable) | **POST** /convert/edit/docx/insert-table | Insert a new table into a DOCX
*EditDocumentApi* | [**EditDocumentDocxRemoveHeadersAndFooters**](docs/EditDocumentApi.md#editdocumentdocxremoveheadersandfooters) | **POST** /convert/edit/docx/remove-headers-and-footers | Remove headers and footers from DOCX
*EditDocumentApi* | [**EditDocumentDocxRemoveObject**](docs/EditDocumentApi.md#editdocumentdocxremoveobject) | **POST** /convert/edit/docx/remove-object | Delete any object in a DOCX
*EditDocumentApi* | [**EditDocumentDocxReplace**](docs/EditDocumentApi.md#editdocumentdocxreplace) | **POST** /convert/edit/docx/replace-all | Replace string in DOCX
*EditDocumentApi* | [**EditDocumentDocxSetFooter**](docs/EditDocumentApi.md#editdocumentdocxsetfooter) | **POST** /convert/edit/docx/set-footer | Set the footer in a DOCX
*EditDocumentApi* | [**EditDocumentDocxSetHeader**](docs/EditDocumentApi.md#editdocumentdocxsetheader) | **POST** /convert/edit/docx/set-header | Set the header in a DOCX
*EditDocumentApi* | [**EditDocumentFinishEditing**](docs/EditDocumentApi.md#editdocumentfinishediting) | **POST** /convert/edit/finish-editing | Download result from document editing
*EditDocumentApi* | [**EditDocumentPptxReplace**](docs/EditDocumentApi.md#editdocumentpptxreplace) | **POST** /convert/edit/pptx/replace-all | Replace string in PPTX
*EditDocumentApi* | [**EditDocumentXlsxGetColumns**](docs/EditDocumentApi.md#editdocumentxlsxgetcolumns) | **POST** /convert/edit/xlsx/get-columns | Get rows and cells from a XLSX worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetImages**](docs/EditDocumentApi.md#editdocumentxlsxgetimages) | **POST** /convert/edit/xlsx/get-images | Get images from a XLSX worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetRowsAndCells**](docs/EditDocumentApi.md#editdocumentxlsxgetrowsandcells) | **POST** /convert/edit/xlsx/get-rows-and-cells | Get rows and cells from a XLSX worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetStyles**](docs/EditDocumentApi.md#editdocumentxlsxgetstyles) | **POST** /convert/edit/xlsx/get-styles | Get styles from a XLSX worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetWorksheets**](docs/EditDocumentApi.md#editdocumentxlsxgetworksheets) | **POST** /convert/edit/xlsx/get-worksheets | Get worksheets from a XLSX
*EditDocumentApi* | [**EditDocumentXlsxInsertWorksheet**](docs/EditDocumentApi.md#editdocumentxlsxinsertworksheet) | **POST** /convert/edit/xlsx/insert-worksheet | Insert a new worksheet into an XLSX spreadsheet
*MergeDocumentApi* | [**MergeDocumentDocx**](docs/MergeDocumentApi.md#mergedocumentdocx) | **POST** /convert/merge/docx | Merge Multple Word DOCX Together
*MergeDocumentApi* | [**MergeDocumentPdf**](docs/MergeDocumentApi.md#mergedocumentpdf) | **POST** /convert/merge/pdf | Merge Multple PDF Files Together
*MergeDocumentApi* | [**MergeDocumentPptx**](docs/MergeDocumentApi.md#mergedocumentpptx) | **POST** /convert/merge/pptx | Merge Multple PowerPoint PPTX Together
*MergeDocumentApi* | [**MergeDocumentXlsx**](docs/MergeDocumentApi.md#mergedocumentxlsx) | **POST** /convert/merge/xlsx | Merge Multple Excel XLSX Together
*SplitDocumentApi* | [**SplitDocumentXlsx**](docs/SplitDocumentApi.md#splitdocumentxlsx) | **POST** /convert/split/xlsx | Split a single Excel XLSX into Separate Worksheets
*ValidateDocumentApi* | [**ValidateDocumentDocxValidation**](docs/ValidateDocumentApi.md#validatedocumentdocxvalidation) | **POST** /convert/validate/docx | Validate a Word document (DOCX)
*ValidateDocumentApi* | [**ValidateDocumentPptxValidation**](docs/ValidateDocumentApi.md#validatedocumentpptxvalidation) | **POST** /convert/validate/pptx | Validate a PowerPoint presentation (PPTX)
*ValidateDocumentApi* | [**ValidateDocumentXlsxValidation**](docs/ValidateDocumentApi.md#validatedocumentxlsxvalidation) | **POST** /convert/validate/xlsx | Validate a Excel document (XLSX)
*ViewerToolsApi* | [**ViewerToolsCreateSimple**](docs/ViewerToolsApi.md#viewertoolscreatesimple) | **POST** /convert/viewer/create/web/simple | Create a web-based viewer


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AlternateFileFormatCandidate](docs/AlternateFileFormatCandidate.md)
 - [Model.AutodetectGetInfoResult](docs/AutodetectGetInfoResult.md)
 - [Model.AutodetectToPngResult](docs/AutodetectToPngResult.md)
 - [Model.ConvertedPngPage](docs/ConvertedPngPage.md)
 - [Model.DocumentValidationError](docs/DocumentValidationError.md)
 - [Model.DocumentValidationResult](docs/DocumentValidationResult.md)
 - [Model.DocxBody](docs/DocxBody.md)
 - [Model.DocxCellStyle](docs/DocxCellStyle.md)
 - [Model.DocxFooter](docs/DocxFooter.md)
 - [Model.DocxHeader](docs/DocxHeader.md)
 - [Model.DocxImage](docs/DocxImage.md)
 - [Model.DocxInsertImageRequest](docs/DocxInsertImageRequest.md)
 - [Model.DocxInsertImageResponse](docs/DocxInsertImageResponse.md)
 - [Model.DocxParagraph](docs/DocxParagraph.md)
 - [Model.DocxRemoveObjectRequest](docs/DocxRemoveObjectRequest.md)
 - [Model.DocxRemoveObjectResponse](docs/DocxRemoveObjectResponse.md)
 - [Model.DocxRun](docs/DocxRun.md)
 - [Model.DocxSection](docs/DocxSection.md)
 - [Model.DocxSetFooterRequest](docs/DocxSetFooterRequest.md)
 - [Model.DocxSetFooterResponse](docs/DocxSetFooterResponse.md)
 - [Model.DocxSetHeaderRequest](docs/DocxSetHeaderRequest.md)
 - [Model.DocxSetHeaderResponse](docs/DocxSetHeaderResponse.md)
 - [Model.DocxStyle](docs/DocxStyle.md)
 - [Model.DocxTable](docs/DocxTable.md)
 - [Model.DocxTableCell](docs/DocxTableCell.md)
 - [Model.DocxTableRow](docs/DocxTableRow.md)
 - [Model.DocxTemplateApplicationRequest](docs/DocxTemplateApplicationRequest.md)
 - [Model.DocxTemplateOperation](docs/DocxTemplateOperation.md)
 - [Model.DocxText](docs/DocxText.md)
 - [Model.ExifValue](docs/ExifValue.md)
 - [Model.FinishEditingRequest](docs/FinishEditingRequest.md)
 - [Model.GetDocxBodyRequest](docs/GetDocxBodyRequest.md)
 - [Model.GetDocxBodyResponse](docs/GetDocxBodyResponse.md)
 - [Model.GetDocxHeadersAndFootersRequest](docs/GetDocxHeadersAndFootersRequest.md)
 - [Model.GetDocxHeadersAndFootersResponse](docs/GetDocxHeadersAndFootersResponse.md)
 - [Model.GetDocxImagesRequest](docs/GetDocxImagesRequest.md)
 - [Model.GetDocxImagesResponse](docs/GetDocxImagesResponse.md)
 - [Model.GetDocxSectionsRequest](docs/GetDocxSectionsRequest.md)
 - [Model.GetDocxSectionsResponse](docs/GetDocxSectionsResponse.md)
 - [Model.GetDocxStylesRequest](docs/GetDocxStylesRequest.md)
 - [Model.GetDocxStylesResponse](docs/GetDocxStylesResponse.md)
 - [Model.GetDocxTablesRequest](docs/GetDocxTablesRequest.md)
 - [Model.GetDocxTablesResponse](docs/GetDocxTablesResponse.md)
 - [Model.GetImageInfoResult](docs/GetImageInfoResult.md)
 - [Model.GetXlsxColumnsRequest](docs/GetXlsxColumnsRequest.md)
 - [Model.GetXlsxColumnsResponse](docs/GetXlsxColumnsResponse.md)
 - [Model.GetXlsxImagesRequest](docs/GetXlsxImagesRequest.md)
 - [Model.GetXlsxImagesResponse](docs/GetXlsxImagesResponse.md)
 - [Model.GetXlsxRowsAndCellsRequest](docs/GetXlsxRowsAndCellsRequest.md)
 - [Model.GetXlsxRowsAndCellsResponse](docs/GetXlsxRowsAndCellsResponse.md)
 - [Model.GetXlsxStylesRequest](docs/GetXlsxStylesRequest.md)
 - [Model.GetXlsxStylesResponse](docs/GetXlsxStylesResponse.md)
 - [Model.GetXlsxWorksheetsRequest](docs/GetXlsxWorksheetsRequest.md)
 - [Model.GetXlsxWorksheetsResponse](docs/GetXlsxWorksheetsResponse.md)
 - [Model.HtmlMdResult](docs/HtmlMdResult.md)
 - [Model.HtmlTemplateApplicationRequest](docs/HtmlTemplateApplicationRequest.md)
 - [Model.HtmlTemplateApplicationResponse](docs/HtmlTemplateApplicationResponse.md)
 - [Model.HtmlTemplateOperation](docs/HtmlTemplateOperation.md)
 - [Model.HtmlToOfficeRequest](docs/HtmlToOfficeRequest.md)
 - [Model.HtmlToPdfRequest](docs/HtmlToPdfRequest.md)
 - [Model.InsertDocxInsertParagraphRequest](docs/InsertDocxInsertParagraphRequest.md)
 - [Model.InsertDocxInsertParagraphResponse](docs/InsertDocxInsertParagraphResponse.md)
 - [Model.InsertDocxTablesRequest](docs/InsertDocxTablesRequest.md)
 - [Model.InsertDocxTablesResponse](docs/InsertDocxTablesResponse.md)
 - [Model.InsertXlsxWorksheetRequest](docs/InsertXlsxWorksheetRequest.md)
 - [Model.InsertXlsxWorksheetResponse](docs/InsertXlsxWorksheetResponse.md)
 - [Model.MultipageImageFormatConversionResult](docs/MultipageImageFormatConversionResult.md)
 - [Model.PageConversionResult](docs/PageConversionResult.md)
 - [Model.PdfToPngResult](docs/PdfToPngResult.md)
 - [Model.RemoveDocxHeadersAndFootersRequest](docs/RemoveDocxHeadersAndFootersRequest.md)
 - [Model.RemoveDocxHeadersAndFootersResponse](docs/RemoveDocxHeadersAndFootersResponse.md)
 - [Model.ReplaceStringRequest](docs/ReplaceStringRequest.md)
 - [Model.ScreenshotRequest](docs/ScreenshotRequest.md)
 - [Model.SplitXlsxWorksheetResult](docs/SplitXlsxWorksheetResult.md)
 - [Model.TextConversionResult](docs/TextConversionResult.md)
 - [Model.ViewerResponse](docs/ViewerResponse.md)
 - [Model.WorksheetResult](docs/WorksheetResult.md)
 - [Model.XlsxImage](docs/XlsxImage.md)
 - [Model.XlsxSpreadsheetCell](docs/XlsxSpreadsheetCell.md)
 - [Model.XlsxSpreadsheetColumn](docs/XlsxSpreadsheetColumn.md)
 - [Model.XlsxSpreadsheetRow](docs/XlsxSpreadsheetRow.md)
 - [Model.XlsxWorksheet](docs/XlsxWorksheet.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

