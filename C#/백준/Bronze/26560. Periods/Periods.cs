int iDataCount = int.Parse(Console.ReadLine());
for(int iIndex = 0; iIndex<iDataCount; iIndex++){
    string sData = Console.ReadLine();
    Console.WriteLine(sData[^1] == '.' ? sData : sData + ".");
}