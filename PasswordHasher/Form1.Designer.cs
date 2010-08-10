namespace PasswordHasher
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
            this.labelHashType = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.labelStringHash = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtStringHashResult = new System.Windows.Forms.TextBox();
            this.comboHashType = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.txtHexHashResult = new System.Windows.Forms.TextBox();
            this.labelHexHash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHashType
            // 
            this.labelHashType.AutoSize = true;
            this.labelHashType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHashType.Location = new System.Drawing.Point(24, 13);
            this.labelHashType.Name = "labelHashType";
            this.labelHashType.Size = new System.Drawing.Size(96, 17);
            this.labelHashType.TabIndex = 0;
            this.labelHashType.Text = "Hash Type: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(33, 52);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password: ";
            // 
            // labelStringHash
            // 
            this.labelStringHash.AutoSize = true;
            this.labelStringHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStringHash.Location = new System.Drawing.Point(18, 92);
            this.labelStringHash.Name = "labelStringHash";
            this.labelStringHash.Size = new System.Drawing.Size(103, 17);
            this.labelStringHash.TabIndex = 2;
            this.labelStringHash.Text = "String Hash: ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtStringHashResult
            // 
            this.txtStringHashResult.Location = new System.Drawing.Point(126, 92);
            this.txtStringHashResult.Name = "txtStringHashResult";
            this.txtStringHashResult.Size = new System.Drawing.Size(463, 20);
            this.txtStringHashResult.TabIndex = 4;
            // 
            // comboHashType
            // 
            this.comboHashType.FormattingEnabled = true;
            this.comboHashType.Location = new System.Drawing.Point(126, 13);
            this.comboHashType.Name = "comboHashType";
            this.comboHashType.Size = new System.Drawing.Size(121, 21);
            this.comboHashType.TabIndex = 5;
            this.comboHashType.SelectedIndexChanged += new System.EventHandler(this.comboHashType_SelectedIndexChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(126, 170);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(97, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Hash Password";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // txtHexHashResult
            // 
            this.txtHexHashResult.Location = new System.Drawing.Point(126, 130);
            this.txtHexHashResult.Name = "txtHexHashResult";
            this.txtHexHashResult.Size = new System.Drawing.Size(463, 20);
            this.txtHexHashResult.TabIndex = 8;
            // 
            // labelHexHash
            // 
            this.labelHexHash.AutoSize = true;
            this.labelHexHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHexHash.Location = new System.Drawing.Point(33, 130);
            this.labelHexHash.Name = "labelHexHash";
            this.labelHexHash.Size = new System.Drawing.Size(87, 17);
            this.labelHexHash.TabIndex = 7;
            this.labelHexHash.Text = "Hex Hash: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 215);
            this.Controls.Add(this.txtHexHashResult);
            this.Controls.Add(this.labelHexHash);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboHashType);
            this.Controls.Add(this.txtStringHashResult);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelStringHash);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.labelHashType);
            this.Name = "Form1";
            this.Text = "Password Hasher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHashType;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label labelStringHash;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtStringHashResult;
        private System.Windows.Forms.ComboBox comboHashType;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox txtHexHashResult;
        private System.Windows.Forms.Label labelHexHash;
    }
}

