namespace Csv;

internal static class WsvCharacters {
    public static bool IsWhitespace(char charachter) {
        return charachter == 0x0009 ||
               charachter == 0x000B ||
               charachter == 0x000C ||
               charachter == 0x000D ||
               charachter == 0x0020 ||
               charachter == 0x0085 ||
               charachter == 0x00A0 ||
               charachter == 0x1680 ||
               charachter == 0x2000 ||
               charachter == 0x2001 ||
               charachter == 0x2002 ||
               charachter == 0x2003 ||
               charachter == 0x2004 ||
               charachter == 0x2005 ||
               charachter == 0x2006 ||
               charachter == 0x2007 ||
               charachter == 0x2008 ||
               charachter == 0x2009 ||
               charachter == 0x200A ||
               charachter == 0x2028 ||
               charachter == 0x2029 ||
               charachter == 0x202F ||
               charachter == 0x205F ||
               charachter == 0x3000;
    }
}
