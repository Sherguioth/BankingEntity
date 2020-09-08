using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using ClienteBankSWNet.structural;

namespace ClienteBankSWNet.controller
{
    public class ClientController
    {
        private static ClientController controller = null;

        private static HttpClient httpClient;

        private ClientController(){ }

        private void InstanceHttpClient()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
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

        public Client[] ListAllClients()
        {
            Client[] listClients = null;

            try
            {
                InstanceHttpClient();
                httpClient.BaseAddress = new Uri(GeneralController.URL + "Client/listAllClients");
                HttpResponseMessage response = httpClient.GetAsync(httpClient.BaseAddress).Result;
                HttpContent httpContent = response.Content;

                listClients = JsonConvert.DeserializeObject<Client[]>(httpContent.ReadAsStringAsync().Result.ToString());
                httpClient = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listClients;
        }

        public bool AddClient(String strIdNumber, String docType, String name, DateTime birthday, String email, String phoneNumber, String gender)
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

                Client newClient = new Client
                {
                    identificationNumber = identificationNumber,
                    documetType = docType,
                    name = name,
                    birthday = birthday.ToString("yyyy-MM-dd"),
                    email = email,
                    phoneNumber = phoneNumber,
                    gender = gender
                };

                InstanceHttpClient();
                httpClient.BaseAddress = new Uri(GeneralController.URL + "Client/insertClient");
                string strJson = JsonConvert.SerializeObject(newClient);
                HttpContent httpContent = new StringContent(strJson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = httpClient.PostAsync(httpClient.BaseAddress, httpContent).Result;
                httpClient = null;

                return response.IsSuccessStatusCode;
            }
        }

        public Client FindClient(string strIdNumber)
        {
            Client client;

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

                InstanceHttpClient();
                httpClient.BaseAddress = new Uri(GeneralController.URL + "Client/findClient?clientId="+strIdNumber);
                HttpResponseMessage response = httpClient.GetAsync(httpClient.BaseAddress).Result;
                HttpContent httpContent = response.Content;

                client = JsonConvert.DeserializeObject<Client>(httpContent.ReadAsStringAsync().Result.ToString());
                httpClient = null;

                if (client != null)
                {
                    return client;
                }
                else
                {
                    throw new Exception("El cliente con el número de identificación " + identificationNumber +
                    " no ha sido encontrado");
                }

            }
        }

        public bool UpdateClient(String strIdNumber, String docType, String name, DateTime birthday, String email, String phoneNumber, String gender)
        {
            Client clientToUpdate;
            try
            {
                clientToUpdate = this.FindClient(strIdNumber);
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
                clientToUpdate.documetType = docType;
                clientToUpdate.name = name;
                clientToUpdate.birthday = birthday.ToString("yyyy-MM-dd");
                clientToUpdate.email = email;
                clientToUpdate.phoneNumber = phoneNumber;
                clientToUpdate.gender = gender;

                InstanceHttpClient();
                httpClient.BaseAddress = new Uri(GeneralController.URL + "Client/updateClient?clientId="+strIdNumber);
                string strJson = JsonConvert.SerializeObject(clientToUpdate);
                HttpContent httpContent = new StringContent(strJson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = httpClient.PutAsync(httpClient.BaseAddress, httpContent).Result;
                httpClient = null;

                return response.IsSuccessStatusCode;
            }
        }
        
        public bool DeleteClient(String strIdNumber)
        {
            Client clientToDelete;

            try
            {
                clientToDelete = this.FindClient(strIdNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            InstanceHttpClient();
            httpClient.BaseAddress = new Uri(GeneralController.URL + "Client/deleteClient?clientId=" + strIdNumber);
            HttpResponseMessage response = httpClient.DeleteAsync(httpClient.BaseAddress).Result;
            httpClient = null;

            return response.IsSuccessStatusCode;
        }
    }
}
