import java.util.Scanner;

public class _1_SymmetricNumbersiInRange {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
	int start = input.nextInt();
		int end = input.nextInt();
		if (start < 10) {
			for (int i = start; start < end; start++) {
				System.out.println(start);
				if (start == 10) {
					break;
				}
			}
		}

		if (end > 10 && start < 100)
		
		{
			for (int i = start; start <= end; start++) {
				int firstTemp = start / 10;
				int secondTemp = start % 10;
				if (firstTemp == secondTemp) {
					System.out.println(start);
				}
				if (start == 100) {
					break;
				}
			}
		}	
		
		if (end > 100) {
			for (int i = start; start <= end; start++) {
				int firstDigTemp = start / 100;
				int thirdDigTemp = start % 10;
				int middleDigTemp = (start / 10) % 10;
				if ((firstDigTemp == thirdDigTemp)
						|| (firstDigTemp == middleDigTemp && middleDigTemp == thirdDigTemp)) {
					System.out.println(start);
				}
			}
		}
	}
}
