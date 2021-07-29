
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.revealBtn = new System.Windows.Forms.Button();
            this.engilish = new System.Windows.Forms.Button();
            this.frenchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBox, "cmbBox");
            this.cmbBox.Name = "cmbBox";
            // 
            // nameLable
            // 
            resources.ApplyResources(this.nameLable, "nameLable");
            this.nameLable.Name = "nameLable";
            // 
            // revealBtn
            // 
            resources.ApplyResources(this.revealBtn, "revealBtn");
            this.revealBtn.Name = "revealBtn";
            this.revealBtn.UseVisualStyleBackColor = true;
            this.revealBtn.Click += new System.EventHandler(this.revealBtn_Click);
            // 
            // engilish
            // 
            resources.ApplyResources(this.engilish, "engilish");
            this.engilish.Name = "engilish";
            this.engilish.UseVisualStyleBackColor = true;
            this.engilish.Click += new System.EventHandler(this.engilishBtn_Click);
            // 
            // frenchBtn
            // 
            resources.ApplyResources(this.frenchBtn, "frenchBtn");
            this.frenchBtn.Name = "frenchBtn";
            this.frenchBtn.UseVisualStyleBackColor = true;
            this.frenchBtn.Click += new System.EventHandler(this.frenchBtn_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frenchBtn);
            this.Controls.Add(this.engilish);
            this.Controls.Add(this.revealBtn);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.cmbBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Button revealBtn;
        private System.Windows.Forms.Button engilish;
        private System.Windows.Forms.Button frenchBtn;
    }
}

