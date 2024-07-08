int iCaseCount = int.Parse(Console.ReadLine());
for(int iCount = 0; iCount<iCaseCount; iCount++){
    string[] sInputData = Console.ReadLine().Split(' ');
    for(int iDataCount = 0; iDataCount < int.Parse(sInputData[0]); iDataCount++){
        Console.Write($"{sInputData[1]}");
    }
    Console.Write("\n");
}