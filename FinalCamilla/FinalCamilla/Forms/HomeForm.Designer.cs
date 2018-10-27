namespace FinalCamilla.Forms
{
    partial class HomeForm
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.pbxLog = new System.Windows.Forms.PictureBox();
            this.pbxProfile = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pbxCategory = new System.Windows.Forms.PictureBox();
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(53, 15);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(55, 16);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Produto";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(319, 14);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(67, 16);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Categoria";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(185, 124);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(62, 16);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuários";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(60, 243);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(38, 16);
            this.lblProfile.TabIndex = 8;
            this.lblProfile.Text = "Perfil";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(325, 243);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(31, 16);
            this.lblLog.TabIndex = 9;
            this.lblLog.Text = "Log";
            // 
            // pbxLog
            // 
            this.pbxLog.BackgroundImage = global::FinalCamilla.Properties.Resources.log_128;
            this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLog.Location = new System.Drawing.Point(289, 259);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(104, 88);
            this.pbxLog.TabIndex = 4;
            this.pbxLog.TabStop = false;
            this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
            this.pbxLog.MouseEnter += new System.EventHandler(this.pbxLog_MouseEnter);
            this.pbxLog.MouseLeave += new System.EventHandler(this.pbxLog_MouseLeave);
            // 
            // pbxProfile
            // 
            this.pbxProfile.BackgroundImage = global::FinalCamilla.Properties.Resources._user_profile_icon_1108089;
            this.pbxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProfile.Location = new System.Drawing.Point(28, 259);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.Size = new System.Drawing.Size(104, 88);
            this.pbxProfile.TabIndex = 3;
            this.pbxProfile.TabStop = false;
            this.pbxProfile.Click += new System.EventHandler(this.pbxProfile_Click);
            this.pbxProfile.MouseEnter += new System.EventHandler(this.pbxProfile_MouseEnter);
            this.pbxProfile.MouseLeave += new System.EventHandler(this.pbxProfile_MouseLeave);
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImage = global::FinalCamilla.Properties.Resources.employeer;
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Location = new System.Drawing.Point(163, 140);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(104, 88);
            this.pbxUser.TabIndex = 2;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            this.pbxUser.MouseEnter += new System.EventHandler(this.pbxUser_MouseEnter);
            this.pbxUser.MouseLeave += new System.EventHandler(this.pbxUser_MouseLeave);
            // 
            // pbxCategory
            // 
            this.pbxCategory.BackgroundImage = global::FinalCamilla.Properties.Resources.Category2;
            this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCategory.Location = new System.Drawing.Point(299, 34);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(104, 88);
            this.pbxCategory.TabIndex = 1;
            this.pbxCategory.TabStop = false;
            this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click);
            this.pbxCategory.MouseEnter += new System.EventHandler(this.pbxCategory_MouseEnter);
            this.pbxCategory.MouseLeave += new System.EventHandler(this.pbxCategory_MouseLeave);
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackColor = System.Drawing.SystemColors.Control;
            this.pbxProduct.BackgroundImage = global::FinalCamilla.Properties.Resources.Category1;
            this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProduct.Location = new System.Drawing.Point(28, 34);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(104, 88);
            this.pbxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProduct.TabIndex = 0;
            this.pbxProduct.TabStop = false;
            this.pbxProduct.Click += new System.EventHandler(this.pbxProduct_Click);
            this.pbxProduct.MouseEnter += new System.EventHandler(this.pbxProduct_MouseEnter);
            this.pbxProduct.MouseLeave += new System.EventHandler(this.pbxProduct_MouseLeave);
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::FinalCamilla.Properties.Resources.Back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Location = new System.Drawing.Point(2, 373);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(58, 46);
            this.pbxBack.TabIndex = 22;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 421);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.pbxLog);
            this.Controls.Add(this.pbxProfile);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pbxCategory);
            this.Controls.Add(this.pbxProduct);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxProduct;
        private System.Windows.Forms.PictureBox pbxCategory;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxProfile;
        private System.Windows.Forms.PictureBox pbxLog;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}