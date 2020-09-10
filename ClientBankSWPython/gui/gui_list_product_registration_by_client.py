# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIListProductRegistrationByClient.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets


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
        self.tableWidget.setColumnCount(0)
        self.tableWidget.setRowCount(0)
        GUI_List_Product_Registration_By_Client.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(GUI_List_Product_Registration_By_Client)
        self.statusbar.setObjectName("statusbar")
        GUI_List_Product_Registration_By_Client.setStatusBar(self.statusbar)

        self.retranslateUi(GUI_List_Product_Registration_By_Client)
        QtCore.QMetaObject.connectSlotsByName(GUI_List_Product_Registration_By_Client)

    def retranslateUi(self, GUI_List_Product_Registration_By_Client):
        _translate = QtCore.QCoreApplication.translate
        GUI_List_Product_Registration_By_Client.setWindowTitle(_translate("GUI_List_Product_Registration_By_Client", "MainWindow"))
        self.label_title.setText(_translate("GUI_List_Product_Registration_By_Client", "Lista de registros del cliente"))
        self.label_client_id.setText(_translate("GUI_List_Product_Registration_By_Client", "Documento del cliente:"))
        self.btn_find_client.setText(_translate("GUI_List_Product_Registration_By_Client", "..."))


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    GUI_List_Product_Registration_By_Client = QtWidgets.QMainWindow()
    ui = Ui_GUI_List_Product_Registration_By_Client()
    ui.setupUi(GUI_List_Product_Registration_By_Client)
    GUI_List_Product_Registration_By_Client.show()
    sys.exit(app.exec_())
