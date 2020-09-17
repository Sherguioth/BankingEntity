# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIListProductRegistrationByClient.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtWidgets import QTableWidgetItem
from gui.gui_modal_list_clients import GUI_Modal
from controller import product_registration_controller


class Ui_GUI_List_Product_Registration_By_Client(object):
    def setupUi(self, GUI_List_Product_Registration_By_Client):
        GUI_List_Product_Registration_By_Client.setObjectName("GUI_List_Product_Registration_By_Client")
        GUI_List_Product_Registration_By_Client.resize(800, 432)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(GUI_List_Product_Registration_By_Client.sizePolicy().hasHeightForWidth())
        GUI_List_Product_Registration_By_Client.setSizePolicy(sizePolicy)
        self.centralwidget = QtWidgets.QWidget(GUI_List_Product_Registration_By_Client)
        self.centralwidget.setObjectName("centralwidget")
        self.label_title = QtWidgets.QLabel(self.centralwidget)
        self.label_title.setGeometry(QtCore.QRect(30, 20, 731, 51))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(24)
        self.label_title.setFont(font)
        self.label_title.setContextMenuPolicy(QtCore.Qt.NoContextMenu)
        self.label_title.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.label_title.setAlignment(QtCore.Qt.AlignCenter)
        self.label_title.setObjectName("label_title")
        self.txt_client_id = QtWidgets.QTextEdit(self.centralwidget)
        self.txt_client_id.setGeometry(QtCore.QRect(200, 90, 271, 24))
        self.txt_client_id.setObjectName("txt_client_id")
        self.label_client_id = QtWidgets.QLabel(self.centralwidget)
        self.label_client_id.setGeometry(QtCore.QRect(30, 90, 158, 23))
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_client_id.setFont(font)
        self.label_client_id.setObjectName("label_client_id")
        self.btn_find_client = QtWidgets.QPushButton(self.centralwidget)
        self.btn_find_client.setGeometry(QtCore.QRect(480, 90, 41, 24))
        self.btn_find_client.setObjectName("btn_find_client")
        self.tableWidget = QtWidgets.QTableWidget(self.centralwidget)
        self.tableWidget.setGeometry(QtCore.QRect(20, 130, 761, 271))
        self.tableWidget.setObjectName("tableWidget")
        self.tableWidget.setColumnCount(7)
        self.tableWidget.setRowCount(0)
        self.btn_get_balance = QtWidgets.QPushButton(self.centralwidget)
        self.btn_get_balance.setGeometry(QtCore.QRect(580, 90, 75, 23))
        self.btn_get_balance.setObjectName("btn_get_balance")
        GUI_List_Product_Registration_By_Client.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(GUI_List_Product_Registration_By_Client)
        self.statusbar.setObjectName("statusbar")
        GUI_List_Product_Registration_By_Client.setStatusBar(self.statusbar)
        
        columnsNames = ("Código del producto", "Cliente", "Número de producto",  "Saldo", "Fecha de registro",
                        "Fecha de expiracion", "Estado")
        self.tableWidget.setHorizontalHeaderLabels(columnsNames)
        
        self.btn_find_client.clicked.connect(self.find_client)
        self.btn_get_balance.clicked.connect(self.get_balance_total)
        
        self.retranslateUi(GUI_List_Product_Registration_By_Client)
        QtCore.QMetaObject.connectSlotsByName(GUI_List_Product_Registration_By_Client)

    def retranslateUi(self, GUI_List_Product_Registration_By_Client):
        _translate = QtCore.QCoreApplication.translate
        GUI_List_Product_Registration_By_Client.setWindowTitle(_translate("GUI_List_Product_Registration_By_Client", "MainWindow"))
        self.label_title.setText(_translate("GUI_List_Product_Registration_By_Client", "Lista de registros del cliente"))
        self.label_client_id.setText(_translate("GUI_List_Product_Registration_By_Client", "Documento del cliente:"))
        self.btn_find_client.setText(_translate("GUI_List_Product_Registration_By_Client", "..."))
        self.btn_get_balance.setText(_translate("GUI_List_Product_Registration_By_Client", "Dar balance"))
        
    
    def find_client(self):    
        self.modal = GUI_Modal(self).exec_()
    
    def set_id_client_selected(self, data):
        try:
            id_client = data
            self.txt_client_id.setPlainText(id_client)
            self.load_data_table(id_client)
        except Exception as ex:
            msgBox = QtWidgets.QMessageBox()
            msgBox.setWindowTitle("Error")
            msgBox.setText(ex)
            msgBox.exec()
        
    
    def load_data_table(self, id_client):
        try:
            id_client = int(id_client)
            product_registrations = product_registration_controller.list_all_product_registration()
            product_registrations = list(filter (lambda product_registration: product_registration["clientId"] == id_client, product_registrations))
            
            for row, product_registration in enumerate(product_registrations):
                self.tableWidget.setRowCount(row+1)
                self.tableWidget.setItem(row, 0,QTableWidgetItem(str(product_registration["productCode"])))
                self.tableWidget.setItem(row, 1,QTableWidgetItem(str(product_registration["clientId"])))
                self.tableWidget.setItem(row, 2,QTableWidgetItem(str(product_registration["productNumber"])))
                self.tableWidget.setItem(row, 3,QTableWidgetItem(str(product_registration["balance"])))
                self.tableWidget.setItem(row, 4,QTableWidgetItem(product_registration["registrationDate"]))
                self.tableWidget.setItem(row, 5,QTableWidgetItem(product_registration["expirationDate"]))
                state = lambda state_json : "Activo" if (state_json) else "Inactivo"
                self.tableWidget.setItem(row, 6,QTableWidgetItem(state(product_registration["state"])))
        except Exception as ex:
            msgBox = QtWidgets.QMessageBox()
            msgBox.setWindowTitle("Error")
            msgBox.setText(ex)
            msgBox.exec()
        
    
    def get_balance_total(self):
        try:
            id_client = int(self.txt_client_id.toPlainText())
            product_registrations = product_registration_controller.list_all_product_registration()
            product_registrations = list(filter (lambda product_registration: product_registration["clientId"] == id_client, product_registrations))
            
            suma = 0
            for product in product_registrations:
                suma += product["balance"]
            
            msgBox = QtWidgets.QMessageBox()
            msgBox.setWindowTitle("Información")
            msgBox.setText("La sumatroria de saldos es de: {}".format(suma))
            msgBox.exec()
        except Exception as ex:
            msgBox = QtWidgets.QMessageBox()
            msgBox.setWindowTitle("Error")
            msgBox.setText(ex)
            msgBox.exec()
