// //int age = 15;
// //if (age >= 18) {
//     //Console.WriteLine("Доступ разрешён");
// //}
// //Console.WriteLine( "Программа продолжает работу");


// // int age = 15;
// // if (age >= 18) {
// //     Console.WriteLine("Доступ разрешён");
// // } else {
// // Console.WriteLine("Доступ запрещён");
// // Console.WriteLine($"До совершеннолетия осталось ждать: {18 - age} лет");
// // }


// // int age = 100;
// // if (age < 13) {
// //     Console.WriteLine("Ребёнок");
// // } else if (age < 18) {
// //     Console.WriteLine("Подросток");
// // } else if (age < 60) {
// //     Console.WriteLine("Взрослый");
// // } else {
// //     Console.WriteLine("Пенсионер");
// // }


// int age = 16;
// double height = 1.55;
// bool hasAdult = true; 

// if (age >= 14 && (height >= 1.5 || hasAdult)) {
//     Console.WriteLine("Можно кататься");
// } else
// {
//     Console.WriteLine("Пока нельзя");
// }


//ЗАДАЧА А
// Console.WriteLine();
// Console.WriteLine("Чётное или нечётное");

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// if (number % 2 == 0) {
//     Console.WriteLine("Число чётное");
// } else {
    
//     Console.WriteLine("Число нечётное");
// }


// ЗАДАЧА Б
Console.WriteLine();
Console.WriteLine("Оценка");

Console.Write("Введите оценку (2-5): ");
int grade = int.Parse(Console.ReadLine());

if (grade == 5) {
    Console.WriteLine("Отлично");
} else if (grade == 4) {
    Console.WriteLine("Хорошо");
} else if (grade == 3) {
    Console.WriteLine("Удовлетворительно");
} else if (grade == 2) {
    Console.WriteLine("Неудовлетворительно");
} else {
    Console.WriteLine("Неверная оценка");
}

