using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerisiNiz_Click(object sender, EventArgs e)
        {
            try
            {
                Zadatak2Klasa.clsMath clsMath = new Zadatak2Klasa.clsMath();
                long[] rezultat = clsMath.GenFibonacci(Convert.ToInt32(txtBrojClanova.Text));
                lstListaClanova.Items.Clear();
                foreach (long deo in rezultat)
                {
                    lstListaClanova.Items.Add(deo);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // zatvaranje aplikacije na dugme ESC
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
