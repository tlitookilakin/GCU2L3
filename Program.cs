namespace ExponentsLab;

class Program
{
	static void Main(string[] args)
	{
		const string format = "{0,8:N0}\t{1,9:N0}\t{2,13:N0}";
		uint max_value = (uint)Math.Cbrt(uint.MaxValue);

		Console.WriteLine("Learn your squares and cubes!\n");

		do
		{
			Console.WriteLine("Please enter a number:");
			uint count = GetInput(1, max_value);

            Console.WriteLine();
            Console.WriteLine(string.Format(format, "Number", "Squared", "Cubed"));
			Console.WriteLine(string.Format(format, "=======", "=======", "======="));
			for (uint i = 1; i <= count; i++)
				Console.WriteLine(string.Format(format, i, GetSquared(i), GetCubed(i)));

		} while (GetContinue("Would you like to continue?"));
	}

	static uint GetInput(uint min, uint max)
	{
		uint result = uint.Parse(Console.ReadLine());
		while (result < min || result > max)
		{
			Console.WriteLine($"Please enter a number between {min} and {max}");
			result = uint.Parse(Console.ReadLine());
		}
		return result;
	}

	static uint GetSquared(uint num)
	{
		return num * num;
	}

	static uint GetCubed(uint num)
	{
		return num * num * num;
	}
	static bool GetContinue(string message)
	{
		Console.WriteLine(message + " [Y/N]");
		
		while (true)
		{
			string? input = Console.ReadLine();

			switch(input)
			{
				case "y":
				case "Y":
					return true;
				case "n":
				case "N":
					return false;
			}
		}
	}
}
