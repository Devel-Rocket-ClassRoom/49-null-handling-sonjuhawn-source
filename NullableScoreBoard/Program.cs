using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 경기 상태 ===");

int?[] scores = { 3, null, 7, null, 5 };

for (int i = 0; i < scores.Length; i++)
{
    if (scores[i].HasValue)
    {
        Console.WriteLine($"경기 {i + 1}: {scores[i]}점 (진행 완료)");
    }
    else
    {
        Console.WriteLine($"경기 {i + 1}: 미진행");
    }
}
Console.WriteLine();


Console.WriteLine("=== 전체 점수 (미진행 = -1) ===");

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"경기 {i + 1}: {scores[i].GetValueOrDefault(-1)}");
}
Console.WriteLine();


Console.WriteLine("=== 통계 ===");
int count = 0;
int sum = 0;
double avg = 0;
for (int i = 0; i < scores.Length; i++)
{
    if( scores[i].HasValue)
    {
        count++;
        sum += (int)scores[i];
    }
}
avg = sum / (double)count;
Console.WriteLine($"진행된 경기 수: {count}");
Console.WriteLine($"총점: {sum}");
Console.WriteLine($"평균: {avg:F1}");
