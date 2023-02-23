

Console.WriteLine("Enter array includes tracks between S,1,2,T:");
Console.WriteLine("\nHere is the scheme:");
Console.WriteLine("\nC\tS\t1\t2\tT");
Console.WriteLine("\nS\tx\tx\tx\tx");
Console.WriteLine("\n1\tx\tx\tx\tx");
Console.WriteLine("\n2\tx\tx\tx\tx");
Console.WriteLine("\nT\tx\tx\tx\tx");
Console.WriteLine("\nEnter array:");

int[,] enter_array = new int[4, 4];
enter_array[0, 0] = 0;           //ручное задание массива
enter_array[0, 1] = 3;           //ручное задание массива
enter_array[0, 2] = 2;           //ручное задание массива
enter_array[0, 3] = 3;           //ручное задание массива
enter_array[1, 0] = 1;           //ручное задание массива
enter_array[1, 1] = 0;           //ручное задание массива
enter_array[1, 2] = 5;           //ручное задание массива
enter_array[1, 3] = 4;           //ручное задание массива
enter_array[2, 0] = 4;           //ручное задание массива
enter_array[2, 1] = 3;           //ручное задание массива
enter_array[2, 2] = 0;           //ручное задание массива
enter_array[2, 3] = 1;           //ручное задание массива
enter_array[3, 0] = 6;           //ручное задание массива
enter_array[3, 1] = 5;           //ручное задание массива
enter_array[3, 2] = 2;           //ручное задание массива
enter_array[3, 3] = 0;           //ручное задание массива

int [,] beg_array=new int[4, 4];
beg_array[0, 0] = 0;
beg_array[0, 1] = 3;
beg_array[0, 2] = 2;
beg_array[0, 3] = 3;
beg_array[1, 0] = 1;
beg_array[1, 1] = 0;
beg_array[1, 2] = 5;
beg_array[1, 3] = 4;
beg_array[2, 0] = 4;
beg_array[2, 1] = 3;
beg_array[2, 2] = 0;
beg_array[2, 3] = 1;
beg_array[3, 0] = 6;
beg_array[3, 1] = 5;
beg_array[3, 2] = 2;
beg_array[3, 3] = 0;

Console.WriteLine("\nC\tS\t1\t2\tT");
WriteArray(enter_array);


if (enter_array[0, 3] != 0)
{
    Console.WriteLine("Iteration starting");
    Console.WriteLine("Selected way: S->T");
    int min = enter_array[0, 3];
    Console.WriteLine($"min = {min}");

    enter_array[0, 3] = 0;
    enter_array[3, 0] += min; 
    

    Console.WriteLine("new array:");
    Console.WriteLine("\nC1\tS\t1\t2\tT");
    WriteArray(enter_array);
}

if (enter_array[0, 1] != 0 && enter_array[1, 3] != 0)
{
    Console.WriteLine("Iteration starting");
    Console.WriteLine("Selected way: S->1->T");
    int min1 = enter_array[0, 1];
    int min2 = enter_array[1, 3];
    int min = min1;
    if (min2 < min1)
    {
        min = min2;
    }
    Console.WriteLine($"min = {min}");

    if (enter_array[0, 1] > min)
    {
        enter_array[0, 1] -= min;
    }
    else { enter_array[0, 1] = 0; }

    if (enter_array[1, 3] > min)
    {
        enter_array[1, 3] -= min;
    }
    else { enter_array[1, 3] = 0; }

    enter_array[1, 0] += min;
    enter_array[3, 1] += min;

    Console.WriteLine("new array:");
    Console.WriteLine("\nC2\tS\t1\t2\tT");
    WriteArray(enter_array);
}

if (enter_array[0, 2] != 0 && enter_array[2, 3] != 0)
{
    Console.WriteLine("Iteration starting");
    Console.WriteLine("Selected way: S->2->T");
    int min1 = enter_array[0, 2];
    int min2 = enter_array[2, 3];
    int min = min1;
    if (min2 < min1)
    {
        min = min2;
    }
    Console.WriteLine($"min = {min}");

    if (enter_array[0, 2] > min)
    {
        enter_array[0, 2] -= min;
    }
    else { enter_array[0, 2] = 0; }

    if (enter_array[2, 3] > min)
    {
        enter_array[2, 3] -= min;
    }
    else { enter_array[2, 3] = 0; }

    enter_array[2, 0] += min;
    enter_array[3, 2] += min;

    Console.WriteLine("new array:");
    Console.WriteLine("\nC3\tS\t1\t2\tT");
    WriteArray(enter_array);
}

int iter_num_T = 0;
for (int i = 1; i < 3; i++)
{
    if (enter_array[i, 3] != 0)
    {
        iter_num_T = i;
    }
}
int iter_num_S = 0;
for (int i = 1; i < 3; i++)
{
    if (enter_array[0, i] != 0)
    {
        iter_num_S = i;
    }
}

switch (iter_num_S)
{
    case 1: 
        {
            if (iter_num_T == 1)
            {
                Console.WriteLine("Iteration starting");
                Console.WriteLine("Selected way: S->1->T");
                int min1 = enter_array[0, 1];
                int min2 = enter_array[1, 3];
                int min = min1;
                if (min2 < min1)
                {
                    min = min2;
                }
                Console.WriteLine($"min = {min}");

                if (enter_array[0, 1] > min)
                {
                    enter_array[0, 1] -= min;
                }
                else { enter_array[0, 1] = 0; }

                if (enter_array[1, 3] > min)
                {
                    enter_array[1, 3] -= min;
                }
                else { enter_array[1, 3] = 0; }

                enter_array[1, 0] += min;
                enter_array[3, 1] += min;

                Console.WriteLine("new array:");
                Console.WriteLine("\nC4\tS\t1\t2\tT");
                WriteArray(enter_array);
            }
            if (iter_num_T == 2)
            {
                Console.WriteLine("Iteration starting");
                Console.WriteLine("Selected way: S->1->2->T");
                int[] min = new int[3];
                min[0] = enter_array[0, 1];
                min[1] = enter_array[1, 2];
                min[2] = enter_array[2, 3];
                int minim = min[0];
                foreach (int i in min)
                {
                    if (i < minim)
                    {
                        minim = i;
                    }
                }
                Console.WriteLine($"min = {minim}");

                if (enter_array[0, 1] > minim)
                {
                    enter_array[0, 1] -= minim;
                }
                else { enter_array[0, 1] = 0; }
                enter_array[1, 0] += minim;

                if (enter_array[1, 2] > minim)
                {
                    enter_array[1, 2] -= minim;
                }
                else { enter_array[1, 2] = 0; }
                enter_array[2, 1] += minim;
                
                if (enter_array[2, 3] > minim)
                {
                    enter_array[2, 3] -= minim;
                }
                else { enter_array[2, 3] = 0; }
                enter_array[3, 2] += minim;

                Console.WriteLine("new array:");
                Console.WriteLine("\nC4\tS\t1\t2\tT");
                WriteArray(enter_array);
            }
        }
        break;
    case 2:
        {
            if (iter_num_T == 2)
            {
                Console.WriteLine("Iteration starting");
                Console.WriteLine("Selected way: S->2->T");
                int min1 = enter_array[0, 2];
                int min2 = enter_array[2, 3];
                int min = min1;
                if (min2 < min1)
                {
                    min = min2;
                }
                Console.WriteLine($"min = {min}");

                if (enter_array[0, 2] > min)
                {
                    enter_array[0, 2] -= min;
                }
                else { enter_array[0, 2] = 0; }

                if (enter_array[2, 3] > min)
                {
                    enter_array[2, 3] -= min;
                }
                else { enter_array[2, 3] = 0; }

                enter_array[2, 0] += min;
                enter_array[3, 2] += min;

                Console.WriteLine("new array:");
                Console.WriteLine("\nC4\tS\t1\t2\tT");
                WriteArray(enter_array);
            }
            if (iter_num_T == 1)
            {
                Console.WriteLine("Iteration starting");
                Console.WriteLine("Selected way: S->2->1->T");
                int[] min = new int[3];
                min[0] = enter_array[0, 2];
                min[1] = enter_array[2, 1];
                min[2] = enter_array[1, 3];
                int minim = min[0];
                foreach (int i in min)
                {
                    if (i < minim)
                    {
                        minim = i;
                    }
                }
                Console.WriteLine($"min = {minim}");

                if (enter_array[0, 2] > minim)
                {
                    enter_array[0, 2] -= minim;
                }
                else { enter_array[0, 2] = 0; }
                enter_array[2, 0] += minim;

                if (enter_array[2, 1] > minim)
                {
                    enter_array[2, 1] -= minim;
                }
                else { enter_array[2, 1] = 0; }
                enter_array[1, 2] += minim;

                if (enter_array[1, 3] > minim)
                {
                    enter_array[1, 3] -= minim;
                }
                else { enter_array[1, 3] = 0; }
                enter_array[3, 1] += minim;

                Console.WriteLine("new array:");
                Console.WriteLine("\nC4\tS\t1\t2\tT");
                WriteArray(enter_array);
            }
        }
        break;
}

bool null_string = false;
for (int i = 1; i < 4; i++)
{
    if (enter_array[0, i] == 0)
    {
        null_string = true;
    }
}
if (null_string == false)
{
    for (int i = 1; i < 4; i++)
    {
        if (enter_array[i, 3] == 0)
        {
            null_string = true;
        }
    }
}

if (null_string == true)
{
    Console.WriteLine("Here is C* array");
    Console.WriteLine("\nC*\tS\t1\t2\tT");
    WriteArray(enter_array);
 
    Console.WriteLine("Building X array");
    int[,] X=new int[4, 4];
    X = enter_array;
   
    Console.WriteLine("\nX\tS\t1\t2\tT");

    for(int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (beg_array[i, j] > X[i, j])
            {
                X[i, j] = beg_array[i, j] - enter_array[i,j];
            }
            else{ X[i, j] = 0; }
        }
    }   

    WriteArray(X);
    int mf = 0;
    for(int i = 0; i < 4; i++)
    {
        mf += X[0, i];
    }
    Console.WriteLine("max flow:" + mf);
}
void WriteArray(int[,] e) 
{
    Console.WriteLine($"\nS\t{e[0,0]}\t{e[0,1]}\t{e[0,2]}\t{e[0,3]}");
    Console.WriteLine($"\n1\t{e[1,0]}\t{e[1,1]}\t{e[1,2]}\t{e[1,3]}");
    Console.WriteLine($"\n2\t{e[2,0]}\t{e[2,1]}\t{e[2,2]}\t{e[2,3]}");
    Console.WriteLine($"\nT\t{e[3,0]}\t{e[3,1]}\t{e[3,2]}\t{e[3,3]}");
}