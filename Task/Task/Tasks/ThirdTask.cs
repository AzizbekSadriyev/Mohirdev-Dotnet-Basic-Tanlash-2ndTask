// O'rtacha ballni hisoblash:

/*
Foydalanuvchidan uchta fan bo'yicha (0 dan 100 gacha) baholarni so'raydigan va ularning o'rtacha ballini hisoblaydigan dastur yozing. Keyin dastur natija haqida xabarni ko'rsatadi: "A'lo" (o'rtacha ball 80 dan 100 gacha), "Yaxshi" (o'rtacha ball 60 dan 79 gacha), "Qoniqarli" (o'rtacha ball 40 dan 59 gacha) yoki "Qoniqarsiz" ( o'rtacha ball 40 dan kam). Shartlarni tekshirish uchun ternary operatoridan foydalaning.
*/

namespace Task
{
    public class ThirdTask
    {
        public static void Task()
        {
            Console.WriteLine("Enter 3 subject names: ");

            Console.Write("1. ");
            string? firstSubject = Console.ReadLine();

            Console.Write("2. ");
            string? secondSubject = Console.ReadLine();

            Console.Write("3. ");
            string? thirdSubject = Console.ReadLine();

            Console.Write($"Enter grade for {firstSubject}: ");
            int firstGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter grade for {secondSubject}: ");
            int secondGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter grade for {thirdSubject}: ");
            int thirdGrade = Convert.ToInt32(Console.ReadLine());

            int averageGrade = (firstGrade + secondGrade + thirdGrade) / 3;

            string typeGrade =
                averageGrade >= 80 && 100 >= averageGrade
                    ? "Excellent"
                    : averageGrade >= 60 && 79 >= averageGrade
                        ? "Good"
                        : averageGrade >= 40 && 59 >= averageGrade
                            ? "Not Bad"
                            : "Bad";

            Console.WriteLine($"Your average grade: {averageGrade}\nThis is: \"{typeGrade}\"");
        }
    }
}
