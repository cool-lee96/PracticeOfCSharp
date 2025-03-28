/* 33165 */

class 徒競走
{
    static void Main()
    {
        // 문제 입력 받기
        var input_T = int.Parse(Console.ReadLine()?.Trim());
        var input_V = int.Parse(Console.ReadLine()?.Trim());

        // 결과 출력
        Console.Write(input_T * input_V);
    }
}
