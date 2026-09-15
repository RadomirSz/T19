
void main() {
//    zad1();
//    zad2();
//    zad3();
//    zad4();
//    zad5();
//    zad6();
//    zad7();
//    zad8();
//    zad9();
//    zad10();
//    zad11();
//    zad12();
//    zad13();
//    zad14();
//    zad15();

}

Scanner scanner = new Scanner(System.in);
void zad1(){
//    1. Napisz program, który wczytuje dwie liczby całkowite i wypisuje ich sumę, różnicę, iloczyn oraz iloraz.
    int a = scanner.nextInt();
    int b = scanner.nextInt();
    IO.println(a+b);
    IO.println(a-b);
    IO.println(a*b);
    IO.println(a/b);
}

void zad2(){
//2. Napisz program obliczający pole i obwód prostokąta na podstawie wczytanych boków.
    int a = scanner.nextInt();
    int b = scanner.nextInt();
    IO.println("pole: " + a*b);
    IO.println("obwód: " + 2*a+2*b);
}
void zad3(){
//3. Napisz program zamieniający temperaturę podaną w stopniach Celsjusza na Fahrenheity.
    int a = scanner.nextInt();
    IO.println(a*1.8 + 32);
}
void zad4(){
//        4. Napisz program obliczający największy wspólny dzielnik dwóch liczb za pomocą algorytmu Euklidesa.
    int a = scanner.nextInt();
    int b = scanner.nextInt();
    while (a!=b){
        if(a>b){a=a-b;}
        if(a<b){b=b-a;}
    }
    IO.println(a);
}
void zad5(){
//        5. Napisz program obliczający najmniejszą wspólną wielokrotność dwóch liczb.
    int a = scanner.nextInt();
    int b = scanner.nextInt();
    int c = a*b;
    while (a!=b){
        if(a>b){a=a-b;}
        if(a<b){b=b-a;}
    }
    IO.println(c/a);
}
void zad6(){
//        6. Napisz program obliczający sumę cyfr podanej liczby całkowitej.
    int a = scanner.nextInt();
    int suma = 0;
    while(a>0){
        suma += a%10;
        a = a/10;
    }
    IO.println(suma);
}
void zad7(){
//        7. Napisz program sprawdzający, czy podana liczba jest palindromem (czytana tak samo od przodu i od tyłu).
    String a = scanner.next();
    String b = new StringBuilder(a).reverse().toString();
    if(a == b){
        IO.println("jest");
    }
    else{
        IO.println("nie jest");
    }
}

boolean czyPierwsza(int a){
    for (int i = 2; i <= Math.sqrt(a); i++) {
        if(a%i==0){
            return false;
        }
    }
    return true;
}
void zad8(){
//        8. Napisz program sprawdzający, czy podana liczba jest liczbą pierwszą.
    int a = scanner.nextInt();
    if(czyPierwsza(a)){
        IO.println("pierwsza ");
    }
    else{
        IO.println("nie pierwsza ");
    }
}
void zad9(){
//        9. Napisz program wypisujący wszystkie liczby pierwsze z podanego zakresu.
    int a = scanner.nextInt();
    for (int j = 2; j <= a; j++) {
        if(czyPierwsza(j)){
            IO.println(j);
        }
    }
}
void zad10(){
//        10. Napisz program obliczający silnię podanej liczby.
    int a = scanner.nextInt();
    int silnia = 1;
    for (int i = 2; i <= a; i++) {
        silnia *= i;
    }
    IO.println(silnia);
}
void zad11(){
//        11. Napisz program generujący n początkowych wyrazów ciągu Fibonacciego.
    int n = scanner.nextInt();
    int a = 1;
    int b = 1;
    for (int i = 0; i < n; i++) {
        IO.println(a);
        int temp = a+b;
        a=b;
        b=temp;
    }
}
void zad12(){
//        12. Napisz program zamieniający wszystkie litery w podanym tekście na wielkie oraz na małe.

}
void zad13(){
//13. Napisz program zliczający liczbę samogłosek i spółgłosek w podanym tekście.

}
void zad14(){
//        14. Napisz program sprawdzający, czy podany tekst jest palindromem (bez uwzględniania wielkości liter).

}
void zad15(){
//        15. Napisz program odwracający kolejność słów w podanym zdaniu.

}
