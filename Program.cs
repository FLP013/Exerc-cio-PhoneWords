string Telefone, Phone;

Console.Clear();

Console.Write("telefone: ");
Telefone = Console.ReadLine()!;

Phone = Telefone.ToUpper()
.Replace("A", "2")
.Replace("B", "2")
.Replace("C", "2")
.Replace("D", "3")
.Replace("E", "3")
.Replace("F", "3")
.Replace("G", "4")
.Replace("H", "4")
.Replace("I", "4")
.Replace("J", "5")
.Replace("K", "5")
.Replace("L", "5")
.Replace("M", "6")
.Replace("N", "6")
.Replace("O", "6")
.Replace("P", "7")
.Replace("Q", "7")
.Replace("R", "7")
.Replace("S", "7")
.Replace("T", "8")
.Replace("U", "8")
.Replace("V", "8")
.Replace("W", "9")
.Replace("X", "9")
.Replace("Y", "9")
.Replace("Z", "9");

Console.WriteLine($"O número digitado é {Phone}.");