using System;
using System.Windows.Forms;

namespace Revisao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            txtPhone.Text = "(00) 0 0000-0000";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            try
            {
                c.Data["name"] = txtName.Text;
                c.Data["phone"] = txtPhone.Text;
                c.Data["gender"] = cbGender.SelectedItem.ToString();
                c.Data["birth"] = dtpBirth.Value.ToString();
                labelReg.Text = c.ID.ToString();
            } catch(Exception exc) {
                Console.WriteLine("Exception thrown:\n{0}", exc);
                MessageBox.Show(exc.Message, "Exception thrown", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Console.WriteLine(c);
            MessageBox.Show(c.ToString(), "Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
