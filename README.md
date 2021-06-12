C# code to calculate the coefficients of the Butterworth filter and to filter the data

This code calculates the coefficients of the Band-pass, Band-stop, Low-pass and High-pass Butterworth filters.  It also filters the data, but no zero-phase delay is applied. namespace IIR_Butterworth_C_Sharp.

Each filter function will return a 2 rows x N coefficients 2D vector, where Row 1 = Numerator and Row 2 = Denumerator. The method "Check_stability_iir" can be used to check the stability of the filter. Please, keep in mind that if the filter is unstable, numerical instability leading to numerical overflow might happen when the order selected is extremely high. If that situation occurs, the program might assign a default value of 10^10 at the denominator.

1) Band-pass: the function is "double[][] Lp2bp(double W_f1, double W_f2, int order_filt)". The first two arguments are the two normalized cut-off frequencies (f1/NF, f2/NF), where NF is the Nyquist frequency. This means that the cutoff frequencies must be within the interval of (0,1). The last argument is the order. Please, keep in mind that if you enter order_filt = 2, the order of the order will be 2 * order_filt = 4;

2) Band-stop: the function is "double[][] Lp2bs(double W_f1, double W_f2, int order_filt)". The first two arguments are the two normalized cut-off frequencies (f1/NF, f2/NF), where NF is the Nyquist frequency. This means that the cutoff frequencies must be within the interval of (0,1). The last argument is the order. Please, keep in mind that if you enter order_filt = 2, the order of the order will be 2 * order_filt = 4;

3) Low-pass: the function is "double[][] Lp2lp(double W_f1, int order_filt)". The first argument is the normalized cut-off frequency (f/NF), where NF is the Nyquist frequency. This means that the cutoff frequency must be within the interval of (0,1). The last argument is the order;

4) High-pass: the function is "double[][] Lp2hp(double W_f1, int order_filt)". The first argument is the normalized cut-off frequency (f/NF), where NF is the Nyquist frequency. This means that the cutoff frequency must be within the interval of (0,1). The last argument is the order;

5) Check the stability of the filter: the method is "bool Check_stability_iir(double[][] coeff_filt)". The argument is the 2D array containing the filter coefficients. It returns "true" if the filter is stable, "false" if it is unstable. 

6) Filter the data: the method is "double[] Filter_Data(double[][] coeff_filt, double[] pre_filt_signal)". The two arguments are the filter coefficients and the signal to be filtered. It returns the filtered signal.

This code has been written following the Matlab code, so the arguments of each function reflect the arguments that you should pass to the equivalent functions in Matlab. I tried to be consistent with the names of the functions, in case someone wants to compare this code with Matlab code. The only exception is the function Check_stability_iir, which is not present in Matlab. 

If you have any question and/or want to report bugs, please e-mail me (Ale) at: pressalex@hotmail.com
