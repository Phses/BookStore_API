﻿
namespace bookstore.Domain.Utils
{
    public static class UploadUtil
    {
        
        public static bool UploadArquivo(string arquivo, string imgNome)
        {
            var imgDataByteArray = Convert.FromBase64String(arquivo);

            if (string.IsNullOrEmpty(arquivo))
            {
                return false;
            }

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwRoot/Imagens", imgNome);

            if (System.IO.File.Exists(filePath))
            {
                return false;
            }

            System.IO.File.WriteAllBytes(filePath, imgDataByteArray);
            return true;
        }

    }
}
