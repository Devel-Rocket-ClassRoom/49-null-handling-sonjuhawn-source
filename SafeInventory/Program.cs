using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

List<string> player1 = null;
List<string> player2 = new List<string>();
List<string> player3 = new List<string> { "검", "방패", "포션" };

Console.WriteLine("=== 플레이어 1(인벤토리 없음) ===");
Console.WriteLine($"아이템 수: {player1?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {(player1?.Count != 0 ? player1?[0] ?? "없음" : "없음")}");
Console.WriteLine($"마지막 아이템: {(player1?.Count != 0 ? player1?[^1] ?? "없음" : "없음")}");

Console.WriteLine("=== 플레이어 2(인벤토리 없음) ===");
Console.WriteLine($"아이템 수: {player2?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {(player2?.Count != 0 ? player2?[0] ?? "없음" : "없음")}");
Console.WriteLine($"마지막 아이템: {(player2?.Count != 0 ? player2?[^1] ?? "없음" : "없음")}");

Console.WriteLine("=== 플레이어 3(인벤토리 없음) ===");
Console.WriteLine($"아이템 수: {player3?.Count ?? 0}");
Console.WriteLine($"첫 번째 아이템: {(player3?.Count != 0 ? player3?[0] ?? "없음" : "없음")}");
Console.WriteLine($"마지막 아이템: {(player3?.Count != 0 ? player3?[^1] ?? "없음" : "없음")}");