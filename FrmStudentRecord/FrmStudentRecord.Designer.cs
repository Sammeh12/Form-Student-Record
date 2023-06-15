namespace FrmStudentRecord
{
    partial class FrmStudentRecord
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
            this.btRegister = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.btUpload = new System.Windows.Forms.Button();
            this.lvShowText = new System.Windows.Forms.ListView();
            this.lblViewRecord = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btRegister
            // 
            this.btRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.Location = new System.Drawing.Point(556, 48);
            this.btRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(97, 35);
            this.btRegister.TabIndex = 20;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click_1);
            // 
            // btFind
            // 
            this.btFind.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.Location = new System.Drawing.Point(556, 91);
            this.btFind.Margin = new System.Windows.Forms.Padding(4);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(97, 35);
            this.btFind.TabIndex = 21;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btUpload
            // 
            this.btUpload.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpload.Location = new System.Drawing.Point(556, 134);
            this.btUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(97, 35);
            this.btUpload.TabIndex = 22;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // lvShowText
            // 
            this.lvShowText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(22, 49);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(524, 234);
            this.lvShowText.TabIndex = 23;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            this.lvShowText.View = System.Windows.Forms.View.List;
            // 
            // lblViewRecord
            // 
            this.lblViewRecord.AutoSize = true;
            this.lblViewRecord.Location = new System.Drawing.Point(15, 9);
            this.lblViewRecord.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblViewRecord.Name = "lblViewRecord";
            this.lblViewRecord.Size = new System.Drawing.Size(164, 37);
            this.lblViewRecord.TabIndex = 24;
            this.lblViewRecord.Text = "View Record";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 307);
            this.Controls.Add(this.lblViewRecord);
            this.Controls.Add(this.lvShowText);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.btRegister);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "FrmStudentRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Label lblViewRecord;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}