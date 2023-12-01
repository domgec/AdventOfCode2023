try
{
    using StreamReader sr = new("Calibration.txt");
    string? line;
    int sum = 0;

    while ((line = sr.ReadLine()) != null)
    {
        string digits = new(line.Where(char.IsDigit).ToArray());
        char[] toAdd = new[] { digits.First(), digits.Last() };

        sum += int.Parse(new(toAdd));
    }

    Console.WriteLine($"Sum of all calibration values: {sum}");
}
catch (Exception e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}
