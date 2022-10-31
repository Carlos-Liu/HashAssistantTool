
namespace BCI.HashAssistant
{
  public partial class CheckResultPane : UserControl
  {
    private bool _isPassed;
    public bool IsPassed
    {
      get { return _isPassed; }
      set
      {
        _isPassed = value;
        labelResult.Text = _isPassed ? "Pass" : "Fail";
        pictureBox.Image = _isPassed ? Resource.pass : Resource.error;
      }
    }

    public CheckResultPane()
    {
      InitializeComponent();
    }
  }
}
