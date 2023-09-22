public class Main {
    public static void main(String[] args) {
        int[] dizi = {1, 2, 3, 4, 5};
        System.out.println("Dizinin ilk hali;");
        for (int eleman : dizi)
            System.out.println(eleman);

        System.out.println("Dizinin ters dönmüş hali;");
        tersCevir(dizi);
        for (int eleman : dizi)
            System.out.println(eleman);

    }
    public static void tersCevir(int[] dizi){
        for(int i = 0; i < dizi.length / 2; i++){
            int sayi = dizi[i];
            dizi[i] = dizi[dizi.length - 1 - i];
            dizi[dizi.length - 1 - i] = sayi;
        }
    }
}