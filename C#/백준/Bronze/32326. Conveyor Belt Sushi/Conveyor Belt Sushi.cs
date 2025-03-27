/* 32326 */

// 입력 받을 접시 수 배열
int[] Plates;

// 배열의 인덱스
int index = 0;

// RRR :  3달러, GGG : 4달러, BBB: 5달러
int[] PlatePrices = { 3, 4, 5 };

// 자원 관리를 위한 using문
using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
{
    // 선언
    Plates = new int[PlatePrices.Length];

    // 예외를 위한 배열 convert + while문
    while (true)
    {
        var temp = sr.ReadLine() ?? "";
        try
        {
            var tempArray = Array.ConvertAll(temp.Split(" "), int.Parse);
            Plates[index] = tempArray[0];
        }
        catch (Exception ex) { } // 예외가 발생시 처리 안함(입력 예외)

        // 접시 수 예외 처리
        if (0 <= Plates[index]) index++;

        // RRR, GGG, BBB 처리가 끝나면 while break
        if (index == PlatePrices.Length) break;
    }

    // 자원 관리를 위한 using문
    using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
    {
        int sum = 0;

        // 가격 계산
        for (int i = 0; i < index; i++)
        {
            sum += (Plates[i] * PlatePrices[i]);
        }

        // 계산값 출력
        sw.WriteLine(sum);
    }
}