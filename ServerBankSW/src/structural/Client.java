package structural;

import java.sql.Date;

import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "Client")
public class Client {

    private int identificationNumber;
    private String documetType;
    private String name;
    private Date birthday;
    private String email;
    private String phoneNumber;
    private String gender;

    public Client() {
        super();
    }


    public Client(int identificationNumber, String documetType, String name, Date birthday, String email,
                  String phoneNumber, String gender) {
        super();
        this.identificationNumber = identificationNumber;
        this.documetType = documetType;
        this.name = name;
        this.birthday = birthday;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.gender = gender;
    }

    public int getIdentificationNumber() {
            return identificationNumber;
        }

        public void setIdentificationNumber(int identificationNumber) {
            this.identificationNumber = identificationNumber;
        }

        public String getDocumetType() {
            return documetType;
        }

        public void setDocumetType(String documetType) {
            this.documetType = documetType;
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

        public String getGender() {
            return gender;
        }

        public void setGender(String gender) {
            this.gender = gender;
        }

        @Override
        public String toString() {
            return "Client{" + "identificationNumber=" + identificationNumber + ", documetType=" + documetType + ", name=" + name + ", birthday=" + birthday + ", email=" + email + ", phoneNumber=" + phoneNumber + ", gender=" + gender + '}';
        }
}
