﻿using ClassLibrary.DataAccess;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ClassLibrary {
    public static class GlobalConfig {
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Function initialize type of the data connection for the app.
        /// </summary>
        /// <param name="db">Enum which represent type of data connection.</param>
        public static void InitializeDataConnection(DataBase db) {
            if (db == DataBase.textFile) {
                Connection = new TextFileConnector(); 
            }
            
            else if (db == DataBase.mySql) {
                Connection = new MySqlConnector();
            }
        }
    }
}
