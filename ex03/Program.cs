System.Console.Write("Введите номер дня недели: ");
string value = Console.ReadLine ();
int day = int.Parse(value); // преобразовали строку в число
if (day == 1) System.Console.WriteLine("Это понедельник");
if (day == 2) System.Console.WriteLine("Это вторник");
 if (day == 3) System.Console.WriteLine("Это среда");
 if (day == 4) System.Console.WriteLine("Это четверг");
 if (day == 5) System.Console.WriteLine("Это пятница");
 if (day == 6) System.Console.WriteLine("Это суббота");
 if (day == 7) System.Console.WriteLine("Это воскресенье");
