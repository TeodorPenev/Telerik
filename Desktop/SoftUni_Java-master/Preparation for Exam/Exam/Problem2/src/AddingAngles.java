import java.util.HashSet;
import java.util.Scanner;

public class AddingAngles {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = Integer.parseInt(input.nextLine());
		String tempStr[] = input.nextLine().split(" ");
		int[] digits = new int[n];
		boolean exist =false;
		for (int i = 0; i < tempStr.length; i++) {
			digits[i] = Integer.parseInt(tempStr[i]);
		}
		for (int a = 0; a < digits.length; a++) {
			for (int b = 0; b < digits.length; b++) {
				for (int c = 0; c < digits.length; c++) {
					if (a==b || b==c || a==c) {
						continue;
					}
					else {
						if (a<b && b<c) {
							int tempRes =(digits[a]+digits[b]+digits[c])%360;
							int tempSum =digits[a]+digits[b]+digits[c];
							if (tempRes ==0) {
							System.out.println(digits[a]+" + "+digits[b]+" + "+digits[c]+ " = "+tempSum+" degrees");
							exist =true;
							}	
						}
					}
				}
			}
		}
		if (exist==false) {
			System.out.println("No");
		}
	}
}
