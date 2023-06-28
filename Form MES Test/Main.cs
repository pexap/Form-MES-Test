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
using Form_MES_Test.Feature;

namespace Form_MES_Test
{
    public partial class Main : Form
    {
        string ID = "Administrator";
        string PW = "Ocg123!";

        ContainerTransaction ConTransaction;
        FactoryTransaction FacTransaction;

        public Main()
        {
            InitializeComponent();

            ConTransaction = new ContainerTransaction(textBox_Log);
            FacTransaction = new FactoryTransaction (textBox_Log);
        }

        private void btn_MoveStd(object sender, EventArgs e)
        {
            ConTransaction.MoveNonStd();
        }

        private void btn_FactoryAdd(object sender, EventArgs e)
        {
            FacTransaction.FactoryAdd();
        }

        private void btn_FactoryUpdate(object sender, EventArgs e)
        {
            FacTransaction.FactoryUpdate();
        }

        private void btn_FactoryDelete(object sender, EventArgs e)
        {
            FacTransaction.FactoryDelete();
        }
    }
}
