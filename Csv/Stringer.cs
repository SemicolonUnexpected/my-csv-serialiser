using System.Text;

namespace Csv;

public static class Stringer {
    public static string Stringify(IEnumerable<string?> values) {
        StringBuilder stringBuilder = new();

        foreach(string? value in values) {
            if (value is null) stringBuilder.Append(@"\-,");
            else {
                // String builder for speed
                StringBuilder fieldBuilder = new(value);

                // Replace all characters that need escaping
                fieldBuilder.Replace(@"\", @"\\");
                fieldBuilder.Replace(@",", @"\,");
                fieldBuilder.Replace("\n", @"\n");

                stringBuilder.Append(fieldBuilder.ToString());
            }
        }

        return stringBuilder.ToString();
    }

    public static string Stringify(params string?[] values) {
        return Stringify(values);
    }
}
