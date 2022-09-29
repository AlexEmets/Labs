

import javafx.util.Pair;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;


class Main {
    public static void main(String[] args) throws IOException {
        try {
            Integer count_alhab = 2;
            File file = new File("/home/oleksandr/Documents/University/Labs/SPLab2/dataFile.txt");
            Scanner scan = new Scanner(file);

            Integer count_states = scan.nextInt();

            Integer begin_state = scan.nextInt();

            Integer count_final_states = scan.nextInt();

            ArrayList<Integer> final_states = new ArrayList<Integer>();

            Map< Pair<Integer, Character>, Integer> moves = new HashMap<Pair<Integer, Character>, Integer>();

            for (int i = 0; i < count_final_states; i++) {
                Integer temp = scan.nextInt();
                final_states.add(temp);
            }

            System.out.print("Множина фінальних станів:\n");
            for (int i = 0; i < count_final_states; i++) {System.out.print(final_states.get(i));System.out.print(" ");}
            System.out.print("\n");

            while (scan.hasNext()) {
                Integer prev_state = scan.nextInt();
                Character letter = scan.next().trim().charAt(0);
                Integer next_state = scan.nextInt();
                Pair<Integer, Character> pair = new Pair<Integer, Character>(prev_state, letter);
                moves.put(pair, next_state);
            }

            // Перевіримо чи літери сприймаються автоматом
            String letters = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < count_alhab; i++) {
                Character ch = letters.charAt(i);
                Pair<Integer, Character> temp = new Pair<Integer, Character>(begin_state, ch);
                Integer next_state = moves.getOrDefault(temp, 0);

                //На кожній ітерації перевіряємо, чи нам вдалось опинитись у фінальному стані
                if (!(final_states.contains(next_state))) {
                    System.out.print("Do not accept: ");
                    System.out.print(letters.charAt(i));
                    System.out.print("\n");
                }
            }
        } catch (java.io.FileNotFoundException e) {
            System.out.println("No such file");
        }
    }
}


//File:
// кількість станів
// початковий стан
// кількість фінальних станів
// множина фінальних станів
// задання автомату:
// e.g. 2 b 3
// .....


//3
//0
//1
//1
//0 a 1
//0 b 2
//1 a 1
//1 b 2





