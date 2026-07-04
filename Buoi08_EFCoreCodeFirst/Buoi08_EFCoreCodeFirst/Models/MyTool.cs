namespace Buoi08_EFCoreCodeFirst.Models
{
    public class MyTool
    {
        public static string UploadFileToFolder(IFormFile file, string folder)
        {
            try
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", folder, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return fileName;
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it)
                return null;
            }
        }
    }
}
