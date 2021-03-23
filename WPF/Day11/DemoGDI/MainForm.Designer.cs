namespace DemoGDI
{
    partial class MainForm
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
            this.btnDrowRec = new System.Windows.Forms.Button();
            this.btnDrowImege = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrowRec
            // 
            this.btnDrowRec.Location = new System.Drawing.Point(38, 217);
            this.btnDrowRec.Name = "btnDrowRec";
            this.btnDrowRec.Size = new System.Drawing.Size(131, 58);
            this.btnDrowRec.TabIndex = 0;
            this.btnDrowRec.Text = "DrowRectangle";
            this.btnDrowRec.UseVisualStyleBackColor = true;
            this.btnDrowRec.Click += new System.EventHandler(this.btnDrowRec_Click);
            // 
            // btnDrowImege
            // 
            this.btnDrowImege.Location = new System.Drawing.Point(213, 217);
            this.btnDrowImege.Name = "btnDrowImege";
            this.btnDrowImege.Size = new System.Drawing.Size(131, 58);
            this.btnDrowImege.TabIndex = 1;
            this.btnDrowImege.Text = "DrowImege";
            this.btnDrowImege.UseVisualStyleBackColor = true;
            this.btnDrowImege.Click += new System.EventHandler(this.btnDrowImege_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 528);
            this.Controls.Add(this.btnDrowImege);
            this.Controls.Add(this.btnDrowRec);
            this.Name = "MainForm";
            this.Text = "DemoGDI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrowRec;
        private System.Windows.Forms.Button btnDrowImege;
    }
}

