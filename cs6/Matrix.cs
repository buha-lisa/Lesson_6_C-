namespace cs6
{
    internal class Matrix
    {
        public int Rows;
        public int Cols;
        public int[,] Data;

        public Matrix(int row, int col)
        {
            Rows = row;
            Cols = col;
            Data = new int[row, col];
            
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result.Data[i, j] = a.Data[i, j] + b.Data[i, j];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result.Data[i, j] = a.Data[i, j] - b.Data[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result.Data[i, j] = a.Data[i, j] * b.Data[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix a, int b)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result.Data[i, j] = a.Data[i, j] * b;
                }
            }
            return result;
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            return a.Data == b.Data;
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            return a.Data != b.Data;
        }
        public override bool Equals(object obj)
        {
            if (obj is Matrix)
            {
                Matrix other = (Matrix)obj;
                return this.Data == other.Data;
            }
            return false;
        }

    }
}
