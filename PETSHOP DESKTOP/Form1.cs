using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETSHOP_DESKTOP
{
    public partial class PETSHOP : Form
    {
        public PETSHOP()
        {
            InitializeComponent();
        }

        private void animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pETSHOPDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pETSHOPDataSet.Animais'. Você pode movê-la ou removê-la conforme necessário.
            this.animaisTableAdapter.Fill(this.pETSHOPDataSet.Animais);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
