using System.Text;
Console.WriteLine(ROT13(Console.ReadLine()));

string ROT13(string text)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < text.Length; i++)
    {
        if (Char.IsLetter(text[i]))
        {
            if ((text[i] > 64 && text[i] < 78) || (text[i] > 96 && text[i] <110))
            {
                sb.Append((char)(text[i]+13));
            }
            else
            {
                sb.Append((char)(text[i] - 13));
            }
        }
        else
        {
            sb.Append(text[i]);
        }
    }
    return sb.ToString();
}