namespace bankingmachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnWyplataInna = new System.Windows.Forms.Button();
            this.btnWyplata200PLN = new System.Windows.Forms.Button();
            this.btnWyplata100PLN = new System.Windows.Forms.Button();
            this.btnWyplata50PLN = new System.Windows.Forms.Button();
            this.btnWyplata20PLN = new System.Windows.Forms.Button();
            this.btnWyplata10PLN = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnWplacAnuluj = new System.Windows.Forms.Button();
            this.btnWplata = new System.Windows.Forms.Button();
            this.txbKwotaWplata1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankingmachineDataSet = new bankingmachine.bankingmachineDataSet();
            this.btnZamknij0 = new System.Windows.Forms.Button();
            this.btnZaloguj0 = new System.Windows.Forms.Button();
            this.historyTableAdapter = new bankingmachine.bankingmachineDataSetTableAdapters.historyTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new bankingmachine.bankingmachineDataSetTableAdapters.usersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.txbWyplataInna = new System.Windows.Forms.TextBox();
            this.btnWyplataInnaPotwierdz = new System.Windows.Forms.Button();
            this.btnWyplataInnaAnuluj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnWyslijPrzelew = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingmachineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(447, 250);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnWyplataInnaAnuluj);
            this.tabPage1.Controls.Add(this.btnWyplataInnaPotwierdz);
            this.tabPage1.Controls.Add(this.txbWyplataInna);
            this.tabPage1.Controls.Add(this.btnWyplataInna);
            this.tabPage1.Controls.Add(this.btnWyplata200PLN);
            this.tabPage1.Controls.Add(this.btnWyplata100PLN);
            this.tabPage1.Controls.Add(this.btnWyplata50PLN);
            this.tabPage1.Controls.Add(this.btnWyplata20PLN);
            this.tabPage1.Controls.Add(this.btnWyplata10PLN);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(439, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wypłata";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnWyplataInna
            // 
            this.btnWyplataInna.Location = new System.Drawing.Point(299, 124);
            this.btnWyplataInna.Name = "btnWyplataInna";
            this.btnWyplataInna.Size = new System.Drawing.Size(134, 53);
            this.btnWyplataInna.TabIndex = 5;
            this.btnWyplataInna.Text = "Inna kwota";
            this.btnWyplataInna.UseVisualStyleBackColor = true;
            this.btnWyplataInna.Click += new System.EventHandler(this.btnWyplataInna_Click);
            // 
            // btnWyplata200PLN
            // 
            this.btnWyplata200PLN.Location = new System.Drawing.Point(299, 65);
            this.btnWyplata200PLN.Name = "btnWyplata200PLN";
            this.btnWyplata200PLN.Size = new System.Drawing.Size(134, 53);
            this.btnWyplata200PLN.TabIndex = 4;
            this.btnWyplata200PLN.Text = "200PLN";
            this.btnWyplata200PLN.UseVisualStyleBackColor = true;
            this.btnWyplata200PLN.Click += new System.EventHandler(this.btnWyplata200PLN_Click);
            // 
            // btnWyplata100PLN
            // 
            this.btnWyplata100PLN.Location = new System.Drawing.Point(299, 6);
            this.btnWyplata100PLN.Name = "btnWyplata100PLN";
            this.btnWyplata100PLN.Size = new System.Drawing.Size(134, 53);
            this.btnWyplata100PLN.TabIndex = 3;
            this.btnWyplata100PLN.Text = "100PLN";
            this.btnWyplata100PLN.UseVisualStyleBackColor = true;
            this.btnWyplata100PLN.Click += new System.EventHandler(this.btnWyplata100PLN_Click);
            // 
            // btnWyplata50PLN
            // 
            this.btnWyplata50PLN.Location = new System.Drawing.Point(6, 124);
            this.btnWyplata50PLN.Name = "btnWyplata50PLN";
            this.btnWyplata50PLN.Size = new System.Drawing.Size(134, 53);
            this.btnWyplata50PLN.TabIndex = 2;
            this.btnWyplata50PLN.Text = "50PLN";
            this.btnWyplata50PLN.UseVisualStyleBackColor = true;
            this.btnWyplata50PLN.Click += new System.EventHandler(this.btnWyplata50PLN_Click);
            // 
            // btnWyplata20PLN
            // 
            this.btnWyplata20PLN.Location = new System.Drawing.Point(6, 65);
            this.btnWyplata20PLN.Name = "btnWyplata20PLN";
            this.btnWyplata20PLN.Size = new System.Drawing.Size(134, 53);
            this.btnWyplata20PLN.TabIndex = 1;
            this.btnWyplata20PLN.Text = "20PLN";
            this.btnWyplata20PLN.UseVisualStyleBackColor = true;
            this.btnWyplata20PLN.Click += new System.EventHandler(this.btnWyplata20PLN_Click);
            // 
            // btnWyplata10PLN
            // 
            this.btnWyplata10PLN.Location = new System.Drawing.Point(6, 6);
            this.btnWyplata10PLN.Name = "btnWyplata10PLN";
            this.btnWyplata10PLN.Size = new System.Drawing.Size(134, 53);
            this.btnWyplata10PLN.TabIndex = 0;
            this.btnWyplata10PLN.Text = "10PLN";
            this.btnWyplata10PLN.UseVisualStyleBackColor = true;
            this.btnWyplata10PLN.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnWplacAnuluj);
            this.tabPage2.Controls.Add(this.btnWplata);
            this.tabPage2.Controls.Add(this.txbKwotaWplata1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(439, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wpłata";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnWplacAnuluj
            // 
            this.btnWplacAnuluj.Location = new System.Drawing.Point(160, 140);
            this.btnWplacAnuluj.Name = "btnWplacAnuluj";
            this.btnWplacAnuluj.Size = new System.Drawing.Size(134, 53);
            this.btnWplacAnuluj.TabIndex = 2;
            this.btnWplacAnuluj.Text = "Anuluj";
            this.btnWplacAnuluj.UseVisualStyleBackColor = true;
            // 
            // btnWplata
            // 
            this.btnWplata.Location = new System.Drawing.Point(160, 81);
            this.btnWplata.Name = "btnWplata";
            this.btnWplata.Size = new System.Drawing.Size(134, 53);
            this.btnWplata.TabIndex = 1;
            this.btnWplata.Text = "Wpłać";
            this.btnWplata.UseVisualStyleBackColor = true;
            this.btnWplata.Click += new System.EventHandler(this.btnWplata_Click);
            // 
            // txbKwotaWplata1
            // 
            this.txbKwotaWplata1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbKwotaWplata1.Location = new System.Drawing.Point(169, 28);
            this.txbKwotaWplata1.Name = "txbKwotaWplata1";
            this.txbKwotaWplata1.Size = new System.Drawing.Size(116, 32);
            this.txbKwotaWplata1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnWyslijPrzelew);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(439, 221);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Przelew";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(439, 221);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Historia";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(439, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "history";
            this.historyBindingSource.DataSource = this.bankingmachineDataSet;
            // 
            // bankingmachineDataSet
            // 
            this.bankingmachineDataSet.DataSetName = "bankingmachineDataSet";
            this.bankingmachineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnZamknij0
            // 
            this.btnZamknij0.Location = new System.Drawing.Point(380, 12);
            this.btnZamknij0.Name = "btnZamknij0";
            this.btnZamknij0.Size = new System.Drawing.Size(75, 23);
            this.btnZamknij0.TabIndex = 1;
            this.btnZamknij0.Text = "Zamknij";
            this.btnZamknij0.UseVisualStyleBackColor = true;
            this.btnZamknij0.Click += new System.EventHandler(this.btnZamknij0_Click);
            // 
            // btnZaloguj0
            // 
            this.btnZaloguj0.Location = new System.Drawing.Point(299, 12);
            this.btnZaloguj0.Name = "btnZaloguj0";
            this.btnZaloguj0.Size = new System.Drawing.Size(75, 23);
            this.btnZaloguj0.TabIndex = 2;
            this.btnZaloguj0.Text = "Zaloguj";
            this.btnZaloguj0.UseVisualStyleBackColor = true;
            this.btnZaloguj0.Click += new System.EventHandler(this.btnZaloguj0_Click);
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.bankingmachineDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txbWyplataInna
            // 
            this.txbWyplataInna.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbWyplataInna.Location = new System.Drawing.Point(162, 26);
            this.txbWyplataInna.Name = "txbWyplataInna";
            this.txbWyplataInna.Size = new System.Drawing.Size(114, 32);
            this.txbWyplataInna.TabIndex = 6;
            this.txbWyplataInna.Visible = false;
            // 
            // btnWyplataInnaPotwierdz
            // 
            this.btnWyplataInnaPotwierdz.Location = new System.Drawing.Point(152, 84);
            this.btnWyplataInnaPotwierdz.Name = "btnWyplataInnaPotwierdz";
            this.btnWyplataInnaPotwierdz.Size = new System.Drawing.Size(134, 53);
            this.btnWyplataInnaPotwierdz.TabIndex = 7;
            this.btnWyplataInnaPotwierdz.Text = "Wypłać";
            this.btnWyplataInnaPotwierdz.UseVisualStyleBackColor = true;
            this.btnWyplataInnaPotwierdz.Visible = false;
            this.btnWyplataInnaPotwierdz.Click += new System.EventHandler(this.btnWyplataInnaPotwierdz_Click);
            // 
            // btnWyplataInnaAnuluj
            // 
            this.btnWyplataInnaAnuluj.Location = new System.Drawing.Point(152, 143);
            this.btnWyplataInnaAnuluj.Name = "btnWyplataInnaAnuluj";
            this.btnWyplataInnaAnuluj.Size = new System.Drawing.Size(134, 53);
            this.btnWyplataInnaAnuluj.TabIndex = 8;
            this.btnWyplataInnaAnuluj.Text = "Anuluj";
            this.btnWyplataInnaAnuluj.UseVisualStyleBackColor = true;
            this.btnWyplataInnaAnuluj.Visible = false;
            this.btnWyplataInnaAnuluj.Click += new System.EventHandler(this.btnWyplataInnaAnuluj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.sprawdzAdresata);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(322, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 32);
            this.textBox3.TabIndex = 2;
            // 
            // btnWyslijPrzelew
            // 
            this.btnWyslijPrzelew.Location = new System.Drawing.Point(299, 162);
            this.btnWyslijPrzelew.Name = "btnWyslijPrzelew";
            this.btnWyslijPrzelew.Size = new System.Drawing.Size(134, 53);
            this.btnWyslijPrzelew.TabIndex = 3;
            this.btnWyslijPrzelew.Text = "Wyślij";
            this.btnWyslijPrzelew.UseVisualStyleBackColor = true;
            this.btnWyslijPrzelew.Click += new System.EventHandler(this.btnWyslijPrzelew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 295);
            this.Controls.Add(this.btnZaloguj0);
            this.Controls.Add(this.btnZamknij0);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bankomat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingmachineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnZamknij0;
        private System.Windows.Forms.Button btnZaloguj0;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bankingmachineDataSet bankingmachineDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private bankingmachineDataSetTableAdapters.historyTableAdapter historyTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private bankingmachineDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button btnWyplata10PLN;
        private System.Windows.Forms.Button btnWyplataInna;
        private System.Windows.Forms.Button btnWyplata200PLN;
        private System.Windows.Forms.Button btnWyplata100PLN;
        private System.Windows.Forms.Button btnWyplata50PLN;
        private System.Windows.Forms.Button btnWyplata20PLN;
        private System.Windows.Forms.Button btnWplacAnuluj;
        private System.Windows.Forms.Button btnWplata;
        private System.Windows.Forms.TextBox txbKwotaWplata1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWyplataInnaAnuluj;
        private System.Windows.Forms.Button btnWyplataInnaPotwierdz;
        private System.Windows.Forms.TextBox txbWyplataInna;
        private System.Windows.Forms.Button btnWyslijPrzelew;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

