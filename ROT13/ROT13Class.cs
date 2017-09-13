class ROT13Class
{
    private static string[] alfabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " " };
    private static string[] alfabetROT13 = { "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", " " };

    private static string[] Split(string value)//Slit string to letters
    {
        string[] Splited = new string[value.Length];
        int i = 0;
        foreach (char c in value)
        {
            Splited[i] += c;
            i++;
        }
        return Splited;
    }
    public static string Rot13(string value)//convert to ROT13 and from ROT13
    {
        string[] Splited = Split(value);
        value = string.Empty;
        for (int i = 0; i < Splited.Length; i++)
        {
            for (int j = 0; j < alfabet.Length; j++)
            {
                if (Splited[i] == alfabet[j])
                {
                    value += alfabetROT13[j];
                }
            }
        }
        return value;
    }
}
