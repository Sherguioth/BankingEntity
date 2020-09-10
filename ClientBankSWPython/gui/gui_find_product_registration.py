# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIFindProductRegistration.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets
from gui.gui_modal_list_clients import GUI_Modal
from controller import product_registration_controller, product_controller

class Ui_GUI_Find_Product_Registration(object):
    def setupUi(self, GUI_Find_Product_Registration):
        GUI_Find_Product_Registration.setObjectName("GUI_Find_Product_Registration")
        GUI_Find_Product_Registration.resize(575, 360)
        self.centralwidget = QtWidgets.QWidget(GUI_Find_Product_Registration)
        self.centralwidget.setObjectName("centralwidget")
        self.dateEdit_registrtion_date = QtWidgets.QDateEdit(self.centralwidget)
        self.dateEdit_registrtion_date.setGeometry(QtCore.QRect(210, 200, 321, 24))
        self.dateEdit_registrtion_date.setObjectName("dateEdit_registrtion_date")
        self.label_title = QtWidgets.QLabel(self.centralwidget)
        self.label_title.setGeometry(QtCore.QRect(0, 10, 575, 51))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(24)
        self.label_title.setFont(font)
        self.label_title.setContextMenuPolicy(QtCore.Qt.NoContextMenu)
        self.label_title.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.label_title.setAlignment(QtCore.Qt.AlignCenter)
        self.label_title.setObjectName("label_title")
        self.btn_find_client = QtWidgets.QPushButton(self.centralwidget)
        self.btn_find_client.setGeometry(QtCore.QRect(490, 80, 41, 24))
        self.btn_find_client.setObjectName("btn_find_client")
        self.comboBox_product_code = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox_product_code.setGeometry(QtCore.QRect(210, 110, 321, 24))
        self.comboBox_product_code.setObjectName("comboBox_product_code")
        self.btn_find_product_registration = QtWidgets.QPushButton(self.centralwidget)
        self.btn_find_product_registration.setGeometry(QtCore.QRect(190, 290, 201, 41))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(14)
        self.btn_find_product_registration.setFont(font)
        self.btn_find_product_registration.setObjectName("btn_find_product_registration")
        self.txt_balance = QtWidgets.QTextEdit(self.centralwidget)
        self.txt_balance.setGeometry(QtCore.QRect(210, 170, 321, 24))
        self.txt_balance.setObjectName("txt_balance")
        self.dateEdit_expiration_date = QtWidgets.QDateEdit(self.centralwidget)
        self.dateEdit_expiration_date.setGeometry(QtCore.QRect(210, 230, 321, 24))
        self.dateEdit_expiration_date.setObjectName("dateEdit_expiration_date")
        self.verticalLayoutWidget = QtWidgets.QWidget(self.centralwidget)
        self.verticalLayoutWidget.setGeometry(QtCore.QRect(40, 80, 160, 201))
        self.verticalLayoutWidget.setObjectName("verticalLayoutWidget")
        self.verticalLayout_2 = QtWidgets.QVBoxLayout(self.verticalLayoutWidget)
        self.verticalLayout_2.setContentsMargins(0, 0, 0, 0)
        self.verticalLayout_2.setObjectName("verticalLayout_2")
        self.label_client_id_2 = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_client_id_2.setFont(font)
        self.label_client_id_2.setObjectName("label_client_id_2")
        self.verticalLayout_2.addWidget(self.label_client_id_2)
        self.label_product_code_2 = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_product_code_2.setFont(font)
        self.label_product_code_2.setObjectName("label_product_code_2")
        self.verticalLayout_2.addWidget(self.label_product_code_2)
        self.label_product_number_2 = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_product_number_2.setFont(font)
        self.label_product_number_2.setObjectName("label_product_number_2")
        self.verticalLayout_2.addWidget(self.label_product_number_2)
        self.label_balance_2 = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_balance_2.setFont(font)
        self.label_balance_2.setObjectName("label_balance_2")
        self.verticalLayout_2.addWidget(self.label_balance_2)
        self.label_registration_date_2 = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_registration_date_2.setFont(font)
        self.label_registration_date_2.setObjectName("label_registration_date_2")
        self.verticalLayout_2.addWidget(self.label_registration_date_2)
        self.label_expiration_date_2 = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_expiration_date_2.setFont(font)
        self.label_expiration_date_2.setObjectName("label_expiration_date_2")
        self.verticalLayout_2.addWidget(self.label_expiration_date_2)
        self.label_state_2 = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_state_2.setFont(font)
        self.label_state_2.setObjectName("label_state_2")
        self.verticalLayout_2.addWidget(self.label_state_2)
        self.txt_client_id = QtWidgets.QTextEdit(self.centralwidget)
        self.txt_client_id.setGeometry(QtCore.QRect(210, 80, 271, 24))
        self.txt_client_id.setObjectName("txt_client_id")
        self.txt_product_number = QtWidgets.QTextEdit(self.centralwidget)
        self.txt_product_number.setGeometry(QtCore.QRect(210, 140, 321, 24))
        self.txt_product_number.setObjectName("txt_product_number")
        self.txt_state = QtWidgets.QPlainTextEdit(self.centralwidget)
        self.txt_state.setGeometry(QtCore.QRect(210, 260, 321, 24))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Preferred)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.txt_state.sizePolicy().hasHeightForWidth())
        self.txt_state.setSizePolicy(sizePolicy)
        self.txt_state.setObjectName("txt_state")
        GUI_Find_Product_Registration.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(GUI_Find_Product_Registration)
        self.statusbar.setObjectName("statusbar")
        GUI_Find_Product_Registration.setStatusBar(self.statusbar)
        
        self.btn_find_client.clicked.connect(self.find_client)
        self.btn_find_product_registration.clicked.connect(self.find_product_registration)
        
        self.retranslateUi(GUI_Find_Product_Registration)
        QtCore.QMetaObject.connectSlotsByName(GUI_Find_Product_Registration)

    def retranslateUi(self, GUI_Find_Product_Registration):
        _translate = QtCore.QCoreApplication.translate
        GUI_Find_Product_Registration.setWindowTitle(_translate("GUI_Find_Product_Registration", "Buscar registro"))
        self.label_title.setText(_translate("GUI_Find_Product_Registration", "Buscar producto"))
        self.btn_find_client.setText(_translate("GUI_Find_Product_Registration", "..."))
        self.btn_find_product_registration.setText(_translate("GUI_Find_Product_Registration", "Buscar registro"))
        self.label_client_id_2.setText(_translate("GUI_Find_Product_Registration", "Documento del cliente:"))
        self.label_product_code_2.setText(_translate("GUI_Find_Product_Registration", "Producto:"))
        self.label_product_number_2.setText(_translate("GUI_Find_Product_Registration", "Número de producto:"))
        self.label_balance_2.setText(_translate("GUI_Find_Product_Registration", "Saldo:"))
        self.label_registration_date_2.setText(_translate("GUI_Find_Product_Registration", "Fecha de expedición:"))
        self.label_expiration_date_2.setText(_translate("GUI_Find_Product_Registration", "Fecha de vencimiento:"))
        self.label_state_2.setText(_translate("GUI_Find_Product_Registration", "Estado:"))
        
    def find_client(self):    
        self.modal = GUI_Modal(self).exec_()
    
    def set_id_client_selected(self, data):
        id_client = data
        self.txt_client_id.setPlainText(id_client)
        
        product_registrations = product_registration_controller.list_all_product_registration()
        clients_registations = list(filter(lambda product_registration: product_registration["clientId"] == int(id_client), 
                               product_registrations))
        
        products_codes = []
        print(clients_registations)
        for product in clients_registations:
            products_codes.append(str(product["productCode"]))
        
        self.comboBox_product_code.addItems(products_codes)
    
    def find_product_registration(self):
        client_id = self.txt_client_id.toPlainText()
        product_code = str(self.comboBox_product_code.currentText())
        
        prodcut_registration = product_registration_controller.find_product_registration(client_id, product_code)
        
        self.txt_product_number.setPlainText(str(prodcut_registration["productNumber"]))
        self.txt_balance.setPlainText(str(prodcut_registration["balance"]))
        self.dateEdit_registrtion_date.setDate(QtCore.QDate.fromString(prodcut_registration["registrationDate"], "yyyy-MM-dd"))
        self.dateEdit_expiration_date.setDate(QtCore.QDate.fromString(prodcut_registration["expirationDate"], "yyyy-MM-dd"))
        state = lambda state_json : "Activo" if (state_json) else "Inactivo"
        self.txt_state.setPlainText(state(prodcut_registration["state"]))
        
        self.txt_product_number.setEnabled(False)
        self.txt_balance.setEnabled(False)
        self.dateEdit_registrtion_date.setEnabled(False)
        self.dateEdit_expiration_date.setEnabled(False)
        self.txt_state.setEnabled(False)