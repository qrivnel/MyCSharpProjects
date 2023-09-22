import java.io.*;

public class Main {
    public static void main(String[] args) throws IOException {
        File file = new File("dosyaoku.txt");
        File file2 = new File("dosyaoku2.txt");

        FileReader fileReader = new FileReader(file);


        BufferedReader bufferedReader = new BufferedReader(fileReader);
        String array[] = new String[5];

        for (int i=0;i<array.length;i++){
            array[i] = bufferedReader.readLine();
        }

        for(String value2: array){
            System.out.println(value2);
        }
        bufferedReader.close();

        FileWriter fileWriter = new FileWriter(file2,true);
        fileWriter.write("\nerhannnnn");

        bufferedWriter.close();


    }
}