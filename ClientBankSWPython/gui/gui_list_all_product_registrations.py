# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIListAllProductRegistrations.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtWidgets import QTableWidgetItem
from controller import product_registration_controller, product_controller

class Ui_GUI_List_All_Product_Registrations(object):
    def setupUi(self, GUI_List_All_Product_Registrations):
        GUI_List_All_Product_Registrations.setObjectName("GUI_List_All_Product_Registrations")
        GUI_List_All_Product_Registrations.resize(800, 479)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(GUI_List_All_Product_Registrations.sizePolicy().hasHeightForWidth())
        GUI_List_All_Product_Registrations.setSizePolicy(sizePolicy)
        self.centralwidget = QtWidgets.QWidget(GUI_List_All_Product_Registrations)
        self.centralwidget.setObjectName("centralwidget")
        self.tableWidget = QtWidgets.QTableWidget(self.centralwidget)
        self.tableWidget.setGeometry(QtCore.QRect(20, 120, 761, 271))
        self.tableWidget.setObjectName("tableWidget")
        self.tableWidget.setColumnCount(7)
        self.tableWidget.setRowCount(0)
        self.tableWidget.horizontalHeader().setDefaultAlignment(QtCore.Qt.AlignHCenter|QtCore.Qt.AlignVCenter|
                                                          QtCore.Qt.AlignCenter)
        self.label_title = QtWidgets.QLabel(self.centralwidget)
        self.label_title.setGeometry(QtCore.QRect(20, 10, 731, 51))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(24)
        self.label_title.setFont(font)
        self.label_title.setContextMenuPolicy(QtCore.Qt.NoContextMenu)
        self.label_title.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.label_title.setAlignment(QtCore.Qt.AlignCenter)
        self.label_title.setObjectName("label_title")
        self.btn_refresh = QtWidgets.QPushButton(self.centralwidget)
        self.btn_refresh.setGeometry(QtCore.QRect(330, 410, 141, 41))
        font = QtGui.QFont()
        font.setFamily("Lucida Calligraphy")
        font.setPointSize(12)
        self.btn_refresh.setFont(font)
        self.btn_refresh.setObjectName("btn_refresh")
        self.comboBox_product_type = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox_product_type.setGeometry(QtCore.QRect(170, 80, 181, 24))
        self.comboBox_product_type.setObjectName("comboBox_product_type")
        self.comboBox_state = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox_state.setGeometry(QtCore.QRect(440, 80, 91, 24))
        self.comboBox_state.setObjectName("comboBox_state")
        self.label_product_type = QtWidgets.QLabel(self.centralwidget)
        self.label_product_type.setGeometry(QtCore.QRect(40, 80, 121, 24))
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_product_type.setFont(font)
        self.label_product_type.setObjectName("label_product_type")
        self.label_2 = QtWidgets.QLabel(self.centralwidget)
        self.label_2.setGeometry(QtCore.QRect(380, 80, 51, 24))
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_2.setFont(font)
        self.label_2.setObjectName("label_2")
        self.btn_filter = QtWidgets.QPushButton(self.centralwidget)
        self.btn_filter.setGeometry(QtCore.QRect(580, 80, 131, 24))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(12)
        self.btn_filter.setFont(font)
        self.btn_filter.setObjectName("btn_filter")
        GUI_List_All_Product_Registrations.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(GUI_List_All_Product_Registrations)
        self.statusbar.setObjectName("statusbar")
        GUI_List_All_Product_Registrations.setStatusBar(self.statusbar)
        
        columnsNames = ("Código del producto", "Cliente", "Número de producto",  "Saldo", "Fecha de registro",
                        "Fecha de expiracion", "Estado")
        self.tableWidget.setHorizontalHeaderLabels(columnsNames)
        porducts_registrations =product_registration_controller.list_all_product_registration()
        self.load_table_data(porducts_registrations)
        self.load_filters()
        
        self.btn_refresh.clicked.connect(self.refesh_data)
        self.btn_filter.clicked.connect(self.filter_product_registrations)
        
        self.retranslateUi(GUI_List_All_Product_Registrations)
        QtCore.QMetaObject.connectSlotsByName(GUI_List_All_Product_Registrations)

    def retranslateUi(self, GUI_List_All_Product_Registrations):
        _translate = QtCore.QCoreApplication.translate
        GUI_List_All_Product_Registrations.setWindowTitle(_translate("GUI_List_All_Product_Registrations", "Lista de registros"))
        self.label_title.setText(_translate("GUI_List_All_Product_Registrations", "Lista de registros"))
        self.btn_refresh.setText(_translate("GUI_List_All_Product_Registrations", "Recargar lista"))
        self.label_product_type.setText(_translate("GUI_List_All_Product_Registrations", "Tipo de producto:"))
        self.label_2.setText(_translate("GUI_List_All_Product_Registrations", "Estado:"))
        self.btn_filter.setText(_translate("GUI_List_All_Product_Registrations", "Filtrar"))
    
    def load_table_data(self, product_registrations):
        self.tableWidget.clearContents()

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
    
    def refesh_data(self):
        porducts_registrations =product_registration_controller.list_all_product_registration()
        self.load_table_data(porducts_registrations)
        self.comboBox_product_type.setCurrentIndex(0)
        self.comboBox_state.setCurrentIndex(0)
    
    def load_filters(self):
        product_types = [""]
        products = product_controller.list_all_products()
        
        for product in products:
            product_types.append(product["name"])
            
        self.comboBox_state.addItems(list(["", "Activo", "Inactivo"]))
        self.comboBox_product_type.addItems(product_types)
    
    def filter_product_registrations(self):
        product_registrations = product_registration_controller.list_all_product_registration()
        
        product_type = self.comboBox_product_type.currentText()
        product_state = self.comboBox_state.currentText()
        if product_type == "" and product_state == "":
            msgBox = QtWidgets.QMessageBox()
            msgBox.setWindowTitle("Advertencia")
            msgBox.setText("Seleccione al menos un criterio de filtrado")
            msgBox.exec()
            
        else:
            products = product_controller.list_all_products()
            
            if product_type != "" and product_state == "":
                get_product_code = lambda product_name: list(filter(lambda product: product["name"] == product_type, products))
                product_list = get_product_code(product_type)
                product = product_list[0]
                product_registrations = list(filter(lambda product_registration: product_registration["productCode"] == product["code"],
                       product_registrations))
                self.load_table_data(product_registrations)
                
            elif product_type == "" and product_state != "":
                state = lambda registrartion_state : True if (registrartion_state == "Activo") else False
                product_registrations = list(filter(lambda product_registration: product_registration["state"] == state(product_state), 
                                                    product_registrations))
                self.load_table_data(product_registrations)
            else:
                get_product_code = lambda product_name: list(filter(lambda product: product["name"] == product_type, products))
                state = lambda registrartion_state : True if (registrartion_state == "Activo") else False
                product_list = get_product_code(product_type)
                product = product_list[0]
                product_registrations = list(filter(lambda product_registration: product_registration["productCode"] == product["code"] and product_registration["state"] == state(product_state),
                       product_registrations))
                self.load_table_data(product_registrations)