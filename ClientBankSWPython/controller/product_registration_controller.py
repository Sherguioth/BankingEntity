import requests
from general_contoller import url

def list_all_product_registration():
    response = requests.get(url("ProductRegistration/listAllProductRegistrations"))
    return response.json()

def insert_product_registration(client_id, product_code, product_number, balance, registration_date, expiration_date, state):
    client_id = int(client_id)
    product_code = int(product_code)
    product_number = int(product_number)
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
    
    response = requests.post(url("ProductRegistration/insertProductRegistration"), json=new_product_registration)
    return response.json()

def find_product_registration(client_id, product_code):
    client_id = int(client_id)
    product_code = int(product_code)
    
    response = requests.get(url("ProductRegistration/findProductRegistration?productCode={}&clientId={}".format(product_code, client_id)))
    return response.json()

def update_product_registration(client_id, product_code, product_number, balance, registration_date, expiration_date, state):
    product_registration_to_update = find_product_registration(client_id, product_code)
    
    client_id = int(client_id)
    product_code = int(product_code)
    product_number = int(product_number)
    balance = float(balance)
    
    product_registration_to_update['clientId'] = client_id
    product_registration_to_update['productCode'] = product_code
    product_registration_to_update['productNumber'] = product_number
    product_registration_to_update['balance'] = balance
    product_registration_to_update['registrationDate'] = registration_date
    product_registration_to_update['expirationDate'] = expiration_date
    product_registration_to_update['state'] = state
    
    response = requests.put(url("ProductRegistration/updateProductRegistration?productCode={}&clientId={}".format(product_code, client_id)), json=product_registration_to_update)
    return response.json()

def delete_product_registration(client_id, product_code):
    product_registration_to_update = find_product_registration(client_id, product_code)
    
    client_id = int(client_id)
    product_code = int(product_code)
    
    response = requests.delete(url("ProductRegistration/deleteProductRegistration?productCode={}&clientId={}".format(product_code, client_id)))
    return response.json()