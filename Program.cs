// See https://aka.ms/new-console-template for more information
string valor = null;
string s2 = valor ?? "nothing";
valor = valor?.Trim().ToUpper();
Console.WriteLine(s2);
