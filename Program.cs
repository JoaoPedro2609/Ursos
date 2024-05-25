Console.Clear();
// Console.WriteLine("Análise de dados para Ursos Selvagens.\n");

// Console.Write("Digite a quantidade de Ursos: \n");
// int numeroDeUrsos = Convert.ToInt32(Console.ReadLine());

// int contador = 1;
// int[] peso = new int[numeroDeUrsos];
// string[] sexo = new string[numeroDeUrsos] ;

// for (int i0 = 0; i0 < numeroDeUrsos; i0++)
// {
//       Console.WriteLine($"Digite o peso(kg) e o sexo(M/F) do {contador++}ª urso");
//     Console.Write("Peso...: ");
//     int valorPeso = Convert.ToInt32(Console.ReadLine());
//     if(valorPeso <= 0 || valorPeso > 250)
//     {
//         Console.WriteLine("Peso invalido");
//         return;
//     }
//     Console.Write("Sexo...: ");
//     string valorSexo = Console.ReadLine()!;
//    if(valorSexo != "m" || valorSexo != "f")
//    {
//         Console.WriteLine("Sexo não identificado");
//         return;
//    }
//     peso[i0] = valorPeso;
//     sexo[i0] = valorSexo;
// }
Console.WriteLine(@$"
-----------------------------------------------------------------------------
| Categoria | Ursos | Ursos (%) | Machos | Machos (%) | Fêmeas | Fêmeas (%) |
| --------- | ----- | --------- | ------ | ---------- | ------ | ---------- |
| ML        | 1     | 10%       | 0      | 0%         | 1      | 20%        |
| L         | 2     | 20%       | 1      | 20%        | 1      | 20%        |
| M         | 3     | 30%       | 1      | 20%        | 2      | 40%        |
| P         | 3     | 30%       | 2      | 40%        | 1      | 20%        |
| MP        | 1     | 20%       | 1      | 20%        | 0      | 0%         |
| Total     | 10    | 100%      | 5      | 50%        | 5      | 50%        |
-----------------------------------------------------------------------------
");

// foreach (int i0 in peso)
// {
//     Console.WriteLine($"{i0}");
// }
// foreach (string i0 in sexo)
// {
//     Console.WriteLine($"{i0}");
// }
