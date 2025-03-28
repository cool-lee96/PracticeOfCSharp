/* 33170 */

class ブラックジャック
{
    static void Main()
    {
        // 문제 입력 받기
        int input_A = int.Parse(Console.ReadLine()?.Trim());
        input_A += int.Parse(Console.ReadLine()?.Trim());
        input_A += int.Parse(Console.ReadLine()?.Trim());

        // 결과 출력
        Console.Write(input_A <= 21 ? 1 : 0);
    }
}
