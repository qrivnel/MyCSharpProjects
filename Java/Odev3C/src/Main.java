public class Main {
    public static void main(String[] args) {

        int[][] dizi = {
                {1,3,2},
                {1,4,5},
                {3,4,2}
        };

        System.out.println("Dizinin ilk hali;");
        for(int[] boyut1 : dizi){
            for(int boyut2 : boyut1){
                System.out.print(boyut2 + " ");
            }
            System.out.println();
        }

        System.out.println("Dizinin ters dönmüş hali;");
        tersCevir(dizi);
        for(int[] boyut1 : dizi){
            for(int boyut2 : boyut1){
                System.out.print(boyut2 + " ");
            }
            System.out.println();
        }
    }
    public static void tersCevir(int[][] dizi){
        for(int i = 0; i < dizi.length; i++){
            for(int j = 0; j < dizi[i].length / 2; j++ ){
                int sayi = dizi[i][j];
                dizi[i][j] = dizi[i][dizi.length - 1 - j];
                dizi[i][dizi.length - 1 - j] = sayi;
            }
        }
        for (int i = 0; i < dizi.length / 2; i++){
            int[] sayi = dizi[i];
            dizi[i] = dizi[dizi.length - 1 - i];
            dizi[dizi.length - 1 - i] = sayi;
        }
    }
}