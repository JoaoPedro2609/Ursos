Console.Clear();
Console.WriteLine("Análise de dados para Ursos Selvagens.\n");
Console.Write("Digite a quantidade de Ursos: \n");
int numeroDeUrsos = Convert.ToInt32(Console.ReadLine());

int contador = 1, machos = 0, femeas = 0, geral = 0;
double peso;
string sexo;

string sexoPesoMaior = "";
double pesoMaior = 0;

double somaPesos = 0, somaPesosMachos = 0, somaPesosFemeas = 0;
double mediaPeso, mediaPesoMachos = 0, mediaPesoFemeas = 0;

int geralMl = 0, geralL = 0, geralM = 0, geralP = 0, geralMP = 0;
int machosMl = 0, machosL = 0, machosM = 0, machosP = 0, machosMP = 0;
int femeasMl = 0, femeasL = 0, femeasM = 0, femeasP = 0, femeasMP = 0;

double porcentagemMl = 0, porcentagemL = 0, porcentagemM = 0, porcentagemP = 0, porcentagemMP = 0;
double porcentagemMachos = 0, porcentagemMachosMl = 0, porcentagemMachosL = 0, porcentagemMachosM = 0, porcentagemMachosP = 0, porcentagemMachosMP = 0;
double porcentagemFemeas = 0, porcentagemFemeasMl = 0, porcentagemFemeasL = 0, porcentagemFemeasM = 0, porcentagemFemeasP = 0, porcentagemFemeasMP = 0;

while(contador != numeroDeUrsos + 1)
{
       Console.WriteLine($"\n-- Urso #{contador ++} ---");

    Console.Write("Peso (até 250kg)...: ");
    peso = Convert.ToDouble(Console.ReadLine());

    if (peso <= 0 || peso > 250) break;

    Console.Write("Sexo (M/F).....: ");
    sexo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

    if (sexo != "M" && sexo != "F") break;

    geral++;

    switch(sexo)
    {
        case "M": 
        machos++;
        somaPesosMachos += peso;
        break;

        case "F":
        femeas++;
        somaPesosFemeas += peso;
        break;
    }

    if (peso <= 50 && sexo == "M") machosMl++;
    else if (peso <= 100 && sexo == "M") machosL++;
    else if (peso <= 150 && sexo == "M") machosM++;
    else if (peso <= 200 && sexo == "M") machosP++;
    else if (peso <= 250 && sexo == "M") machosMP++;
    else if (peso <= 50 && sexo == "F") femeasMl++;
    else if (peso <= 100 && sexo == "F") femeasL++;
    else if (peso <= 150 && sexo == "F") femeasM++;
    else if (peso <= 200 && sexo == "F") femeasP++;
    else if (peso <= 250 && sexo == "F") femeasMP++;

        if (peso > pesoMaior)
    {
        pesoMaior = peso;
        sexoPesoMaior = sexo;
    }
}

if(geral == 0) return;


geralMl = machosMl + femeasMl;
geralL = machosL + femeasL;
geralM = machosM + femeasM;
geralP = machosP + femeasP;
geralMP = machosMP + femeasMP;

porcentagemMl = geralMl / geral * 100;
porcentagemL = geralL / geral * 100;
porcentagemM = geralM / geral * 100;
porcentagemP = geralP / geral * 100;
porcentagemMP = geralMP / geral * 100;


porcentagemMachos = machos / geral * 100;
porcentagemFemeas = femeas / geral * 100;

somaPesos = somaPesosMachos + somaPesosFemeas;
mediaPeso = somaPesos / geral;

    porcentagemMachosMl = machosMl / machos * 100;
    porcentagemMachosL = machosL / machos * 100;
    porcentagemMachosM = machosM / machos * 100;
    porcentagemMachosP = machosP / machos * 100;
    porcentagemMachosMP = machosMP / machos * 100;

    mediaPesoMachos = somaPesosMachos / machos;



    porcentagemFemeasMl = femeasMl / femeas * 100;
    porcentagemFemeasL = femeasL / femeas * 100;
    porcentagemFemeasM = femeasM / femeas * 100;
    porcentagemFemeasP = femeasP / femeas * 100;
    porcentagemFemeasMP = femeasMP / femeas * 100;

    mediaPesoFemeas = somaPesosFemeas / femeas;


Console.WriteLine($"\nUrso mais pesado: {pesoMaior} ({sexoPesoMaior})\n");

Console.WriteLine($"Pesos médios: \tMachos = {mediaPesoMachos:N1}\tFêmeas = {mediaPesoFemeas:N1}\tGeral  = {mediaPeso:N1}\n");

Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine("Categoria       Ursos    Ursos (%)    Machos   Machos (%)    Fêmeas  Fêmeas (%)");
Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine($"{"ML",-10} {geralMl,6} {porcentagemMl,12:N1}% {machosMl,7} {porcentagemMachosMl,12:N1}% {femeasMl,8} {porcentagemFemeasMl,9:N1}%");
Console.WriteLine($"{"L",-10} {geralL,6} {porcentagemL,12:N1}% {machosL,7} {porcentagemMachos,12:N1}% {femeasL,8} {porcentagemFemeasL,9:N1}%");
Console.WriteLine($"{"M",-10} {geralM,6} {porcentagemM,12:N1}% {machosM,7} {porcentagemMachosM,12:N1}% {femeasM,8} {porcentagemFemeasM,9:N1}%");
Console.WriteLine($"{"P",-10} {geralP,6} {porcentagemP,12:N1}% {machosP,7} {porcentagemMachosP,12:N1}% {femeasP,8} {porcentagemFemeasP,9:N1}%");
Console.WriteLine($"{"MP",-10} {geralMP,6} {porcentagemMP,12:N1}% {machosMP,7} {porcentagemMachosMP,12:N1}% {femeasMP,8} {porcentagemFemeasMP,9:N1}%");
Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine($"{"Total",-10} {geral,6} {100,10}% {machos,10} {porcentagemMachos,10:N1}% {femeas,10} {porcentagemFemeas,10:N1}%");