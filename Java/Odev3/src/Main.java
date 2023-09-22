import java.lang.reflect.Array;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Random random = new Random();
        System.out.print("Dizinin kaç elemanlı olacağını girin: ");
        //Kullanıcıdan değer alma
        int[] dizi = new int[scanner.nextInt()];

        //Diziye rastgele eleman üretme
        for(int i = 0; i < dizi.length; i++)
            dizi[i] = random.nextInt(100);
        // İlk hali
        System.out.println("Dizinin ilk hali;");
        for (int i = 0; i < dizi.length; i++)
            System.out.println(dizi[i]);

        //Küçükten büyüğe sıralanmış hali
        dizi = kucuktenBuyugeSiralaA1(dizi);
        System.out.println("Dizinin sıralanmış hali;");
        for (int i = 0; i < dizi.length; i++)
            System.out.println(dizi[i]);

        //Seçilen elemanın silinmiş hali
        System.out.print("En küçük kaçıncı eleman silinsin: ");
        int sira = scanner.nextInt();
        System.out.println("En küçük " + sira + ". elemanın silinmiş hali;");
        int[] silinmisDizi = enKucukElemanSilmeA2(kucuktenBuyugeSiralaA1(dizi), sira - 1);
        dizi = silinmisDizi;
        for (int i = 0; i < silinmisDizi.length; i++)    //Seçilen sıradaki elemanı silinmiş hali
            System.out.println(silinmisDizi[i]);

    }
    public static int[] kucuktenBuyugeSiralaA1(int[] dizi){
        //Dizideki en küçük elemanı bulma
        for(int i = 0; i < dizi.length; i++) {
            int min = dizi[i];
            int minIndex = 0;
            //En küçük sayıyı bulma
            for(int j = i; j < dizi.length; j++){
                if(min > dizi[j]){
                    min = dizi[j];
                    minIndex = j;
                }
            }
            //En küçük sayıyı en başa alma
            if(dizi[i] > min){
                dizi[minIndex] = dizi[i];
                dizi[i] = min;
            }
        }
        return dizi;
    }
    public static int[] enKucukElemanSilmeA2(int[] dizi, int silinecekSira){
        int[] silinmisDizi = new int[dizi.length - 1];
        //Eleman silme
        for(int i = 0; i < dizi.length - 1; i++)
            if(i >= silinecekSira)
                silinmisDizi[i] = dizi[i + 1];
            else
                silinmisDizi[i] = dizi[i];
        return silinmisDizi;
    }

}