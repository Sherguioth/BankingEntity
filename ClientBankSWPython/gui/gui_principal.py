from tkinter import messagebox
from tkinter import *

import gui_add_client.GUI_Add_Client

class GUI_principal:
    
    def __init__(self):
        super().__init__()
        
        self.root = Tk()
        root.geometry("556x595")
        root.title('BankEntity')

        menu_bar = Menu(self.root)
        root.config(menu=menu_bar)

        file_menu = Menu(menu_bar, tearoff=0)
        file_menu.add_command(label="Salir", command=exit_app)

        clients_menu = Menu(menu_bar, tearoff=0)
        clients_menu.add_command(label="Listar clientes", command=list_clients)
        clients_menu.add_command(label="Agregar Cliente", command=add_client)
        clients_menu.add_command(label="Buscar Cliente", command=find_client)
        clients_menu.add_command(label="Actualizar Cliente", command=update_client)
        clients_menu.add_command(label="Eliminar Cliente", command=delete_client)

        registations_menu = Menu(menu_bar, tearoff=0)
        registations_menu.add_command(label="Listar todos los registros", command=list_all_registrations)
        registations_menu.add_command(label="Listar registros por cliente", command=list_registrtions_by_client)
        registations_menu.add_command(label="Registrar producto a un cliente", command=add_product_registation)
        registations_menu.add_command(label="Buscar registro", command=find_product_registation)
        registations_menu.add_command(label="Actualizar registro", command=update_product_registration)
        registations_menu.add_command(label="Eliminar registro", command=delete_product_registation)

        help_menu = Menu(menu_bar, tearoff=0)
        help_menu.add_command(label="Acerca de...", command=info_about)

        menu_bar.add_cascade(label="Archivo", menu=file_menu)
        menu_bar.add_cascade(label="Clientes", menu=clients_menu)
        menu_bar.add_cascade(label="Registros", menu=registations_menu)
        menu_bar.add_cascade(label="Ayuda", menu=help_menu)

        root.mainloop()
    
    def exit_app(self):
        self.root.destroy()

    def info_about(self):
        messagebox.showinfo("Ayuda", "Desarrollado por Ezequiel Melo & Andrés Novoa  v. 2.0")

    def list_clients(self):
        pass

    def add_client(self):
        gui = GUI_Add_Client()

    def find_client(self):
        pass

    def update_client(self):
        pass

    def delete_client(self):
        pass

    def list_all_registrations(self):
        pass

    def list_registrtions_by_client(self):
        pass

    def add_product_registation(self):
        pass

    def find_product_registation(self):
        pass

    def update_product_registration(self):
        pass

    def delete_product_registation(self):
        pass



