using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIMS.Context
{
    public class GlobalVariables
    {
        public static string ConnectionStringMainDatabase { get; set; }
        public static string Issuer { get; set; }
        public static string Audience { get; set; }
        public static string SecretKey { get; set; }
        public static string EnvironmentType { get; set; }
        public static string ClientHost { get; set; }
    }
}
