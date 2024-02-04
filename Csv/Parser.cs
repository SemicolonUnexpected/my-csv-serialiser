namespace Csv;

public static class Parser {
    public static List<string?> ParseLine(string line) {
        return Lexer.Lex(new LineIterator(line));
    }

    public static string?[][] ParseText(string text) {
        string[] lines = text.Split('\n');
        string?[][] output = new string[lines.Length][];
        for(int i = 0; i < lines.Length; i++) {
            output[i] = ParseLine(lines[i] + '\n').ToArray();
        }
        return output;
    }
}
