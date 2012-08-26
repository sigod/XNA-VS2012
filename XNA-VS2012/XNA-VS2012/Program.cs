using System;

namespace XNA_VS2012
{
	static class Program
	{
		static void Main(string[] args)
		{
			using (Game1 game = new Game1())
			{
				game.Run();
			}
		}
	}
}