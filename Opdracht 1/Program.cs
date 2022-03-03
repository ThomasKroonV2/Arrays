string[] zin = new string[6];
zin[0] = "Peter";
zin[1] = "is";
zin[2] = "de";
zin[3] = "broer";
zin[4] = "van";
zin[5] = "hans";
foreach (var i in zin)
{
    Console.Write($"{i} ");
}

//enters
Console.WriteLine();
Console.WriteLine();

//switch var
string sen = zin[5];
zin[5] = zin[0];
zin[0] = sen;
foreach (var i in zin)
{
    Console.Write($"{i} ");
}
