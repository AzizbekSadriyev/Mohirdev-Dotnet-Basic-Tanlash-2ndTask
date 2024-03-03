// Vaqt kalkulyatori: 

/*
Kirish sifatida daqiqalar sonini oladigan va uni soat:daqiqa formatida chiqaradigan dastur yozing. Misol uchun, agar foydalanuvchi 135 daqiqani kiritsa, dastur "2:15" chiqishi kerak. Hisoblash uchun arifmetik amallardan foydalaning.
*/

namespace Task
{
    public class FirstTask
    {
        public static void Task()
        {
            Console.Write("Enter the minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Time is {minutes/60}:{minutes%60}");
        }
    }
}
