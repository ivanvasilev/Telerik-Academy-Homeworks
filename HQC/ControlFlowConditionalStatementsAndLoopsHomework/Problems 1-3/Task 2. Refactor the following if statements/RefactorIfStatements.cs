namespace Refactoring
{
    using System;

    class RefactorIfStatements
    {
        static void Main()
        {
            // First if-statement
            Potato potato = new Potato();

            if (potato != null)
            {
                bool peeled = potato.IsPeeled;
                bool notRotten = !potato.IsRotten;

                if (peeled && notRotten)
                {
                    potato.Cook();
                }
            }

            // Second if-statement
            const int MinX = 0;
            const int MaxX = 100;
            const int MinY = 0;
            const int MaxY = 100;

            int x = 25;
            int y = 75;

            bool shouldVisitCell = true;

            if (shouldVisitCell && IsInRange(x, MinX, MaxX) && IsInRange(y, MinY, MaxY))
            {
                VisitCell();
            }
        }

        public static void VisitCell()
        {
            Console.WriteLine("Visited!");
        }

        public static bool IsInRange(int value, int min, int max)
        {
            bool isInRange = value >= min && value <= max;

            return isInRange;
        }

    }
}