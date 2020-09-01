using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBankSWNet.controller
{
    using ClientWebService;
    using System.Runtime.InteropServices.WindowsRuntime;

    public class ClientController
    {
        private static ClientController controller = null;
        private ClientWebServiceClient clientWebService;

        private ClientController()
        {
            clientWebService = new ClientWebServiceClient();
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

        public client[] ListAllClients()
        {
            client[] listClients;

            try
            {
                listClients = clientWebService.listAllClients();
            }
            catch(Exception ex)
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
                int identificationNumber = 0;
                try
                {
                    identificationNumber = Int32.Parse(strIdNumber);
                }
                catch (Exception)
                {
                    throw new Exception("Número de identificación invalido.\nPor favor introducir un valor numérico");
                }

                client newClient = new client();

                newClient.identificationNumber = identificationNumber;
                newClient.documetType = docType;
                newClient.name = name;
                newClient.birthday = birthday;
                newClient.birthdaySpecified = true;
                newClient.email = email;
                newClient.phoneNumber = phoneNumber;
                newClient.gender = gender;

                return this.clientWebService.insertClient(newClient);
            }
        }

        public client FindClient(String strIdNumber)
        {
            client client = null;

            if (strIdNumber.Equals(""))
            {
                throw new Exception("Por favor ingrese un número de identificación.");
            }
            else
            {
                int identificationNumber = 0;
                try
                {
                    identificationNumber = Int32.Parse(strIdNumber);
                }
                catch (Exception)
                {
                    throw new Exception("Número de identificación invalido.\nPor favor introducir un valor numérico");
                }

                client = this.clientWebService.findClient(identificationNumber);

                if(client != null)
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
            client clientToUpdate = null;

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
                clientToUpdate.birthday = birthday;
                clientToUpdate.birthdaySpecified = true;
                clientToUpdate.email = email;
                clientToUpdate.phoneNumber = phoneNumber;
                clientToUpdate.gender = gender;

                return this.clientWebService.updateClient(clientToUpdate.identificationNumber, clientToUpdate);
            }
        }
        
        public bool DeleteClient(String strIdNumber)
        {
            client clientToDelete = null;

            try
            {
                clientToDelete = this.FindClient(strIdNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return this.clientWebService.deleteClient(clientToDelete.identificationNumber);
        }
    }
}
