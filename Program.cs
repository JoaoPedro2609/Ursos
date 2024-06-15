Console.Clear();
Console.WriteLine("Análise de dados para Ursos Selvagens.\n");
Console.Write("Digite a quantidade de Ursos: ");
int geral = Convert.ToInt32(Console.ReadLine());

int contador = 1, machos = 0, femeas = 0;
double peso;
string sexo;

string sexoPesoMaior = "";
double pesoMaior = 0;

double somaPesos = 0, somaPesosMachos = 0, somaPesosFemeas = 0;
double mediaPeso, mediaPesoMachos = 0, mediaPesoFemeas = 0;

int geralMl = 0, geralL = 0, geralM = 0, geralP = 0, geralMP = 0;
int machosMl = 0, machosL = 0, machosM = 0, machosP = 0, machosMP = 0;
int femeasMl = 0, femeasL = 0, femeasM = 0, femeasP = 0, femeasMP = 0;

double porcentagemMl, porcentagemL, porcentagemM, porcentagemP, porcentagemMP;
double porcentagemMachos, porcentagemMachosMl, porcentagemMachosL, porcentagemMachosM, porcentagemMachosP, porcentagemMachosMP;
double porcentagemFemeas, porcentagemFemeasMl, porcentagemFemeasL, porcentagemFemeasM, porcentagemFemeasP, porcentagemFemeasMP;
while(contador != geral + 1)
{
       Console.WriteLine($"\n-- Urso #{contador ++} ---");

    Console.Write("Peso (até 250kg)...: ");
    peso = Convert.ToDouble(Console.ReadLine());

    if (peso <= 0 || peso > 250) break;

    Console.Write("Sexo (M/F).....: ");
    sexo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

    if (sexo != "M" && sexo != "F") break;

    

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

porcentagemMl = (double)geralMl / geral * 100;
porcentagemL = (double)geralL / geral * 100;
porcentagemM = (double)geralM / geral * 100;
porcentagemP = (double)geralP / geral * 100;
porcentagemMP = (double)geralMP / geral * 100;


porcentagemMachos = (double)machos / geral * 100;
porcentagemFemeas = (double)femeas / geral * 100;

somaPesos = somaPesosMachos + somaPesosFemeas;
mediaPeso = somaPesos / geral;

    porcentagemMachosMl = (double)machosMl / machos * 100;
    porcentagemMachosL = (double)machosL / machos * 100;
    porcentagemMachosM = (double)machosM / machos * 100;
    porcentagemMachosP = (double)machosP / machos * 100;
    porcentagemMachosMP = (double)machosMP / machos * 100;

    mediaPesoMachos = somaPesosMachos / machos;



    porcentagemFemeasMl = (double)femeasMl / femeas * 100;
    porcentagemFemeasL = (double)femeasL / femeas * 100;
    porcentagemFemeasM = (double)femeasM / femeas * 100;
    porcentagemFemeasP = (double)femeasP / femeas * 100;
    porcentagemFemeasMP = (double)femeasMP / femeas * 100;

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

Console.WriteLine("\n----- Ursos Machos -----");
Console.WriteLine("   +...10...20...30...40...50...60...70...80...90..100");
Console.WriteLine($"ML |{"".PadRight((int)porcentagemMachosMl / 2, '*')}");
Console.WriteLine($"L  |{"".PadRight((int)porcentagemMachosL / 2, '*')}");
Console.WriteLine($"M  |{"".PadRight((int)porcentagemMachosM / 2, '*')}");
Console.WriteLine($"P  |{"".PadRight((int)porcentagemMachosP / 2, '*')}");
Console.WriteLine($"MP |{"".PadRight((int)porcentagemMachosMP / 2, '*')}");

Console.WriteLine("\n----- Ursos Femeas -----");
Console.WriteLine("   +...10...20...30...40...50...60...70...80...90..100");
Console.WriteLine($"ML |{"".PadRight((int)porcentagemFemeasMl / 2, '*')}");
Console.WriteLine($"L  |{"".PadRight((int)porcentagemFemeasL / 2, '*')}");
Console.WriteLine($"M  |{"".PadRight((int)porcentagemFemeasM / 2, '*')}");
Console.WriteLine($"P  |{"".PadRight((int)porcentagemFemeasP / 2, '*')}");
Console.WriteLine($"MP |{"".PadRight((int)porcentagemFemeasMP / 2, '*')}");

Console.WriteLine("\n----- Ursos (todos) -----");
Console.WriteLine("   +...10...20...30...40...50...60...70...80...90..100");
Console.WriteLine($"ML |{"".PadRight((int)porcentagemMl / 2, '*')}");
Console.WriteLine($"L  |{"".PadRight((int)porcentagemL / 2, '*')}");
Console.WriteLine($"M  |{"".PadRight((int)porcentagemM / 2, '*')}");
Console.WriteLine($"P  |{"".PadRight((int)porcentagemP / 2, '*')}");
Console.WriteLine($"MP |{"".PadRight((int)porcentagemMP / 2, '*')}");