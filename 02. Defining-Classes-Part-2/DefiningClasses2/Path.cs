using System;
using System.Collections.Generic;
using System.IO;

namespace DefiningClasses2
{
    class Path
    {
        private static List<Point3D> PointPath = new List<Point3D>();

        public static List<Point3D> List
        {
            get
            {
                return PointPath;
            }
            set
            {
                List = PointPath;
            }
        }

        public static void SavePoint(Point3D point)
        {
            PointPath.Add(point);
        }
        public static List<Point3D> ReturnPoints()
        {
            return PointPath;
        }
    }

    class PathStorage
    {
        public static void ReadFromFile(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string text = reader.ReadToEnd();
            string[] pattern = new string[] { Environment.NewLine };
            string[] textArray = text.Split(pattern, StringSplitOptions.None);
            for (int i = 0; i < textArray.Length; i++)
            {
                string row = textArray[i];
                char[] separator = { ',' };
                string[] coordinatesString = row.Split(separator);
                double[] coordinates = new double[coordinatesString.Length];

                for (int j = 0; j < coordinatesString.Length; j++)
                {
                    coordinates[j] = double.Parse(coordinatesString[j]);
                }
                Point3D point = new Point3D(coordinates[0], coordinates[1], coordinates[2]);
                Path.SavePoint(point);
            }
        }

        public static void WriteOnFile(string filename, List<Point3D> pathList)
        {
            StreamWriter writer = new StreamWriter(filename);
            using (writer)
            {
                foreach (Point3D point in pathList)
                {
                    writer.WriteLine(point);
                }
            }    
        }
    }
}
