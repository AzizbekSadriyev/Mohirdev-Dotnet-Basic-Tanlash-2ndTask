// Yosh toifasini aniqlash:

/*
Foydalanuvchining yoshini so'ragan va uning yosh toifasini aniqlaydigan dastur yarating: "bola" (0-12 yosh), "o'smir" (13-19 yosh), "kattalar" (20-59 yosh) yoki " katta” (60 yosh) va undan katta). Bu vazifa uchun if-else iboralaridan foydalaning.
*/

namespace Task
{
    public class SecondTask
    {
        public static void Task()
        {
            Console.Write("Foydalanuvchi yoshini kiriting: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string ageCategory;

            if(age >= 0 && 12 >= age)
            {
                ageCategory = "Child";
            }
            else if(age >= 13 && 19 >= age)
            {
                ageCategory = "Young";
            }
            else if(age >= 20 && 59 >= age)
            {
                ageCategory = "Adult";
            }
            else if(age >= 60)
            {
                ageCategory = "Seniors";
            }
            else
            {
                ageCategory = "Category Not Found";
            }

            Console.WriteLine($"{age} age category: {ageCategory}");
        }
    }
}
