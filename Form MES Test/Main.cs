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
        ContainerChanges ConTransaction;
        Feature.FactoryChanges FacTransaction;
        Feature.ResourceChanges ResTransaction;

        public Main()
        {
            InitializeComponent();

            ConTransaction = new ContainerChanges(textBox_Log);
            FacTransaction = new Feature.FactoryChanges(textBox_Log);
            ResTransaction = new Feature.ResourceChanges(textBox_Log);
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

        private void btn_ResourceAdd(object sender, EventArgs e)
        {
            ResTransaction.ResourceAdd();
        }

        private void btn_ResourceUpdate(object sender, EventArgs e)
        {
            ResTransaction.ResourceUpdate();
        }

        private void btn_ResourceDelete(object sender, EventArgs e)
        {
            ResTransaction.ResourceDelete();
        }

        private void btn_ResourceGet(object sender, EventArgs e)
        {

        }
    }
}
