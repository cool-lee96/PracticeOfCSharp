using System;

namespace ByteAirlineSeating
{
    class Program
    {
        static void Main(string[] args)
        {
            // 입력을 받아서 각 변수에 할당
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int n1 = int.Parse(inputs[0]); // 비즈니스석 열의 수
            int k1 = int.Parse(inputs[1]); // 비즈니스석 각 열의 좌석 수
            int n2 = int.Parse(inputs[2]); // 이코노미석 열의 수
            int k2 = int.Parse(inputs[3]); // 이코노미석 각 열의 좌석 수

            // 비즈니스석 총 좌석 수 계산
            long totalBusinessSeats = (long)n1 * k1;

            // 이코노미석 총 좌석 수 계산
            long totalEconomySeats = (long)n2 * k2;

            // 총 좌석 수 계산
            long totalSeats = totalBusinessSeats + totalEconomySeats;

            // 결과 출력
            Console.WriteLine(totalSeats);
        }
    }
}
