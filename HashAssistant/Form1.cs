using BCI.HashAssistant;

namespace HashAssistant
{
  public partial class FormHashAssistant : Form
  {
    private CheckResultPane checkResultPane = new CheckResultPane();

    private string FileToCheck
    {
      get { return textBoxFileFullPath.Text.Trim(); }
      set
      {
        textBoxFileFullPath.Text = value;
        ResetCheckingRelatedControls();
      }
    }

    private string ExpectedHashValue
    {
      get { return textBoxExpectedHash.Text.Trim(); }
      set
      {
        textBoxExpectedHash.Text = value;
        ResetCheckingRelatedControls();
      }
    }

    public FormHashAssistant()
    {
      InitializeComponent();

      checkResultPane.Anchor = AnchorStyles.Left;
      checkResultPane.IsPassed = false;
      checkResultPane.Location = new Point(3, 140);
      checkResultPane.Name = "checkResultPane";
      checkResultPane.Size = new Size(200, 36);
      checkResultPane.TabIndex = 9;
      tableLayoutPanel1.Controls.Add(this.checkResultPane, 2, 3);

      ResetCheckingRelatedControls();
    }

    private void ResetCheckingRelatedControls()
    {
      progressBar.Visible = false;
      checkResultPane.Visible = false;
    }

    private void ToggleUiState(bool isEnabled)
    {
      buttonBrowseFileToCompute.Enabled = isEnabled;
      textBoxExpectedHash.Enabled = isEnabled;
      buttonCheckHash.Enabled = isEnabled;
    }

    private string BrowseFile()
    {
      var openFileDialog = new OpenFileDialog
      {
        Filter = Resource.OpenFileFilter,
        RestoreDirectory = true,
        Multiselect = false
      };

      var dialogResult = openFileDialog.ShowDialog();
      switch (dialogResult)
      {
        case DialogResult.OK:
          return openFileDialog.FileName;
        
        default:
          return string.Empty;
      }
    }

    private void buttonBrowse_Click(object sender, EventArgs e)
    {
      var fileNameToOpen = BrowseFile();
      FileToCheck = fileNameToOpen;
    }

    private void buttonBrowseHashFile_Click(object sender, EventArgs e)
    {
      var fileNameToOpen = BrowseFile();
      LoadHashFromFile(fileNameToOpen);
    }

    private void LoadHashFromFile(string hashFile)
    {
      if (string.IsNullOrWhiteSpace(hashFile))
      {
        return;
      }

      try
      {
        string fileContent = File.ReadAllText(hashFile);
        ExpectedHashValue = fileContent;
      }
      catch (Exception ex)
      {
        var error = string.Format(Resource.Msg_ReadHashFileError, ex.Message);
        MessageBox.Show(error, Resource.DialogTitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void textBoxExpectedHash_TextChanged(object sender, EventArgs e)
    {
      ResetCheckingRelatedControls();
    }

    private async void buttonCheckHash_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(FileToCheck))
      {
        MessageBox.Show(
          Resource.Msg_SelectFilePrompt,
          Resource.DialogTitleInformation,
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        return;
      }

      if (string.IsNullOrWhiteSpace(ExpectedHashValue))
      {
        MessageBox.Show(
          Resource.Msg_InputHashPrompt, 
          Resource.DialogTitleInformation, 
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        return;
      }

      string? actualHashValue;
      try
      {
        progressBar.Visible = true;
        ToggleUiState(false);
        actualHashValue = await HashGenerator.ComputeHashAsync(FileToCheck);
      }
      catch (Exception ex)
      {
        var error = string.Format(Resource.Msg_ComputeHashError, ex.Message);
        MessageBox.Show(error, Resource.DialogTitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      finally
      {
        progressBar.Visible = false;
        ToggleUiState(true);
      }

      var areHashTheSame = string.Equals(ExpectedHashValue, actualHashValue, StringComparison.OrdinalIgnoreCase);
      checkResultPane.IsPassed = areHashTheSame;
      checkResultPane.Visible = true;
    }

    private void SupportDropFiles(DragEventArgs e)
    {
      if (e == null || e.Data == null) return;

      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        e.Effect = DragDropEffects.All;
      }
      else
      {
        e.Effect = DragDropEffects.None;
      }
    }

    private string GetDroppedFile(DragEventArgs e)
    {
      if (e == null || e.Data == null) return string.Empty;

      string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
      if (files.Length > 1)
      {
        MessageBox.Show(
          Resource.Msg_OnlySupportDropSingleFile,
          Resource.DialogTitleInformation,
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        return string.Empty;
      }

      return files[0];
    }

    private void textBoxFileFullPath_DragEnter(object sender, DragEventArgs e)
    {
      SupportDropFiles(e);
    }

    private void textBoxFileFullPath_DragDrop(object sender, DragEventArgs e)
    {
      var droppedFile = GetDroppedFile(e);
      if (string.IsNullOrEmpty(droppedFile)) return;

      FileToCheck = droppedFile;
    }

    private void textBoxExpectedHash_DragEnter(object sender, DragEventArgs e)
    {
      SupportDropFiles(e);
    }

    private void textBoxExpectedHash_DragDrop(object sender, DragEventArgs e)
    {
      var droppedFile = GetDroppedFile(e);
      if (string.IsNullOrEmpty(droppedFile)) return;

      LoadHashFromFile(droppedFile);
    }
  }
}