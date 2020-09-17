import sys
import requests
from controller.general_contoller import get_db

db = get_db()

def list_all_products():
    products_ref = db.collection(u'products')
    docs = products_ref.stream()
    products = []
    for doc in docs:
        products.append(doc.to_dict())
    return products

def find_produt(code):
    doc_ref = db.collection(u'products').document(code)
    doc = doc_ref.get()
    if doc.exists:
        return doc.to_dict()
    else:
        raise Exception("Producto no encontrado")