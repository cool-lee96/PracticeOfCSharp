int iCaseMax = int.Parse(Console.ReadLine());
for(int iCase = 0; iCase < iCaseMax; iCase++){
    int[] iDiceArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    Console.WriteLine($"Case {iCase+1}: {iDiceArray.Sum()}");
}