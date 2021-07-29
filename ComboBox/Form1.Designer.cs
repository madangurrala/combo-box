
namespace ComboBox
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
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.revealBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(285, 147);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(121, 21);
            this.cmbBox.TabIndex = 0;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(214, 150);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(35, 13);
            this.nameLable.TabIndex = 1;
            this.nameLable.Text = "Name";
            // 
            // revealBtn
            // 
            this.revealBtn.Location = new System.Drawing.Point(445, 145);
            this.revealBtn.Name = "revealBtn";
            this.revealBtn.Size = new System.Drawing.Size(75, 23);
            this.revealBtn.TabIndex = 2;
            this.revealBtn.Text = "Show Id";
            this.revealBtn.UseVisualStyleBackColor = true;
            this.revealBtn.Click += new System.EventHandler(this.revealBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.revealBtn);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.cmbBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Button revealBtn;
    }
}

