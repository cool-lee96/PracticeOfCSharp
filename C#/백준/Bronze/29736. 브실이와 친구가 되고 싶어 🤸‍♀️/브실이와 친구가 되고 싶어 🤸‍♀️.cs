int[] intProblemData = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] intSolvedData = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int intSolvedMin = intSolvedData[0] - intSolvedData[1];
int intSolvedMax = intSolvedData[0] + intSolvedData[1];

int intFriendCount = Enumerable.Range(intProblemData[0], intProblemData[1] - intProblemData[0] + 1).Count(x=>intSolvedMin <= x && x <= intSolvedMax);
Console.WriteLine(intFriendCount != 0 ? intFriendCount : "IMPOSSIBLE");
