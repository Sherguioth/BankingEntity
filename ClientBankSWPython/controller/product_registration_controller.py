import sys
import requests
from controller.general_contoller import get_db

db = get_db()

def list_all_product_registration():
    registrations_ref = db.collection(u'products_registrations')
    docs = registrations_ref.stream()
    registrations = []
    for doc in docs:
        registrations.append(doc.to_dict())
    return registrations

def insert_product_registration(str_client_id, str_product_code, str_product_number, balance,
                                 registration_date, expiration_date, state):
    client_id = int(str_client_id)
    product_code = int(str_product_code)
    product_number = int(str_product_number)
    balance = float(balance)
    
    new_product_registration = {
        "clientId" : client_id,
        "productCode" : product_code,
        "productNumber" : product_number,
        "balance" : balance,
        "registrationDate" : registration_date,
        "expirationDate" : expiration_date,
        "state" : state
    }
    
    doc_ref = db.collection(u'products_registrations').document("{}-{}".format(str_client_id, str_product_code))
    doc_ref.set(new_product_registration)
    return True

def find_product_registration(str_client_id, str_product_code):
    doc_ref = db.collection(u'products_registrations').document("{}-{}".format(str_client_id, str_product_code))
    doc = doc_ref.get()
    if doc.exists:
        return doc.to_dict()
    else:
        raise Exception("Registro de producto no encontrado")

def update_product_registration(str_client_id, str_product_code, str_product_number, balance, 
                                registration_date, expiration_date, state):
    try:
        product_registration_to_update = find_product_registration(str_client_id, str_product_code)
    
        client_id = int(str_client_id)
        product_code = int(str_product_code)
        product_number = int(str_product_number)
        balance = float(balance)
        
        product_registration_to_update['clientId'] = client_id
        product_registration_to_update['productCode'] = product_code
        product_registration_to_update['productNumber'] = product_number
        product_registration_to_update['balance'] = balance
        product_registration_to_update['registrationDate'] = registration_date
        product_registration_to_update['expirationDate'] = expiration_date
        product_registration_to_update['state'] = state
        
        doc_ref = db.collection(u'products_registrations').document("{}-{}".format(str_client_id, str_product_code))
        doc_ref.set(product_registration_to_update)
        return True
    except Exception as ex:
        raise ex

def delete_product_registration(str_client_id, str_product_code):
    try:
        product_registration_to_delete = find_product_registration(str_client_id, str_product_code)
        db.collection(u'products_registrations').document("{}-{}".format(str_client_id, str_product_code)).delete
        return True
    except Exception as ex:
        raise ex