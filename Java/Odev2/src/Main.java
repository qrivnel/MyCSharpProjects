public class Main {
    public static void hanoiKuleleri(int diskSayisi, String mevcutSutun, String hedefSutun, String ekSutun) {

        if (diskSayisi == 1) { //Tek bir disk varsa mevcut sütundan hedef sütuna taşı
            System.out.println("Disk 1 " + mevcutSutun + " sütunundan " + hedefSutun + " sütununa taşınıyor."); //Taşınma işlemini yazdırma
            return;
        }
        //diskSayisi-1 yani sonraki diski ek sütuna taşı
        hanoiKuleleri(diskSayisi - 1, mevcutSutun, ekSutun, hedefSutun);
        //Kalan son diski hedef sütuna taşı
        System.out.println("Disk " + diskSayisi + " " + mevcutSutun + " sütunundan " + hedefSutun + " sütununa taşınıyor."); //Taşınma işlemini yazdırma
        //diskSayisi-1 diskini yani sonraki diski ek sütundan hedef sütuna taşı
        hanoiKuleleri(diskSayisi - 1, ekSutun, hedefSutun, mevcutSutun);
    }

    public static void main(String[] args) {
        int diskSayisi = 5; //Mevcut sütunda olan disk sayısı
        String mevcutSutun = "1"; //Disklerin hangi sütunda olduğu
        String hedefSutun = "3"; //Taşınacak sütun
        String ekSutun = "2"; //Ara sütunlar

        hanoiKuleleri(diskSayisi, mevcutSutun, hedefSutun, ekSutun); //Fonksiyonu çağırma
    }
}