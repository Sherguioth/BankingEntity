# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIModalListClients.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtWidgets import QTableWidgetItem, QAbstractItemView
from controller.client_controller import *


class GUI_Modal(QtWidgets.QDialog):
    def __init__(self, parent=None):
        super(GUI_Modal, self).__init__()
        self.setWindowTitle("Lista de clientes")
        self.setWindowFlags(QtCore.Qt.WindowCloseButtonHint | QtCore.Qt.MSWindowsFixedSizeDialogHint)
        self.setFixedSize(770, 420)
        self.parent = parent
        self.setupUi()
    
    def setupUi(self):
        self.tableWidget = QtWidgets.QTableWidget(self)
        self.tableWidget.setGeometry(QtCore.QRect(10, 80, 731, 301))
        self.tableWidget.setRowCount(4)
        self.tableWidget.setColumnCount(7)
        self.tableWidget.setObjectName("tableWidget")
        self.tableWidget.setEditTriggers(QAbstractItemView.NoEditTriggers)
        self.tableWidget.setDragDropOverwriteMode(False)
        self.tableWidget.setSelectionBehavior(QAbstractItemView.SelectRows)
        self.tableWidget.setSelectionMode(QAbstractItemView.SingleSelection)
        self.tableWidget.horizontalHeader().setDefaultAlignment(QtCore.Qt.AlignHCenter|QtCore.Qt.AlignVCenter|
                                                          QtCore.Qt.AlignCenter)
        
        self.label_title = QtWidgets.QLabel(self)
        self.label_title.setGeometry(QtCore.QRect(10, 10, 731, 51))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(24)
        self.label_title.setFont(font)
        self.label_title.setContextMenuPolicy(QtCore.Qt.NoContextMenu)
        self.label_title.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.label_title.setAlignment(QtCore.Qt.AlignCenter)
        self.label_title.setObjectName("label_title")
        
        columnsNames = ("Número de identificación", "Tipo de documento", "Nombre",  "Fecha de nacimiento", "E-mail",
                        "Número de teléfono", "Género")
        self.tableWidget.setHorizontalHeaderLabels(columnsNames)
        self.load_table_data()
        
        self.tableWidget.clicked.connect(self.get_client_selected)
        
        self.retranslateUi(self)
        QtCore.QMetaObject.connectSlotsByName(self)

    def retranslateUi(self, GUI_Modal):
        _translate = QtCore.QCoreApplication.translate
        GUI_Modal.setWindowTitle(_translate("GUI_Modal", "Form"))
        self.label_title.setText(_translate("GUI_Modal", "Lista de clientes"))
    
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
        
    
    def get_client_selected(self):
        self.id_client = self.tableWidget.item(self.tableWidget.currentRow(), 0)
        self.parent.set_id_client_selected(self.id_client.text())
        self.close()