// Первая группа методов

void Metod1()
{
Console.WriteLine("Автор …");
}
// Metod1();

// Вторая группа методов с аргументами

void Metod2(string msg)
{
Console.WriteLine(msg);
}
// Metod2("Текст сообщения");
// Metod2(msg: "Текст сообщения"); // явно указываем присвоение

void Metod21(string msg, int count)
{
int i = 0;
	while (i < count)
	{
	// где переменная count отображает на экране определённое количество сообщений msg
	Console.WriteLine(msg); 
	i++;
	}
}
// Metod21("Текст", 4);
// Metod21(msg: "новый текст", count: 4); // явно указываем присвоение

// Третья группа методов
// Эти методы, которые что-то возвращают, но ничего не принимают. Если метод что-то
// возвращает, мы в обязательном порядке должны указать тип данных, значение которого
// ожидаем.

int Metod3()
{
return DateTime.Now.Year; // обязательное использование оператора return
}
int year = Metod3(); // вызываем метод, в левой части используем идентификатор 
// переменной (year) и через оператор присваивания (=) кладём нужное значение
// Console.WriteLine(year);


// Четвёртая группа методов
// Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают.

// с циклом while

string Metod4(int count, string text)
{
	int i = 0;
	string result = String.Empty; // пустая строка
	while (i < count)
	{
	result = result + text;
	i++;
	}
	return result;
}
string res = Metod4(10, "asdf"); // 10 раз выйдет asdf
// Console.WriteLine(res);

//с циклом for

string Metod41(int count, string text)
{
	string result = String.Empty;
	for(int i = 0; i<count; i++)
	{
	result = result + text;
	}
	return result;
}
string resu = Metod41(10, "метод 41");
// Console.WriteLine(resu);