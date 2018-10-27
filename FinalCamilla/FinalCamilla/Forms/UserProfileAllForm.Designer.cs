namespace FinalCamilla.Forms
{
    partial class UserProfileAllForm
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvProfile = new System.Windows.Forms.DataGridView();
            this.pbxClean = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxPlus = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(101, 27);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(276, 20);
            this.tbxSearch.TabIndex = 16;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(83, 20);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Pesquisar:";
            // 
            // dgvProfile
            // 
            this.dgvProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfile.Location = new System.Drawing.Point(33, 85);
            this.dgvProfile.Name = "dgvProfile";
            this.dgvProfile.Size = new System.Drawing.Size(517, 252);
            this.dgvProfile.TabIndex = 9;
            // 
            // pbxClean
            // 
            this.pbxClean.BackgroundImage = global::FinalCamilla.Properties.Resources.download;
            this.pbxClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxClean.Location = new System.Drawing.Point(427, 14);
            this.pbxClean.Name = "pbxClean";
            this.pbxClean.Size = new System.Drawing.Size(41, 33);
            this.pbxClean.TabIndex = 17;
            this.pbxClean.TabStop = false;
            // 
            // pbxSearch
            // 
            this.pbxSearch.BackgroundImage = global::FinalCamilla.Properties.Resources.Search;
            this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSearch.Location = new System.Drawing.Point(383, 14);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(38, 33);
            this.pbxSearch.TabIndex = 14;
            this.pbxSearch.TabStop = false;
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::FinalCamilla.Properties.Resources.Back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Location = new System.Drawing.Point(1, 382);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(58, 46);
            this.pbxBack.TabIndex = 13;
            this.pbxBack.TabStop = false;
            // 
            // pbxPlus
            // 
            this.pbxPlus.BackgroundImage = global::FinalCamilla.Properties.Resources.Plus;
            this.pbxPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxPlus.Location = new System.Drawing.Point(456, 382);
            this.pbxPlus.Name = "pbxPlus";
            this.pbxPlus.Size = new System.Drawing.Size(55, 46);
            this.pbxPlus.TabIndex = 12;
            this.pbxPlus.TabStop = false;
            // 
            // pbxEdit
            // 
            this.pbxEdit.BackgroundImage = global::FinalCamilla.Properties.Resources.Edit;
            this.pbxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxEdit.Location = new System.Drawing.Point(383, 382);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(55, 46);
            this.pbxEdit.TabIndex = 11;
            this.pbxEdit.TabStop = false;
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = global::FinalCamilla.Properties.Resources.delete_sign_icon_remove_button_black_vector_21584667;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Location = new System.Drawing.Point(517, 382);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(63, 46);
            this.pbxDelete.TabIndex = 10;
            this.pbxDelete.TabStop = false;
            // 
            // UserProfileAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 429);
            this.Controls.Add(this.pbxClean);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxPlus);
            this.Controls.Add(this.pbxEdit);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.dgvProfile);
            this.Name = "UserProfileAllForm";
            this.Text = "UserProfileAllForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxClean;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxPlus;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.DataGridView dgvProfile;
    }
}