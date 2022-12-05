


//char[,] shipCreates = new char[10, 28] { { }, {'B', 'V', 'W', 'T', 'Q', 'N', 'H', 'D'}, {'B', 'W', 'D'}, { 'C', 'J'}

List<char> emptyrow = new List<char>();
List<char> firstrow = new List<char>{'D', 'H', 'N', 'Q', 'T', 'W', 'V', 'B'};
List<char> secondrow = new List<char> { 'D', 'W', 'B'};
List<char> thirdtrow = new List<char> { 'T', 'S', 'Q', 'W', 'J', 'C'};
List<char> fourthrow = new List<char> { 'F', 'J', 'R', 'N', 'Z', 'T', 'P'};
List<char> fifthrow = new List<char> { 'G', 'P', 'V', 'J', 'M', 'S', 'T'};
List<char> sixrow = new List<char> { 'B', 'W', 'F', 'T', 'N'};
List<char> seventhrow = new List<char> { 'B', 'L', 'D', 'Q', 'F', 'H', 'V', 'N' };
List<char> eighthrow = new List<char> { 'H', 'P', 'F', 'R'};
List<char> ninthrow = new List<char> { 'Z', 'S', 'M', 'B', 'L', 'N', 'P', 'H' };

List<char>[] columns = new List<char>[10] { emptyrow, firstrow, secondrow, thirdtrow, fourthrow, fifthrow, sixrow, seventhrow, eighthrow, ninthrow };


string[] lines = File.ReadLines(@"C:\Users\evka\Documents\adventofcode5.txt")
                     .Skip(10)
                     .Take(Int32.MaxValue)
                     .ToArray();

foreach (string line in lines)
{
    string[] input = line.Split(' ');

    int iterations = Convert.ToInt32(input[1]);
    int fromContainer = Convert.ToInt32(input[3]);
    int toContainer = Convert.ToInt32(input[5]);
    List<char> elements = new List<char>();
    for (int i = 0; i < iterations; i++)
    {
        char element = columns[fromContainer].Last();
        columns[fromContainer].RemoveAt(columns[fromContainer].Count - 1);
        elements.Add(element);
    }

    for (int i = 0; i < iterations; i++)
    {
        char e = elements.Last();
        elements.RemoveAt(elements.Count-1);
        columns[toContainer].Add(e);
    }

}

foreach(var col in columns)
{
    foreach(var c in col)
    {
        Console.Write(c);
        Console.Write(", ");
    }
    Console.WriteLine("-");
} 
