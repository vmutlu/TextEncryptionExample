
namespace Encryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEncrytion = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.lblOrijinal = new System.Windows.Forms.Label();
            this.lblSifreli = new System.Windows.Forms.Label();
            this.lblsonucorjin = new System.Windows.Forms.Label();
            this.lblsonucsifreli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEncrytion
            // 
            this.txtEncrytion.Location = new System.Drawing.Point(12, 71);
            this.txtEncrytion.Multiline = true;
            this.txtEncrytion.Name = "txtEncrytion";
            this.txtEncrytion.Size = new System.Drawing.Size(1051, 105);
            this.txtEncrytion.TabIndex = 0;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(13, 183);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(1050, 23);
            this.btnSifrele.TabIndex = 1;
            this.btnSifrele.Text = "Encrypt Text";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // lblOrijinal
            // 
            this.lblOrijinal.AutoSize = true;
            this.lblOrijinal.Location = new System.Drawing.Point(93, 16);
            this.lblOrijinal.Name = "lblOrijinal";
            this.lblOrijinal.Size = new System.Drawing.Size(76, 15);
            this.lblOrijinal.TabIndex = 2;
            this.lblOrijinal.Text = "Original Text:";
            // 
            // lblSifreli
            // 
            this.lblSifreli.AutoSize = true;
            this.lblSifreli.Location = new System.Drawing.Point(76, 43);
            this.lblSifreli.Name = "lblSifreli";
            this.lblSifreli.Size = new System.Drawing.Size(93, 15);
            this.lblSifreli.TabIndex = 3;
            this.lblSifreli.Text = "Encyrypted Text:";
            // 
            // lblsonucorjin
            // 
            this.lblsonucorjin.AutoSize = true;
            this.lblsonucorjin.Location = new System.Drawing.Point(178, 16);
            this.lblsonucorjin.Name = "lblsonucorjin";
            this.lblsonucorjin.Size = new System.Drawing.Size(38, 15);
            this.lblsonucorjin.TabIndex = 4;
            this.lblsonucorjin.Text = "label1";
            // 
            // lblsonucsifreli
            // 
            this.lblsonucsifreli.AutoSize = true;
            this.lblsonucsifreli.Location = new System.Drawing.Point(177, 44);
            this.lblsonucsifreli.Name = "lblsonucsifreli";
            this.lblsonucsifreli.Size = new System.Drawing.Size(38, 15);
            this.lblsonucsifreli.TabIndex = 5;
            this.lblsonucsifreli.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 217);
            this.Controls.Add(this.lblsonucsifreli);
            this.Controls.Add(this.lblsonucorjin);
            this.Controls.Add(this.lblSifreli);
            this.Controls.Add(this.lblOrijinal);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtEncrytion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Encrypiton Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncrytion;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Label lblOrijinal;
        private System.Windows.Forms.Label lblSifreli;
        private System.Windows.Forms.Label lblsonucorjin;
        private System.Windows.Forms.Label lblsonucsifreli;
    }
}

