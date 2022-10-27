using System.Security.Cryptography;
using System.Text;

namespace BCI.HashAssistant
{
  internal static class HashGenerator
  {
    public static async Task<string> ComputeHashAsync(string fileFullPath)
    {
      if (string.IsNullOrWhiteSpace(fileFullPath))
      {
        throw new ArgumentNullException(nameof(fileFullPath));
      }

      if (!File.Exists(fileFullPath))
      {
        throw new FileNotFoundException("File not found.", fileFullPath);
      }

      using (var sha512 = SHA512.Create())
      {
        using (var fileStream = File.OpenRead(fileFullPath))
        {
          fileStream.Position = 0;
          var hashValue = await sha512.ComputeHashAsync(fileStream);

          var hashedInputStringBuilder = new StringBuilder(512);
          foreach (var b in hashValue)
          {
            hashedInputStringBuilder.Append(b.ToString("x2"));
          }
          return hashedInputStringBuilder.ToString();
        }
      }
    }
  }
}
