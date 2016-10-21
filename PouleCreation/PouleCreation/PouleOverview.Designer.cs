namespace PouleCreation
{
    partial class PouleOverview
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
            this.lbJudokas = new System.Windows.Forms.ListBox();
            this.btAddJudoka = new System.Windows.Forms.Button();
            this.lblPouleName = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbJudokas
            // 
            this.lbJudokas.FormattingEnabled = true;
            this.lbJudokas.Location = new System.Drawing.Point(35, 57);
            this.lbJudokas.Name = "lbJudokas";
            this.lbJudokas.Size = new System.Drawing.Size(120, 95);
            this.lbJudokas.TabIndex = 0;
            // 
            // btAddJudoka
            // 
            this.btAddJudoka.Location = new System.Drawing.Point(197, 87);
            this.btAddJudoka.Name = "btAddJudoka";
            this.btAddJudoka.Size = new System.Drawing.Size(75, 23);
            this.btAddJudoka.TabIndex = 1;
            this.btAddJudoka.Text = "Add Judoka";
            this.btAddJudoka.UseVisualStyleBackColor = true;
            // 
            // lblPouleName
            // 
            this.lblPouleName.AutoSize = true;
            this.lblPouleName.Location = new System.Drawing.Point(76, 22);
            this.lblPouleName.Name = "lblPouleName";
            this.lblPouleName.Size = new System.Drawing.Size(35, 13);
            this.lblPouleName.TabIndex = 2;
            this.lblPouleName.Text = "label1";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(197, 128);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // PouleOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lblPouleName);
            this.Controls.Add(this.btAddJudoka);
            this.Controls.Add(this.lbJudokas);
            this.Name = "PouleOverview";
            this.Text = "PouleOverview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbJudokas;
        private System.Windows.Forms.Button btAddJudoka;
        private System.Windows.Forms.Label lblPouleName;
        private System.Windows.Forms.Button btClose;
    }
}