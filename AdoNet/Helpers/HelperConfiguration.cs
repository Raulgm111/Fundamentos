using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Helpers
{
    public class HelperConfiguration
    {
        public static string GetConnectionString()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json", true, true);
            IConfigurationRoot config = builder.Build();

            string connectionString =
                config["SqlHospital"];
            return connectionString;
        }

        public static string GetConnectionString2()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json", true, true);
            IConfigurationRoot config = builder.Build();

            string connectionString =
                config["SqlPersonajes"];
            return connectionString;
        }
    }
}
