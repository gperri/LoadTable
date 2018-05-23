namespace loadtable
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cboDatabaseList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTables = new System.Windows.Forms.ComboBox();
            this.cmdKo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(101, 88);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(406, 20);
            this.txtFile.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "CSV file...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboDatabaseList
            // 
            this.cboDatabaseList.FormattingEnabled = true;
            this.cboDatabaseList.Location = new System.Drawing.Point(101, 19);
            this.cboDatabaseList.Margin = new System.Windows.Forms.Padding(2);
            this.cboDatabaseList.Name = "cboDatabaseList";
            this.cboDatabaseList.Size = new System.Drawing.Size(407, 21);
            this.cboDatabaseList.TabIndex = 9;
            this.cboDatabaseList.TextChanged += new System.EventHandler(this.cboDatabaseList_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "DATABASES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TABLES";
            // 
            // cboTables
            // 
            this.cboTables.FormattingEnabled = true;
            this.cboTables.Location = new System.Drawing.Point(101, 55);
            this.cboTables.Margin = new System.Windows.Forms.Padding(2);
            this.cboTables.Name = "cboTables";
            this.cboTables.Size = new System.Drawing.Size(407, 21);
            this.cboTables.TabIndex = 12;
            // 
            // cmdKo
            // 
            this.cmdKo.AutoSize = true;
            this.cmdKo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdKo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdKo.Image = ((System.Drawing.Image)(resources.GetObject("cmdKo.Image")));
            this.cmdKo.Location = new System.Drawing.Point(27, 37);
            this.cmdKo.Name = "cmdKo";
            this.cmdKo.Size = new System.Drawing.Size(54, 54);
            this.cmdKo.TabIndex = 14;
            this.cmdKo.UseVisualStyleBackColor = true;
            this.cmdKo.Click += new System.EventHandler(this.cmdKo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "SEPARATOR";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(101, 115);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(28, 20);
            this.txtSeparator.TabIndex = 16;
            this.txtSeparator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.cmdKo);
            this.panel1.Location = new System.Drawing.Point(513, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 138);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.dgvPreview);
            this.panel2.Location = new System.Drawing.Point(2, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 295);
            this.panel2.TabIndex = 19;
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.AllowUserToOrderColumns = true;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreview.Location = new System.Drawing.Point(0, 0);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.Size = new System.Drawing.Size(618, 295);
            this.dgvPreview.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 20;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 469);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSeparator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTables);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDatabaseList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboDatabaseList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTables;
        private System.Windows.Forms.Button cmdKo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Button button3;
    }
}

