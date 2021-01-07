using System;


namespace XYZsort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Podaje liczbę tablic, które zostaną utworzone
            string strInput = Console.ReadLine();
            int num = Int32.Parse(strInput);
            //Każda tablica ma mieć po 3 liczby
            int[,] tab = new int[num,3];

            //Pętla wykonuje się X razy, czyli liczbę zadeklorowanych tablic.
            for (int i = 0;i < num; i++)
            {
                var values = (Console.ReadLine().Split(' '));
                for (int j = 0;j < num; j++) 
                {
                    tab[i, j] = int.Parse(values[j]);
                }

                //Przypisanie wartości do pozycji w tablicy
                // tab[i,0] = x;
              //  tab[i,1] = y;
            //    tab[i,2] = z;

               
            }
            int ch = 1;
                while (ch > 0)
                {
                    ch = 0;
                    for (int i = 0; i < num - 1; i++)
                    {
                        if (tab[i, 0] > tab[i + 1, 0])
                        {
                            int[] temp = new int[] { tab[i, 0], tab[i, 1], tab[i, 2] };
                            tab[i, 0] = tab[i + 1, 0];
                            tab[i, 1] = tab[i + 1, 1];
                            tab[i, 2] = tab[i + 1, 2];
                            tab[i + 1, 0] = temp[0];
                            tab[i + 1, 1] = temp[1];
                            tab[i + 1, 2] = temp[2];
                            ch++;
                        }
                    }

                    int[] tmp = new int[3];
                    for (int i = 0; i < num; i++)
                    {
                        if (i + 1 < num)
                        {
                            if (tab[i, 0] > tab[i + 1, 0])
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    tmp[j] = tab[i, j];
                                    tab[i, j] = tab[i + 1, j];
                                    tab[i + 1, j] = tmp[j];
                                }
                            }
                        }
                    }

                    int[] tmp2 = new int[3];
                    for (int i = 0; i < num; i++)
                    {
                        if (i + 1 < num)
                        {
                            if (tab[i, 0] > tab[i + 1, 0])
                            {
                                if (tab[i, 1] > tab[i + 1, 1])
                                    for (int j = 0; j < 3; j++)
                                    {
                                        tmp2[j] = tab[i, j];
                                        tab[i, j] = tab[i + 1, j];
                                        tab[i + 1, j] = tmp2[j];
                                    }
                            }
                        }
                    }

                    int[] tmp3 = new int[3];
                    for (int i = 0; i < num; i++)
                    {
                        if (i + 1 < num)
                        {
                            if (tab[i, 0] > tab[i + 1, 0])
                            {
                                if (tab[i, 1] > tab[i + 1, 2])
                                    for (int j = 0; j < 3; j++)
                                    {
                                        tmp3[j] = tab[i, j];
                                        tab[i, j] = tab[i + 1, j];
                                        tab[i + 1, j] = tmp3[j];
                                    }
                            }
                        }
                    }
                
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tab[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.Read();
            }


        }
    }

