Console.Clear();              //затем dotnet run - и очистится терминал
// Console.SetCursorPosition(10, 4);   //будет рисовать (отступ слева, сверху)
// Console.WriteLine("+");


// int xa = 1;                  //оределить вершину треугольника - по оси х=1 символ
// int ya = 1;
// int xb = 1;
// int yb = 30;
int xa = 40, ya = 1,             //другой вариант форматирования
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;                //местоположение первой точки (для определенности)

int count = 0;                    //изначально счетчик =0

while (count < 10000)                 //сколько раз найти отрезок и поделить его пополам
{
  int what = new Random().Next(0, 3);   //сгенерить случайное число "what" и выбирать одну из 3-х точек (Next(0,3)значит полуинтервал[0,3) включающий 0,1,2
  if (what == 0)                     //если случайное число=0, то в х положить середину отрезка
  {
    x = (x + xa) / 2;
    y = (y + ya) / 2;
  }

  if (what == 1)
  {
    x = (x + xb) / 2;
    y = (y + yb) / 2;
  }

 if (what == 2)
  {
    x = (x + xc) / 2;
    y = (y + yc) / 2;
  }

  Console.SetCursorPosition(x, y);
  Console.WriteLine("+");
  count = count + 1;                        //равнозначная команда count +=1 или count++
}