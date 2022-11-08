DayTime dayTime = DayTime.Evening;

if (dayTime == DayTime.Evening)
    Console.WriteLine("Добрый вечер");
else
    Console.WriteLine("Привет");


enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}