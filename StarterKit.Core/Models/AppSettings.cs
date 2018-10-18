using System;
using System.Collections.Generic;
using System.Text;

namespace StarterKit.Core.Models
{
    public class AppSettings
    {
        public string DbConnection => $"User ID={DbUsername};Password={DbPassword};Server={DbServer};Port=5432;Database={DbName};Pooling=true;SSL Mode=Prefer;Trust Server Certificate=true";
        
        public string DbUsername => Environment.GetEnvironmentVariable("PG_DATABASE_USER");

        public string DbPassword => Environment.GetEnvironmentVariable("PG_DATABASE_PASS");

        public string DbName => Environment.GetEnvironmentVariable("PG_DATABASE_NAME");

        public string DbServer => Environment.GetEnvironmentVariable("PG_DATABASE_HOST");
        
    }
}
