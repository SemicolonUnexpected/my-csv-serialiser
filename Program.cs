﻿using Csv;

while (true) {
    Console.Write(">>> ");
    string test = Console.ReadLine() + '\n';

    Console.WriteLine($"{test}\nLength: {test.Length}");

    LineIterator iterator = new LineIterator(test);

    var fields = Parser.Lex(iterator);

    System.Console.WriteLine("----- Output ------");

   System.Console.WriteLine(string.Join("\n", fields.Select(x => x is null ? "null" : x)));
}
