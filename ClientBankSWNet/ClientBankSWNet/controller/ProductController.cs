using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace ClientBankSWNet.controller
{
    class ProductController
    {
        private static ProductController controller = null;
        private static FirestoreDb db;

        private ProductController()
        {
            db = GeneralController.DataBase;
        }

        public static ProductController Instance
        {
            get
            {
                if (controller == null)
                    controller = new ProductController();

                return controller;
            }
        }

        public async Task<List<Dictionary<string, object>>> ListAllProducts()
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

            try
            {
                CollectionReference collRef = db.Collection("products");
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

        public async Task<Dictionary<string, object>> FindProduct(String strCode)
        {
            int code;
            try
            {
                code = Int32.Parse(strCode);
            }
            catch (Exception)
            {
                throw new Exception("Código de producto invalido");
            }

            DocumentReference docRef = db.Collection("products").Document(strCode);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                Dictionary<string, object> product = snapshot.ToDictionary();
                return product;
            }
            else
            {
                throw new Exception("Producto número " + strCode + "No se ha encontrado");
            }
        }
    }
}
