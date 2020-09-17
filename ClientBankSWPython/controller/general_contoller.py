import sys
import os
import firebase_admin
from firebase_admin import firestore
from firebase_admin import credentials

absolute_url = os.path.dirname(os.path.abspath(__file__)) + "/"

cred = credentials.Certificate(absolute_url+'proyectosoa2020bankemb-firebase-adminsdk-cvrqv-5c56158e88.json')
app = firebase_admin.initialize_app(cred)
db = firestore.client()

def url(path):
    return "http://192.168.16.14:7101/AppBankRESTful-Servidor-context-root/resources/webServices/" + path

def get_db():
    return db