using System;


namespace XYZsort
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            int num = Int32.Parse(strInput);
            int[,] tab = new int[num,3];
            for (int i = 0;i < num; i++)
            {
                string xA = Console.ReadLine();
                string[] test = xA.Split(" ");
                string xAA = test[0];
                int x = Int32.Parse(xAA);

                string yb = Console.ReadLine();
                string[] test1 = xA.Split(" ");
                string yBB = test[0];
                int y = Int32.Parse(yBB);

                string zC = Console.ReadLine();
                string[] test2 = xA.Split(" ");
                string zCC = test[0];
                int z = Int32.Parse(yBB);

                tab[i,0] = x;
                tab[i,1] = y;
                tab[i,2] = z;

            }
                
            



            int ch = 1;
                while (ch > 0)
                {
                    ch = 0;
                    for (int i = 0; i < num; i++)
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

                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            Console.WriteLine(tab[x, y]);
                            Console.WriteLine();
                        }
                    }

                }
                Console.Read();
            }


        }
    }

