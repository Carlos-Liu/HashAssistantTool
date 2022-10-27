using System.Runtime.InteropServices;
using BCI.HashAssistant;

namespace HashAssistant
{
  internal static class Program
  {
    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    const int SW_HIDE = 0;
    const int SW_SHOW = 5;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      if (args.Length == 0)
      {
        var handle = GetConsoleWindow();
        // Hide the console
        ShowWindow(handle, SW_HIDE);

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormHashAssistant());
      }
      else
      {
        var firstArgument = args[0];
        if(string.Equals(firstArgument, "--help", StringComparison.OrdinalIgnoreCase) ||
           string.Equals(firstArgument, "/help", StringComparison.OrdinalIgnoreCase) ||
           string.Equals(firstArgument, "/?", StringComparison.OrdinalIgnoreCase))
        {
          Console.WriteLine(Resource.Msg_CmdLinePrompt);
          Console.ReadKey();
          return;
        }

        var fileFullPath = args[0];
        if(!File.Exists(fileFullPath)) 
        {
          Console.Write($"File '{fileFullPath}' does not exist.");
          Environment.Exit(-1);
        }

        var hashFileFullPath = string.Empty;
        if(args.Length > 1)
        {
          hashFileFullPath = args[1];
        }
        var directoryName = Path.GetDirectoryName(hashFileFullPath);
        if (string.IsNullOrWhiteSpace(directoryName))
        {
          // write hash file in the same directory with the file to calculate hash value
          // if does not specify the full file path
          var hashFileDirectory = Path.GetDirectoryName(fileFullPath);
          var nameOfFileToCalcHash = Path.GetFileNameWithoutExtension(fileFullPath);
          var hashFileName = string.IsNullOrWhiteSpace(hashFileFullPath)
            ? $"hash ({nameOfFileToCalcHash}).txt"
            : hashFileFullPath;

          hashFileFullPath = Path.Combine(hashFileDirectory, hashFileName);
        }

        var hashValue = HashGenerator.ComputeHashAsync(fileFullPath);

        try
        {
          File.WriteAllText(hashFileFullPath, hashValue.Result);
          Console.Write($"Hash file '{hashFileFullPath}' is created for file '{fileFullPath}'.");
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex);
          Environment.Exit(-1);
        }
      }
    }
  }
}