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
      this.checkResultPane = new BCI.HashAssistant.CheckResultPane();
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
      this.tableLayoutPanel1.Controls.Add(this.checkResultPane, 2, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 189);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // labelFile
      // 
      this.labelFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.labelFile.AutoSize = true;
      this.labelFile.Location = new System.Drawing.Point(13, 15);
      this.labelFile.Margin = new System.Windows.Forms.Padding(13, 15, 3, 3);
      this.labelFile.Name = "labelFile";
      this.labelFile.Size = new System.Drawing.Size(121, 23);
      this.labelFile.TabIndex = 0;
      this.labelFile.Text = "File to compute hash:";
      this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBoxFileFullPath
      // 
      this.textBoxFileFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.textBoxFileFullPath, 2);
      this.textBoxFileFullPath.Location = new System.Drawing.Point(140, 15);
      this.textBoxFileFullPath.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
      this.textBoxFileFullPath.Name = "textBoxFileFullPath";
      this.textBoxFileFullPath.ReadOnly = true;
      this.textBoxFileFullPath.Size = new System.Drawing.Size(378, 23);
      this.textBoxFileFullPath.TabIndex = 1;
      // 
      // labelExpectedHash
      // 
      this.labelExpectedHash.AutoSize = true;
      this.labelExpectedHash.Location = new System.Drawing.Point(13, 74);
      this.labelExpectedHash.Margin = new System.Windows.Forms.Padding(13, 3, 3, 15);
      this.labelExpectedHash.Name = "labelExpectedHash";
      this.labelExpectedHash.Size = new System.Drawing.Size(119, 15);
      this.labelExpectedHash.TabIndex = 3;
      this.labelExpectedHash.Text = "Expected Hash Value:";
      this.labelExpectedHash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // textBoxExpectedHash
      // 
      this.textBoxExpectedHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.textBoxExpectedHash, 2);
      this.textBoxExpectedHash.Location = new System.Drawing.Point(140, 74);
      this.textBoxExpectedHash.Multiline = true;
      this.textBoxExpectedHash.Name = "textBoxExpectedHash";
      this.textBoxExpectedHash.Size = new System.Drawing.Size(378, 50);
      this.textBoxExpectedHash.TabIndex = 4;
      this.textBoxExpectedHash.TextChanged += new System.EventHandler(this.textBoxExpectedHash_TextChanged);
      // 
      // buttonCheckHash
      // 
      this.buttonCheckHash.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonCheckHash.Location = new System.Drawing.Point(140, 141);
      this.buttonCheckHash.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
      this.buttonCheckHash.Name = "buttonCheckHash";
      this.buttonCheckHash.Size = new System.Drawing.Size(132, 36);
      this.buttonCheckHash.TabIndex = 5;
      this.buttonCheckHash.Text = "&Check Hash";
      this.buttonCheckHash.UseVisualStyleBackColor = true;
      this.buttonCheckHash.Click += new System.EventHandler(this.buttonCheckHash_Click);
      // 
      // buttonBrowseFileToCompute
      // 
      this.buttonBrowseFileToCompute.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonBrowseFileToCompute.Location = new System.Drawing.Point(524, 15);
      this.buttonBrowseFileToCompute.Margin = new System.Windows.Forms.Padding(3, 15, 13, 3);
      this.buttonBrowseFileToCompute.Name = "buttonBrowseFileToCompute";
      this.buttonBrowseFileToCompute.Size = new System.Drawing.Size(40, 23);
      this.buttonBrowseFileToCompute.TabIndex = 2;
      this.buttonBrowseFileToCompute.Text = "...";
      this.buttonBrowseFileToCompute.UseVisualStyleBackColor = true;
      this.buttonBrowseFileToCompute.Click += new System.EventHandler(this.buttonBrowse_Click);
      // 
      // progressBar
      // 
      this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBar.Location = new System.Drawing.Point(534, 146);
      this.progressBar.Margin = new System.Windows.Forms.Padding(13, 3, 13, 3);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(212, 23);
      this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progressBar.TabIndex = 6;
      // 
      // labelHashPrompt
      // 
      this.labelHashPrompt.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.labelHashPrompt, 3);
      this.labelHashPrompt.Location = new System.Drawing.Point(140, 41);
      this.labelHashPrompt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
      this.labelHashPrompt.Name = "labelHashPrompt";
      this.labelHashPrompt.Size = new System.Drawing.Size(285, 15);
      this.labelHashPrompt.TabIndex = 7;
      this.labelHashPrompt.Text = "SHA512 algorithm is used to calculate the hash value";
      // 
      // buttonBrowseHashFile
      // 
      this.buttonBrowseHashFile.Location = new System.Drawing.Point(524, 74);
      this.buttonBrowseHashFile.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
      this.buttonBrowseHashFile.Name = "buttonBrowseHashFile";
      this.buttonBrowseHashFile.Size = new System.Drawing.Size(40, 23);
      this.buttonBrowseHashFile.TabIndex = 8;
      this.buttonBrowseHashFile.Text = "...";
      this.buttonBrowseHashFile.UseVisualStyleBackColor = true;
      this.buttonBrowseHashFile.Click += new System.EventHandler(this.buttonBrowseHashFile_Click);
      // 
      // checkResultPane
      // 
      this.checkResultPane.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.checkResultPane.IsPassed = false;
      this.checkResultPane.Location = new System.Drawing.Point(278, 140);
      this.checkResultPane.Name = "checkResultPane";
      this.checkResultPane.Size = new System.Drawing.Size(240, 36);
      this.checkResultPane.TabIndex = 9;
      // 
      // FormHashAssistant
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 189);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    private BCI.HashAssistant.CheckResultPane checkResultPane;
  }
}