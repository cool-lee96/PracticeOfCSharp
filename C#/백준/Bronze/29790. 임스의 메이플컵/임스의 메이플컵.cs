int[] intInputDataArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int intScore = 0;
if(1000 <= intInputDataArray[0]) intScore += 1;
if(8000 <= intInputDataArray[1] || 260 <= intInputDataArray[2]) intScore += 2;

switch(intScore){
    case 0:
    case 2:
        Console.WriteLine("Bad");
    break;
    case 1:
        Console.WriteLine("Good");
    break;
    case 3:
        Console.WriteLine("Very Good");
    break;
}
