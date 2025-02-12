package solutions;

public class CanPlaceFolwers {

	public static boolean solution(int[] flowerbed, int n) {

		if (flowerbed.length < 3) {
			if (flowerbed.length == 1) {
				if (n == 1 && flowerbed[0] == 0) {
					n--;
				}
			}
			if (flowerbed.length == 2) {
				if (n == 1 && flowerbed[1] == 0 && flowerbed[0] == 0) {
					n--;
				}
			}
		} else {
			for (int i = 0; i < flowerbed.length; i++) {

				if (i == 0) {
					if (flowerbed[i] == 0 && flowerbed[i + 1] == 0) {
						flowerbed[i] = 1;
						n--;
					}
				} else if (i == flowerbed.length - 1) {
					if (flowerbed[i] == 0 && flowerbed[i - 1] == 0) {
						flowerbed[i] = 1;
						n--;
					}
				} else {
					if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0) {
						flowerbed[i] = 1;
						n--;
					}
				}
			}

		}

		return n <= 0;

	}
}
