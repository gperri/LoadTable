namespace loadtable
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdKo = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtHost.Location = new System.Drawing.Point(79, 77);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(134, 21);
            this.txtHost.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Host";
            // 
            // cmdKo
            // 
            this.cmdKo.AutoSize = true;
            this.cmdKo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdKo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdKo.Image = ((System.Drawing.Image)(resources.GetObject("cmdKo.Image")));
            this.cmdKo.Location = new System.Drawing.Point(79, 113);
            this.cmdKo.Name = "cmdKo";
            this.cmdKo.Size = new System.Drawing.Size(54, 54);
            this.cmdKo.TabIndex = 13;
            this.cmdKo.UseVisualStyleBackColor = true;
            this.cmdKo.Click += new System.EventHandler(this.cmdKo_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.AutoSize = true;
            this.cmdOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdOk.Image = ((System.Drawing.Image)(resources.GetObject("cmdOk.Image")));
            this.cmdOk.Location = new System.Drawing.Point(159, 113);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(54, 54);
            this.cmdOk.TabIndex = 12;
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtPassword.Location = new System.Drawing.Point(79, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(134, 21);
            this.txtPassword.TabIndex = 11;
            // 
            // txtUID
            // 
            this.txtUID.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtUID.Location = new System.Drawing.Point(79, 29);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(134, 21);
            this.txtUID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User ID";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.CancelButton = this.cmdKo;
            this.ClientSize = new System.Drawing.Size(251, 179);
            this.ControlBox = false;
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdKo);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Opacity = 0.78D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdKo;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}