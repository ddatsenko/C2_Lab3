using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task1
{
    class MyMatrix
    {
        private double[,] matrix;
        public int Height
        {
            get => this.matrix.GetLength(0);
        }
        public int Width
        {
            get => this.matrix.GetLength(1);
        }
        public int GetHeight()
        {
            return Height;
        }
        public int GetWidth()
        {
            return Width;
        }
        public MyMatrix(MyMatrix input_A)
        {
            this.matrix = input_A.matrix;
        }
        public MyMatrix(double[,] input_A)
        {
            this.matrix = input_A;
        }
        public MyMatrix(double[][] input_B)
        {
            try
            {
                foreach (double[] arr in input_B)
                {
                    if (input_B.Length != arr.Length)
                    {
                        throw new Exception("Numbers of rows and columns are not equal.");
                    }
                }
                int size = input_B.Length;
                this.matrix = new double[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        this.matrix[i, j] = input_B[i][j];
                    }
                }
            }
            catch
            {
                Console.WriteLine("This matrix is not rectangular.");
            }
        }
        public MyMatrix(String[] txt)
        {
            int size = txt[0].Split(' ').Length;
            try
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (size != txt[i].Split(' ').Length)
                    {
                        throw new Exception("Matrix has a different number of elements.");
                    }
                }
                matrix = new double[txt.Length, size];
                for (int i = 0; i < Height; i++)
                {
                    String[] numbers = txt[i].Split(' ');
                    for (int j = 0; j < Width; j++)
                    {
                        this.matrix[i, j] = Convert.ToDouble(numbers[j]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Matrix has a different number of elements.");
            }
        }
        public double this[int x, int y]
        {
            get 
            { 
                return matrix[x, y]; 
            }
            set 
            { 
                this.matrix[x, y] = value; 
            }
        }
        public double GetElement(int i, int j)
        {
            return this.matrix[i, j];
        }
        public void SetElement(int i, int j, double num)
        {
            this.matrix[i, j] = num;
        }
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            double[,] result = new double[matrix1.Height, matrix2.Width];
            try
            {
                if (matrix1.Width != matrix2.Height)
                {
                    throw new Exception("Width of the first matrix and height of the second matrix aren't equal.");
                }

                for (int i = 0; i < matrix1.Height; i++)
                {
                    for (int j = 0; j < matrix2.Width; j++)
                    {
                        result[i, j] = 0;
                        for (int glass = 0; glass < matrix1.Width; glass++)
                        {
                            result[i, j] += matrix1[i, glass] * matrix2[glass, j];
                        }
                    }
                }
                return new MyMatrix(result);
            }
            catch
            {
                Console.WriteLine("Error: matrix multiplication is not possible.");
            }
            return new MyMatrix(result);
        }
        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {
            double[,] result = new double[matrix1.Height, matrix2.Width];
            try
            {
                if (matrix1.Height != matrix2.Height && matrix1.Width != matrix2.Width)
                    throw new Exception("Height OR width of first matrix and height OR width of second matrix aren't equal!");

                for (int i = 0; i < matrix1.Height; i++)
                {
                    for (int j = 0; j < matrix2.Width; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
                return new MyMatrix(result);
            }
            catch
            {
                Console.WriteLine("Error: matrix addition is not possible.");
            }
            return new MyMatrix(result);
        }
        protected double[,] GetTransponedArray()
        {
            double[,] result = new double[Width, Height];

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    result[i, j] = this.matrix[j, i];
                }
            }
            return result;
        }
        public MyMatrix GetTransponedCopy() => new MyMatrix(this.GetTransponedArray());
        public void TransponeMe() => this.matrix = GetTransponedArray();
        override public String ToString()
        {
            String txt = "";
            if (this.matrix == null) return "The matrix is empty.";
            {
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        txt += this.matrix[i, j] + "\t";
                    }
                    txt += "\n";
                }
            }
            return txt;
        }
    }
}