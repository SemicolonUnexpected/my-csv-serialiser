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

                // Add a comma separator
                fieldBuilder.Append(',');

                stringBuilder.Append(fieldBuilder.ToString());
            }
        }

        // Remove the trailing comma from the string, add a trailing newline and return the final text
        stringBuilder.Remove(stringBuilder.Length - 1, 1);
        stringBuilder.Append('\n');
        return stringBuilder.ToString();
    }
}
