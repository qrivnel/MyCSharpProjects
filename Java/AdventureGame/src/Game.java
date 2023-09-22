import java.util.Scanner;

public class Game{
    Player player;
    public void start(){
        Scanner scan = new Scanner(System.in);
        System.out.print("Macera oyununa hoşgeldiniz..\nİsminizi girin: ");
        String pName = scan.next();
        System.out.println("Hoşgeldin "+pName);
        player = new Player(pName);
        player.characterChoose();
        System.out.println("Karakter: "+player.getcName()+"\nHasar: "+player.getDamage()+"\nSağlık: "+player.getHealt()+"\nMevcut para: "+player.getMoney());
    }

    public void go(int choose){
        switch (choose){
            case 1:
                System.out.println("Mekan: Güvenli ev\tSağlık yenilendi..");

                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                break;
        }
    }
    public void fight(){

    }
    public void show(){
        System.out.println("Karakter: "+player.getcName()+"\nHasar: "+player.getDamage()+"\nSağlık: "+player.getHealt()+"\nMevcut para: "+player.getMoney());
    }
}
