import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {}
}

abstract class Product
{
    public int Price;
    private String Name;
    public int getPrice(){return Price;}
    public String getName(){return Name;}
    public Product(){}

}
class PhysicalProduct extends Product {}
class DigitalProduct extends Product {}

interface DiscountStrategy
{
    int discount(int price);
}

class PercentageDiscount implements DiscountStrategy
{
    public int discount(int price){
        return (int) (price * 0.8);
    }
}

class FixedAmountDiscount implements DiscountStrategy
{
    public int discount(int price){
        if (price > 2) return (price - 2);
        else return price;
    }
}
class Koszyk
{
    ArrayList<Product> listaProduktow = new ArrayList<Product>();

    public int total(DiscountStrategy d){
        int suma = 0;
        for(Product produkt : listaProduktow){
            suma += produkt.getPrice();
        }
        suma = d.discount(suma);
        return suma;
    }
}