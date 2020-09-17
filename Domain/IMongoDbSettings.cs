using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IMongoDbSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
