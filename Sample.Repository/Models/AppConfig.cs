using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class AppConfig
    {
        public string Hostname { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
    }
}
