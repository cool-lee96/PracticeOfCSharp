/* 27240 */

class Электричка
{
    static void Main()
    {
        // 문제 입력 받기    
        int[] input_nab = Array.ConvertAll(Console.ReadLine()?.Split(" "), int.Parse);
        int[] input_st = Array.ConvertAll(Console.ReadLine()?.Split(" "), int.Parse);

        if (input_st[0] > input_st[1])
        {
            int temp = input_st[0];
            input_st[0] = input_st[1];
            input_st[1] = temp;
        }

        int[] outside_index = { input_nab[1], input_nab[2] }; // 1~ a, b ~ n

        // 결과 출력
        if (input_st[0] > outside_index[0] && input_st[1] < outside_index[1])
        {
            Console.WriteLine("City");
        }
        else if ((input_st[0] <= outside_index[0] && input_st[1] <= outside_index[0]) || (input_st[0] >= outside_index[1] && input_st[1] >= outside_index[1]))
        {
            Console.WriteLine("Outside");
        }
        else
        {
            Console.WriteLine("Full");
        }

        
    }
}
