import sys
import requests
from controller.general_contoller import url

def list_all_clients():
    response = requests.get(url("Client/listAllClients"))
    return response.json()

def insert_client(id_number, doc_type, name, birthday, email, phone_number, gender):
    id_number = int(id_number)
    
    new_client = {
        "identificationNumber" : id_number,
        "documetType" : doc_type,
        "name" : name,
        "birthday" : birthday,
        "email" : email,
        "phoneNumber" : phone_number,
        "gender" : gender
    }
    
    response = requests.post(url("Client/insertClient"), json= new_client)
    return response.content()

def find_client(id_number):
    id_number = int(id_number)
    
    response = requests.get(url("Client/findClient?clientId={}".format(id_number)))
    return response.json()

def update_client(id_number, doc_type, name, birthday, email, phone_number, gender):
    client_to_update = find_client(id_number)
    id_number = int(id_number)
    
    client_to_update["identificationNumber"] = id_number
    client_to_update["documetType"] = doc_type
    client_to_update["name"] = name
    client_to_update["birthday"] = birthday
    client_to_update["email"] = email
    client_to_update["phoneNumber"] = phone_number
    client_to_update["gender"] = gender
    
    response = requests.put(url("Client/updateClient?clientId={}".format(id_number)), json=client_to_update)
    return response.json()

def delete_client(id_number):
    client_to_delete = find_client(id_number)
    
    response = requests.delete(url("Client/deleteClient?clientId={}".format(client_to_delete["identificationNumber"])))
    return response.json()