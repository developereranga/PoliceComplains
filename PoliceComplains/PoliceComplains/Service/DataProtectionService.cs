using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;

namespace PoliceComplains.Service
{
    public class DataProtectionService
    {
        private readonly IDataProtector _protector;


        public DataProtectionService(IDataProtectionProvider dataProtectionProvider, IConfiguration _configuration)
        {
            _protector =
                dataProtectionProvider.CreateProtector(_configuration.GetSection("DataProtection:SecretKey").Value);
        }

        public string Decrypt(string text)
        {
            return _protector.Unprotect(text);
        }

        public string Encypt(string text)
        {
            return _protector.Protect(text);
        }

        public string ToMd5(string text)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(text);
                var hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                var sb = new StringBuilder();
                for (var i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
                return sb.ToString();
            }
        }
    }

}
