using System.Text;

var sb = new StringBuilder();
for (byte i = 0; i < byte.MaxValue; i++)
{
    if (i > 0)
        sb.Append(' ');

    if (i > 0 && i % 16 == 0)
    {
        sb.AppendFormat(" ({0})", i);
        sb.AppendLine();
    }
    
    sb.AppendFormat("{0:X2}", i);
}
sb.AppendFormat(" {0:X2}", byte.MaxValue);
sb.AppendFormat("  ({0})", byte.MaxValue + 1);

Console.WriteLine(sb.ToString());
Console.ReadKey();