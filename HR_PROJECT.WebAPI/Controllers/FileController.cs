

using Azure.Storage.Blobs;
using HR_PROJECT.WebAPI.DTOs.FileDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Authorize]
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

            var uniqueFileName = $"{Guid.NewGuid().ToString()}-{Path.GetFileName(file.FileName)}";
            var blobClient = blobContainerClient.GetBlobClient(uniqueFileName);

            using (var stream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, true);
            }

            string message = "File uploaded successfully.";
            string fileName = uniqueFileName;

            var response = new UploadFileDTO
            {
                FileName = fileName,
                Message = message
            };

            return Ok(response);
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

            var contentType = response.Value.ContentType ?? "application/octet-stream";

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
