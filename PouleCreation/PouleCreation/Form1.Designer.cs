namespace PouleCreation
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
            this.createPoule = new System.Windows.Forms.Button();
            this.lbPoule = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createPoule
            // 
            this.createPoule.Location = new System.Drawing.Point(772, 151);
            this.createPoule.Name = "createPoule";
            this.createPoule.Size = new System.Drawing.Size(129, 30);
            this.createPoule.TabIndex = 0;
            this.createPoule.Text = "Create Poule";
            this.createPoule.UseVisualStyleBackColor = true;
            this.createPoule.Click += new System.EventHandler(this.createPoule_Click);
            // 
            // lbPoule
            // 
            this.lbPoule.FormattingEnabled = true;
            this.lbPoule.Location = new System.Drawing.Point(177, 126);
            this.lbPoule.Name = "lbPoule";
            this.lbPoule.Size = new System.Drawing.Size(120, 95);
            this.lbPoule.TabIndex = 1;
            this.lbPoule.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(lbPoule_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 593);
            this.Controls.Add(this.lbPoule);
            this.Controls.Add(this.createPoule);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createPoule;
        private System.Windows.Forms.ListBox lbPoule;
    }
}

