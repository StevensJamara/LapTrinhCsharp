public class Program
{
    public static void Main(string[] args)
    {
        string sourceText = "D:\\Programming\\Test\\SourceText.txt";
        string destinationFile = "D:\\Programming\\Test\\DestinationText.txt";

        #region Check if source file exists
        bool isExists = File.Exists(destinationFile);
        File.Copy(sourceText, destinationFile, isExists);
        Console.WriteLine("File copied successfully.");
        #endregion
        #region File info
        FileInfo sourceFileText = new FileInfo(sourceText);
        long size = sourceFileText.Length;
        Console.WriteLine($"File size: {size} bytes");
        #endregion
    }
}
