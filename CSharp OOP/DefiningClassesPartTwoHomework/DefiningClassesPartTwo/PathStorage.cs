using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefiningClassesPartTwo
{
    public static class PathStorage
    {
        // Static methods
        public static void SavePath(Path path, string fileName)
        {
            StreamWriter save = new StreamWriter(String.Format(@"../../{0}.txt", fileName));

            using (save)
            {
                foreach (var point in path.PointsPath)
                {
                    save.WriteLine("#" + point.ToString());
                }
                save.Close();
            }
        }

        public static Path LoadPath(string fileName)
        {
            StreamReader load = new StreamReader(String.Format(@"../../{0}.txt", fileName));

            Path result = new Path();
            using (load)
            {
                List<string> points = load.ReadToEnd().Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int i = 0; i < points.Count; i++)
                {
                    List<string> values = points[i].Split(new char[] {' ', '=', 'x', 'y', 'z'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                    double x = double.Parse(values[0]);
                    double y = double.Parse(values[1]);
                    double z = double.Parse(values[2]);
                    result.AddPoint(x, y, z);
                }
            }
            return result;
        }
    }
}
