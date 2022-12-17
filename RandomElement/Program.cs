string[] TypesOfBasilurTea = { "White moon", "Magic nights", "Frosty afternoon", "Fruit shop", "Winter tea" }; 

Random tea = new Random();
int RandomIndex = tea.Next(0, TypesOfBasilurTea.Length);

Console.WriteLine($"Today I'm goind to drink 10 cups of Basilur {TypesOfBasilurTea[RandomIndex]}.");