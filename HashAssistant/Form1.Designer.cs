namespace HashAssistant
{
  partial class FormHashAssistant
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHashAssistant));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFileFullPath = new System.Windows.Forms.TextBox();
            this.labelExpectedHash = new System.Windows.Forms.Label();
            this.textBoxExpectedHash = new System.Windows.Forms.TextBox();
            this.buttonCheckHash = new System.Windows.Forms.Button();
            this.buttonBrowseFileToCompute = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelHashPrompt = new System.Windows.Forms.Label();
            this.buttonBrowseHashFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFileFullPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelExpectedHash, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxExpectedHash, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCheckHash, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrowseFileToCompute, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelHashPrompt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrowseHashFile, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelFile
            // 
            this.labelFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(19, 25);
            this.labelFile.Margin = new System.Windows.Forms.Padding(19, 25, 4, 5);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(182, 38);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "File to compute hash:";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFileFullPath
            // 
            this.textBoxFileFullPath.AllowDrop = true;
            this.textBoxFileFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxFileFullPath, 2);
            this.textBoxFileFullPath.Location = new System.Drawing.Point(209, 28);
            this.textBoxFileFullPath.Margin = new System.Windows.Forms.Padding(4, 25, 4, 5);
            this.textBoxFileFullPath.Name = "textBoxFileFullPath";
            this.textBoxFileFullPath.ReadOnly = true;
            this.textBoxFileFullPath.Size = new System.Drawing.Size(791, 31);
            this.textBoxFileFullPath.TabIndex = 1;
            this.textBoxFileFullPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFileFullPath_DragDrop);
            this.textBoxFileFullPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFileFullPath_DragEnter);
            // 
            // labelExpectedHash
            // 
            this.labelExpectedHash.AutoSize = true;
            this.labelExpectedHash.Location = new System.Drawing.Point(19, 123);
            this.labelExpectedHash.Margin = new System.Windows.Forms.Padding(19, 5, 4, 25);
            this.labelExpectedHash.Name = "labelExpectedHash";
            this.labelExpectedHash.Size = new System.Drawing.Size(179, 25);
            this.labelExpectedHash.TabIndex = 3;
            this.labelExpectedHash.Text = "Expected Hash Value:";
            this.labelExpectedHash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxExpectedHash
            // 
            this.textBoxExpectedHash.AllowDrop = true;
            this.textBoxExpectedHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxExpectedHash, 2);
            this.textBoxExpectedHash.Location = new System.Drawing.Point(209, 123);
            this.textBoxExpectedHash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExpectedHash.Multiline = true;
            this.textBoxExpectedHash.Name = "textBoxExpectedHash";
            this.textBoxExpectedHash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExpectedHash.Size = new System.Drawing.Size(791, 81);
            this.textBoxExpectedHash.TabIndex = 4;
            this.textBoxExpectedHash.TextChanged += new System.EventHandler(this.textBoxExpectedHash_TextChanged);
            this.textBoxExpectedHash.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxExpectedHash_DragDrop);
            this.textBoxExpectedHash.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxExpectedHash_DragEnter);
            // 
            // buttonCheckHash
            // 
            this.buttonCheckHash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCheckHash.Location = new System.Drawing.Point(209, 233);
            this.buttonCheckHash.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.buttonCheckHash.Name = "buttonCheckHash";
            this.buttonCheckHash.Size = new System.Drawing.Size(189, 60);
            this.buttonCheckHash.TabIndex = 5;
            this.buttonCheckHash.Text = "&Check Hash";
            this.buttonCheckHash.UseVisualStyleBackColor = true;
            this.buttonCheckHash.Click += new System.EventHandler(this.buttonCheckHash_Click);
            // 
            // buttonBrowseFileToCompute
            // 
            this.buttonBrowseFileToCompute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBrowseFileToCompute.Location = new System.Drawing.Point(1008, 25);
            this.buttonBrowseFileToCompute.Margin = new System.Windows.Forms.Padding(4, 25, 19, 5);
            this.buttonBrowseFileToCompute.Name = "buttonBrowseFileToCompute";
            this.buttonBrowseFileToCompute.Size = new System.Drawing.Size(57, 38);
            this.buttonBrowseFileToCompute.TabIndex = 2;
            this.buttonBrowseFileToCompute.Text = "...";
            this.buttonBrowseFileToCompute.UseVisualStyleBackColor = true;
            this.buttonBrowseFileToCompute.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(421, 242);
            this.progressBar.Margin = new System.Windows.Forms.Padding(19, 5, 19, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(564, 38);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 6;
            // 
            // labelHashPrompt
            // 
            this.labelHashPrompt.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelHashPrompt, 3);
            this.labelHashPrompt.Location = new System.Drawing.Point(209, 68);
            this.labelHashPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.labelHashPrompt.Name = "labelHashPrompt";
            this.labelHashPrompt.Size = new System.Drawing.Size(431, 25);
            this.labelHashPrompt.TabIndex = 7;
            this.labelHashPrompt.Text = "SHA512 algorithm is used to calculate the hash value";
            // 
            // buttonBrowseHashFile
            // 
            this.buttonBrowseHashFile.Location = new System.Drawing.Point(1008, 123);
            this.buttonBrowseHashFile.Margin = new System.Windows.Forms.Padding(4, 5, 19, 5);
            this.buttonBrowseHashFile.Name = "buttonBrowseHashFile";
            this.buttonBrowseHashFile.Size = new System.Drawing.Size(57, 38);
            this.buttonBrowseHashFile.TabIndex = 8;
            this.buttonBrowseHashFile.Text = "...";
            this.buttonBrowseHashFile.UseVisualStyleBackColor = true;
            this.buttonBrowseHashFile.Click += new System.EventHandler(this.buttonBrowseHashFile_Click);
            // 
            // FormHashAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 314);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormHashAssistant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Assistant Tool v1.0.0.0";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

    }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelFile;
        private TextBox textBoxFileFullPath;
        private Button buttonBrowseFileToCompute;
        private Label labelExpectedHash;
        private TextBox textBoxExpectedHash;
        private Button buttonCheckHash;
        private ProgressBar progressBar;
        private Label labelHashPrompt;
        private Button buttonBrowseHashFile;
  }
}