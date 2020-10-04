using Aliyun.OSS;
using Aliyun.OSS.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SharpOSS
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 5)
            {
                Console.WriteLine("Author: Uknow");
                Console.WriteLine("Usage: SharpOSS.exe bucketName accessKeyId accessKeySecret endpoint UploadFilePath");
            }
            else
            {
                string bucketName = args[0];
                string accessKeyId = args[1];
                string accessKeySecret = args[2];
                string endpoint = args[3];
                string fileToUpload = args[4];
                OssClient client = new OssClient(endpoint, accessKeyId, accessKeySecret);
                try
                {
                    string key = Path.GetFileName(args[4]);
                    try
                    {
                        client.PutObject(bucketName, key, fileToUpload);
                        Console.WriteLine("\n [+] Upload File {0} to {1}.{2} succeeded", key, bucketName, endpoint);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n [-] Failed with error info: {0}", ex.Message);
                    }

                }
                catch (OssException ex)
                {
                    Console.WriteLine("\n [-] Failed with error code: {0}; Error info: {1}. \nRequestID:{2}\tHostID:{3}",
                                     ex.ErrorCode, ex.Message, ex.RequestId, ex.HostId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n [-] Failed with error info: {0}", ex.Message);
                }

            }
        }
    }
}
