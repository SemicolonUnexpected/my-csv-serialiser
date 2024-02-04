using Csv;

string?[] original = new string[] {
    "test",
    "test",
    "test",
};

Console.WriteLine(original.ToString());

string stringified = Stringer.Stringify(original);

Console.WriteLine("Input has been stringified:\n" + stringified);

string?[] copied = Parser.ParseLine(stringified);

Console.WriteLine($"Stringified has been parsed. Sequence equality : {copied.SequenceEqual(original)}");

//    Console.Write(">>> ");
//    string test = Console.ReadLine() + '\n';
//
//    Console.WriteLine($"{test}\nLength: {test.Length}");
//
//    var fields = Parser.ParseLine(test);
//
//    System.Console.WriteLine("----- Output ------");
//
//    System.Console.WriteLine(string.Join("\n", fields.Select(x => x is null ? "null" : x)));
//}
