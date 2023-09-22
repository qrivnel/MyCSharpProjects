import java.util.Scanner;

public class Player {
    Scanner scan = new Scanner(System.in);
    private int damage, healt, money=20;
    private String name, cName;
    Player (String name){
        this.name = name;
    }
    public void characterChoose(){
        System.out.println("Karakterler");
        System.out.println("  Samuray\t\t  Okçu\t\t    Şövalye");
        System.out.println("  Hasar: 5\t\tHasar: 7\t  Hasar: 8");
        System.out.println("  Sağlık: 21\tSağlık: 18\t  Sağlık: 24");
        System.out.println("  Para: 15\t\tPara: 20\t  Para: 5\nParanız: "+this.money);
        System.out.print("Seçiminiz: ");
        this.cName = scan.next().toLowerCase();

        while(!cName.equals("samuray") && !cName.equals("okçu") && !cName.equals("şövalye")){
            System.out.print("Hatalı seçim!!\nSeçiminiz: ");
            this.cName = scan.next().toLowerCase();
        }

        switch (this.cName){
            case "samuray":
                init(5, 21, 15);
                break;
            case "okçu":
                init(7, 18, 20);
                break;
            case "şövalye":
                init(8, 24, 5);
                break;
            default:
                this.cName = "samuray";
                init(5, 21, 15);
                break;
        }
    }

    public void locationChoose(){
        System.out.println("Mekanlar");
        System.out.println("1) Güvenli ev\tÖzellik: Can yeniliyor.");
        System.out.println("2) Mağara\tCanavar: Zombi(1-3)\tÖzellik: Savaş + Ganimet\tEşya: Yemek");
        System.out.println("3) Orman\tCanavar: Vampir(1-3)\tÖzellik: Savaş + Ganimet\tEşya: Odun");
        System.out.println("4) Nehir\tCanavar: Ayi(1-2)\tÖzellik: Savaş + Ganimet\tEşya: Su");
        System.out.println("5) Mağaza\tÖzellik: Mağaza\tSilah: Tabanca, Kılıç, Tüfek\tZırh: Hafif, Orta, Ağır");
        System.out.print("Seçiminiz: ");
        int choose = scan.nextInt();
        while (choose < 1 || choose > 5){
            System.out.print("Hatalı seçim!\nSeçiminiz: ");
            choose = scan.nextInt();
        }
    }


    public void init(int damage, int healt, int money){
        setDamage(damage);
        setHealt(healt);
        setMoney(money);
    }

    public int getDamage() {
        return damage;
    }

    public void setDamage(int damage) {
        this.damage = damage;
    }

    public int getHealt() {
        return healt;
    }

    public void setHealt(int healt) {
        this.healt = healt;
    }

    public int getMoney() {
        return money;
    }

    public void setMoney(int money) {
        this.money = money;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getcName() {
        return cName;
    }

    public void setcName(String cName) {
        this.cName = cName;
    }


}
