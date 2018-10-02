namespace update
{
    partial class UpdateInfoForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblVersionOld = new System.Windows.Forms.Label();
            this.lblVersionNew = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::update.Properties.Resources.scum_icon__1__by_malfacio_db0lkfl;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(217, 217);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblVersionOld
            // 
            this.lblVersionOld.AutoSize = true;
            this.lblVersionOld.Location = new System.Drawing.Point(235, 9);
            this.lblVersionOld.Name = "lblVersionOld";
            this.lblVersionOld.Size = new System.Drawing.Size(35, 13);
            this.lblVersionOld.TabIndex = 1;
            this.lblVersionOld.Text = "label1";
            // 
            // lblVersionNew
            // 
            this.lblVersionNew.AutoSize = true;
            this.lblVersionNew.Location = new System.Drawing.Point(235, 22);
            this.lblVersionNew.Name = "lblVersionNew";
            this.lblVersionNew.Size = new System.Drawing.Size(35, 13);
            this.lblVersionNew.TabIndex = 2;
            this.lblVersionNew.Text = "label1";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.textDescription.Location = new System.Drawing.Point(238, 61);
            this.textDescription.Name = "textDescription";
            this.textDescription.ReadOnly = true;
            this.textDescription.Size = new System.Drawing.Size(214, 139);
            this.textDescription.TabIndex = 3;
            this.textDescription.TabStop = false;
            this.textDescription.Text = "";
            this.textDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDescription_KeyDown);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(235, 45);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(238, 206);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdateInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 241);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.lblVersionNew);
            this.Controls.Add(this.lblVersionOld);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateInfoForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblVersionOld;
        private System.Windows.Forms.Label lblVersionNew;
        private System.Windows.Forms.RichTextBox textDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
    }
}