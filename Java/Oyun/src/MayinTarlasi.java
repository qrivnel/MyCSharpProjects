import java.util.Random;
import java.util.Scanner;

public class MayinTarlasi {
    int rowNumber, colNumber;
    int[][] map;
    int[][] board;

    MayinTarlasi(int rowNumber, int colNumber){
        this.rowNumber = rowNumber;
        this.colNumber = colNumber;
        this.map = new int[rowNumber][colNumber];
        this.board = new int[rowNumber][colNumber];
    }

    public void answerKey(){
        int i=1;
        System.out.print("\t ");
        for(int j=1;j<map[0].length+1;j++){
            System.out.print(j+". ");
        }
        System.out.println();
        for(int[] sutun: map){
            int k=0;
            System.out.print((i++)+". ");
            for (int value: sutun){
                k++;
                if (k>9){
                    System.out.print(" ");
                    if (k==this.colNumber)
                        k=0;
                }
                if(value==0)
                    System.out.print("  "+value);
                else
                    System.out.print(" "+value);
            }
            System.out.println();
        }

    }
    public void run(){
        int i=1;
        System.out.print("\t ");
        for(int j=1;j<map[0].length+1;j++){
            System.out.print(j+". ");
        }
        System.out.println();
        for(int[] sutun: board){
            int k=0;
            System.out.print((i++)+". ");
            for (int value: sutun){
                k++;
                if (k>9){
                    System.out.print(" ");
                    if (k==this.colNumber)
                        k=0;
                }
                if (value==-1)
                    System.out.print(" "+value);
                else
                    System.out.print("  "+value);
            }
            System.out.println();
        }
    }

    public void prepareGame(){
        Random rand = new Random();
        for (int i=0; i<this.rowNumber*this.colNumber/5;i++){
            int rowR = rand.nextInt(this.rowNumber);
            int colR = rand.nextInt(this.colNumber);
            this.map[rowR][colR] = -1;
        }
    }


    public void play(){
        Scanner scan = new Scanner(System.in);
        System.out.print("Satir girin: ");
        int row = scan.nextInt()-1;
        System.out.print("Sutun girin: ");
        int col = scan.nextInt()-1;
        switch (map[row][col]){
            case -1:
                board[row][col]=-1;
                System.out.println("Kaybettiniz.");
                break;
            case 0:
                int counter=0;
                if((row-1)<=this.rowNumber && map[row-1][col]==-1)       //up
                    counter++;
                if((row+1)<=this.rowNumber && map[row+1][col]==-1)       //down
                    counter++;
                if((col-1)<=this.colNumber && map[row][col-1]==-1)       //left
                    counter++;
                if((col+1)<=this.colNumber && map[row][col+1]==-1)       //right
                    counter++;
                if((row-1)<=this.rowNumber && (col-1)<=this.colNumber && map[row-1][col-1]==-1)     //cross left up
                    counter++;
                if((row-1)<=this.rowNumber && (col+1)<=this.colNumber && map[row-1][col+1]==-1)     //cross right up
                    counter++;
                if((row+1)<=this.rowNumber && (col-1)<=this.colNumber && map[row+1][col-1]==-1)     //cross left down
                    counter++;
                if((row+1)<=this.rowNumber && (col+1)<=this.colNumber && map[row+1][col+1]==-1)         //cross right down
                    counter++;
                board[row][col]=counter;
                break;
        }
    }

}
