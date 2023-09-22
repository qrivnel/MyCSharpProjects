import java.io.*;

public class Main {
    public static void main(String[] args) throws IOException {
        File file = new File("deneme1.txt");
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(file,true));
        bufferedWriter.write("");
        bufferedWriter.close();

    }
}