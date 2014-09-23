import java.util.Scanner;

public class DozensOfEggs {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int sumEggs = 0;
		for (int i = 0; i < 7; i++) {
			String[] temp = input.nextLine().split(" ");
			int count = Integer.parseInt(temp[0]);
			String measure =temp[1];
			if (measure.equals("dozens")) {
				sumEggs+=count*12;
			}
			else {
				sumEggs+=count;
			}
		}
		System.out.printf("%d dozens + %d eggs",sumEggs/12,sumEggs%12);
	}
}
