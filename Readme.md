# How to suppress the "Report has been changed. Do you want to save changes" message when closing a report in the End-User Report Designer


To achieve this goal, it's possible to override the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUserDesignerReportCommandEnumtopic">ReportCommand.Closing</a> End-User Report Designer command as described in the <a href="https://documentation.devexpress.com/XtraReports/CustomDocument2211.aspx">How to: Override Commands in the End-User Designer (Custom Saving)</a> tutorial not to display this dialog or perform saving of all open reports manually. 

<br/>


