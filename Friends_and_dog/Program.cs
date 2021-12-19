Console.WriteLine("Введите скорость движения первого друга:");
int firstFriendspeed = Convert.ToInt32(Console.ReadLine());   // Использование метода Convert для преобразования типа данных string в int.

Console.WriteLine("Введите скорость движения второго друга:");
int secondFriendspeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите скорость движения собаки:");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите величину расстояния между друзьями:");
int distance = Convert.ToInt32(Console.ReadLine());


int friend = 2;
int count = 0;
int time = 0;


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
