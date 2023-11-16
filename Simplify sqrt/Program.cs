while (true) {
    double use, var = 1, i = 2, sq = 4;
    double nmb = Convert.ToDouble(Console.ReadLine());
    use = nmb;
    //while (nmb <= 1000) {
    //if (use % Math.Sqrt(use) == 0) use = Math.Sqrt(use);
    //else{
        var = 1; i = 2; sq = 4;
        while (i <
            use)
        {
            while (use % sq == 0)
            {
                use /= sq;
                var *= i;
            }
            i++;
            sq += (i + i - 1);
        }
    //}
    if (use == Math.Sqrt(nmb)) Console.WriteLine("√" + nmb + " = " + use);
    else if (var == 1) Console.WriteLine("√" + nmb + " = " + "√" + nmb);
    else if (use == 1) Console.WriteLine("√" + nmb + " = " + var);
    else Console.WriteLine("√" + nmb + " = " + var + "√" + use);
    if (var * var * use != nmb && use != Math.Sqrt(nmb)) { Console.WriteLine("wrong ^^^"); break; }
    //nmb++;
    //use = nmb;
    //var = 1;
    //}
}