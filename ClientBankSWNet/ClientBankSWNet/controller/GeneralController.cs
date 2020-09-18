using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace ClientBankSWNet.controller
{
    class GeneralController
    {
        private static FirestoreDb db = null;

        public static FirestoreDb DataBase
        {
            get 
            { 
                if(db == null)
                {
                    crateConnection();
                }
                return db; 
            }
        }

        private static void crateConnection()
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"proyectosoa2020bankemb-firebase-adminsdk-cvrqv-5c56158e88.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("proyectosoa2020bankemb");
        }
    }
}
