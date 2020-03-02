using System;

namespace Matrix_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();
            matrix1.GetFileName("Input_First_Matrix.txt");
            matrix1.ReadFile();
            matrix2.GetFileName("Input_Second_Matrix.txt");
            matrix2.ReadFile();
            Matrix final = matrix1.Multiply(matrix2);
            final.Write_File("Outpit_Final_Matrix.txt");
        }
    }
}
