string sInputHey = Console.ReadLine();
Console.Write($"{sInputHey[0]}");
for(int iCount = 0; iCount<(sInputHey.Length-2)*2; iCount++){
    Console.Write("e");
}
Console.Write($"{sInputHey[sInputHey.Length-1]}");