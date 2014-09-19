using System;
    class ChecksThirdDigitIs7
{
        static void Main()
	{
		int num = int.Parse(Console.ReadLine());
		int DevBy100 = num / 100;
        int thirdDigit = Math.Abs(DevBy100 % 10);
        bool checkThirdDigit7 = thirdDigit == 7;
        Console.WriteLine(checkThirdDigit7);
	}
}

        
