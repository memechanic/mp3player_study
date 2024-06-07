namespace Logic
{
    public class FileManager
    {
        public static string UploadFile(string filePath)
        {

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
            {
                if (File.ReadAllText(filePath) != "")
                {
                    return File.ReadAllText(filePath);
                }
                else { throw new Exception("File is empty"); }
            }
            else { throw new Exception("File do not exist"); }
        }
    }
}
