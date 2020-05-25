C# code to calculate the coefficients of the Butterworth filter

This code calculate the coefficients of the Band-pass, Band-stop, Low-pass and High-pass Butterworth filters. The file IIR_Butterworth_Main.cs can be used to test the code.

Each filter function will return a 2 rows x N coefficients 2D vector, where Row 1 = Numerator and Row 2 = Denumerator. The method "Check_stability_iir" can be used to check the stability of the filter. Please, keep in mind that if the filter is unstable, numerical instability leading to numerical overflow can happen. If that situation, the program assigns a default value of 10^10 at the denominator.

Band-pass: the function is "double[][] Lp2bp(double W_f1, double W_f2, int order_filt);". The first two arguments are the two cut-off frequencies and the last argument is the order;

Band-stop: the function is "double[][] Lp2bs(double W_f1, double W_f2, int order_filt)". The first two arguments are the two cut-off frequencies and the last argument is the order;

Low-pass: the function is "double[][] Lp2lp(double W_f2, int order_filt)". The first argument is the cut-off frequency and the last argument is the order;

High-pass: the function is "double[][] Lp2hp(double W_f1, int order_filt)". The first argument is the cut-off frequency and the last argument is the order;

Check the stability of the filter: the function is bool "bool Check_stability_iir(double[][] coeff_filt)". The argument is the 2D array containing the filter coefficients. It returns "true" if the filter is stable, "false" if it is unstable. 

This code has been written following the Matlab code, so the arguments of each function reflect the arguments that you should pass to the equivalent functions in Matlab. I tried to be consistent with the names of the functions, in case someone wants to compare this code with Matlab code. The only exception is the function Check_stability_iir, which is not present in Matlab. 
