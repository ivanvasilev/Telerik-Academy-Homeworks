namespace Shape
{
    using System;

    public class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be a positive number!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be a positive number!");
                }
                this.height = value;
            }
        }

        public static Shape GetRotatedSize(Shape shape, double angleOfTheShapeThatWillBeRotated)
        {
            double cosinusTimesWidth = Math.Abs(Math.Cos(angleOfTheShapeThatWillBeRotated)) * shape.Width;
            double sinusTimesWidth = Math.Abs(Math.Sin(angleOfTheShapeThatWillBeRotated)) * shape.Width;
            double sinusTimesHeight = Math.Abs(Math.Sin(angleOfTheShapeThatWillBeRotated)) * shape.Height;
            double cosinusTimesHeight = Math.Abs(Math.Cos(angleOfTheShapeThatWillBeRotated)) * shape.Height;

            double rotatedWidth = cosinusTimesWidth * sinusTimesHeight;
            double rotatedHeight = sinusTimesWidth * cosinusTimesHeight;

            Shape rotatedShape = new Shape(rotatedWidth, rotatedHeight);

            return rotatedShape;
        }
    }
}