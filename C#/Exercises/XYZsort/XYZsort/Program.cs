using System;


namespace XYZsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;
            int[,] matrix1;

            row = Convert.ToInt32(Console.ReadLine());
            col = Convert.ToInt32(Console.ReadLine());
            matrix1 = new int[i, col];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
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

