<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603639/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T424864)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form2.cs](./CS/WindowsFormsApplication1/Form2.cs) (VB: [Form2.vb](./VB/WindowsFormsApplication1/Form2.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
<!-- default file list end -->
# How to suppress the "Report has been changed. Do you want to save changes" message when closing a report in the End-User Report Designer


To achieve this goal, it's possible to override the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUserDesignerReportCommandEnumtopic">ReportCommand.Closing</a> End-User Report Designer command as described in the <a href="https://documentation.devexpress.com/XtraReports/CustomDocument2211.aspx">How to: Override Commands in the End-User Designer (Custom Saving)</a> tutorial not to display this dialog or perform saving of all open reports manually. 

<br/>


