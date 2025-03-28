/* 24084 */

class 次の文字
{
    static void Main()
    {
        // 문제 입력 받기    
        int intput_charCount = int.Parse(Console.ReadLine()?.Trim());
        char[] chars = new char[intput_charCount];
        string input_char = Console.ReadLine()?.Trim();

        // 결과 출력
        for (int i = 1; i < intput_charCount; i++)
        {
            if (input_char[i] == 'J')
                Console.WriteLine(input_char[i - 1]);
        }
    }
}
