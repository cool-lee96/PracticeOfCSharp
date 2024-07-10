int intTestCase = int.Parse(Console.ReadLine());
int intTestCaseCount;
for(intTestCaseCount = 1; intTestCaseCount <= intTestCase; intTestCaseCount++){
    string strFinalRound = "Round ";
    int intInputGrade = int.Parse(Console.ReadLine());
    if(25 >= intInputGrade)
        strFinalRound = "World Finals";
    else if(1000 >= intInputGrade)
        strFinalRound += "3";
    else if(4500 >= intInputGrade)
        strFinalRound += "2";
    else
        strFinalRound += "1";
    Console.WriteLine($"Case #{intTestCaseCount}: {strFinalRound}");
}