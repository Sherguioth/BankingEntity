# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIListAllProductRegistrations.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets


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
        self.tableWidget.setColumnCount(0)
        self.tableWidget.setRowCount(0)
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
        self.comboBox = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox.setGeometry(QtCore.QRect(170, 80, 181, 24))
        self.comboBox.setObjectName("comboBox")
        self.comboBox_2 = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox_2.setGeometry(QtCore.QRect(440, 80, 91, 24))
        self.comboBox_2.setObjectName("comboBox_2")
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
