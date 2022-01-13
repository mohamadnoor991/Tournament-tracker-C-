using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        /*list of connectio brcause if 
        we have more than data sourse to connect with*/
        public static IDataConnection Connection { get; private set; }
        
        public static void InitializeConnections(DatabaseType db)
        {
            if(db == DatabaseType.Sql)
            {
                //TODO - Set up the sql connector properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }    
            else if(db == DatabaseType.TextFile)
            {
                //TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
