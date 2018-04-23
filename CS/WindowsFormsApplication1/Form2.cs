using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.UserDesigner.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            reportDesigner1.AddCommandHandler(new MyClosingReportCommandHandler(reportDesigner1));

        }
    }

    public class MyClosingReportCommandHandler : ICommandHandler
    {
        XRDesignMdiController controller;

        public MyClosingReportCommandHandler(XRDesignMdiController controller)
        {
            this.controller = controller;
        }
        public bool CanHandleCommand(ReportCommand command, ref bool useNextHandler)
        {
            useNextHandler = !(command == ReportCommand.Closing || command == ReportCommand.Close);
            return !useNextHandler;
        }

        public void HandleCommand(ReportCommand command, object[] args)
        {

            for (int i = 0; i < controller.XtraTabbedMdiManager.View.Documents.Count; i++)
            {
                BaseDocument document = controller.XtraTabbedMdiManager.View.Documents[i];

                XRDesignPanelForm designForm = document.Form as XRDesignPanelForm;
                if (designForm != null)
                {
                    XRDesignPanel panel = designForm.DesignPanel;
                    if (panel.ReportState != ReportState.Saved && panel.ReportState != ReportState.None)
                    {
                        MessageBox.Show("Perform report saving here!");
                        panel.ReportState = ReportState.Saved;
                        panel.CloseReport();
                    }
                }

            }
        }
    }

}
