//Найти максимум из 9 чисел
int Max(int arg1, int arg2, int arg3)                     // int a1 = 15;
{                                                          // int b1 = 21; 
  int result = arg1;                                       // int c1 = 39;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;                         // int a2 = 12;
  return result;                                           // int b2 = 2311;                                         
}                                                          // int c2 = 33;

int a1 = 15;                                               // int a3 = 13;        
int b1 = 21;                                               // int b3 = 23;
int c1 = 39;                                               // int c3 = 313;

int a2 = 12;                                               // int max = a1; 
int b2 = 2311;                                             // if(b1 > max) max = b1;
int c2 = 33;                                               // if(c1 > max) max = c1;

int a3 = 13;                                               // if(a2 >max) max = a2;
int b3 = 23;                                               // if(b2 > max) max = b2;
int c3 = 313;                                              // if(c2 > max) max = c2;

//int max1 = Max(a1, b1, c1);                                // if(a3 >max) max = a3;
//int max2 = Max(a2, b2, c2);                                // if(b3 > max) max = b3;
//int max3 = Max(a3, b3, c3);                                // if(c3 > max) max = c3;
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);                                    // Console.WriteLine(max);



