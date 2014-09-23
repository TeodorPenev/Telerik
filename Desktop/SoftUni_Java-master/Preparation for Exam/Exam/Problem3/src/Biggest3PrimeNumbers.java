import java.util.HashSet;
import java.util.Scanner;
import java.util.TreeSet;

public class Biggest3PrimeNumbers {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43,
				47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
		String input = in.nextLine();
		String inputIgnore = input.replaceAll("\\s+", "").replace("(", " ")
				.replace(")", " ").trim();
		String[] numsStr = inputIgnore.split("  ");
		int countExist = 0;
		int[] numsI = new int[numsStr.length];
		HashSet<Integer> numsH = new HashSet<Integer>();
		TreeSet<Integer> bigH = new TreeSet<Integer>();
		for (int i = 0; i < numsI.length; i++) {
			numsI[i] = Integer.parseInt(numsStr[i]);
		}

		for (int i = 0; i < numsStr.length; i++) {
			numsH.add(numsI[i]);
		}

		for (int i = 0; i < primes.length; i++) {
			if (numsH.contains(primes[i])) {
				bigH.add(primes[i]);
				countExist++;
			}
		}
		int sum = 0;
		if (countExist >= 3) {
			for (int i = 0; i < 3; i++) {
				sum = sum + (bigH.last());
				bigH.remove(bigH.last());
			}
			System.out.println(sum);
		} else {
			System.out.println("No");
		}

	}
}
