void FillArray(int[] collection)                  //**ПЕРВЫЙ МЕТОД**: чтобы в строке 40 массив был заполнен не нулями, а случайными числами; collection - название аргумента (название массива)
{
  int length = collection.Length;                 //length - получить длину массива при помощи оператора .Length
  int index = 0;
  while (index < length)                          //пока index<length делаем
  {
    collection[index] = new Random().Next(1, 10);     //обратиться к аргументу массива collection на позиции index и положить туда случайное число от [1 до 10)
    index++;                                        //следующий элемент массива
  }
}

void PrintArray(int[] col)                        //**ВТОРОЙ МЕТОД**: метод void - который будет печатать какой-то массив с названием col
{
  int count = col.Length;                         //кол-во элементов этого массива col - по смыслу текущая строка 14 равна смыслу строки 3
  int position = 0;                               //позиция в массиве (вместо index) - по смыслу текущая строка 15 равна смыслу строки 4
  while (position < count)
  {
    Console.WriteLine(col[position]);             //вывод на экран Терминала значение элемента массива
    position++;                                   //следующий элемент массива
  }
}

int IndexOf(int[] collection, int find)           //метод отличный от void с названием IndexOf() для нахождения нужного элемента find массива collection с определением его индекса в массиве
{
  int count = collection.Length;                    //определить кол-во элементов count
  int index = 0;                                    //начальный index
  int position = -1;                                 //индекс обнаруженного или не обнаруженного элемента find; -1 означает что элемент не обнаружен
  while (index < count)                             //пока index<count
  {
    if (collection[index] == find)                     //если элемент массива равен искомому чмслу find
    {
      position = index;
      break;                                        //остановиться как только найдешь первое find, без этой команды выдает последнее вхождение
    }
    index++;                                        //следубщий index
  }
  return position;
}

int[] array = new int[10];                        //создать массив, в котором будет 10 элементов (по умолчанию будет заполнен нулями)

FillArray(array);                                 //вызвали метод FillArray который заполнил нам массив
array[4] = 4;
array[6] = 4;                                     //принудительно в заполненном случайными числами массиве заменили значения на 4 и 6 позициях
PrintArray(array);                                //вызвали метод PrintArray который вывел на экран заполненные строкой выше элементы массива
Console.WriteLine();                              //пустая строчка чтобы отделить массив от индекса искомого элемента

int pos = IndexOf(array, 9);                      //определили переменную pos = (индекс искомого элемента, задать искомый элемент)
Console.WriteLine(pos);