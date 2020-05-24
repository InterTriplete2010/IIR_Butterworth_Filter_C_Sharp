using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.LinearAlgebra;
using System.Net.Http.Headers;
using System.Linq;
using MathNet.Numerics;
using Combinatorics;
using Combinatorics.Collections;


namespace IIR_Butterworth_C_Sharp
{
    class IIR_Butterworth_Main
    {
               

        static void Main(string[] args)
        {
            IIR_Butterworth_Interface IBI = new IIR_Butterworth_C_Sharp.IIR_Butterworth_Implementation();

            double f1 = 1;  //High Pass
            double f2 = 30; //Low Pass
            double sf = 2048;    //Sampling frequency
            int order_filt = 3; //Order
            double Nyquist_F = sf / 2;

            double[][] coeff_final = new double[2][];

            int type_filt = 3;
            
            
            int coeff_numb = 0;
            switch (type_filt)
            {
                case 0:

                    coeff_numb = 2 * order_filt + 1;


                    for (int i = 0; i < 2; i++)
                    {

                        coeff_final[i] = new double[coeff_numb];

                    }


                    coeff_final = IBI.Lp2bp(f1 / Nyquist_F, f2 / Nyquist_F, order_filt);


                    for (int kk = 0; kk < 2; kk++)
                    {
                        if (kk == 0)
                        {

                            Console.Write ("Numerator: ");

                        }

                        else
                        {

                            Console.Write("Denumerator: ");

                        }

                        for (int ll = 0; ll < coeff_numb; ll++)

                        {
                            Console.Write(coeff_final[kk][ll]);
                            Console.Write("\t");

                        }

                        Console.Write("\n");

                    }

                    break;

                case 1:

                    coeff_numb = 2 * order_filt + 1;


                    for (int i = 0; i < 2; i++)
                    {

                        coeff_final[i] = new double[coeff_numb];

                    }


                    coeff_final = IBI.Lp2bs(f1 / Nyquist_F, f2 / Nyquist_F, order_filt);


                    for (int kk = 0; kk < 2; kk++)
                    {
                        if (kk == 0)
                        {

                            Console.Write("Numerator: ");

                        }

                        else
                        {

                            Console.Write("Denumerator: ");

                        }

                        for (int ll = 0; ll < coeff_numb; ll++)

                        {
                            Console.Write(coeff_final[kk][ll]);
                            Console.Write("\t");

                        }

                        Console.Write("\n");

                    }

                    break;

                case 2:

                    coeff_numb = order_filt + 1;

                    for (int i = 0; i < 2; i++)
                    {

                        coeff_final[i] = new double[coeff_numb];

                    }


                    coeff_final = IBI.Lp2hp(f2 / Nyquist_F, order_filt);


                    for (int kk = 0; kk < 2; kk++)
                    {
                        if (kk == 0)
                        {

                            Console.Write("Numerator: ");

                        }

                        else
                        {

                            Console.Write("Denumerator: ");

                        }

                        for (int ll = 0; ll < coeff_numb; ll++)

                        {
                            Console.Write(coeff_final[kk][ll]);
                            Console.Write("\t");

                        }

                        Console.Write("\n");

                    }

                    break;

                case 3:

                    coeff_numb = order_filt + 1;

                    for (int i = 0; i < 2; i++)
                    {

                        coeff_final[i] = new double[coeff_numb];

                    }


                    coeff_final = IBI.Lp2lp(f1 / Nyquist_F, order_filt);


                    for (int kk = 0; kk < 2; kk++)
                    {
                        if (kk == 0)
                        {

                            Console.Write("Numerator: ");

                        }

                        else
                        {

                            Console.Write("Denumerator: ");

                        }

                        for (int ll = 0; ll < coeff_numb; ll++)

                        {
                            Console.Write(coeff_final[kk][ll]);
                            Console.Write("\t");

                        }

                        Console.Write("\n");

                    }

                    break;

            }


        }
    }
}
