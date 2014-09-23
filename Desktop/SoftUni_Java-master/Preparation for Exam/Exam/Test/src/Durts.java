import java.util.Scanner;

public class Durts {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int centerX = sc.nextInt();
		int centerY = sc.nextInt();
		int r = sc.nextInt();
		int n = sc.nextInt();

		double verticalRectMinX = centerX - (0.5 * r);
		double verticalRectMaxX = centerX + (0.5 * r);
		double verticalRectMinY = centerY - r;
		double verticalRectMaxY = centerY + r;

		double horizontalRectMinX = centerX - r;
		double horizontalRectMaxX = centerX + r;
		double horizontalRectMinY = centerY - (0.5 * r);
		double horizontalRectMaxY = centerY + (0.5 * r);

		boolean verticalRect = false;
		boolean horizontalRect = false;
		for (int i = 0; i < n; i++) {
			int x = sc.nextInt();
			int y = sc.nextInt();
			if ((verticalRectMinX <= x && verticalRectMaxX >= x)
					&& (verticalRectMinY <= y && verticalRectMaxY >= y)) {
				verticalRect = true;
			}
			if ((horizontalRectMinX <= x && horizontalRectMaxX >= x)
					&& (horizontalRectMinY <= y && horizontalRectMaxY >= y)) {
				horizontalRect = true;
			}
			if (verticalRect == true || horizontalRect == true) {
				System.out.println("yes");
				horizontalRect=false;
				verticalRect=false;
			} else {
				System.out.println("no");
			}
		}
	}
}
