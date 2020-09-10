import sys
from PyQt5 import uic, QtWidgets
from gui.gui_principal import Ui_GUIPrincipal

if __name__ == '__main__':
    app = QtWidgets.QApplication(sys.argv)
    GUIPrincipal = QtWidgets.QMainWindow()
    ui = Ui_GUIPrincipal()
    ui.setupUi(GUIPrincipal)
    GUIPrincipal.show()
    sys.exit(app.exec_())