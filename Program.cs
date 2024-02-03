using Csv;

string test = @"," + '\n';

Console.WriteLine($"{test}\nLength: {test.Length}");

LineIterator iterator = new LineIterator(test);

var fields = Lexer.Lex(iterator);

System.Console.WriteLine("----- Output ------");

System.Console.WriteLine(string.Join("\n", fields.Select(x => x is null ? "null" : x)));
