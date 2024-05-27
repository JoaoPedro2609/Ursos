Console.Clear();
Console.WriteLine("Análise de dados para Ursos Selvagens.\n");

Console.Write("Digite a quantidade de Ursos: \n");
int numeroDeUrsos = Convert.ToInt32(Console.ReadLine());

int contador = 1, machos = 0, femea = 0;
int[] peso = new int[numeroDeUrsos];
string[] sexo = new string[numeroDeUrsos] ;

string sexoPesoMaior = "";
double pesoMaior = 0;

double somaPesos = 0, somaPesosMachos = 0, somaPesosFemeas = 0;
double mediaPeso, mediaPesoMachos = 0, mediaPesoFemeas = 0;

int geralML = 0, geralL = 0, geralM = 0, geralP = 0, geralMP = 0;
int machosML = 0, machosL = 0, machosM = 0, machosP = 0, machosMP = 0;
int femeasML = 0, femeasL = 0, femeasM = 0, femeasP = 0, femeasMP = 0;

double porcentagemML = 0, porcentagemL = 0, porcentagemM = 0, porcentagemP = 0, porcentagemMP = 0;
double porcentagemMachos = 0, porcentagemMachosML = 0, porcentagemMachosL = 0, porcentagemMachosM = 0, porcentagemMachosP = 0, porcentagemMachosMP = 0;
double porcentagemFemeas = 0, porcentagemFemeasML = 0, porcentagemFemeasL = 0, porcentagemFemeasM = 0, porcentagemFemeasP = 0, porcentagemFemeasMP = 0;

for (int i0 = 0; i0 < numeroDeUrsos; i0++)
{
      Console.WriteLine($"Digite o peso(kg) e o sexo(M/F) do {contador++}ª urso");
    Console.Write("Peso...: ");
    int valorPeso = Convert.ToInt32(Console.ReadLine());
    if(valorPeso <= 0 || valorPeso > 250)
    {
        Console.WriteLine("Peso invalido");
        return;
    }
    Console.Write("Sexo (M/F)...: ");
    string valorSexo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();
   if(valorSexo != "m" || valorSexo != "f")
   {
        Console.WriteLine("Sexo não identificado");
        return;
   }
    peso[i0] = valorPeso;
    sexo[i0] = valorSexo;

    switch(sexo[i0])
    {
        case "M": 
        machos += 
    }

    if (peso[i0] <= 50 && sexo[i0] == "M") machosML++;
    else if (peso[i0] <= 100 && sexo[i0] == "M") machosL++;
    else if (peso[i0] <= 150 && sexo[i0] == "M") machosM++;
    else if (peso[i0] <= 200 && sexo[i0] == "M") machosP++;
    else if (peso[i0] <= 250 && sexo[i0] == "M") machosMP++;
    else if (peso[i0] <= 50 && sexo[i0] == "F") femeasML++;
    else if (peso[i0] <= 100 && sexo[i0] == "F") femeasL++;
    else if (peso[i0] <= 150 && sexo[i0] == "F") femeasM++;
    else if (peso[i0] <= 200 && sexo[i0] == "F") femeasP++;
    else if (peso[i0] <= 250 && sexo[i0] == "F") femeasMP++;

        if (peso[i0] > pesoMaior)
    {
        pesoMaior = peso[i0];
        sexoPesoMaior = sexo[i0];
    }
}

// Console.WriteLine(Math.Max());

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
