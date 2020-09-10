using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class DatabaseSettings
    {
        /// <summary>
        /// Name of the Database
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Hostname of the Database
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Port of the Database
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Username of the user of the Database
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Username of the user of the Database
        /// </summary>
        public string Password { get; set; }
    }
}
