package structural;

import java.util.Date;

public class Client {
    
    private int identificationNumber;
    private String name;
    private Date birthday;
    private String email;
    private String phoneNumber;
    private double balance;
    
    public Client() {
        super();
    }


    public Client(int identificationNumber, String name, Date Date, String email, String phoneNumber, double balance) {
        super();
        this.identificationNumber = identificationNumber;
        this.name = name;
        this.birthday = Date;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.balance = balance;
    }
    
    public int getIdentificationNumber() {
            return identificationNumber;
        }

        public void setIdentificationNumber(int identificationNumber) {
            this.identificationNumber = identificationNumber;
        }

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public Date getBirthday() {
            return birthday;
        }

        public void setBirthday(Date birthday) {
            this.birthday = birthday;
        }

        public String getEmail() {
            return email;
        }

        public void setEmail(String email) {
            this.email = email;
        }

        public String getPhoneNumber() {
            return phoneNumber;
        }

        public void setPhoneNumber(String phoneNumber) {
            this.phoneNumber = phoneNumber;
        }

        public double getBalance() {
            return balance;
        }

        public void setBalance(double balance) {
            this.balance = balance;
        }
        
        public String toString() {
            return "Client{" + "identificationNumber=" + identificationNumber + ", name=" + name + ", birthday=" + birthday + ", email=" + email + ", phoneNumber=" + phoneNumber + ", balance=" + balance + '}';
        }
}
