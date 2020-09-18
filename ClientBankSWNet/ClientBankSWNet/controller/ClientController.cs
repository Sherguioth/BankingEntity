using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace ClientBankSWNet.controller
{
    class ClientController
    {
        private static ClientController controller = null;
        private static FirestoreDb db;

        public ClientController()
        {
            db = GeneralController.DataBase;
        }

        public static ClientController Instance
        {
            get
            {
                if (controller == null)
                    controller = new ClientController();

                return controller;
            }
        }

        public async Task<List<Dictionary<string, object>>> ListAllClients()
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

            try
            {
                CollectionReference collRef = db.Collection("clients");
                QuerySnapshot snapshot = await collRef.GetSnapshotAsync();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    Dictionary<string, object> documentDictionary = document.ToDictionary();
                    list.Add(documentDictionary);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public async Task<bool> AddClient(String strIdNumber, String docType, String name, DateTime birthday, String email, String phoneNumber, String gender)
        {
            if (strIdNumber.Equals("") || docType.Equals("") || name.Equals("") || birthday == null ||
                email.Equals("") || phoneNumber.Equals("") || gender.Equals(""))
            {
                throw new Exception("Por favor diligencie correctamente todos los campos");
            }
            else
            {
                int identificationNumber;
                try
                {
                    identificationNumber = Int32.Parse(strIdNumber);
                }
                catch (Exception)
                {
                    throw new Exception("Número de identificación invalido.\nPor favor introducir un valor numérico");
                }

                Dictionary<string, object> newClient = new Dictionary<string, object>() {
                    {"identificationNumber", identificationNumber },
                    {"documetType" , docType },
                    {"name" , name },
                    {"birthday" , birthday.ToString("yyyy-MM-dd") },
                    {"email" , email},
                    {"phoneNumber" , phoneNumber},
                    {"gender" , gender}
                };

                DocumentReference docRef = db.Collection("clients").Document(strIdNumber);
                await docRef.SetAsync(newClient);

                return true;
            }
        }

        public async Task<Dictionary<string, object>> FindClient(string strIdNumber)
        {
            if (strIdNumber.Equals(""))
            {
                throw new Exception("Por favor ingrese un número de identificación.");
            }
            else
            {
                int identificationNumber;
                try
                {
                    identificationNumber = Int32.Parse(strIdNumber);
                }
                catch (Exception)
                {
                    throw new Exception("Número de identificación invalido.\nPor favor introducir un valor numérico");
                }

                DocumentReference docRef = db.Collection("clients").Document(strIdNumber);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    Dictionary<string, object> client = snapshot.ToDictionary();
                    return client;
                }
                else
                {
                    throw new Exception("El cliente con el número de identificación " + identificationNumber +
                    " no ha sido encontrado");
                }

            }
        }

        public async Task<bool> UpdateClient(String strIdNumber, String docType, String name, DateTime birthday, String email, String phoneNumber, String gender)
        {
            Dictionary<string, object> clientToUpdate;
            try
            {
                clientToUpdate = await this.FindClient(strIdNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (docType.Equals("") || name.Equals("") || birthday == null ||
                email.Equals("") || phoneNumber.Equals("") || gender.Equals(""))
            {
                throw new Exception("Por favor diligencie correctamente todos los campos");
            }
            else
            {
                int identificationNumber = Int32.Parse(strIdNumber);
                clientToUpdate = new Dictionary<string, object>() {
                    {"identificationNumber", identificationNumber },
                    {"documetType" , docType },
                    {"name" , name },
                    {"birthday" , birthday.ToString("yyyy-MM-dd") },
                    {"email" , email},
                    {"phoneNumber" , phoneNumber},
                    {"gender" , gender}
                };

                //Tener en cuenta
                DocumentReference docRef = db.Collection("clients").Document(strIdNumber);
                await docRef.SetAsync(clientToUpdate, SetOptions.MergeAll);

                return true;
            }
        }

        public async Task<bool> DeleteClient(String strIdNumber)
        {
            Dictionary<string, object> clientToDelete;
            try
            {
                clientToDelete = await this.FindClient(strIdNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            DocumentReference docRef = db.Collection("clients").Document(strIdNumber);
            await docRef.DeleteAsync();

            return true;
        }
    }
}
