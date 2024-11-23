using System;
using System.IO;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace BLL
{
    public class R2
    {
        private const string AccessKey = "1cad3628a31e548d9dde83459c47ee6d";
        private const string SecretKey = "50e6265a8128d29935c05acc52ff6f34f6011b2237818f34ba8b981e5645bd95";
        private const string BucketName = "qlkhachsan";
        private const string ServiceUrl = "https://561409b47da3fa82bab13c2d5b1a9cf4.r2.cloudflarestorage.com";
        private readonly AmazonS3Client s3Client;

        public R2()
        {
            var config = new AmazonS3Config
            {
                ServiceURL = ServiceUrl,
                ForcePathStyle = true,
                AuthenticationRegion = "auto",
                MaxErrorRetry = 3
            };
            var credentials = new BasicAWSCredentials(AccessKey, SecretKey);
            s3Client = new AmazonS3Client(credentials, config);
        }
        //-----------------------------------------------------------------------------------------------------
        //Thêm ảnh vào R2
        public async Task<string> UploadImageToR2(string localFilePath, string loaiPhong, int counter)
        {
            string bucketUrl = "pub-c8adcbfebc8642f887468c77f77c44fe.r2.dev";
            string folder = $"LoaiPhong/{loaiPhong}";
            string fileName = $"{loaiPhong}{counter}{Path.GetExtension(localFilePath)}"; // Lấy đúng extension của file
            string objectKey = $"{folder}/{fileName}";

            try
            {
                if (!File.Exists(localFilePath))
                {
                    throw new FileNotFoundException($"Không tìm thấy file: {localFilePath}");
                }

                var transferUtility = new TransferUtility(s3Client);
                var request = new TransferUtilityUploadRequest
                {
                    BucketName = BucketName,
                    FilePath = localFilePath,
                    Key = objectKey,
                    ContentType = GetContentType(localFilePath),
                    DisablePayloadSigning = true
                };

                await transferUtility.UploadAsync(request);

                return $"https://{bucketUrl}/{objectKey}";
            }
            catch (AmazonS3Exception ex)
            {
                Console.WriteLine($"Lỗi S3 khi tải ảnh lên R2: {ex.Message}");
                Console.WriteLine($"Error Code: {ex.ErrorCode}, Error Type: {ex.ErrorType}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải ảnh lên R2: {ex.Message}");
                return null;
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tùy chỉnh thể loại ảnh
        private string GetContentType(string fileName)
        {
            string extension = System.IO.Path.GetExtension(fileName).ToLowerInvariant();
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                case ".gif":
                    return "image/gif";
                default:
                    return "application/octet-stream";
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xóa ảnh trong R2
        public async Task DeleteImageFromR2(string objectKey)
        {
            try
            {
                if (string.IsNullOrEmpty(objectKey))
                {
                    throw new ArgumentException("ObjectKey không được để trống");
                }

                var deleteRequest = new Amazon.S3.Model.DeleteObjectRequest
                {
                    BucketName = BucketName,
                    Key = objectKey
                };

                var response = await s3Client.DeleteObjectAsync(deleteRequest);
                Console.WriteLine($"Xóa ảnh thành công: {objectKey}");
            }
            catch (AmazonS3Exception ex)
            {
                Console.WriteLine($"Lỗi S3 khi xóa ảnh trên R2: {ex.Message}");
                Console.WriteLine($"Error Code: {ex.ErrorCode}, Error Type: {ex.ErrorType}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa ảnh trên R2: {ex.Message}");
            }
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
