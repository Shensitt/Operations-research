using System.Windows.Forms;
using WindowsForms2;
Console.WriteLine("4 states, any amount of shots");
///state 1- system is 100 health
///state 2- system is slightly damaged
///state 3- system is heavily damaged
///state 4- system is destroyed

double[,] p = new double[5, 5];
p[1, 1] = 0.1;
p[1, 2] = 0.5;
p[1, 3] = 0.3;
p[1, 4] = 0.1;
p[2, 1] = 0;
p[2, 2] = 0.2;
p[2, 3] = 0.5;
p[2, 4] = 0.3;
p[3, 1] = 0;
p[3, 2] = 0;
p[3, 3] = 0.3;
p[3, 4] = 0.7;
p[4, 1] = 0;
p[4, 2] = 0;
p[4, 3] = 0;
p[4, 4] = 1;

List<double[]> shot= new List<double[]>();

double[] shot0= { 1,0,0,0};
shot.Add(shot0);

double[] shot1 = { p[1, 1], p[1, 2], p[1, 3], p[1,4] };
shot.Add(shot1);

Console.WriteLine("Choose program mode: (1)graph (2)answer");
string mode = Console.ReadLine();
int md = 0;
if (!int.TryParse(mode, out md))
{
    // Parsing failed error
}
if (md == 1)
{
Console.WriteLine("write number of shots");
string shots=Console.ReadLine();
int shots_cnt =0;
if (!int.TryParse(shots, out shots_cnt))
{
    // Parsing failed error
}

for (int i = 2; i <= shots_cnt; i++) {
    double[] new_shot_arr=new double[4];

    double[] prev_shot_arr = shot[i - 1];
    double nsa1 = p[1, 1] * prev_shot_arr[0]   ;
    double nsa2=  p[2, 1] * prev_shot_arr[1]   ;
    double nsa3=  p[3, 1] * prev_shot_arr[2]   ;
    double nsa4 = p[4, 1] * prev_shot_arr[3];
    new_shot_arr[0] = nsa1 + nsa2 + nsa3 + nsa4;
   // Console.WriteLine(nsa1+ nsa2 + nsa3+nsa4);

    nsa1 = p[1, 2] * prev_shot_arr[0];
    nsa2 = p[2, 2] * prev_shot_arr[1];
    nsa3 = p[3, 2] * prev_shot_arr[2];
    nsa4 = p[4, 2] * prev_shot_arr[3];
    new_shot_arr[1] = nsa1 + nsa2 + nsa3 + nsa4;
   // Console.WriteLine(nsa1 + nsa2 + nsa3 + nsa4);

    nsa1 = p[1, 3] * prev_shot_arr[0];
    nsa2 = p[2, 3] * prev_shot_arr[1];
    nsa3 = p[3, 3] * prev_shot_arr[2];
    nsa4 = p[4, 3] * prev_shot_arr[3];
    new_shot_arr[2] = nsa1 + nsa2 + nsa3 + nsa4;
   // Console.WriteLine(nsa1 + nsa2 + nsa3 + nsa4);

    nsa1 = p[1, 4] * prev_shot_arr[0];
    nsa2 = p[2, 4] * prev_shot_arr[1];
    nsa3 = p[3, 4] * prev_shot_arr[2];
    nsa4 = p[4, 4] * prev_shot_arr[3];
    new_shot_arr[3] = nsa1 + nsa2 + nsa3 + nsa4;
    //Console.WriteLine(nsa1 + nsa2 + nsa3 + nsa4);

    shot.Add(new_shot_arr);
    Console.WriteLine(new_shot_arr.ToString());
}
//run form//////////////////////////
Form1 form=new Form1();
Application.EnableVisualStyles();
//Application.SetCompatibleTextRenderingDefault(false);

form.shot_cnt = shots_cnt;
form.shot=shot;

Application.Run(form);
}
if (md == 2)
{
    Console.WriteLine("what state to check (1/2/3/4)");
    string st = Console.ReadLine();
    int state = 0;
    if (!int.TryParse(st, out state))
    {
        // Parsing failed error
    }
    int check_st_num = 0;
    switch (state)
    {
        case 1:
            {
                check_st_num = 1;
            }
            break;
        case 2:
            {
                check_st_num = 2;
            }
            break;
        case 3:
            {
                check_st_num = 3;
            }
            break;
        case 4:
            {
                check_st_num = 4;
            }
            break;
    }

    //w
    for (int i = 2; ; i++)
    
        {
        double[] new_shot_arr = new double[4];

        double[] prev_shot_arr = shot[i - 1];
        double nsa1 = p[1, 1] * prev_shot_arr[0];
        double nsa2 = p[2, 1] * prev_shot_arr[1];
        double nsa3 = p[3, 1] * prev_shot_arr[2];
        double nsa4 = p[4, 1] * prev_shot_arr[3];
        new_shot_arr[0] = nsa1 + nsa2 + nsa3 + nsa4;
        // Console.WriteLine(nsa1+ nsa2 + nsa3+nsa4);

        nsa1 = p[1, 2] * prev_shot_arr[0];
        nsa2 = p[2, 2] * prev_shot_arr[1];
        nsa3 = p[3, 2] * prev_shot_arr[2];
        nsa4 = p[4, 2] * prev_shot_arr[3];
        new_shot_arr[1] = nsa1 + nsa2 + nsa3 + nsa4;
        // Console.WriteLine(nsa1 + nsa2 + nsa3 + nsa4);

        nsa1 = p[1, 3] * prev_shot_arr[0];
        nsa2 = p[2, 3] * prev_shot_arr[1];
        nsa3 = p[3, 3] * prev_shot_arr[2];
        nsa4 = p[4, 3] * prev_shot_arr[3];
        new_shot_arr[2] = nsa1 + nsa2 + nsa3 + nsa4;
        // Console.WriteLine(nsa1 + nsa2 + nsa3 + nsa4);

        nsa1 = p[1, 4] * prev_shot_arr[0];
        nsa2 = p[2, 4] * prev_shot_arr[1];
        nsa3 = p[3, 4] * prev_shot_arr[2];
        nsa4 = p[4, 4] * prev_shot_arr[3];
        new_shot_arr[3] = nsa1 + nsa2 + nsa3 + nsa4;
        //Console.WriteLine(nsa1 + nsa2 + nsa3 + nsa4);

        shot.Add(new_shot_arr);
        // Console.WriteLine(new_shot_arr.ToString());
        if (new_shot_arr[check_st_num-1]!=null &&new_shot_arr[check_st_num-1] >= 0.95)
        {
            Console.WriteLine($"it needs {i} shots");
            break;
        }
    }
}
    //run form//////////////////////////
   // Form1 form = new Form1();
   // Application.EnableVisualStyles();
    //Application.SetCompatibleTextRenderingDefault(false);

   // form.shot_cnt = shots_cnt;
    //form.shot = shot;

   // Application.Run(form);
