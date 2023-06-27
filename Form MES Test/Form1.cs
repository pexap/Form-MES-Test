using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camstar.WCF.Services;
using Camstar.WCF.ObjectStack;
using Camstar.Util;
using Camstar.Exceptions;

namespace Form_MES_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string id = "Administrator";
        string pw = "Ocg123!";

        private void btn_MoveStd(object sender, EventArgs e)
        {
            try
            {
                MoveStdService oCDOService = new MoveStdService(new UserProfile(id, pw));
                MoveStd oCDO = new MoveStd { Container = new ContainerRef("AAA") };
                ResultStatus oResultStatus = oCDOService.ExecuteTransaction(oCDO);

                if (oResultStatus.IsSuccess) textBox_Log.AppendText(oResultStatus.Message + System.Environment.NewLine);
                else throw new Exception(oResultStatus.ExceptionData.Description);
            }
            catch (Exception ex)
            {
                textBox_Log.AppendText(ex.Message + System.Environment.NewLine);
            }
        }

        private void btn_FactoryAdd(object sender, EventArgs e)
        {
            try
            {
                FactoryMaintService oCDOService = new FactoryMaintService(new UserProfile(id, pw));
                FactoryMaint oCDO = new FactoryMaint();
                oCDO.ObjectChanges = new FactoryChanges { Name = "Factory 1", Description = "My First Factory" };
                oCDOService.BeginTransaction();
                oCDOService.New(oCDO);
                oCDOService.ExecuteTransaction();

                ResultStatus oResultstatus = oCDOService.CommitTransaction();

                if (oResultstatus.IsSuccess) textBox_Log.AppendText(oResultstatus.Message + System.Environment.NewLine);
                else throw new Exception(oResultstatus.ExceptionData.Description);
            }
            catch(Exception ex)
            {
                textBox_Log.AppendText(ex.Message + System.Environment.NewLine);
            }
        }

        private void btn_FactoryUpdate(object sender, EventArgs e)
        {
            try
            {
                FactoryMaintService oCDOService = new FactoryMaintService(new UserProfile(id, pw));
                FactoryMaint oCDO = new FactoryMaint();
                oCDO.ObjectToChange = new NamedObjectRef { Name = "Factory 1" };
                oCDOService.BeginTransaction();
                oCDOService.Load(oCDO);

                oCDO = new FactoryMaint();

                oCDO.ObjectChanges = new FactoryChanges();
                oCDO.ObjectChanges.Description = "Factory 1 Modified";
                oCDOService.ExecuteTransaction(oCDO);

                ResultStatus oResultStatus = oCDOService.CommitTransaction();

                if (oResultStatus.IsSuccess) textBox_Log.AppendText(oResultStatus.Message + System.Environment.NewLine);
                else throw new Exception(oResultStatus.ExceptionData.Description);
            }
            catch(Exception ex)
            {
                textBox_Log.AppendText(ex.Message + System.Environment.NewLine);
            }
        }

        private void btn_FactoryDelete(object sender, EventArgs e)
        {
            try
            {
                FactoryMaintService oCDOService = new FactoryMaintService(new UserProfile(id, pw));
                FactoryMaint oCDO = new FactoryMaint();

                oCDO.ObjectToChange = new NamedObjectRef { Name = "Factory 1" };
                oCDOService.BeginTransaction();
                oCDOService.Delete(oCDO);
                oCDOService.ExecuteTransaction();

                ResultStatus oResultStatus = oCDOService.CommitTransaction();

                if (oResultStatus.IsSuccess) textBox_Log.AppendText(oResultStatus.Message + System.Environment.NewLine);
                else throw new Exception(oResultStatus.ExceptionData.Description);
            }
            catch (Exception ex)
            {
                textBox_Log.AppendText(ex.Message + System.Environment.NewLine);
            }
        }
    }
}
