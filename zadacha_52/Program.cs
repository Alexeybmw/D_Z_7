Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");

double [,] array = new double [m,n];
CreateArrayDouble(array);

Console.WriteLine();
void CreateArrayDouble(double[,]array)
{
      for(int i = 0;i < m;i++)
      {
           for( int j = 0;j < m;j++)
            {
                  array[i,j] = new Random().NextDouble()*10;
            }
      }
}



int[,] arrayWhole = new int[m,n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nсреднее арефметическое: \n");
for (int i = 0;i < n;i++)
{
      double ariphmeticMean = 0;
      for (int j = 0; j < m;j++)
      {
            ariphmeticMean +=arrayWhole[j,i];
      }
      ariphmeticMean = Math.Round(ariphmeticMean / m, 1 );
      Console.WriteLine($"столбца №  {i+1} | {ariphmeticMean}");
}

int[,] TransformationArrayWhole(double[,] array)
{
      int [,] arrayWhole = new int[array.GetLength(0),array.GetLength(1)];
      for (int i = 0; i < array.GetLength(0);i++)
      {
            for (int j = 0; j < array.GetLength(1);j++)
            {
                  arrayWhole[i,j] = Convert.ToInt32(array[i,j]);
            }
      }
      return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole)
{
      for (int i = 0;i < m;i++)
      {
            for (int j = 0;j < n; j++)
            {
                  Console.Write(arrayWhole[i,j] + " ");
            }
            Console.WriteLine();
      }
}