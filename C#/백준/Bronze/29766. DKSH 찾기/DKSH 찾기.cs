const string STR_FIND_KEYWORD = "DKSH";
string strInputData = Console.ReadLine();
int intReplaceCount = 0;
while(true){
    if(strInputData.Contains(STR_FIND_KEYWORD)){
        int intindex = strInputData.IndexOf(STR_FIND_KEYWORD);
        strInputData = intindex < 0 ? strInputData : strInputData.Substring(0, intindex) + "" + strInputData.Substring(intindex + STR_FIND_KEYWORD.Length);
        intReplaceCount++;
    }else{
        Console.WriteLine(intReplaceCount);
        return;
    }
}
