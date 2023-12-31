﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camstar.WCF.Services;
using Camstar.WCF.ObjectStack;
using Camstar.Util;

namespace Form_MES_Test.Feature
{
    public class ResourceChanges
    {
        string ID = "Administrator";
        string PW = "Ocg123!";

        TextBox Log;

        public ResourceChanges(TextBox _Log)
        {
            Log = _Log;
        }

        public void ResourceAdd()
        {
            try
            {
                ResourceMaintService oCDOService = new ResourceMaintService(new UserProfile(ID, PW));
                ResourceMaint oCDO = new ResourceMaint();
                oCDO.ObjectChanges = new Camstar.WCF.ObjectStack.ResourceChanges { Name = "Resource 1", Description = "My First Resource" };
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

        public void ResourceUpdate()
        {
            try
            {
                ResourceMaintService oCDOService = new ResourceMaintService(new UserProfile(ID, PW));
                ResourceMaint oCDO = new ResourceMaint();
                oCDO.ObjectToChange = new NamedObjectRef { Name = "Resource 1" };
                oCDOService.BeginTransaction();
                oCDOService.Load(oCDO);

                oCDO = new ResourceMaint();

                oCDO.ObjectChanges = new Camstar.WCF.ObjectStack.ResourceChanges();
                oCDO.ObjectChanges.Description = "Resource 1 Modified";
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
        
        public void ResourceDelete()
        {
            try
            {
                ResourceMaintService oCDOService = new ResourceMaintService(new UserProfile(ID, PW));
                ResourceMaint oCDO = new ResourceMaint();

                oCDO.ObjectToChange = new NamedObjectRef { Name = "Resource 1" };
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

        public void ResourceGet()
        {
            try
            {
                ResourceMaintService oCDOService = new ResourceMaintService(new UserProfile(ID, PW));
                ResourceMaint oCDO = new ResourceMaint();


            }
            catch (Exception ex)
            {
                Log.AppendText(ex.Message + System.Environment.NewLine);
            }
        }
    }
}
