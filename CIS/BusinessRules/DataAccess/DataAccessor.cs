using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace BusinessRules.DataAccess
{
    class DataAccessor:DataAccessBoundary
    {
        /// <summary>
        /// Configure the DatabaseFactory to read its configuration from the .config file
        /// </summary>
        static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        /// <summary>
        /// Create the default Database object from the factory.
        ///The actual concrete type is determined by the configuration settings.
        /// </summary>
        Database defaultDB = factory.CreateDefault();
        Database namedDB = factory.Create("ExampleDatabase");
    }
}
