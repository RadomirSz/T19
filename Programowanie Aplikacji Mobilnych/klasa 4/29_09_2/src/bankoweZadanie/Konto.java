package bankoweZadanie;

public class Konto {
    private int Saldo;

    public int getSaldo() {
        return Saldo;
    }

    public void setSaldo(int saldo) {
        Saldo = saldo;
    }
    public void dodaj(){
        Saldo += 10;
    }
}
