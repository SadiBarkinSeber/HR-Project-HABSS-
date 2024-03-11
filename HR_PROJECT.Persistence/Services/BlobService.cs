using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Services
{
    public class BlobService : BlobServiceClient
    {
        private readonly string _connectionString = "DefaultEndpointsProtocol=https;AccountName=hrprojectphotos;AccountKey=qHhBO15p6tnKPJSMwQC0v1ajiwOVN+x8Kn+3r2dUEC0X5hLnTD4jKQZ9r7Mj4fqrPH4oA8ekRWyZ+AStGyM7/g==;EndpointSuffix=core.windows.net";
        private readonly string _containerName = "employeeprofilephotos";

        public BlobService(string connectionString, string containerName)
        {
            _connectionString = connectionString;
            _containerName = containerName;
        }
    }
}
