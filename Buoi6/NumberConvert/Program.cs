public class ConvertNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Nhập vào một số nguyên: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 10 && number > 0)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("Không");
                    break;
                case 1:
                    Console.WriteLine("Một");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bốn");
                    break;
                case 5:
                    Console.WriteLine("Năm");
                    break;
                case 6:
                    Console.WriteLine("Sáu");
                    break;
                case 7:
                    Console.WriteLine("Bảy");
                    break;
                case 8:
                    Console.WriteLine("Tám");
                    break;
                case 9:
                    Console.WriteLine("Chín");
                    break;
                default:
                    Console.WriteLine("Số không hợp lệ");
                    break;
            }
        }
        else if (number < 20 && number >= 10)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine("Mười");
                    break;
                case 11:
                    Console.WriteLine("Mười một");
                    break;
                case 12:
                    Console.WriteLine("Mười hai");
                    break;
                case 13:
                    Console.WriteLine("Mười ba");
                    break;
                case 14:
                    Console.WriteLine("Mười bốn");
                    break;
                case 15:
                    Console.WriteLine("Mười lăm");
                    break;
                case 16:
                    Console.WriteLine("Mười sáu");
                    break;
                case 17:
                    Console.WriteLine("Mười bảy");
                    break;
                case 18:
                    Console.WriteLine("Mười tám");
                    break;
                case 19:
                    Console.WriteLine("Mười chín");
                    break;
                default:
                    Console.WriteLine("Số không hợp lệ");
                    break;
            }
        }
        else if (number >= 20 && number <= 99)
        {
            int units = number % 10; // Get the units place
            int tens = number / 10; // Get the tens place
            switch (tens)
            {
                case 2:
                    Console.Write("Hai mươi");
                    break;
                case 3:
                    Console.Write("Ba mươi");
                    break;
                case 4:
                    Console.Write("Bốn mươi");
                    break;
                case 5:
                    Console.Write("Năm mươi");
                    break;
                case 6:
                    Console.Write("Sáu mươi");
                    break;
                case 7:
                    Console.Write("Bảy mươi");
                    break;
                case 8:
                    Console.Write("Tám mươi");
                    break;
                case 9:
                    Console.Write("Chín mươi");
                    break;
                default:
                    Console.Write("Số không hợp lệ");
                    return; // Exit if the tens place is invalid
            }   
            switch (units)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.Write(" một");
                    break;
                case 2:
                    Console.Write(" hai");
                    break;
                case 3:
                    Console.Write(" ba");
                    break;
                case 4:
                    Console.Write(" bốn");
                    break;
                case 5:
                    Console.Write(" năm");
                    break;
                case 6:
                    Console.Write(" sáu");
                    break;
                case 7:
                    Console.Write(" bảy");
                    break;
                case 8:
                    Console.Write(" tám");
                    break;
                case 9:
                    Console.Write(" chín");
                    break;
                default:
                    Console.Write("Số không hợp lệ");
                    break;
            }
        }
    }
}