# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIListAllClients.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtWidgets import QTableWidgetItem
from controller.client_controller import *


class Ui_GUI_List_Clients(object):
    def setupUi(self, GUI_List_Clients):
        GUI_List_Clients.setObjectName("GUI_List_Clients")
        GUI_List_Clients.resize(771, 471)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(GUI_List_Clients.sizePolicy().hasHeightForWidth())
        GUI_List_Clients.setSizePolicy(sizePolicy)
        self.centralwidget = QtWidgets.QWidget(GUI_List_Clients)
        self.centralwidget.setObjectName("centralwidget")
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
        self.btn_refresh.setGeometry(QtCore.QRect(320, 400, 141, 41))
        font = QtGui.QFont()
        font.setFamily("Lucida Calligraphy")
        font.setPointSize(12)
        self.btn_refresh.setFont(font)
        self.btn_refresh.setObjectName("btn_refresh")
        self.tableWidget = QtWidgets.QTableWidget(self.centralwidget)
        self.tableWidget.setGeometry(QtCore.QRect(20, 80, 731, 301))
        self.tableWidget.setRowCount(0)
        self.tableWidget.setColumnCount(7)
        self.tableWidget.setObjectName("tableWidget")
        self.tableWidget.horizontalHeader().setDefaultAlignment(QtCore.Qt.AlignHCenter|QtCore.Qt.AlignVCenter|
                                                          QtCore.Qt.AlignCenter)
        GUI_List_Clients.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(GUI_List_Clients)
        self.statusbar.setObjectName("statusbar")
        GUI_List_Clients.setStatusBar(self.statusbar)
        
        columnsNames = ("Número de identificación", "Tipo de documento", "Nombre",  "Fecha de nacimiento", "E-mail",
                        "Número de teléfono", "Género")
        self.tableWidget.setHorizontalHeaderLabels(columnsNames)
        self.load_table_data()
        
        self.btn_refresh.clicked.connect(self.load_table_data)
        
        self.retranslateUi(GUI_List_Clients)
        QtCore.QMetaObject.connectSlotsByName(GUI_List_Clients)

    def retranslateUi(self, GUI_List_Clients):
        _translate = QtCore.QCoreApplication.translate
        GUI_List_Clients.setWindowTitle(_translate("GUI_List_Clients", "Listar todos los clientes"))
        self.label_title.setText(_translate("GUI_List_Clients", "Lista de clientes"))
        self.btn_refresh.setText(_translate("GUI_List_Clients", "Recargar lista"))
    
    def load_table_data(self):
        try:
            self.tableWidget.clearContents()
            clients = list_all_clients()
            for row, client in enumerate(clients):
                self.tableWidget.setRowCount(row+1)
                self.tableWidget.setItem(row, 0, QTableWidgetItem(str(client["identificationNumber"])))
                self.tableWidget.setItem(row, 1, QTableWidgetItem(client["documetType"]))
                self.tableWidget.setItem(row, 2, QTableWidgetItem(client["name"]))
                self.tableWidget.setItem(row, 3, QTableWidgetItem(client["birthday"]))
                self.tableWidget.setItem(row, 4, QTableWidgetItem(client["email"]))
                self.tableWidget.setItem(row, 5, QTableWidgetItem(client["phoneNumber"]))
                self.tableWidget.setItem(row, 6, QTableWidgetItem(client["gender"]))
        except Exception as ex:
            msgBox = QtWidgets.QMessageBox()
            msgBox.setWindowTitle("Error")
            msgBox.setText(str(ex))
            msgBox.exec()

        

