namespace ExponentsLab;

class Program
{
	static void Main(string[] args)
	{
		const string format = "{0,-7}\t{1,-7}\t{2,-7}";

		Console.WriteLine("Learn your squares and cubes!\n");

		do
		{
			Console.WriteLine("Please enter a number:");
			int count = GetInput(0);

			Console.WriteLine("\nNumber\tSquared\tCubed");
			Console.WriteLine("=======\t=======\t=======\n");
			for (int i = 1; i <= count; i++)
				Console.WriteLine(string.Format(format, i, GetSquared(i), GetCubed(i)));

		} while (GetContinue("Would you like to continue?"));
	}

	static int GetInput(int min)
	{
		int result = int.Parse(Console.ReadLine());
		while (result <= min)
		{
			Console.WriteLine($"Please enter a number greater than {min}");
			result = int.Parse(Console.ReadLine());
		}
		return result;
	}

	static int GetSquared(int num)
	{
		return num * num;
	}

	static int GetCubed(int num)
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
