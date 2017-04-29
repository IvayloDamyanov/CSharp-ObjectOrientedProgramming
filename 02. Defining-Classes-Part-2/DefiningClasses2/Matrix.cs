using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    class Matrix<T>
    {
        private int _row;
        private int _col;
        private T[,] MatrixArray { get; set; }

        public int Row
        {
            get
            {
                return this._row;
            }
        }

        public int Col
        {
            get
            {
                return this._col;
            }
        }

        public Matrix(int row, int col)
        {
            this._row = row;
            this._col = col;
            this.MatrixArray = new T[row, col];
        }

        public T this[int row, int col]
        {
            get
            {
                return MatrixArray[row, col];
            }
            set
            {
                MatrixArray[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            isSizeSame(matrixOne, matrixTwo);
            Matrix<T> resultMatrix = new Matrix<T>(matrixOne._row, matrixOne._col);
            for (int r = 0; r < matrixOne._row; r++)
            {
                for (int c = 0; c < matrixOne._col; c++)
                {
                    dynamic sum = (dynamic)matrixOne[r, c] + matrixTwo[r, c];
                    resultMatrix[r, c] = sum;
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            isSizeSame(matrixOne, matrixTwo);
            Matrix<T> resultMatrix = new Matrix<T>(matrixOne._row, matrixOne._col);
            for (int r = 0; r < matrixOne._row; r++)
            {
                for (int c = 0; c < matrixOne._col; c++)
                {
                    dynamic sum = (dynamic)matrixOne[r, c] - matrixTwo[r, c];
                    resultMatrix[r, c] = sum;
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            isSizeSame(matrixOne, matrixTwo);
            Matrix<T> resultMatrix = new Matrix<T>(matrixOne._row, matrixOne._col);
            for (int r = 0; r < matrixOne._row; r++)
            {
                for (int c = 0; c < matrixOne._col; c++)
                {
                    dynamic sum = (dynamic)matrixOne[r, c] * matrixTwo[r, c];
                    resultMatrix[r, c] = sum;
                }
            }
            return resultMatrix;
        }

        private static bool SizeCheck (Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            bool output = true;
            if (matrixOne.Row != matrixTwo.Row || matrixOne.Col != matrixTwo.Col)
            {
                output = false;
            }
            return output;
        }

        private static void isSizeSame(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (SizeCheck(matrixOne, matrixTwo) != true)
            {
                throw new Exception("Matrix size is not the same");
            }
        }

        public static bool operator true(Matrix<T> matrix) //не разбрах, от условието, за какво точно трябва да проверявам, иначе ще е нещо такова ...
        {
            bool output = true;
            for (int r = 0; r < matrix._row; r++)
            {
                for (int c = 0; c < matrix._col; c++)
                {
                    if (matrix[r, c] == null)
                    {
                        output = false;
                        break;
                    }
                }
            }
            return output;
        } 

        public static bool operator false(Matrix<T> matrix) //не разбрах, от условието, за какво точно трябва да проверявам, иначе ще е нещо такова ...
        {
            bool output = false;
            for (int r = 0; r < matrix._row; r++)
            {
                for (int c = 0; c < matrix._col; c++)
                {
                    if (matrix[r, c] != null)
                    {
                        output = true;
                        break;
                    }
                }
            }
            return output;
        }
    }
}
