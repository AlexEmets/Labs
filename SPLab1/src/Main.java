// 11 variant
import java.io.IOException;
import java.nio.file.Paths;
import java.util.*;
public class Main {

    public static void main(String[] args) throws IOException {

        Scanner inputFile = new Scanner(Paths.get("/home/oleksandr/IdeaProjects/SPLab1/src/words"));

        Map<String, Integer> map = new HashMap<>();
        String nextLineOfTheFile;

        while (inputFile.hasNext()) {
            nextLineOfTheFile = inputFile.nextLine();
            if(nextLineOfTheFile.isEmpty()) {
                continue;
            }
            String[] wordsInLine = nextLineOfTheFile.split("[^a-zA-Zа-яА-Я]", 0);
            for (String word : wordsInLine) {

                if (word.length() > 30) {
                    word = word.substring(0, 30);
                }

                int count = 0;
                for (int i = 0; i < word.length(); i++) {
                    if (word.charAt(i) == 'a' || word.charAt(i) == 'e' || word.charAt(i) == 'i' || word.charAt(i) == 'o' ||  word.charAt(i) == 'u' || word.charAt(i) == 'y') {
                        count++;
                    }
                }
                map.put(word, count);
            }
        }
        List<Map.Entry<String, Integer>> list = new ArrayList<>(map.entrySet());
        list.sort(Map.Entry.comparingByValue());

        for (Map.Entry<String, Integer> entry : list) {
            System.out.println(entry.getKey());
        }

    }

}