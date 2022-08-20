string[] arrayWeek = {"Понедельник","Вторник","Среда","Четверг","Пятинца","Суббота","Воскресенье"};
int numWeek = Convert.ToInt32(Console.ReadLine());
if (numWeek < arrayWeek.Length && numWeek > 0){
    Console.WriteLine(arrayWeek[numWeek - 1]);
} else {
    Console.WriteLine("Введеное число не совпадает с днем недели");
}
