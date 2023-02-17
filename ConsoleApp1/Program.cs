using System.Security.Cryptography.X509Certificates;

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
int [,] beg_array=new int[4, 4];
for (int i = 0; i < 4; i++)                                     //задание входного массива генерацией случайных чисел
{                                                               //задание входного массива генерацией случайных чисел
    for (int j = 0; j < 4; j++)                                 //задание входного массива генерацией случайных чисел
    {                                                           //задание входного массива генерацией случайных чисел
        var random_num = new Random().Next(0, 10);              //задание входного массива генерацией случайных чисел
        enter_array[i, j] = random_num;   
        beg_array[i, j] = random_num;                           //задание входного массива генерацией случайных чисел
    }                                                           //задание входного массива генерацией случайных чисел
}


//beg_array = enter_array;

int firstMove = 0;
int secondMove = 0;
int wrongfirstMove = 0;
int wrongsecondMove = 0;
beg:////////////////////////////////////////////////////////////////
int wrong_iter = 0;
Console.WriteLine("\nC\tS\t1\t2\tT");
WriteArray(enter_array);


    if (enter_array[0, 1] == 0&& enter_array[0, 2] ==0 && enter_array[0, 3] == 0)
    {
    goto X;
    }
if (enter_array[0, 3] == 0 && enter_array[1, 3] == 0 && enter_array[2, 3] == 0)
{
    goto X;
}
Console.WriteLine("\nPreparing for iteration");
Console.WriteLine("\nSelecting track to go:");

int[] quta = new int[3];
string[] chars= new string[3];

///////////////////////////////////////////////////первая итерация
int maxStringNum = enter_array[0, 1];
int maxStringNumStep = 1;//temp to assign
for (int j = 1; j < 4; j++)
{
    if (j == wrongfirstMove)
    {
        j++;
    }
    if (enter_array[0, j] > maxStringNum)
    {
        maxStringNum = enter_array[0, j];
        maxStringNumStep = j;
        //quta[0] = enter_array[0, j];
    }
    
}
int secondPoint = 0;//temp to assign
A: 
switch (maxStringNumStep)
{
    case 1: secondPoint = 1; quta[0]= enter_array[0, 1]; firstMove = 1;
        if (enter_array[0, 1] == 0) { maxStringNumStep = 2; secondPoint = 2; goto A; }
        if (enter_array[1, 3] == 0) { maxStringNumStep = 2; secondPoint = 2;goto A; }
        if (enter_array[1, 3] == 0&& enter_array[2, 3] == 0 ) { maxStringNumStep = 3; secondPoint = 3; goto A; }
        break;
    case 2: secondPoint = 2; quta[0] = enter_array[0, 2]; firstMove = 2;
        if (enter_array[0, 2] == 0) { maxStringNumStep = 1; secondPoint = 1; goto A; }
        if (enter_array[2, 3] == 0) { maxStringNumStep = 1; secondPoint = 1; goto A; }
        if (enter_array[1, 3] == 0 && enter_array[2, 3] == 0) { maxStringNumStep = 3; secondPoint = 3; goto A; }
        break;
    case 3: secondPoint = 3; quta[0] = enter_array[0, 3]; firstMove = 3; break;
}
if (secondPoint == 3 || (enter_array[1,3]==0&& enter_array[2, 3] == 0  ))
{ 
    Console.WriteLine("S -> T");
    chars[0] = "T";
    //quta[1] = 11;
    //quta[2] = 11;
}
else
{
    Console.WriteLine("S -> " + secondPoint);
    chars[0] = secondPoint.ToString();
}

switch (maxStringNumStep)
{
    case 1:
        {
            maxStringNum = enter_array[1, 2];
            maxStringNumStep = 2;//temp to assign              
            for (int j = 2; j < 4; j++)
            {
                if (j == wrongsecondMove)
                {
                    j++;
                }
                if (enter_array[1, j] > maxStringNum)
                {
                    maxStringNum = enter_array[1, j];
                    maxStringNumStep = j;
                    switch (j)
                    {
                        case 2:
                            {
                                if (enter_array[2, 3] == 0)
                                {
                                    maxStringNumStep = 3;
                                    if(wrong_iter==1)
                                    wrongsecondMove = secondMove;
                                }
                            }
                            break;
                        case 3:
                            {
                                if (enter_array[3, 3] == 0)
                                {
                                    maxStringNumStep = 2;
                                    if (wrong_iter == 1)
                                        wrongsecondMove = secondMove;
                                }
                            }
                            break;
                    }
                }
            }
            secondPoint = 0;//temp to assign
            switch (maxStringNumStep)
            {
                case 2: secondPoint = 2; quta[1] = enter_array[1, maxStringNumStep]; chars[1] = secondPoint.ToString(); secondMove = 2;
                    if (enter_array[2, 3] == 0) { maxStringNumStep = 3; secondPoint = 3; }
                    break;
                case 3: secondPoint = 3; quta[1] = enter_array[1, maxStringNumStep]; chars[1] = secondPoint.ToString(); chars[2] = "N"; secondMove = 3;
        break;
            }
            if (secondPoint == 3)
            {
                if (enter_array[maxStringNumStep, 3] == 0)
                {
                    wrongfirstMove = firstMove;
                    wrongsecondMove= secondMove;
                    goto beg;
                }
    chars[2] = "T";
    Console.Write("-> T");
                Console.WriteLine("\nTrack endpoint reached, way is done");
                quta[2] = 11;
   
    //smol_iter_2 = 3;
    //Console.WriteLine("\nMin value = " + enter_array[0, maxStringNumStep]);
    //TrackCalcs(maxStringNumStep);
    //Console.WriteLine("\nEntering iteration 1, here is the new array:");
    //Console.WriteLine("\nC1\tS\t1\t2\tT");
    //WriteArray();

}
            else
            {
                if (enter_array[1, 3] == 0)
                {
                    wrongsecondMove = secondMove;
                }
                chars[2] = "T";
    Console.Write("-> " + secondPoint);
                // smol_iter_2 = secondPoint;
quta[2] = enter_array[secondPoint,3];
                Console.Write("\n-> T");
                Console.WriteLine("\nTrack endpoint reached, way is done");
            }

        }
        break;
    case 2:
        {
            maxStringNum = enter_array[2, 1];
            maxStringNumStep = 1;//temp to assign              
            for (int j = 1; j < 4; j++)
            {
                if (j == wrongsecondMove)
                {
                    j++;
                }
                if (enter_array[2, j] > maxStringNum)
                {
                    if (j != 2)
                    {
                        maxStringNum = enter_array[2, j];
                        maxStringNumStep = j;
                        switch (j)
                        {
                            case 1:
                                {
                                    if (enter_array[1, 3] == 0)
                                    {
                                        maxStringNumStep = 3;
                                        //if (enter_array[2,3])
                                        //{
                                        if(wrong_iter == 1)
                                        wrongsecondMove = secondMove;
                                        //    wrongfirstMove= firstMove;
                                        //}
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (enter_array[3, 3] == 0)
                                    {
                                         maxStringNumStep = 1;
                                        if(wrong_iter == 1)
                                        wrongsecondMove = secondMove;
                                    }
                                }
                                break;
                        }
                        
                    }
                }
            }
            secondPoint = 0;//temp to assign
            switch (maxStringNumStep)
            {
                case 1: secondPoint = 1;quta[1] = enter_array[2, maxStringNumStep]; chars[1] = secondPoint.ToString(); secondMove = 1;
                    if (enter_array[1,3]==0) { maxStringNumStep = 3;secondPoint = 3; } break;
                case 3: secondPoint = 3; quta[1] = enter_array[2, maxStringNumStep] ; chars[1] = secondPoint.ToString(); chars[2] = "N"; secondMove = 3;break;
            }
            if (secondPoint == 3)
            {
                if (enter_array[maxStringNumStep, 3] == 0)
                {
                    wrongfirstMove = firstMove;
                    wrongsecondMove = secondMove;
                    goto beg;
                }
                quta[2] = 11;
    chars[2] = "T";
                Console.Write("-> T");
                //smol_iter_2 = 3;
                Console.WriteLine("\nTrack endpoint reached, way is done");
                //Console.WriteLine("\nMin value = " + enter_array[0, maxStringNumStep]);
                //TrackCalcs(maxStringNumStep);
                //Console.WriteLine("\nEntering iteration 1, here is the new array:");
                //Console.WriteLine("\nC1\tS\t1\t2\tT");
                //WriteArray();
                //
            }
            else
            {
                if (enter_array[2, 3] == 0)
                {
                    wrongsecondMove = secondMove;
                }
        chars[2] = "T";
                        quta[2] = enter_array[secondPoint, 3];
                Console.Write("-> " + secondPoint);
                //smol_iter_2 = secondPoint;
                Console.Write("\n-> T");
                Console.WriteLine("\nTrack endpoint reached, way is done");
            }


        }
        break;
    case 3:
        {
            
            quta[1] = 111;
            quta[2] = 111;
    chars[1] = secondPoint.ToString(); chars[2] = "T"; 
    Console.WriteLine("\nTrack endpoint reached, way is done");
            //smol_iter_2= 0;
            //Console.WriteLine("\nMin value = " + enter_array[0,maxStringNumStep]);
            //TrackCalcs(maxStringNumStep);
            //Console.WriteLine("\nEntering iteration 1, here is the new array:");
            //Console.WriteLine("\nC1\tS\t1\t2\tT");
            //WriteArray();
        }
        break;

}

int min = 10;
foreach (var q in quta)
{
    Console.Write(q.ToString()+",");
    if (q < min)
    {
        min = q;
    }
}


//    if (quta[2] == 0)
//{
//    if (quta[1] == 0) 
//    {
//        wrongMove = firstMove;
//    }

//}
Console.WriteLine("min =" + min);

if (min == 0)
{
    if (wrong_iter == 1)
    {
          wrongsecondMove = secondMove;
    }
  
wrongfirstMove = firstMove;
    wrong_iter++;

    goto beg;
}
Console.WriteLine("Way =");
foreach (var ch in chars)
{
    Console.WriteLine(ch + ',');
}

////////////////действия в массиве
int char0 = 0;
int char1 = 0;
switch (chars[0])
{
    case "1":
        {
            char0 = 1;
            if (enter_array[0, 1] >= min)
            {
                enter_array[0, 1] -= min;
            }
            else { enter_array[0, 1] = 0; }
           
            enter_array[1, 0] += min;
        }
        break;
    case "2":
        {
            char0 = 2;
            if (enter_array[0, 2] >= min)
            {
                enter_array[0, 2] -= min;
            }
            else { enter_array[0, 2] = 0; }

            enter_array[2, 0] += min;
        } 
        break;
    case "3" or "T" or null:
        {
            if (enter_array[0, 3] == 0)
            {
                wrongfirstMove = firstMove;goto beg;
            }

            if (enter_array[0, 3] >= min)
            {
                enter_array[0, 3] -= min;
            }
            else { enter_array[0, 3] = 0; }

            enter_array[3, 0] += min;

            goto next;
        }
        break;
       
}
switch (chars[1])
{
    case "1":
        {
            char1 = 1;
            if (enter_array[char0, 1] >= min)
            {
                enter_array[char0, 1] -= min;
            }
            else { enter_array[char0, 1] = 0; }

            enter_array[1, char0] += min;
        }
        break;
    case "2":
        {
            char1 = 2;
            if (enter_array[char0, 2] >= min)
            {
                enter_array[char0, 2] -= min;
            }
            else { enter_array[char0, 2] = 0; }

            enter_array[2, char0] += min;
        }
        break;
    case "3" or "T" or null:
        {
            char1 = 3;
            if (enter_array[char0, 3] == 0)
            {
                wrongfirstMove = firstMove; goto beg;
            }

            if (enter_array[char0, 3] >= min)
            {
                enter_array[char0, 3] -= min;
            }
            else { enter_array[char0, 3] = 0; }

            enter_array[3, char0] += min;
            goto next;
        }
        break;

}
switch (chars[2])
{
    case "1":
        {
            if (enter_array[char1, 1] >= min)
            {
                enter_array[char1, 1] -= min;
            }
            else { enter_array[char1, 1] = 0; }

            enter_array[1, char1] += min;
        }
        break;
    case "2":
        {
            if (enter_array[char1, 2] >= min)
            {
                enter_array[char1, 2] -= min;
            }
            else { enter_array[char1, 2] = 0; }

            enter_array[2, char1] += min;
        }
        break;
    case "3" or "T" or null:
        {
            if (enter_array[char1, 3]==0)
            {
                wrongsecondMove = secondMove;
                wrongfirstMove = firstMove; goto beg;
            }

            if (enter_array[char1, 3] >= min)
            {
                enter_array[char1, 3] -= min;
            }
            else { enter_array[char1, 3] = 0; }

            enter_array[3, char1] += min;
            goto next;
        }
        break;

}
next:
goto beg;
//////////////////////////////////////////////////////////////////////////////////////////////////
X:
Console.WriteLine("\n\nC*\tS\t1\t2\tT");
WriteArray(enter_array);
Console.WriteLine("\nC* array, making X");
int[,] x_array = new int[4, 4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (beg_array[i, j] >= enter_array[i, j])
        {
            x_array[i, j] = beg_array[i, j] - enter_array[i, j];
        }
        else
        {
            x_array[i, j] = 0;
        }

    }
}

Console.WriteLine("\nX\tS\t1\t2\tT");
WriteArray(x_array);
int fs = 0;
for (int i = 0; i < 4; i++)
{
    fs += x_array[0, i];
}
Console.WriteLine("max net flow: (1st string)"+fs);
///////////////////////////////////////////////////////////////////////////////////////////////////
void WriteArray(int[,] enter_array)
{
    Console.WriteLine("\nS \t" + enter_array[0, 0] + "\t" + enter_array[0, 1] + "\t" + enter_array[0, 2] + "\t" + enter_array[0, 3] + "");
    Console.WriteLine("\n1 \t" + enter_array[1, 0] + "\t" + enter_array[1, 1] + "\t" + enter_array[1, 2] + "\t" + enter_array[1, 3] + "");
    Console.WriteLine("\n2 \t" + enter_array[2, 0] + "\t" + enter_array[2, 1] + "\t" + enter_array[2, 2] + "\t" + enter_array[2, 3] + "");
    Console.WriteLine("\nT \t" + enter_array[3, 0] + "\t" + enter_array[3, 1] + "\t" + enter_array[3, 2] + "\t" + enter_array[3, 3] + "");
}