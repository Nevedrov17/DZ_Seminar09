// Задача 64.

void NatNum(int m, int n)
{
    if (m <= n)
    {
    Console.Write(m + " ");
    NatNum(m+1,n);
    }
}
NatNum(4,9);

// Задача 66.

int SumNat(int m, int n)
{
    if (m <= n)
    {
    return m + SumNat(m+1,n);
    }
    return 0;
}
Console.WriteLine(SumNat(2,6));
