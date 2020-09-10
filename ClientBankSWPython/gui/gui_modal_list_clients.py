# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIModalListClients.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_GUI_Modal_List_Clients(object):
    def setupUi(self, GUI_Modal_List_Clients):
        GUI_Modal_List_Clients.setObjectName("GUI_Modal_List_Clients")
        GUI_Modal_List_Clients.setWindowModality(QtCore.Qt.WindowModal)
        GUI_Modal_List_Clients.resize(772, 419)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(GUI_Modal_List_Clients.sizePolicy().hasHeightForWidth())
        GUI_Modal_List_Clients.setSizePolicy(sizePolicy)
        GUI_Modal_List_Clients.setFocusPolicy(QtCore.Qt.NoFocus)
        self.centralwidget = QtWidgets.QWidget(GUI_Modal_List_Clients)
        self.centralwidget.setObjectName("centralwidget")
        self.label_title = QtWidgets.QLabel(self.centralwidget)
        self.label_title.setGeometry(QtCore.QRect(10, 10, 731, 51))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(24)
        self.label_title.setFont(font)
        self.label_title.setContextMenuPolicy(QtCore.Qt.NoContextMenu)
        self.label_title.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.label_title.setAlignment(QtCore.Qt.AlignCenter)
        self.label_title.setObjectName("label_title")
        self.tableWidget = QtWidgets.QTableWidget(self.centralwidget)
        self.tableWidget.setGeometry(QtCore.QRect(10, 80, 731, 301))
        self.tableWidget.setRowCount(4)
        self.tableWidget.setColumnCount(7)
        self.tableWidget.setObjectName("tableWidget")
        GUI_Modal_List_Clients.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(GUI_Modal_List_Clients)
        self.statusbar.setObjectName("statusbar")
        GUI_Modal_List_Clients.setStatusBar(self.statusbar)

        self.retranslateUi(GUI_Modal_List_Clients)
        QtCore.QMetaObject.connectSlotsByName(GUI_Modal_List_Clients)

    def retranslateUi(self, GUI_Modal_List_Clients):
        _translate = QtCore.QCoreApplication.translate
        GUI_Modal_List_Clients.setWindowTitle(_translate("GUI_Modal_List_Clients", "Lista de clientes"))
        self.label_title.setText(_translate("GUI_Modal_List_Clients", "Lista de clientes"))
