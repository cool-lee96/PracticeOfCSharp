string sInputWord = Console.ReadLine();
int iCount = 0;
for(int iIndex = 0; iIndex < sInputWord.Length; iIndex++){
    iCount = sInputWord[iIndex] == 'a' || sInputWord[iIndex] == 'e' || sInputWord[iIndex] == 'i' || sInputWord[iIndex] == 'o' || sInputWord[iIndex] == 'u' ? iCount + 1 : iCount;
}
Console.WriteLine($"{iCount}");