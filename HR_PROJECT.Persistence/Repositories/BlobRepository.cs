using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Repositories
{
    public class BlobRepository : IBlobRepository
    {
        private readonly BlobService _blobService;
        

        public BlobRepository(BlobService blobService)
        {
            _blobService = blobService;
        }

        public async Task DeleteBlobAsync(string containerName, string blobName)
        {
            var blobContainerClient = _blobService.GetBlobContainerClient(containerName);
            var blobClient = blobContainerClient.GetBlobClient(blobName);

            await blobClient.DeleteIfExistsAsync();
        }

        public async Task<Stream> GetBlobStreamAsync(string containerName, string blobName)
        {
            var blobContainerClient = _blobService.GetBlobContainerClient(containerName);
            var blobClient = blobContainerClient.GetBlobClient(blobName);

            var response = await blobClient.DownloadAsync();
            var stream = response.Value.Content;

            return stream;
        }

        public async Task UploadBlobAsync(string containerName, string blobName, Stream stream)
        {
            var blobContainerClient = _blobService.GetBlobContainerClient(containerName);
            var blobClient = blobContainerClient.GetBlobClient(blobName);

            await blobClient.UploadAsync(stream, true);
        }
    }
}
