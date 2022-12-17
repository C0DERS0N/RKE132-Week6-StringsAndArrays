//string[] screen = {"CMYK", "RGB", "sRGB"};

string[] screen = new string[3];

screen[0] = "cMYK";
screen[1] = "hSV";
screen[2] = "rGB";

Console.WriteLine($"{screen[0]}, {screen[1]}, {screen[2]}");

int screenArrayLength = screen.Length;
Console.WriteLine($"There are {screenArrayLength} things in the array.");

for (int i = 0; i < screenArrayLength; i++)
{
    screen[i] = screen[i].Replace(screen[i][0], char.ToUpper(screen[i][0]));
}

//for (int i = 0; i < screenArrayLength; i++)
//{
//    Console.WriteLine(screen[i]);
//}

foreach (string AnyElementName in screen)
{
    Console.WriteLine(AnyElementName);
}