using System.Text;

var sb = new StringBuilder();
for (byte i = 0; i < byte.MaxValue; i++)
{
    if (i > 0)
        sb.Append(' ');

    if (i % 16 == 0)
        sb.AppendLine();
    
    sb.AppendFormat("{0:X2}", i);
}
sb.AppendFormat(" {0:X2}", byte.MaxValue);

Console.WriteLine(sb.ToString());
Console.ReadKey();