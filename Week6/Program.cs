string Morning = "  good morning! I'm going back to sleep.  ";

int stringLength = Morning.Length;

Console.WriteLine($"There are {Morning.Length} symbols in the text before trimming.");

string TrimmedMorning = Morning.Trim();

Morning = Morning.Trim();

//char FirstLetter = Morning[0];
//Console.WriteLine(FirstLetter);

Morning = (char.ToUpper(Morning[0]) + Morning.Substring(1));

//Console.WriteLine(Morning[0]);

Console.WriteLine(Morning);

int WordCouner = 1; // If WordCouner = 0, then {WordCouner + 1} below.

for (int i = 0; i < Morning.Length; i++)
{
    if (char.IsWhiteSpace(Morning[i]))
    {
        WordCouner++;
    }
    //Console.WriteLine($"{i} symbol in string: {Morning[i]}");
}

//{
//    if (Morning[i] == ' ')
//    {
//        WordCouner++;
//    }
//}

Console.WriteLine($"Word count in this text is: {WordCouner} words."); // {WordCouner + 1} if WordCouner = 0 above.
Console.WriteLine($"There are {Morning.Length} symbols in the text after trimming the empty space.");