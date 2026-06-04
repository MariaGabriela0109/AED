using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int tamanho = 500000;
        Random r = new Random(100);

        int[] intCrescente = new int[tamanho];
        int[] intDecrescente = new int[tamanho];
        int[] intAleatorio = new int[tamanho];

        decimal[] decCrescente = new decimal[tamanho];
        decimal[] decDecrescente = new decimal[tamanho];
        decimal[] decAleatorio = new decimal[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            intCrescente[i] = i;
            intDecrescente[i] = tamanho - i;
            intAleatorio[i] = r.Next();

            decCrescente[i] = i;
            decDecrescente[i] = tamanho - i;
            decAleatorio[i] = (decimal)r.NextDouble() * 1000000m;
        }

        ExecutarTestesInt("Crescente", intCrescente);
        ExecutarTestesInt("Decrescente", intDecrescente);
        ExecutarTestesInt("Aleatório", intAleatorio);

        ExecutarTestesDecimal("Crescente", decCrescente);
        ExecutarTestesDecimal("Decrescente", decDecrescente);
        ExecutarTestesDecimal("Aleatório", decAleatorio);

        Console.ReadLine();
    }

    static void ExecutarTestesInt(string tipo, int[] vetorOriginal)
    {
        int[] vetorMerge = (int[])vetorOriginal.Clone();
        int[] vetorQuick = (int[])vetorOriginal.Clone();

        long comp = 0, mov = 0;
        Stopwatch stopWatch = new Stopwatch();

        stopWatch.Restart();
        MergesortInt(vetorMerge, 0, vetorMerge.Length - 1, ref comp, ref mov);
        stopWatch.Stop();
        ImprimirResultado($"Int {tipo} Mergesort", comp, mov, stopWatch.Elapsed);

        comp = 0; mov = 0;
        stopWatch.Restart();
        QuicksortInt(vetorQuick, 0, vetorQuick.Length - 1, ref comp, ref mov);
        stopWatch.Stop();
        ImprimirResultado($"Int {tipo} Quicksort", comp, mov, stopWatch.Elapsed);
    }

    static void ExecutarTestesDecimal(string tipo, decimal[] vetorOriginal)
    {
        decimal[] vetorMerge = (decimal[])vetorOriginal.Clone();
        decimal[] vetorQuick = (decimal[])vetorOriginal.Clone();

        long comp = 0, mov = 0;
        Stopwatch stopWatch = new Stopwatch();

        stopWatch.Restart();
        MergesortDec(vetorMerge, 0, vetorMerge.Length - 1, ref comp, ref mov);
        stopWatch.Stop();
        ImprimirResultado($"Dec {tipo} Mergesort", comp, mov, stopWatch.Elapsed);

        comp = 0; mov = 0;
        stopWatch.Restart();
        QuicksortDec(vetorQuick, 0, vetorQuick.Length - 1, ref comp, ref mov);
        stopWatch.Stop();
        ImprimirResultado($"Dec {tipo} Quicksort", comp, mov, stopWatch.Elapsed);
    }

    static void ImprimirResultado(string algoritmo, long comp, long mov, TimeSpan ts)
    {
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

        Console.WriteLine($"{algoritmo,-25} | Comparações: {comp,-12} | Movimentações: {mov,-12} | Tempo: {elapsedTime}");
    }

    static void MergesortInt(int[] array, int esq, int dir, ref long comp, ref long mov)
    {
        if (esq < dir)
        {
            int meio = (esq + dir) / 2;
            MergesortInt(array, esq, meio, ref comp, ref mov);
            MergesortInt(array, meio + 1, dir, ref comp, ref mov);
            IntercalarInt(array, esq, meio, dir, ref comp, ref mov);
        }
    }

    static void IntercalarInt(int[] array, int esq, int meio, int dir, ref long comp, ref long mov)
    {
        int n1 = meio - esq + 1;
        int n2 = dir - meio;
        int[] a1 = new int[n1 + 1];
        int[] a2 = new int[n2 + 1];

        for (int x = 0; x < n1; x++) { a1[x] = array[esq + x]; mov++; }
        for (int y = 0; y < n2; y++) { a2[y] = array[meio + 1 + y]; mov++; }

        a1[n1] = int.MaxValue;
        a2[n2] = int.MaxValue;

        int i = 0, j = 0;
        for (int k = esq; k <= dir; k++)
        {
            comp++;
            if (a1[i] <= a2[j])
            {
                array[k] = a1[i++];
            }
            else
            {
                array[k] = a2[j++];
            }
            mov++;
        }
    }

    static void QuicksortInt(int[] array, int esq, int dir, ref long comp, ref long mov)
    {
        int i = esq, j = dir;
        int pivo = array[(dir + esq) / 2];

        while (i <= j)
        {
            while (array[i] < pivo) { comp++; i++; }
            comp++;

            while (array[j] > pivo) { comp++; j--; }
            comp++;

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                mov += 3;
                i++;
                j--;
            }
        }
        if (esq < j) QuicksortInt(array, esq, j, ref comp, ref mov);
        if (i < dir) QuicksortInt(array, i, dir, ref comp, ref mov);
    }

    static void MergesortDec(decimal[] array, int esq, int dir, ref long comp, ref long mov)
    {
        if (esq < dir)
        {
            int meio = (esq + dir) / 2;
            MergesortDec(array, esq, meio, ref comp, ref mov);
            MergesortDec(array, meio + 1, dir, ref comp, ref mov);
            IntercalarDec(array, esq, meio, dir, ref comp, ref mov);
        }
    }

    static void IntercalarDec(decimal[] array, int esq, int meio, int dir, ref long comp, ref long mov)
    {
        int n1 = meio - esq + 1;
        int n2 = dir - meio;
        decimal[] a1 = new decimal[n1 + 1];
        decimal[] a2 = new decimal[n2 + 1];

        for (int x = 0; x < n1; x++) { a1[x] = array[esq + x]; mov++; }
        for (int y = 0; y < n2; y++) { a2[y] = array[meio + 1 + y]; mov++; }

        a1[n1] = decimal.MaxValue;
        a2[n2] = decimal.MaxValue;

        int i = 0, j = 0;
        for (int k = esq; k <= dir; k++)
        {
            comp++;
            if (a1[i] <= a2[j])
            {
                array[k] = a1[i++];
            }
            else
            {
                array[k] = a2[j++];
            }
            mov++;
        }
    }

    static void QuicksortDec(decimal[] array, int esq, int dir, ref long comp, ref long mov)
    {
        int i = esq, j = dir;
        decimal pivo = array[(dir + esq) / 2];

        while (i <= j)
        {
            while (array[i] < pivo) { comp++; i++; }
            comp++;

            while (array[j] > pivo) { comp++; j--; }
            comp++;

            if (i <= j)
            {
                decimal temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                mov += 3;
                i++;
                j--;
            }
        }
        if (esq < j) QuicksortDec(array, esq, j, ref comp, ref mov);
        if (i < dir) QuicksortDec(array, i, dir, ref comp, ref mov);
    }
}