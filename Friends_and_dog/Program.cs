
Console.WriteLine("Введите скорость движения первого друга:");
double firstFriendspeed = Convert.ToDouble(Console.ReadLine());   // Использование метода Convert для преобразования типа данных string в double.
                                                                  // в случае с int преобразование выглядело бы Convert.Toint32()ю
Console.WriteLine("Введите скорость движения второго друга:");
double secondFriendspeed = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите скорость движения собаки:");
double dogSpeed = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите величину расстояния между друзьями:");
double distance = Convert.ToDouble(Console.ReadLine());


int friend = 2;
int count = 0;
double time = 0;


while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendspeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendspeed + dogSpeed);
        friend = 1;
    }

    distance = distance - (firstFriendspeed + secondFriendspeed) * time;
    count++;

}

Console.WriteLine($"Собака пробежит {count} раз.");
