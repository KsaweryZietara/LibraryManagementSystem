using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public static class GlobalConfig {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeDataConnection(string dataBaseType) {
            if (dataBaseType == "textFile") {
                Connection = new TextFileConnector(); 
            }
            
            if (dataBaseType == "sql") {

            }
        }
    }
}
