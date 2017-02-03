using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankingmachine
{
    public partial class logowanieForm : Form
    {
        public Form1 form1;

        public logowanieForm(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            try
            {
                using (bankingmachineEntities context = new bankingmachineEntities())
                {
                    user logowanieUser = context.users.Where(i => i.login == textBox1.Text.ToString()).SingleOrDefault();
                    if (logowanieUser.passhash == textBox2.Text)
                    {
                        form1.bLogged = true;
                        form1.loggedUser = logowanieUser.login.ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Błąd logowania. Wprowadź dane ponownie", "Błąd", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {

            }
        }
    }
}
