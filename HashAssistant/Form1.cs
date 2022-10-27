using BCI.HashAssistant;

namespace HashAssistant
{
  public partial class FormHashAssistant : Form
  {
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
      if (string.IsNullOrWhiteSpace(fileNameToOpen))
      {
        return;
      }

      try
      {
        string fileContent = File.ReadAllText(fileNameToOpen);
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
  }
}