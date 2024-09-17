using Tyuiu.ParamonovaVA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.ParamonovaVA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массивва = " + DataService.AdditionArray(numsArray));

            Console.WriteLine("Разность элементов массивва = " + DataService.SubtractionArray(numsArray));

            Console.WriteLine("Произведение элементов массивва = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
