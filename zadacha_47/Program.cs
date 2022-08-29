Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");
double [,] array = new double [m,n];
CreateArrayDouble(array);
WriteArray(array);
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
void WriteArray(double[,]array)
{
     for(int i = 0;i < m;i++)
      {
            for(int j = 0;j < m;j++)
            {
                  double Number = Math.Round(array[i,j],1);
                  Console.Write(Number + "|");
            } 
            Console.WriteLine();
      }
}