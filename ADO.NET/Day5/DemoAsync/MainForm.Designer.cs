namespace DemoAsync
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
      this.lsbInfo = new System.Windows.Forms.ListBox();
      this.btnNoAsync = new System.Windows.Forms.Button();
      this.btnOldAsync = new System.Windows.Forms.Button();
      this.btnAsyncAwait = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lsbInfo
      // 
      this.lsbInfo.FormattingEnabled = true;
      this.lsbInfo.ItemHeight = 24;
      this.lsbInfo.Location = new System.Drawing.Point(15, 31);
      this.lsbInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.lsbInfo.Name = "lsbInfo";
      this.lsbInfo.Size = new System.Drawing.Size(626, 436);
      this.lsbInfo.TabIndex = 0;
      // 
      // btnNoAsync
      // 
      this.btnNoAsync.Location = new System.Drawing.Point(653, 31);
      this.btnNoAsync.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnNoAsync.Name = "btnNoAsync";
      this.btnNoAsync.Size = new System.Drawing.Size(150, 42);
      this.btnNoAsync.TabIndex = 1;
      this.btnNoAsync.Text = "NoAsync";
      this.btnNoAsync.UseVisualStyleBackColor = true;
      this.btnNoAsync.Click += new System.EventHandler(this.btnNoAsync_Click);
      // 
      // btnOldAsync
      // 
      this.btnOldAsync.Location = new System.Drawing.Point(653, 85);
      this.btnOldAsync.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnOldAsync.Name = "btnOldAsync";
      this.btnOldAsync.Size = new System.Drawing.Size(150, 42);
      this.btnOldAsync.TabIndex = 2;
      this.btnOldAsync.Text = "OldAsync";
      this.btnOldAsync.UseVisualStyleBackColor = true;
      this.btnOldAsync.Click += new System.EventHandler(this.btnOldAsync_Click);
      // 
      // btnAsyncAwait
      // 
      this.btnAsyncAwait.Location = new System.Drawing.Point(653, 139);
      this.btnAsyncAwait.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnAsyncAwait.Name = "btnAsyncAwait";
      this.btnAsyncAwait.Size = new System.Drawing.Size(150, 42);
      this.btnAsyncAwait.TabIndex = 3;
      this.btnAsyncAwait.Text = "AsyncAwait";
      this.btnAsyncAwait.UseVisualStyleBackColor = true;
      this.btnAsyncAwait.Click += new System.EventHandler(this.btnAsyncAwait_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(827, 492);
      this.Controls.Add(this.btnAsyncAwait);
      this.Controls.Add(this.btnOldAsync);
      this.Controls.Add(this.btnNoAsync);
      this.Controls.Add(this.lsbInfo);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "MainForm";
      this.Text = "DEMO ASYNC";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lsbInfo;
    private System.Windows.Forms.Button btnNoAsync;
    private System.Windows.Forms.Button btnOldAsync;
    private System.Windows.Forms.Button btnAsyncAwait;
  }
}

