# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIUpdateClient.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets
from controller.client_controller import *

class Ui_GUI_Update_Client(object):
    def setupUi(self, GUI_Update_Client):
        GUI_Update_Client.setObjectName("GUI_Update_Client")
        GUI_Update_Client.resize(575, 361)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(GUI_Update_Client.sizePolicy().hasHeightForWidth())
        GUI_Update_Client.setSizePolicy(sizePolicy)
        self.centralwidget = QtWidgets.QWidget(GUI_Update_Client)
        self.centralwidget.setObjectName("centralwidget")
        self.btn_find_client = QtWidgets.QPushButton(self.centralwidget)
        self.btn_find_client.setGeometry(QtCore.QRect(460, 70, 81, 24))
        font = QtGui.QFont()
        font.setPointSize(10)
        self.btn_find_client.setFont(font)
        self.btn_find_client.setObjectName("btn_find_client")
        self.txt_email = QtWidgets.QTextEdit(self.centralwidget)
        self.txt_email.setGeometry(QtCore.QRect(250, 200, 259, 24))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Preferred, QtWidgets.QSizePolicy.Preferred)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.txt_email.sizePolicy().hasHeightForWidth())
        self.txt_email.setSizePolicy(sizePolicy)
        self.txt_email.setObjectName("txt_email")
        self.txt_name = QtWidgets.QTextEdit(self.centralwidget)
        self.txt_name.setGeometry(QtCore.QRect(250, 110, 259, 24))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Preferred, QtWidgets.QSizePolicy.Preferred)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.txt_name.sizePolicy().hasHeightForWidth())
        self.txt_name.setSizePolicy(sizePolicy)
        self.txt_name.setObjectName("txt_name")
        self.label = QtWidgets.QLabel(self.centralwidget)
        self.label.setGeometry(QtCore.QRect(0, 10, 571, 51))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(24)
        self.label.setFont(font)
        self.label.setContextMenuPolicy(QtCore.Qt.NoContextMenu)
        self.label.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.label.setAlignment(QtCore.Qt.AlignCenter)
        self.label.setObjectName("label")
        self.label_id_number = QtWidgets.QLabel(self.centralwidget)
        self.label_id_number.setGeometry(QtCore.QRect(10, 70, 181, 23))
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_id_number.setFont(font)
        self.label_id_number.setObjectName("label_id_number")
        self.txt_id_number = QtWidgets.QPlainTextEdit(self.centralwidget)
        self.txt_id_number.setGeometry(QtCore.QRect(190, 70, 259, 24))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Preferred, QtWidgets.QSizePolicy.Preferred)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.txt_id_number.sizePolicy().hasHeightForWidth())
        self.txt_id_number.setSizePolicy(sizePolicy)
        self.txt_id_number.setObjectName("txt_id_number")
        self.verticalLayoutWidget = QtWidgets.QWidget(self.centralwidget)
        self.verticalLayoutWidget.setGeometry(QtCore.QRect(50, 110, 191, 171))
        self.verticalLayoutWidget.setObjectName("verticalLayoutWidget")
        self.verticalLayout = QtWidgets.QVBoxLayout(self.verticalLayoutWidget)
        self.verticalLayout.setContentsMargins(0, 0, 0, 0)
        self.verticalLayout.setObjectName("verticalLayout")
        self.label_name = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_name.setFont(font)
        self.label_name.setObjectName("label_name")
        self.verticalLayout.addWidget(self.label_name)
        self.label_doc_type = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_doc_type.setFont(font)
        self.label_doc_type.setObjectName("label_doc_type")
        self.verticalLayout.addWidget(self.label_doc_type)
        self.label_birthday = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_birthday.setFont(font)
        self.label_birthday.setObjectName("label_birthday")
        self.verticalLayout.addWidget(self.label_birthday)
        self.label_email = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_email.setFont(font)
        self.label_email.setObjectName("label_email")
        self.verticalLayout.addWidget(self.label_email)
        self.label_phone = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_phone.setFont(font)
        self.label_phone.setObjectName("label_phone")
        self.verticalLayout.addWidget(self.label_phone)
        self.label_gender = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_gender.setFont(font)
        self.label_gender.setObjectName("label_gender")
        self.verticalLayout.addWidget(self.label_gender)
        self.dateEdit_birthday = QtWidgets.QDateEdit(self.centralwidget)
        self.dateEdit_birthday.setGeometry(QtCore.QRect(250, 170, 259, 24))
        self.dateEdit_birthday.setObjectName("dateEdit_birthday")
        self.txt_phone_number = QtWidgets.QPlainTextEdit(self.centralwidget)
        self.txt_phone_number.setGeometry(QtCore.QRect(250, 230, 259, 24))
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Preferred, QtWidgets.QSizePolicy.Preferred)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.txt_phone_number.sizePolicy().hasHeightForWidth())
        self.txt_phone_number.setSizePolicy(sizePolicy)
        self.txt_phone_number.setObjectName("txt_phone_number")
        self.comboBox_doc_type = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox_doc_type.setGeometry(QtCore.QRect(250, 140, 259, 24))
        self.comboBox_doc_type.setObjectName("comboBox_doc_type")
        self.comboBox_gender = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox_gender.setGeometry(QtCore.QRect(250, 260, 259, 24))
        self.comboBox_gender.setObjectName("comboBox_gender")
        self.btn_update_client = QtWidgets.QPushButton(self.centralwidget)
        self.btn_update_client.setGeometry(QtCore.QRect(160, 300, 251, 41))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(16)
        self.btn_update_client.setFont(font)
        self.btn_update_client.setObjectName("btn_update_client")
        GUI_Update_Client.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(GUI_Update_Client)
        self.statusbar.setObjectName("statusbar")
        GUI_Update_Client.setStatusBar(self.statusbar)
        
        self.comboBox_doc_type.addItems(list(["Cedula de ciudadania",
                                             "Tarjeta de identidad",
                                             "Cedula de extranjeria"]))
        
        self.comboBox_gender.addItems(list(["Masculino",
                                           "Femenino",
                                           "Otro"]))
        
        self.btn_find_client.clicked.connect(self.find_client)
        self.btn_update_client.clicked.connect(self.update_client)
        
        self.retranslateUi(GUI_Update_Client)
        QtCore.QMetaObject.connectSlotsByName(GUI_Update_Client)

    def retranslateUi(self, GUI_Update_Client):
        _translate = QtCore.QCoreApplication.translate
        GUI_Update_Client.setWindowTitle(_translate("GUI_Update_Client", "Actualizar cliente"))
        self.btn_find_client.setText(_translate("GUI_Update_Client", "Buscar"))
        self.label.setText(_translate("GUI_Update_Client", "Actualizar Cliente"))
        self.label_id_number.setText(_translate("GUI_Update_Client", "Número de Identificación:"))
        self.label_name.setText(_translate("GUI_Update_Client", "Nombre:"))
        self.label_doc_type.setText(_translate("GUI_Update_Client", "Tipo de documento:"))
        self.label_birthday.setText(_translate("GUI_Update_Client", "Fecha de nacimiento:"))
        self.label_email.setText(_translate("GUI_Update_Client", "E-mail:"))
        self.label_phone.setText(_translate("GUI_Update_Client", "Teléfono:"))
        self.label_gender.setText(_translate("GUI_Update_Client", "Género:"))
        self.btn_update_client.setText(_translate("GUI_Update_Client", "Actualizar Cliente"))
    
    def find_client(self):
        try:
            client = find_client(self.txt_id_number.toPlainText())
            
            self.txt_id_number.setPlainText(str(client["identificationNumber"]))
            
            index_combo = self.comboBox_doc_type.findText(client["documetType"], QtCore.Qt.MatchCaseSensitive)
            if index_combo >= 0:
                self.comboBox_doc_type.setCurrentIndex(index_combo)
            
            self.txt_name.setPlainText(client["name"])
            self.dateEdit_birthday.setDate(QtCore.QDate.fromString(client["birthday"], "yyyy-MM-dd"))
            self.txt_email.setPlainText(client["email"])
            self.txt_phone_number.setPlainText(client["phoneNumber"])
            
            index_combo = self.comboBox_gender.findText(client["gender"], QtCore.Qt.MatchCaseSensitive)
            if index_combo >= 0:
                self.comboBox_gender.setCurrentIndex(index_combo)
        except Exception as ex:
            msgBox = QtWidgets.QMessageBox()
            msgBox.setWindowTitle("Error")
            msgBox.setText(str(ex))
            msgBox.exec()
        
    
    def update_client(self):
        try:
            client = find_client(self.txt_id_number.toPlainText())
            
            id_number = self.txt_id_number.toPlainText()
            doct_type = str(self.comboBox_doc_type.currentText())
            name = self.txt_name.toPlainText()
            birthday = self.dateEdit_birthday.date()
            email = self.txt_email.toPlainText()
            phone_number = self.txt_phone_number.toPlainText()
            gender = str(self.comboBox_gender.currentText())
            
            resp = update_client(id_number, doct_type, name, birthday.toString(QtCore.Qt.ISODate), email, phone_number, gender)
            
            if resp:
                msgBox = QtWidgets.QMessageBox()
                msgBox.setWindowTitle("Confirmación")
                msgBox.setText("Cliente se ha acutalizado correctamente")
                msgBox.exec()
                
                self.txt_id_number.setPlainText("")
                self.txt_name.setPlainText("")
                self.txt_email.setPlainText("")
                self.txt_phone_number.setPlainText("")
                
            else:
                msgBox = QtWidgets.QMessageBox()
                msgBox.setWindowTitle("Advertencia")
                msgBox.setText("No se pudo acutalizar el cliente")
                msgBox.exec()
        except Exception as ex:
            msgBox = QtWidgets.QMessageBox()
            msgBox.setWindowTitle("Error")
            msgBox.setText(str(ex))
            msgBox.exec()
        