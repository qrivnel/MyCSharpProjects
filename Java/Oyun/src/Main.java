import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int row, col;
        Scanner scan = new Scanner(System.in);
        MayinTarlasi game;
        System.out.print("Mayin tarlasina hoş geldiniz!\nBaşlamak için satir ve sutun sayisi girin\nSatir sayisi: ");
        row = scan.nextInt();
        System.out.print("Sutun sayisi: ");
        col = scan.nextInt();
        game = new MayinTarlasi(row, col);
        game.prepareGame();
        game.answerKey();
        game.run();
        while(true){
            game.play();
            game.run();
        }
    }
}