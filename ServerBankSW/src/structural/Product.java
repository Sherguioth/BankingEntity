package structural;

import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "Product")
public class Product {

    private int code;
    private String name;
    private String desc;
    private String typeProduct;
    private boolean sate;

    public Product() {
        super();
    }

    public Product(int code, String name, String desc, String typeProduct, boolean sate) {
        super();
        this.code = code;
        this.name = name;
        this.desc = desc;
        this.typeProduct = typeProduct;
        this.sate = sate;
    }

    public int getCode() {
        return code;
    }

    public void setCode(int code) {
        this.code = code;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDesc() {
        return desc;
    }

    public void setDesc(String desc) {
        this.desc = desc;
    }

    public String getTypeProduct() {
        return typeProduct;
    }

    public void setTypeProduct(String typeProduct) {
        this.typeProduct = typeProduct;
    }

    public boolean getSate() {
        return sate;
    }

    public void setSate(boolean sate) {
        this.sate = sate;
    }

    @Override
    public String toString() {
        return "Product{" + "code=" + code + ", name=" + name + ", desc=" + desc + ", typeProduct=" + typeProduct +
               ", sate=" + sate + '}';
    }
}
