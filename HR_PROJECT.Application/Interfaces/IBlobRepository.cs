using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Interfaces
{
    public interface IBlobRepository
    {
        Task<Stream> GetBlobStreamAsync(string containerName, string blobName);
        Task UploadBlobAsync(string containerName, string blobName, Stream stream);
        Task DeleteBlobAsync(string containerName, string blobName);
    }
}
