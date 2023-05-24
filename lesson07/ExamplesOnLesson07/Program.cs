// Собираем строку с числами от a до b, a≤b
string NumbersFor1(int a, int b)
{
  string result = string.Empty;
  for (int i = a; i <= b; i++)
  {
    result += $"{i} ";
  }
  return result;
}

string NumbersRec1(int a, int b)
{
  if (a <= b) return $"{a} " + NumbersRec1(a + 1, b);
  else return string.Empty;
}
// System.Console.WriteLine(NumbersFor1(1, 10));
// System.Console.WriteLine(NumbersRec1(1, 10));

// Собираем строку с числами от a до b, a>=b
string NumbersFor2(int a, int b)
{
  string result = string.Empty;
  for (int i = b; i >= a; i--)
  {
    result += $"{i} ";
  }
  return result;
}

string NumbersRec2(int a, int b)
{
  if (b >= a) return NumbersRec2(a + 1, b) + $"{a} ";
  else return string.Empty;
}
// System.Console.WriteLine(NumbersFor2(1, 10));
// System.Console.WriteLine(NumbersRec2(1, 10));

// Сумма чисел от 1 до n
int SumFor1(int n)
{
  int result = 0;
  for (int i = 0; i <= n; i++) result +=i;
  return result;
}

int SumRec1(int n)
{
  if (n == 0) return 0;
  else return n + SumRec1(n - 1);
}
// System.Console.WriteLine(SumFor1(10));
// System.Console.WriteLine(SumRec1(10));

// Факториал числа
int FactorialFor(int n)
{
  int result = 1;
  for (int i = 1; i <= n; i++) result *= i;
  return result;
}

int FactorialRec(int n)
{
  if (n == 1) return 1;
  else return n * FactorialRec(n - 1);
}
// System.Console.WriteLine(FactorialFor(10));
// System.Console.WriteLine(FactorialRec(10));

// Вычислить a в степени n
int PowFor(int a, int n)
{
  int result = 1;
  for (int i = 1; i <= n; i++) result *= a;
  return result;
}

int PowRec(int a, int n)
{
  return n == 0 ? 1 : PowRec(a, n - 1) * a;
}

int PowRecMath(int a, int n)
{
  if (n == 0) return 1;
  else if (n % 2 == 0) return PowRecMath(a * a, n / 2);
  else return PowRecMath(a, n - 1) * a;
}
// System.Console.WriteLine(PowFor(2, 10));
// System.Console.WriteLine(PowRec(2, 10));
// System.Console.WriteLine(PowRecMath(3, 10));

// Перебор слов: Пусть у нас будет некоторый алфавит, состоящий из
// четырёх букв, и нас просят показать все возможные слова, состоящие из T букв. Т может
// равняться 1, 2, 3 и так далее
int n = 0;
  void FindWords(string alphabet, char[] word, int length = 0)
  {
    if (length == word.Length)
    { System.Console.WriteLine($"{n++} {new String (word)}"); return;}
    for (int i = 0; i < alphabet.Length; i++)
    {
      word[length] = alphabet[i];
      FindWords(alphabet, word, length + 1);
    }
  }
// FindWords("abcd", new char[3]); // 63 варианта перебора этих 4 букв в 3 степени

// алгоритм обхода директории
string path01 = "/Users/ElenaD/Documents/01_DEVGB/03_Знакомство с языком C#/lesson06/hw06/hw06_task01";
DirectoryInfo di = new DirectoryInfo(path01);
// System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
  // System.Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "")
{
  DirectoryInfo catalog = new DirectoryInfo(path);

  DirectoryInfo[] catalogs = catalog.GetDirectories();
  for (int i = 0; i < catalogs.Length; i++)
  {
    System.Console.WriteLine($"{indent}{catalogs[i].Name}");
    CatalogInfo(catalogs[i].FullName, indent + " ");
  }
  FileInfo[] files = catalog.GetFiles();

  for (int i = 0; i < files.Length; i++)
  {
    System.Console.WriteLine($"{indent}{files[i].Name}");
  }
}
string path02 = @"/Users/ElenaD/Documents/01_DEVGB/03_Знакомство с языком C#/lesson06/hw06";
// CatalogInfo(path02);

// Игра Башни
void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
{
  if (count > 1) Towers(with, some, on, count - 1);
  Console.WriteLine($"{with} >> {on}");
  if (count > 1) Towers(some, on, with, count - 1);
}
// Towers();

// Обход разных структур
// ((4 - 2) * (1 + 3)) / 10
string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                  0   1    2     3    4     5   6     7   8     9   10   11
void InOrderTraversal(int pos = 1) // позиция, с которой делаем обход
{
  if (pos < tree.Length)
  {
    int left = 2 * pos;
    int right = 2 * pos + 1;
    // если позиция слева есть и она не пустая
    if (left < tree.Length && !string.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
    System.Console.WriteLine(tree[pos]);
    if (right < tree.Length && !string.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
  }
}
  // InOrderTraversal();

