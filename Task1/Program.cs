// Урок 4. Функции
// Задача 777

// 1. Ввод N int <- (string)
int GetVal(string text)
{
  return Convert.ToInt32(text);
}
// 2. Создание массива
int[] CreateArray(int size)
{
  int[] array = new int[size];
  return array;
}
// 3. Заполнение массива
void FillArray(int[] array)
{
  int length = array.Length;
  array[0] = 1;
  for (int index = 1; index < length; index++)
  {
    array[index] = new Random().Next(0, 2);
    index++;
  }
}
// 4. Печать
string PrintArray(int[] array)
{
  string sed = String.Empty;

  for (int j = 0; j < array.Length; j++)
  {
    sed = sed + array[j];
  }
  return sed;
}
// 5. Конвертация
int ToDes(int[] array)
{
  int des = 0;
  for (int r = 0; r < array.Length; r++)
  {
    des = des + (int)(array[r] * Math.Pow(2, array.Length - 1 - r));
  }
  return des;
}
//6. Принимает массив
string SevPrint(int des)
{
  return $"десятичное число {des}";
}
Console.WriteLine("Введите длину массива: ");
int length = GetVal(Console.ReadLine());
int[] numbers = CreateArray(length);
FillArray(numbers);
Console.WriteLine(PrintArray(numbers));
int des = ToDes(numbers);
Console.WriteLine(SevPrint(des));