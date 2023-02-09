int[,] enter_array = new int[4, 4];

Console.WriteLine("Enter array includes tracks between S,1,2,T:");
Console.WriteLine("\nHere is the scheme:");
Console.WriteLine("\nC\tS\t1\t2\tT");
Console.WriteLine("\nS\tx\tx\tx\tx");
Console.WriteLine("\n1\tx\tx\tx\tx");
Console.WriteLine("\n2\tx\tx\tx\tx");
Console.WriteLine("\nT\tx\tx\tx\tx");
Console.WriteLine("\nEnter array:");

//enter_array[0 ,0] = 2;           //ручное задание массива
//enter_array[0 ,1] = 6;           //ручное задание массива
//enter_array[0, 2] = 7;           //ручное задание массива
//enter_array[0, 3] = 7;           //ручное задание массива
//enter_array[1, 0] = 7;           //ручное задание массива
//enter_array[1, 1] = 4;           //ручное задание массива
//enter_array[1, 2] = 9;           //ручное задание массива
//enter_array[1, 3] = 6;           //ручное задание массива
//enter_array[2, 0] = 3;           //ручное задание массива
//enter_array[2, 1] = 8;           //ручное задание массива
//enter_array[2, 2] = 5;           //ручное задание массива
//enter_array[2, 3] = 8;           //ручное задание массива
//enter_array[3, 0] = 5;           //ручное задание массива
//enter_array[3, 1] = 3;           //ручное задание массива
//enter_array[3, 2] = 8;           //ручное задание массива
//enter_array[3, 3] = 9;           //ручное задание массива

for (int i = 0; i < 4; i++)                                     //задание входного массива генерацией случайных чисел
{                                                               //задание входного массива генерацией случайных чисел
    for (int j = 0; j < 4; j++)                                 //задание входного массива генерацией случайных чисел
    {                                                           //задание входного массива генерацией случайных чисел
        var random_num = new Random().Next(0, 10);              //задание входного массива генерацией случайных чисел
        enter_array[i, j] = random_num;                         //задание входного массива генерацией случайных чисел
    }                                                           //задание входного массива генерацией случайных чисел
}

Console.WriteLine("\nC\tS\t1\t2\tT");
WriteArray();

Console.WriteLine("\nPreparing for C1 iteration");
Console.WriteLine("\nSelecting track to go:");

int maxStringNum = enter_array[0,0];
int maxStringNumStep=1;//temp to assign
for(int j = 1; j < 4; j++)
{
    if (enter_array[0, j] > maxStringNum)
    {
        maxStringNum= enter_array[0, j];
        maxStringNumStep = j;
    }
}
int secondPoint=0;//temp to assign
switch (maxStringNumStep)
{
    case 1:secondPoint= 1; break;
    case 2:secondPoint= 2; break;
    case 3:secondPoint= 3; break;
}
if (secondPoint == 3)
{
    Console.WriteLine("\tS -> T");
}
else
{
    Console.WriteLine("\tS -> "+secondPoint);
}

if (maxStringNumStep == 3)
{
    Console.WriteLine("\nTrack endpoint reached, way is done");
    Console.WriteLine("\nMin value = " + enter_array[0,maxStringNumStep]);
    TrackCalcs(maxStringNumStep);
    Console.WriteLine("\nEntering iteration 1, here is the new array:");
    Console.WriteLine("\nC1\tS\t1\t2\tT");
    WriteArray();
}
else
{

    //////////////////next iteration C3
}







void WriteArray()
{
    Console.WriteLine("\nS \t" + enter_array[0, 0] + "\t" + enter_array[0, 1] + "\t" + enter_array[0, 2] + "\t" + enter_array[0, 3] + "");
    Console.WriteLine("\n1 \t" + enter_array[1, 0] + "\t" + enter_array[1, 1] + "\t" + enter_array[1, 2] + "\t" + enter_array[1, 3] + "");
    Console.WriteLine("\n2 \t" + enter_array[2, 0] + "\t" + enter_array[2, 1] + "\t" + enter_array[2, 2] + "\t" + enter_array[2, 3] + "");
    Console.WriteLine("\nT \t" + enter_array[3, 0] + "\t" + enter_array[3, 1] + "\t" + enter_array[3, 2] + "\t" + enter_array[3, 3] + "");
}
void TrackCalcs(int max)
{
    enter_array[max, 0] += enter_array[0, max];
    enter_array[0, max] = 0;
}