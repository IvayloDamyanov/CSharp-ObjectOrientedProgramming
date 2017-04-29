using System;

namespace DefiningClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point3D tests
            Point3D pointOne = new Point3D(2, 3, 5);
            Point3D pointTwo = new Point3D(-1, -4, 0);
            Console.WriteLine("--------\nPoint3D tests:\n--------");
            Console.WriteLine("Point 1 coordinates: "+pointOne.ToString());
            Console.WriteLine("Point 2 coordinates: "+pointTwo.ToString());
            Console.WriteLine("Distance between points: "+Calculation.PointsDistance(pointOne, pointTwo));

            //Path tests
            string textFileOne = @"../../textfiles/fileOne.txt";
            string textFileTwo = @"../../textfiles/fileTwo.txt"; //изтрий всичко във fileTwo.txt и го провери след стартиране на програмата, за да видиш, че копира всичко от fileOne.txt
            PathStorage.ReadFromFile(textFileOne);
            PathStorage.WriteOnFile(textFileTwo, Path.ReturnPoints());


            //Generic tests
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 32; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("--------\nGeneric tests:\n--------");

            Console.WriteLine("List ToString: \n" + list.ToString() + "\n");

            Console.WriteLine("Access pos 27 " + list.Access(27));

            list.Remove(27);
            Console.WriteLine("Position 27 after Remove: " + list.Access(27));

            list.Insert(1337, 28);
            Console.WriteLine("position 28: " + list.Access(28));

            Console.WriteLine("1337 found at pos: " + list.Find(1337));

            Console.WriteLine("Min: " + list.Min());
            Console.WriteLine("Max: " + list.Max());

            list.Clear();
            Console.WriteLine("\nList ToString after Clear: \n" + list.ToString() + "\n");

            Matrix<int> matrixOne = new Matrix<int>(4, 5);
            Matrix<int> matrixTwo = new Matrix<int>(4, 5);
            Matrix<int> resultmatrix = new Matrix<int>(4, 5);
            //Matrix<int> matrixOne = new Matrix<int>(4, 5); 
            //Matrix<int> matrixTwo = new Matrix<int>(3, 5); това е за проба на Exception-а, когато матриците са с различен размер
            resultmatrix = matrixOne + matrixTwo;
            resultmatrix = matrixOne - matrixTwo;
            resultmatrix = matrixOne * matrixTwo;

            //не ми остана време за тест на Версията.
        }
    }
}
