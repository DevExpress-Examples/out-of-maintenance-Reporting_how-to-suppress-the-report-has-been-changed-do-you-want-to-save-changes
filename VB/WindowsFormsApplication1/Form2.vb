Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraReports.UserDesigner.Native
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
    Partial Public Class Form2
        Inherits Form

        Public Sub New()
            InitializeComponent()
            reportDesigner1.AddCommandHandler(New MyClosingReportCommandHandler(reportDesigner1))

        End Sub
    End Class

    Public Class MyClosingReportCommandHandler
        Implements ICommandHandler

        Private controller As XRDesignMdiController

        Public Sub New(ByVal controller As XRDesignMdiController)
            Me.controller = controller
        End Sub
        Public Function CanHandleCommand(ByVal command As ReportCommand, ByRef useNextHandler As Boolean) As Boolean Implements ICommandHandler.CanHandleCommand
            useNextHandler = Not (command = ReportCommand.Closing Or command = ReportCommand.Close)
            Return Not useNextHandler
        End Function

        Public Sub HandleCommand(ByVal command As ReportCommand, ByVal args() As Object) Implements ICommandHandler.HandleCommand

            For i As Integer = 0 To controller.XtraTabbedMdiManager.View.Documents.Count - 1
                Dim document As BaseDocument = controller.XtraTabbedMdiManager.View.Documents(i)

                Dim designForm As XRDesignPanelForm = TryCast(document.Form, XRDesignPanelForm)
                If designForm IsNot Nothing Then
                    Dim panel As XRDesignPanel = designForm.DesignPanel
                    If panel.ReportState <> ReportState.Saved AndAlso panel.ReportState <> ReportState.None Then
                        MessageBox.Show("Perform report saving here!")
                        panel.ReportState = ReportState.Saved
                        panel.CloseReport()
                    End If
                End If

            Next i
        End Sub
    End Class

End Namespace
