import sys
import requests
from controller.general_contoller import url

def list_all_products():
    response = requests.get(url("Product/listAllProducts"))
    return response.json()

def find_produt(code):
    code = int(code)

    response = requests.get(url("Product/Product/findProduct?code={}".format(code)))
    return response.json()