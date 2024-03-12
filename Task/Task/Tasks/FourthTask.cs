// "Raqamni toping" o'yini

/*
1 dan 100 gacha bo'lgan tasodifiy sonni yaratadigan dastur yarating va keyin foydalanuvchidan bu raqamni taxmin qilishni so'raydi. Dastur sirli raqam foydalanuvchi kiritgan raqamdan katta yoki kichik ekanligi haqida maslahatlar berishi kerak. Ternary operatoridan va Random dan foydalaning
*/
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Sockets;

namespace Task
{
    public class FourthTask
    {
        public static void Task()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            int userNumber;
            string message;

            Console.WriteLine("The computer thought of one secret number.");

            do
            {
                Console.Write("Enter the secret number: ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                if(userNumber == randomNumber)
                {
                    break;
                }
                message = (userNumber > randomNumber)
                    ? "The number entered by the user is greater than the secret number."
                    : "The number entered by the user is less than the secret number.";
                Console.WriteLine(message);
            }
            while(userNumber != randomNumber);

            Console.WriteLine("You have found the secret number.");
        }
    }
}
