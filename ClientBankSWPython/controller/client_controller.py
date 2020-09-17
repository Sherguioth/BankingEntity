import sys
import requests
from controller.general_contoller import get_db

db = get_db()

def list_all_clients():
    clients_ref = db.collection(u'clients')
    docs = clients_ref.stream()
    clients = []
    for doc in docs:
        clients.append(doc.to_dict())
    return clients

def insert_client(str_id_number, doc_type, name, birthday, email, phone_number, gender):
    id_number = int(str_id_number)
    
    new_client = {
        u"identificationNumber" : id_number,
        u"documetType" : doc_type,
        u"name" : name,
        u"birthday" : birthday,
        u"email" : email,
        u"phoneNumber" : phone_number,
        u"gender" : gender
    }
    
    doc_ref = db.collection(u'clients').document(str_id_number)
    doc_ref.set(new_client)
    return True

def find_client(str_id_number):
    doc_ref = db.collection(u'clients').document(str_id_number)
    doc = doc_ref.get()
    if doc.exists:
        return doc.to_dict()
    else:
        raise Exception("Cliente no encontrado")

def update_client(str_id_number, doc_type, name, birthday, email, phone_number, gender):   
    try:
        client_to_update = find_client(str_id_number)
        id_number = int(str_id_number)
        
        client_to_update["identificationNumber"] = id_number
        client_to_update["documetType"] = doc_type
        client_to_update["name"] = name
        client_to_update["birthday"] = birthday
        client_to_update["email"] = email
        client_to_update["phoneNumber"] = phone_number
        client_to_update["gender"] = gender
        
        doc_ref = db.collection(u'clients').document(str_id_number)
        doc_ref.set(client_to_update)
        return True
    except Exception as ex:
        raise ex

def delete_client(str_id_number):   
    try:
        client_to_delete = find_client(str_id_number)
        db.collection(u'clients').document(str_id_number).delete()
        return True
    except Exception as ex:
        raise ex