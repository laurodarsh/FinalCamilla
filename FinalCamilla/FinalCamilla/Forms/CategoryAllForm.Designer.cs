namespace FinalCamilla.Forms
{
    partial class CategoryAllForm
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
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.tbxSearchCategory = new System.Windows.Forms.TextBox();
            this.pbxClean = new System.Windows.Forms.PictureBox();
            this.pbxSearchCategory = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxPlus = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToResizeColumns = false;
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategory.Location = new System.Drawing.Point(33, 83);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(517, 252);
            this.dgvCategory.TabIndex = 0;
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCategory.Location = new System.Drawing.Point(12, 23);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(83, 20);
            this.lblSearchCategory.TabIndex = 6;
            this.lblSearchCategory.Text = "Pesquisar:";
            // 
            // tbxSearchCategory
            // 
            this.tbxSearchCategory.Location = new System.Drawing.Point(101, 25);
            this.tbxSearchCategory.Name = "tbxSearchCategory";
            this.tbxSearchCategory.Size = new System.Drawing.Size(276, 20);
            this.tbxSearchCategory.TabIndex = 7;
            // 
            // pbxClean
            // 
            this.pbxClean.BackgroundImage = global::FinalCamilla.Properties.Resources.download;
            this.pbxClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxClean.Location = new System.Drawing.Point(427, 12);
            this.pbxClean.Name = "pbxClean";
            this.pbxClean.Size = new System.Drawing.Size(41, 33);
            this.pbxClean.TabIndex = 8;
            this.pbxClean.TabStop = false;
            this.pbxClean.Click += new System.EventHandler(this.pbxClean_Click);
            this.pbxClean.MouseEnter += new System.EventHandler(this.pbxClean_MouseEnter);
            this.pbxClean.MouseLeave += new System.EventHandler(this.pbxClean_MouseLeave);
            // 
            // pbxSearchCategory
            // 
            this.pbxSearchCategory.BackgroundImage = global::FinalCamilla.Properties.Resources.Search;
            this.pbxSearchCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSearchCategory.Location = new System.Drawing.Point(383, 12);
            this.pbxSearchCategory.Name = "pbxSearchCategory";
            this.pbxSearchCategory.Size = new System.Drawing.Size(38, 33);
            this.pbxSearchCategory.TabIndex = 5;
            this.pbxSearchCategory.TabStop = false;
            this.pbxSearchCategory.Click += new System.EventHandler(this.pbxSearchCategory_Click);
            this.pbxSearchCategory.MouseEnter += new System.EventHandler(this.pbxSearchCategory_MouseEnter);
            this.pbxSearchCategory.MouseLeave += new System.EventHandler(this.pbxSearchCategory_MouseLeave);
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::FinalCamilla.Properties.Resources.Back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Location = new System.Drawing.Point(1, 380);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(58, 46);
            this.pbxBack.TabIndex = 4;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pbxPlus
            // 
            this.pbxPlus.BackgroundImage = global::FinalCamilla.Properties.Resources.Plus;
            this.pbxPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxPlus.Location = new System.Drawing.Point(395, 380);
            this.pbxPlus.Name = "pbxPlus";
            this.pbxPlus.Size = new System.Drawing.Size(55, 46);
            this.pbxPlus.TabIndex = 3;
            this.pbxPlus.TabStop = false;
            this.pbxPlus.Click += new System.EventHandler(this.pbxPlus_Click);
            // 
            // pbxEdit
            // 
            this.pbxEdit.BackgroundImage = global::FinalCamilla.Properties.Resources.Edit;
            this.pbxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxEdit.Location = new System.Drawing.Point(456, 380);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(55, 46);
            this.pbxEdit.TabIndex = 2;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.Click += new System.EventHandler(this.pbxEdit_Click);
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = global::FinalCamilla.Properties.Resources.delete_sign_icon_remove_button_black_vector_21584667;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Location = new System.Drawing.Point(517, 380);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(63, 46);
            this.pbxDelete.TabIndex = 1;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            // 
            // CategoryAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 426);
            this.Controls.Add(this.pbxClean);
            this.Controls.Add(this.tbxSearchCategory);
            this.Controls.Add(this.lblSearchCategory);
            this.Controls.Add(this.pbxSearchCategory);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxPlus);
            this.Controls.Add(this.pbxEdit);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.dgvCategory);
            this.Name = "CategoryAllForm";
            this.Text = "CategoryAllForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxPlus;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxSearchCategory;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.TextBox tbxSearchCategory;
        private System.Windows.Forms.PictureBox pbxClean;
    }
}