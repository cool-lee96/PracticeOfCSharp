int[] iPaperScale = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] iFontScale = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
float result = 0;

if(iPaperScale[0] < iFontScale[1] || iPaperScale[1] < iFontScale[2])
    result = -1;
else
    result = (float)iFontScale[0] / ((int)(iPaperScale[0] / iFontScale[1]) * (int)(iPaperScale[1] / iFontScale[2]));

Console.WriteLine(result == (int)result ? (int)result : (int)result + 1);