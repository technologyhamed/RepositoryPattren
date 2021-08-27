using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AspNetCoreApi.FileRepository
{
    public interface IFileService
    {
        void UploadFile(List<IFormFile> files, string subDirectory);
        (string fileType, byte[] archiveData, string archiveName) DownloadFiles(string subDirectory);
        string SizeConverter(long bytes);
    }
}