using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace dotnetCore.rsa
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string privateKey = System.IO.File.ReadAllText("private.key").Replace("-----BEGIN RSA PRIVATE KEY-----","").Replace("-----END RSA PRIVATE KEY-----","");
            string publicKey = System.IO.File.ReadAllText("public.key").Replace("-----BEGIN PUBLIC KEY-----","").Replace("-----END PUBLIC KEY-----","");


            var rsa = new RSAHelper(RSAType.RSA2,Encoding.UTF8, privateKey, publicKey);

            string str = "欢迎访问：notepad2.cn";

            Console.WriteLine("原始字符串：" + str);

            //----------------------------------------------加密解密

            /*公钥加密*/
	        string enStr = rsa.Encrypt(str);
            
            Console.WriteLine("加密字符串："+enStr);

            /*私钥解密 */
	        string deStr = rsa.Decrypt(enStr);
            Console.WriteLine("解密字符串："+deStr);


            //----------------------------------------------签名校验

            /*私钥签名 */
	        string signStr = rsa.Sign(str);
            Console.WriteLine("字符串签名：" + signStr);

            /*公钥验证签名 */
	        bool signVerify = rsa.Verify(str,signStr);

            Console.WriteLine("验证签名：" + signVerify);
            Console.ReadKey();

            
        }
    }
}
