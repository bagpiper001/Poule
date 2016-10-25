namespace PouleCreation
{
    partial class CreateJudoka
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
            this.btCreate = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.cbBelt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(185, 176);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 0;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(77, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "Name";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(77, 96);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 3;
            this.tbWeight.Text = "Weight";
            // 
            // cbBelt
            // 
            this.cbBelt.FormattingEnabled = true;
            this.cbBelt.Location = new System.Drawing.Point(77, 70);
            this.cbBelt.Name = "cbBelt";
            this.cbBelt.Size = new System.Drawing.Size(121, 21);
            this.cbBelt.TabIndex = 5;
            // 
            // CreateJudoka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cbBelt);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btCreate);
            this.Name = "CreateJudoka";
            this.Text = "CreateJudoka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.ComboBox cbBelt;
    }
}