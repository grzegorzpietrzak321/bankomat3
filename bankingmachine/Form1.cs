using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankingmachine
{
    public partial class Form1 : Form
    {
        public Form1 form1;
        public bool bLogged = false;
        public string loggedUser = null;
        public history[] histories = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void zaloguj()
        {
            logowanieForm okienkoLogowanieForm = new logowanieForm(this);
            okienkoLogowanieForm.Owner = this;
            okienkoLogowanieForm.ShowDialog();
        }

        public void wyplac(decimal kwotaDecimal)
        {
            if (
                MessageBox.Show("Potwierdź wypłatę", "Potwierdź wypłatę", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (bankingmachineEntities context = new bankingmachineEntities())
                {
                    user logUser = context.users.Where(i => i.login == loggedUser).SingleOrDefault();
                    logUser.accbalance =- kwotaDecimal;
                    context.users.AddOrUpdate(logUser);
                    history wpis = new history();
                    wpis.users_id = logUser.id;
                    wpis.amount = kwotaDecimal;
                    wpis.type = "O";
                    wpis.datetime = DateTime.Now;
                    context.histories.AddOrUpdate(wpis);
                    context.SaveChanges();
                }
            }
        }

        public void odswiezHistorie(string uzytkownikUser)
        {
            try
            {
                using (bankingmachineEntities context = new bankingmachineEntities())
                {
                    var tmp = context.users.Where(i => i.login == uzytkownikUser).SingleOrDefault();
                    histories = new history[context.histories.Where(p => p.users_id == tmp.id).Count()];
                    histories = context.histories.Where(p => p.users_id == tmp.id).ToArray();

                    if (dataGridView1.Columns.Count == 0)
                    {
                        dataGridView1.Columns.Add("Data", "Data");
                        dataGridView1.Columns.Add("Kwota", "Kwota");
                        dataGridView1.Columns.Add("operacji", "Rodzaj operacji");
                    }

                    while (dataGridView1.Rows.Count > 0) { dataGridView1.Rows.RemoveAt(0); }

                    foreach (history o in histories)
                    {
                        if (o.type == "O")
                        {
                            dataGridView1.Rows.Add(o.datetime, o.amount, "Wypłata");
                        }
                        if (o.type == "I")
                        {
                            dataGridView1.Rows.Add(o.datetime, o.amount, "Wpłata");
                        }
                        if (o.type == "T")
                        {
                            dataGridView1.Rows.Add(o.datetime, o.amount, "Przelew");
                        }
                    }
                }
            }
            catch 
            {
                
            }
        }

        private void btnZamknij0_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnZaloguj0_Click(object sender, EventArgs e)
        {
            if (!bLogged)
            {
                zaloguj();
                tabControl1.Enabled = true;
                btnZaloguj0.Text = "Wyloguj";
            }
            else
            {
                if ((MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wyloguj", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                {
                    bLogged = false;
                    loggedUser = null;
                    tabControl1.Enabled = false;
                    btnZaloguj0.Text = "Zaloguj";
                    tabControl1.SelectedIndex = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e) //wyplata 10PLN
        {
            wyplac(10);
        }

        private void btnWyplata20PLN_Click(object sender, EventArgs e)
        {
            wyplac(20);
        }

        private void btnWyplata50PLN_Click(object sender, EventArgs e)
        {
            wyplac(50);
        }

        private void btnWyplata100PLN_Click(object sender, EventArgs e)
        {
            wyplac(100);
        }

        private void btnWyplata200PLN_Click(object sender, EventArgs e)
        {
            wyplac(200);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            odswiezHistorie(loggedUser);
        }

        private void btnWplata_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txbKwotaWplata1.Text) % 10 == 0)
            {
                try
                {
                    using (bankingmachineEntities context = new bankingmachineEntities())
                    {
                        user uzytkownikUser = context.users.Where(i => i.login == loggedUser).SingleOrDefault();
                        uzytkownikUser.accbalance = +Convert.ToDecimal(txbKwotaWplata1.Text);
                        context.users.AddOrUpdate(uzytkownikUser);
                        history historiaHistory = new history();
                        historiaHistory.users_id = uzytkownikUser.id;
                        historiaHistory.datetime = DateTime.Now;
                        historiaHistory.amount = Convert.ToDecimal(txbKwotaWplata1.Text);
                        historiaHistory.type = "I";
                        context.histories.Add(historiaHistory);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Wpłata przebiegła prawidłowo", "Wpłata", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch 
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Wprowadzona kwota musi być wielokrotnością 10", "Błąd wpłaty", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txbKwotaWplata1.Text = "";
            }
        }

        private void btnWyplataInna_Click(object sender, EventArgs e)
        {
            btnWyplataInnaPotwierdz.Visible = true;
            btnWyplataInnaAnuluj.Visible = true;
            txbWyplataInna.Visible = true;

            btnWyplata10PLN.Visible = false;
            btnWyplata20PLN.Visible = false;
            btnWyplata50PLN.Visible = false;
            btnWyplata100PLN.Visible = false;
            btnWyplata200PLN.Visible = false;
            btnWyplataInna.Visible = false;
        }

        private void btnWyplataInnaAnuluj_Click(object sender, EventArgs e)
        {
            btnWyplataInnaPotwierdz.Visible = false;
            btnWyplataInnaAnuluj.Visible = false;
            txbWyplataInna.Visible = false;

            btnWyplata10PLN.Visible = true;
            btnWyplata20PLN.Visible = true;
            btnWyplata50PLN.Visible = true;
            btnWyplata100PLN.Visible = true;
            btnWyplata200PLN.Visible = true;
            btnWyplataInna.Visible = true;
            txbWyplataInna.Text = "";
        }

        private void btnWyplataInnaPotwierdz_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txbWyplataInna.Text)%10 == 0)
            {
                wyplac(Convert.ToDecimal(txbWyplataInna.Text));
            }
            else
            {
                MessageBox.Show("Kwota do wypłaty musi być wielokrotnością 10", "Wypłata", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txbWyplataInna.Text = "";
            }
        }

        private void sprawdzAdresata(object sender, EventArgs e)
        {
            int tmp = 0;

            try
            {
                using(bankingmachineEntities context = new bankingmachineEntities())
                {
                    tmp = Convert.ToInt32(textBox1.Text);
                    textBox2.Text = context.users.Where(i => i.id == tmp).SingleOrDefault().login.ToString();
                }
            }
            catch
            {
                if (!(textBox1.Text == ""))
                {
                    textBox2.Text = "błędny numer konta";
                }
                else
                {
                    textBox2.Text = "";
                }
            }
        }

        private void btnWyslijPrzelew_Click(object sender, EventArgs e)
        {
            
            decimal kwotaPrzelewu = Convert.ToDecimal(textBox1.Text);

            using (bankingmachineEntities context = new bankingmachineEntities())
            {
                user uzytkownikUser = context.users.Where(i => i.login == loggedUser).SingleOrDefault();
                uzytkownikUser.accbalance = -kwotaPrzelewu;
                context.users.AddOrUpdate(uzytkownikUser);

                history historiaHistory = new history();
                historiaHistory.type = "T";
                historiaHistory.amount = kwotaPrzelewu;
                historiaHistory.datetime = DateTime.Now;
                historiaHistory.users_id = uzytkownikUser.id;
                context.histories.Add(historiaHistory);
                context.SaveChanges();
            }

            MessageBox.Show("Przelew wykonany prawidłowo", "Przelew", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
