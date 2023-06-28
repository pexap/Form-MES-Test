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
    public class ContainerChanges
    {
        string ID = "Administrator";
        string PW = "Ocg123!";

        TextBox Log;

        public ContainerChanges(TextBox _Log)
        {
            Log = _Log;
        }

        public void MoveNonStd()
        {
            try
            {
                MoveStdService oCDOService = new MoveStdService(new UserProfile(ID, PW));
                MoveStd oCDO = new MoveStd { Container = new ContainerRef("AAA") };
                ResultStatus oResultStatus = oCDOService.ExecuteTransaction(oCDO);

                if (oResultStatus.IsSuccess)
                {
                    Log.AppendText(oResultStatus.Message + System.Environment.NewLine);
                    //MessageBox.Show(oResultStatus.Message);
                }
                else throw new Exception(oResultStatus.ExceptionData.Description);
            }
            catch (Exception ex)
            {
                Log.AppendText(ex.Message + System.Environment.NewLine);
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
