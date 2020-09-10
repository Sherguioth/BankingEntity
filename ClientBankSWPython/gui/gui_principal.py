# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIPrincipal.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets
from gui.gui_list_all_clients import Ui_GUI_List_Clients
from gui.gui_add_client import Ui_GUI_Add_Client
from gui.gui_find_client import Ui_GUI_Find_Client
from gui.gui_update_client import Ui_GUI_Update_Client
from gui.gui_delete_client import Ui_GUI_Delete_Client
from gui.gui_list_all_product_registrations import Ui_GUI_List_All_Product_Registrations
from gui.gui_list_product_registration_by_client import Ui_GUI_List_Product_Registration_By_Client
from gui.gui_add_product_registration import Ui_GUI_Add_Product_Registration
from gui.gui_find_product_registration import Ui_GUI_Find_Product_Registration
from gui.gui_update_product_registration import Ui_GUI_Update_Product_Registration
from gui.gui_delete_product_registration import Ui_GUI_Delete_Product_Registration

class Ui_GUIPrincipal(object):
    
    def setupUi(self, GUIPrincipal):
        GUIPrincipal.setObjectName("GUIPrincipal")
        GUIPrincipal.resize(556, 595)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(GUIPrincipal.sizePolicy().hasHeightForWidth())
        GUIPrincipal.setSizePolicy(sizePolicy)
        self.centralwidget = QtWidgets.QWidget(GUIPrincipal)
        self.centralwidget.setObjectName("centralwidget")
        self.label_title = QtWidgets.QLabel(self.centralwidget)
        self.label_title.setGeometry(QtCore.QRect(180, 0, 181, 51))
        self.label_title.setTextFormat(QtCore.Qt.RichText)
        self.label_title.setAlignment(QtCore.Qt.AlignCenter)
        self.label_title.setWordWrap(True)
        self.label_title.setObjectName("label_title")
        GUIPrincipal.setCentralWidget(self.centralwidget)
        self.menu_bar = QtWidgets.QMenuBar(GUIPrincipal)
        self.menu_bar.setGeometry(QtCore.QRect(0, 0, 556, 21))
        self.menu_bar.setObjectName("menu_bar")
        self.menu_file = QtWidgets.QMenu(self.menu_bar)
        self.menu_file.setObjectName("menu_file")
        self.clients_menu = QtWidgets.QMenu(self.menu_bar)
        self.clients_menu.setObjectName("clients_menu")
        self.menu_registrations = QtWidgets.QMenu(self.menu_bar)
        self.menu_registrations.setObjectName("menu_registrations")
        self.menu_help = QtWidgets.QMenu(self.menu_bar)
        self.menu_help.setObjectName("menu_help")
        GUIPrincipal.setMenuBar(self.menu_bar)
        self.statusbar = QtWidgets.QStatusBar(GUIPrincipal)
        self.statusbar.setObjectName("statusbar")
        GUIPrincipal.setStatusBar(self.statusbar)
        self.action_exit = QtWidgets.QAction(GUIPrincipal)
        self.action_exit.setObjectName("action_exit")
        self.action_add_client = QtWidgets.QAction(GUIPrincipal)
        self.action_add_client.setObjectName("action_add_client")
        self.action_list_clients = QtWidgets.QAction(GUIPrincipal)
        self.action_list_clients.setObjectName("action_list_clients")
        self.action_find_client = QtWidgets.QAction(GUIPrincipal)
        self.action_find_client.setObjectName("action_find_client")
        self.action_update_client = QtWidgets.QAction(GUIPrincipal)
        self.action_update_client.setObjectName("action_update_client")
        self.action_delete_client = QtWidgets.QAction(GUIPrincipal)
        self.action_delete_client.setObjectName("action_delete_client")
        self.action_list_all_registrations = QtWidgets.QAction(GUIPrincipal)
        self.action_list_all_registrations.setObjectName("action_list_all_registrations")
        self.action_list_product_registration_by_client = QtWidgets.QAction(GUIPrincipal)
        self.action_list_product_registration_by_client.setObjectName("action_list_product_registration_by_client")
        self.action_add_product_registration = QtWidgets.QAction(GUIPrincipal)
        self.action_add_product_registration.setObjectName("action_add_product_registration")
        self.action_find_product_registration = QtWidgets.QAction(GUIPrincipal)
        self.action_find_product_registration.setObjectName("action_find_product_registration")
        self.action_update_product_registration = QtWidgets.QAction(GUIPrincipal)
        self.action_update_product_registration.setObjectName("action_update_product_registration")
        self.action_delete_product_registration = QtWidgets.QAction(GUIPrincipal)
        self.action_delete_product_registration.setObjectName("action_delete_product_registration")
        self.action_about = QtWidgets.QAction(GUIPrincipal)
        self.action_about.setObjectName("action_about")
        self.menu_file.addAction(self.action_exit)
        self.clients_menu.addAction(self.action_list_clients)
        self.clients_menu.addAction(self.action_add_client)
        self.clients_menu.addAction(self.action_find_client)
        self.clients_menu.addAction(self.action_update_client)
        self.clients_menu.addAction(self.action_delete_client)
        self.menu_registrations.addAction(self.action_list_all_registrations)
        self.menu_registrations.addAction(self.action_list_product_registration_by_client)
        self.menu_registrations.addAction(self.action_add_product_registration)
        self.menu_registrations.addAction(self.action_find_product_registration)
        self.menu_registrations.addAction(self.action_update_product_registration)
        self.menu_registrations.addAction(self.action_delete_product_registration)
        self.menu_help.addAction(self.action_about)
        self.menu_bar.addAction(self.menu_file.menuAction())
        self.menu_bar.addAction(self.clients_menu.menuAction())
        self.menu_bar.addAction(self.menu_registrations.menuAction())
        self.menu_bar.addAction(self.menu_help.menuAction())
        
        self.action_exit.triggered.connect(self.exit_app)
        self.action_about.triggered.connect(self.info_about)
        self.action_list_clients.triggered.connect(self.list_clients)
        self.action_add_client.triggered.connect(self.add_client)
        self.action_find_client.triggered.connect(self.find_client)
        self.action_update_client.triggered.connect(self.update_client)
        self.action_delete_client.triggered.connect(self.delete_client )
        self.action_list_all_registrations.triggered.connect(self.list_all_registrations)
        self.action_list_product_registration_by_client.triggered.connect(self.list_registrtions_by_client)
        self.action_add_product_registration.triggered.connect(self.add_product_registation)
        self.action_find_product_registration.triggered.connect(self.find_product_registation)
        self.action_update_product_registration.triggered.connect(self.update_product_registration)
        self.action_delete_product_registration.triggered.connect(self.delete_product_registation)
        
        self.retranslateUi(GUIPrincipal)
        QtCore.QMetaObject.connectSlotsByName(GUIPrincipal)

    def retranslateUi(self, GUIPrincipal):
        _translate = QtCore.QCoreApplication.translate
        GUIPrincipal.setWindowTitle(_translate("GUIPrincipal", "BankEntity"))
        self.label_title.setText(_translate("GUIPrincipal", "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0//EN\" \"http://www.w3.org/TR/REC-html40/strict.dtd\">\n"
"<html><head><meta name=\"qrichtext\" content=\"1\" /><style type=\"text/css\">\n"
"p, li { white-space: pre-wrap; }\n"
"</style></head><body style=\" font-family:\'MS Shell Dlg 2\'; font-size:8pt; font-weight:400; font-style:normal;\">\n"
"<p align=\"center\" style=\" margin-top:0px; margin-bottom:0px; margin-left:0px; margin-right:0px; -qt-block-indent:0; text-indent:0px;\"><span style=\" font-size:28pt; font-style:italic;\">The Bank</span></p></body></html>"))
        self.menu_file.setTitle(_translate("GUIPrincipal", "Archivo"))
        self.clients_menu.setTitle(_translate("GUIPrincipal", "Clientes"))
        self.menu_registrations.setTitle(_translate("GUIPrincipal", "Registros"))
        self.menu_help.setTitle(_translate("GUIPrincipal", "Ayuda"))
        self.action_exit.setText(_translate("GUIPrincipal", "Salir"))
        self.action_add_client.setText(_translate("GUIPrincipal", "Agregar cliente"))
        self.action_list_clients.setText(_translate("GUIPrincipal", "Listar clientes"))
        self.action_find_client.setText(_translate("GUIPrincipal", "Buscar cliente"))
        self.action_update_client.setText(_translate("GUIPrincipal", "Actualizar cliente"))
        self.action_delete_client.setText(_translate("GUIPrincipal", "Eliminar cliente"))
        self.action_list_all_registrations.setText(_translate("GUIPrincipal", "Listar todos los registros"))
        self.action_list_product_registration_by_client.setText(_translate("GUIPrincipal", "Listar registros por cliente"))
        self.action_add_product_registration.setText(_translate("GUIPrincipal", "Registrar un producto a un cliente"))
        self.action_find_product_registration.setText(_translate("GUIPrincipal", "Buscar un registro"))
        self.action_update_product_registration.setText(_translate("GUIPrincipal", "Actualizar un registro"))
        self.action_delete_product_registration.setText(_translate("GUIPrincipal", "Eliminar un registro"))
        self.action_about.setText(_translate("GUIPrincipal", "Acerca de..."))
    
    def exit_app(self):
        self.close()
    
    def info_about(self):
        msgBox = QtWidgets.QMessageBox()
        msgBox.setWindowTitle("Ayuda")
        msgBox.setText("Desarrollado por Ezequiel Melo & Andrés Novoa  v. 2.0")
        msgBox.exec()
    
    def list_clients(self):
        self.wind_list_clients = QtWidgets.QMainWindow()
        self.ui_list_clients = Ui_GUI_List_Clients()
        self.ui_list_clients.setupUi(self.wind_list_clients)
        self.wind_list_clients.show()

    def add_client(self):
        self.wind_add_client = QtWidgets.QMainWindow()
        self.ui_add_client = Ui_GUI_Add_Client()
        self.ui_add_client.setupUi(self.wind_add_client)
        self.wind_add_client.show()

    def find_client(self):
        self.wind_find_client = QtWidgets.QMainWindow()
        self.ui_find_client = Ui_GUI_Find_Client()
        self.ui_find_client.setupUi(self.wind_find_client)
        self.wind_find_client.show()

    def update_client(self):
        self.wind_update_client = QtWidgets.QMainWindow()
        self.ui_update_client = Ui_GUI_Update_Client()
        self.ui_update_client.setupUi(self.wind_update_client)
        self.wind_update_client.show()

    def delete_client(self):
        self.wind_delete_client = QtWidgets.QMainWindow()
        self.ui_delete_client = Ui_GUI_Delete_Client()
        self.ui_delete_client.setupUi(self.wind_delete_client)
        self.wind_delete_client.show()

    def list_all_registrations(self):
        self.wind_list_all_registrations = QtWidgets.QMainWindow()
        self.ui_list_all_registrations = Ui_GUI_List_All_Product_Registrations()
        self.ui_list_all_registrations.setupUi(self.wind_list_all_registrations)
        self.wind_list_all_registrations.show()

    def list_registrtions_by_client(self):
        self.wind_list_registrations_by_client = QtWidgets.QMainWindow()
        self.ui_list_registrations_by_client = Ui_GUI_List_Product_Registration_By_Client()
        self.ui_list_registrations_by_client.setupUi(self.wind_list_registrations_by_client)
        self.wind_list_registrations_by_client.show()

    def add_product_registation(self):
        self.wind_add_product_registration = QtWidgets.QMainWindow()
        self.ui_add_product_registration = Ui_GUI_Add_Product_Registration()
        self.ui_add_product_registration.setupUi(self.wind_add_product_registration)
        self.wind_add_product_registration.show()

    def find_product_registation(self):
        self.wind_find_product_registration = QtWidgets.QMainWindow()
        self.ui_find_product_registration = Ui_GUI_Find_Product_Registration()
        self.ui_find_product_registration.setupUi(self.wind_find_product_registration)
        self.wind_find_product_registration.show()

    def update_product_registration(self):
        self.wind_update_product_registration = QtWidgets.QMainWindow()
        self.ui_update_product_registration = Ui_GUI_Update_Product_Registration()
        self.ui_update_product_registration.setupUi(self.wind_update_product_registration)
        self.wind_update_product_registration.show()

    def delete_product_registation(self):
        self.wind_delete_product_registration = QtWidgets.QMainWindow()
        self.ui_delete_product_registration = Ui_GUI_Delete_Product_Registration()
        self.ui_delete_product_registration.setupUi(self.wind_delete_product_registration)
        self.wind_delete_product_registration.show()
