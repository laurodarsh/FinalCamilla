namespace FinalCamilla.Forms
{
    partial class ForgetPassword
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
            this.lblEmailForget = new System.Windows.Forms.Label();
            this.tbxEmailForget = new System.Windows.Forms.TextBox();
            this.btnForgetPassword = new System.Windows.Forms.Button();
            this.lblForgetPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmailForget
            // 
            this.lblEmailForget.AutoSize = true;
            this.lblEmailForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailForget.Location = new System.Drawing.Point(25, 147);
            this.lblEmailForget.Name = "lblEmailForget";
            this.lblEmailForget.Size = new System.Drawing.Size(55, 20);
            this.lblEmailForget.TabIndex = 0;
            this.lblEmailForget.Text = "Nome:";
            // 
            // tbxEmailForget
            // 
            this.tbxEmailForget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEmailForget.Location = new System.Drawing.Point(83, 147);
            this.tbxEmailForget.Name = "tbxEmailForget";
            this.tbxEmailForget.Size = new System.Drawing.Size(339, 20);
            this.tbxEmailForget.TabIndex = 1;
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassword.Location = new System.Drawing.Point(171, 207);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(119, 36);
            this.btnForgetPassword.TabIndex = 2;
            this.btnForgetPassword.Text = "Confirmar";
            this.btnForgetPassword.UseVisualStyleBackColor = false;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPassword.Location = new System.Drawing.Point(113, 9);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(221, 25);
            this.lblForgetPassword.TabIndex = 3;
            this.lblForgetPassword.Text = "Redefinição de senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalCamilla.Properties.Resources.Back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::FinalCamilla.Properties.Resources.LevelUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(465, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblForgetPassword);
            this.Controls.Add(this.btnForgetPassword);
            this.Controls.Add(this.tbxEmailForget);
            this.Controls.Add(this.lblEmailForget);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.Text = "Redefinição de senha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailForget;
        private System.Windows.Forms.TextBox tbxEmailForget;
        private System.Windows.Forms.Button btnForgetPassword;
        private System.Windows.Forms.Label lblForgetPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}