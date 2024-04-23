namespace ApiSample
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
            this.button_mentes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_mennyiseg = new System.Windows.Forms.TextBox();
            this.textBox_kereses = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_megse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keszlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_mentes
            // 
            this.button_mentes.Location = new System.Drawing.Point(1642, 440);
            this.button_mentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(136, 125);
            this.button_mentes.TabIndex = 1;
            this.button_mentes.Text = "Kész";
            this.button_mentes.UseVisualStyleBackColor = true;
            this.button_mentes.Click += new System.EventHandler(this.button_mentes_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(33, 103);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 629);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox_mennyiseg
            // 
            this.textBox_mennyiseg.Location = new System.Drawing.Point(1482, 252);
            this.textBox_mennyiseg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_mennyiseg.Name = "textBox_mennyiseg";
            this.textBox_mennyiseg.Size = new System.Drawing.Size(295, 31);
            this.textBox_mennyiseg.TabIndex = 4;
            // 
            // textBox_kereses
            // 
            this.textBox_kereses.Location = new System.Drawing.Point(33, 42);
            this.textBox_kereses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_kereses.Name = "textBox_kereses";
            this.textBox_kereses.Size = new System.Drawing.Size(406, 31);
            this.textBox_kereses.TabIndex = 5;
            this.textBox_kereses.TextChanged += new System.EventHandler(this.textBox_kereses_TextChanged);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(1642, 331);
            this.button_plus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(90, 78);
            this.button_plus.TabIndex = 6;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(1526, 331);
            this.button_minus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(90, 78);
            this.button_minus.TabIndex = 7;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_megse
            // 
            this.button_megse.Location = new System.Drawing.Point(1480, 440);
            this.button_megse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_megse.Name = "button_megse";
            this.button_megse.Size = new System.Drawing.Size(136, 125);
            this.button_megse.TabIndex = 8;
            this.button_megse.Text = "Mégse";
            this.button_megse.UseVisualStyleBackColor = true;
            this.button_megse.Click += new System.EventHandler(this.button_megse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nev,
            this.keszlet,
            this.inventory_id});
            this.dataGridView1.Location = new System.Drawing.Point(446, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 629);
            this.dataGridView1.TabIndex = 9;
            
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.Width = 200;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.MinimumWidth = 10;
            this.nev.Name = "nev";
            this.nev.Width = 200;
            // 
            // keszlet
            // 
            this.keszlet.HeaderText = "Készlet";
            this.keszlet.MinimumWidth = 10;
            this.keszlet.Name = "keszlet";
            this.keszlet.Width = 200;
            // 
            // inventory_id
            // 
            this.inventory_id.HeaderText = "Raktár ID";
            this.inventory_id.MinimumWidth = 10;
            this.inventory_id.Name = "inventory_id";
            this.inventory_id.Width = 200;
            // 
            // termekBindingSource
            // 
            this.termekBindingSource.DataSource = typeof(ApiSample.Termek);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 767);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_megse);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.textBox_kereses);
            this.Controls.Add(this.textBox_mennyiseg);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_mentes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_mennyiseg;
        private System.Windows.Forms.TextBox textBox_kereses;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_megse;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource termekBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn keszlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory_id;
    }
}