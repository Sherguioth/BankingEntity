using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace ClientBankSWNet.controller
{
    class ProductRegistrationController
    {
        private static ProductRegistrationController controller = null;
        private static FirestoreDb db;

        private ProductRegistrationController() 
        {
            db = GeneralController.DataBase;
        }

        public static ProductRegistrationController Instance
        {
            get
            {
                if (controller == null)
                    controller = new ProductRegistrationController();

                return controller;
            }
        }

        public async Task<List<Dictionary<string, object>>> ListAllProductRegistations()
        {
            List<Dictionary<string, object>> productRegistrations = new List<Dictionary<string, object>>();

            try
            {
                CollectionReference collRef = db.Collection("products_registrations");
                QuerySnapshot snapshot = await collRef.GetSnapshotAsync();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    Dictionary<string, object> documentDictionary = document.ToDictionary();
                    productRegistrations.Add(documentDictionary);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productRegistrations;
        }

        public async Task<bool> AddProductRegistration(String strClientId, int productCode, String strProductNumber,
                                                String strBalance, DateTime registrationDate, DateTime expirationDate,
                                                bool state)
        {
            if (strClientId.Equals("") || strProductNumber.Equals("") || strBalance.Equals("") ||
                registrationDate == null || expirationDate == null)
            {
                throw new Exception("Por favor diligenciar todos los campos");
            }
            else
            {
                int clientId = int.Parse(strClientId);
                int productNumber;
                double balance;

                try
                {
                    productNumber = int.Parse(strProductNumber);
                }
                catch (Exception)
                {
                    throw new Exception("Número de producto invalido.\nPor favor digite un valor numérico");
                }
                try
                {
                    balance = Double.Parse(strBalance);
                }
                catch (Exception)
                {
                    throw new Exception("Saldo invalido.\nPor favor digite un valor numérico");
                }

                Dictionary<string, object> newRegistration = new Dictionary<string, object>() {
                    {"clientId", clientId },
                    {"productCode" , productCode },
                    {"productNumber" , productNumber },
                    {"balance" , balance },
                    {"registrationDate" , registrationDate.ToString("yyyy-MM-dd")},
                    {"expirationDate" , expirationDate.ToString("yyyy-MM-dd")},
                    {"state" , state}
                };

                DocumentReference docRef = db.Collection("products_registrations").Document(String.Format("{0}-{1}", strClientId, productCode));
                await docRef.SetAsync(newRegistration);

                return true;
            }
        }

        public async Task<Dictionary<string, object>> FindProductRegistration(String strClientId, String strProductCode)
        {
            int clientId = int.Parse(strClientId);
            int productCode;
            try
            {
                productCode = int.Parse(strProductCode);
            }
            catch (Exception)
            {
                throw new Exception("Por favor seleccione un producto");
            }

            DocumentReference docRef = db.Collection("products_registrations").Document(String.Format("{0}-{1}", strClientId, productCode));
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                Dictionary<string, object> productRegistration = snapshot.ToDictionary();
                return productRegistration;
            }
            else
            {
                throw new Exception("No se ha encontrado el registro del producto");
            }
        }

        public async Task<bool> UpdateProductRegistration(String strClientId, String strProductCode, String strProductNumber,
                                                String strBalance, DateTime registrationDate, DateTime expirationDate,
                                                bool state)
        {
            if (strProductNumber.Equals("") || strBalance.Equals("") || registrationDate == null || expirationDate == null)
            {
                throw new Exception("Por favor diligenciar todos los campos");
            }
            else
            {
                Dictionary<string, object> productRegistrationToUpdate;

                try
                {
                    productRegistrationToUpdate = await this.FindProductRegistration(strClientId, strProductCode);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                int clientId = int.Parse(strClientId);
                int productCode;
                int productNumber;
                double balance;

                try
                {
                    productCode = int.Parse(strProductCode);
                }
                catch (Exception)
                {
                    throw new Exception("Por favor seleccione un producto");
                }
                try
                {
                    productNumber = int.Parse(strProductNumber);
                }
                catch (Exception)
                {
                    throw new Exception("Número de producto invalido.\nPor favor digite un valor numérico");
                }
                try
                {
                    balance = Double.Parse(strBalance);
                }
                catch (Exception)
                {
                    throw new Exception("Saldo invalido.\nPor favor digite un valor numérico");
                }

                productRegistrationToUpdate = new Dictionary<string, object>() {
                    {"clientId", clientId },
                    {"productCode" , productCode },
                    {"productNumber" , productNumber },
                    {"balance" , balance },
                    {"registrationDate" , registrationDate.ToString("yyyy-MM-dd")},
                    {"expirationDate" , expirationDate.ToString("yyyy-MM-dd")},
                    {"state" , state}
                };

                DocumentReference docRef = db.Collection("products_registrations").Document(String.Format("{0}-{1}", strClientId, productCode));
                await docRef.SetAsync(productRegistrationToUpdate, SetOptions.MergeAll);

                return true;
            }

        }

        public async Task<bool> DeleteProductRegistration(String strClientId, String strProductCode)
        {
            Dictionary<string, object> productRegistrationToDelete;

            try
            {
                productRegistrationToDelete = await this.FindProductRegistration(strClientId, strProductCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            DocumentReference docRef = db.Collection("products_registrations").Document(String.Format("{0}-{1}", strClientId, strProductCode));
            await docRef.DeleteAsync();

            return true;
        }
    }
}

