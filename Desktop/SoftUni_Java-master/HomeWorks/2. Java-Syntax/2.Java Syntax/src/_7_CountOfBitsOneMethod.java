import java.util.Scanner;

public class _7_CountOfBitsOneMethod {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int dec = input.nextInt();
		Integer bin = Integer.bitCount(dec);
		System.out.println(bin);
	}

}