# dotnetCore.rsa
采用openssl生成RSA算法需要的私钥、公钥。采用.net core 2.1 控制台应用实现基于RSA算法的加密解密和签名校验。

生成私钥、公钥需要下载安装openssl工具包。由于git中就包含该工具包，只要把git程序的user/bin目录加到环境参数 path中，就能直接使用了。我当前win7下目录为：C:\Program Files\Git\usr\bin

生成私钥：
>openssl genrsa -out private.key 2048

根据私钥生成公钥：
>openssl rsa -in private.key -pubout -out public.key

