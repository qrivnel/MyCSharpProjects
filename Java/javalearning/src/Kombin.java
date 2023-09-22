import java.util.Scanner;

public class Kombin {
    Scanner scan = new Scanner(System.in);
    int secim;
    String renk, stil, tur;
    private String[] mRenk = {"beyaz","mavi","kirmizi","siyah","yesil","pembe","mor"}, mStil, mIsim, mTur = {"Mont","Sweatshirt","Tshirt", "Pantolon", "Ayakkabı", "Şapka"};
    double minFiyat, maxFiyat;


    public void uyumBul() {
        mRenk = new String[3];
        switch (this.renk.toLowerCase()) {
            case "beyaz":
                mRenk[0] = "mavi";
                mRenk[1] = "kirmizi";
                mRenk[2] = "siyah";
                break;

            case "mavi":
                mRenk[0] = "beyaz";
                mRenk[1] = "kahverengi";
                mRenk[2] = "gri";
                break;

            case "kirmizi":
                mRenk[0] = "beyaz";
                mRenk[1] = "siyah";
                mRenk[2] = "sari";
                break;

            case "siyah":
                mRenk[0] = "krem";
                mRenk[1] = "yesil";
                mRenk[2] = "lacivert";
                break;

            case "yesil":
                mRenk[0] = "gri";
                mRenk[1] = "siyah";
                mRenk[2] = "krem";
                break;

            case "pembe":
                mRenk[0] = "gri";
                mRenk[1] = "turkuaz";
                mRenk[2] = "mavi";
                break;

            case "mor":
                mRenk[0] = "gri";
                mRenk[1] = "beyaz";
                mRenk[2] = "kahverengi";
                break;

            default:
                System.out.println("Lütfen bir renk girin: ");
                break;
        }
    }

    public void baslat(){
        System.out.println("Kombin yarat 1");
        System.out.println("Kendimi şanslı hissediyorum 2");
        System.out.print("Seciminizi girin: ");
        this.secim = scan.nextInt();
        while(this.secim<1 || this.secim>2){
            System.out.print("Hatali secim!!\nSeciminizi girin: ");
            this.secim = scan.nextInt();
        }
    }

    public void bilgiAl(){
        switch (secim){
            case 1:
                int sec;
                System.out.println("Elinizdeki kıyafetin;");
                System.out.print("Türü\t1)T-shirt  2)Sweat  3)Pantolon  4)Eşofman\nSeçiminiz: ");
                sec = scan.nextInt();
                while(sec<1 || sec>4){
                    System.out.print("Hatali secim!!\nSeciminizi girin: ");
                    sec = scan.nextInt();
                }
                if(sec == 1){
                    this.tur = "T-shirt";
                    this.stil = "Günlük";
                }
                else if (sec == 2){
                    this.tur = "Sweat";
                    this.stil = "Spor";
                }

                else if (sec == 3){
                    this.tur = "Pantolon";
                    this.stil = "Günlük";
                }

                else{
                    this.tur = "Eşofman";
                    this.stil = "Spor";
                }


                System.out.print("Rengi\t1)Beyaz  2)Siyah  3)Mavi  4)Kırmızı  5)Yeşil  6)Pembe  7)Mor\nSeciminizi girin:");
                sec = scan.nextInt();
                while(sec<1 || sec>7){
                    System.out.print("Hatali secim!!\nSeciminizi girin: ");
                    sec = scan.nextInt();
                }
                if(sec == 1)
                    this.renk = "Beyaz";
                else if (sec == 2)
                    this.renk = "Siyah";
                else if (sec == 3)
                    this.renk = "Mavi";
                else if (sec == 4)
                    this.renk = "Kırmızı";
                else if (sec == 5)
                    this.renk = "Yeşil";
                else if (sec == 6)
                    this.renk = "Pembe";
                else
                    this.renk = "Mor";


            default:
                break;
        }
    }

    public void elindekiniGoster(){
        System.out.println("Seçimleriniz\nTürü: "+this.tur+"\nRengi: "+this.renk+"\nStili: "+this.stil);
    }

    public void uyumluRenkleriGoster(){
        System.out.print("Uyumlu renkler\n"+mRenk[0]+"\n"+mRenk[1]+"\n"+mRenk[2]);
    }
}
