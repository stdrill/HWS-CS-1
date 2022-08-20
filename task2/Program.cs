// По заданному номеру дня недели вывести его название

string[] arrayWeek = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
Console.Write("Введите порядковый номер: ");
int numWeek = Convert.ToInt32(Console.ReadLine());
if (numWeek <= arrayWeek.Length && numWeek > 0){
    Console.WriteLine(arrayWeek[numWeek - 1]);
} else {
    Console.WriteLine("Введеное число не совпадает с днем недели");
}
