using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camstar.WCF.Services;
using Camstar.WCF.ObjectStack;
using Camstar.Util;
using Camstar.Exceptions;

namespace Form_MES_Test.Feature
{
    public class FactoryTransaction
    {
        string ID = "Administrator";
        string PW = "Ocg123!";

        TextBox Log;

        public FactoryTransaction(TextBox _Log)
        {
            Log = _Log;
            
        }

        public void FactoryAdd()
        {
            try
            {
                FactoryMaintService oCDOService = new FactoryMaintService(new UserProfile(ID, PW));
                FactoryMaint oCDO = new FactoryMaint();
                oCDO.ObjectChanges = new FactoryChanges { Name = "Factory 1", Description = "My First Factory" };
                oCDOService.BeginTransaction();
                oCDOService.New(oCDO);
                oCDOService.ExecuteTransaction();

                ResultStatus oResultstatus = oCDOService.CommitTransaction();

                if (oResultstatus.IsSuccess)
                {
                    Log.AppendText(oResultstatus.Message + System.Environment.NewLine);
                }
                else throw new Exception(oResultstatus.ExceptionData.Description);
            }
            catch (Exception ex)
            {
                Log.AppendText(ex.Message + System.Environment.NewLine);
            }
        }

        public void FactoryUpdate()
        {
            try
            {
                FactoryMaintService oCDOService = new FactoryMaintService(new UserProfile(ID, PW));
                FactoryMaint oCDO = new FactoryMaint();
                oCDO.ObjectToChange = new NamedObjectRef { Name = "Factory 1" };
                oCDOService.BeginTransaction();
                oCDOService.Load(oCDO);

                oCDO = new FactoryMaint();

                oCDO.ObjectChanges = new FactoryChanges();
                oCDO.ObjectChanges.Description = "Factory 1 Modified";
                oCDOService.ExecuteTransaction(oCDO);

                ResultStatus oResultStatus = oCDOService.CommitTransaction();

                if (oResultStatus.IsSuccess) Log.AppendText(oResultStatus.Message + System.Environment.NewLine);
                else throw new Exception(oResultStatus.ExceptionData.Description);
            }
            catch (Exception ex)
            {
                Log.AppendText(ex.Message + System.Environment.NewLine);
            }
        }

        public void FactoryDelete()
        {
            try
            {
                FactoryMaintService oCDOService = new FactoryMaintService(new UserProfile(ID, PW));
                FactoryMaint oCDO = new FactoryMaint();

                oCDO.ObjectToChange = new NamedObjectRef { Name = "Factory 1" };
                oCDOService.BeginTransaction();
                oCDOService.Delete(oCDO);
                oCDOService.ExecuteTransaction();

                ResultStatus oResultStatus = oCDOService.CommitTransaction();

                if (oResultStatus.IsSuccess) Log.AppendText(oResultStatus.Message + System.Environment.NewLine);
                else throw new Exception(oResultStatus.ExceptionData.Description);
            }
            catch (Exception ex)
            {
                Log.AppendText(ex.Message + System.Environment.NewLine);
            }
        }
    }
}
