using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig 
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        /*list of connectio brcause if 
                                                                               we have more than data sourse to connect with*/
        public static void InitializeConnections(bool database, bool textFile)
        {
            if(database == true)
            {
                //TODO - Set up the sql connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }    
            if(textFile)
            {
                //TODO - Create the Text Connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }



    }
}
