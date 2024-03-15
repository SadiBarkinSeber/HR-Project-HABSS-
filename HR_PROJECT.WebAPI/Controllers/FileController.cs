

using Azure.Storage.Blobs;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly BlobServiceClient _blobServiceClient;

        public FileController(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file was selected for upload.");
            var blobContainerClient = _blobServiceClient.GetBlobContainerClient("photos");

            await blobContainerClient.CreateIfNotExistsAsync();

            var blobName = Path.GetFileName(file.FileName);
            var blobClient = blobContainerClient.GetBlobClient(blobName);

            using (var stream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, true);
            }

            return Ok("File uploaded successfully.");
        }

        [HttpGet]
        [Route("download")]
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                return BadRequest("File name is required for download.");

            var blobContainerClient = _blobServiceClient.GetBlobContainerClient("photos");
            var blobClient = blobContainerClient.GetBlobClient(fileName);

            if (!await blobClient.ExistsAsync())
                return NotFound("File not found.");

            var response = await blobClient.DownloadAsync();
            var stream = response.Value.Content;

            return File(stream, response.Value.ContentType, fileName);
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return BadRequest("File name is required for deletion.");
            var blobContainerClient = _blobServiceClient.GetBlobContainerClient("photos");
            var blobClient = blobContainerClient.GetBlobClient(fileName);

            if (!await blobClient.ExistsAsync())
                return NotFound("File not found.");

            await blobClient.DeleteAsync();

            return Ok("File deleted successfully.");
        }
    }
}
