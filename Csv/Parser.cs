namespace Csv;

public static class Parser {
    public static string?[][] Parse(string text) {
        string[] lines = text.Split('\n');
        string?[][] fields = new string[lines.Length][];

        for (int i = 0; i < lines.Length; i ++) {
            fields[i] = Lexer.Lex(new LineIterator(lines[i])).ToArray();
        }

        return fields;
    }

    public static string?[][] Parse(IEnumerable<string> lines) {

        List<string?[]> fields = new();

        foreach (string line in lines) {
            System.Console.WriteLine("Lexing");
            fields.Add(Lexer.Lex(new LineIterator(line)).ToArray());
        }

        return fields.ToArray();
    }
}
