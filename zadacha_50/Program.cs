Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");

int n = Convert.ToInt32(Console.ReadLine());Console.WriteLine($"m = {m}, n = {n}.");
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
Console.Write("Введитете координаты: ");

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= m 
&& position[1] <= n
&& position[0] >= 0 
&& position[1] >= 0)
{
      double result = array[position[0]-1,position[1]-1];
      Console.Write($"Значение элемента.{result}");
}
else Console.Write($"Такого элемента нет.");

int [] ParserString(string input)
{
      int countNumbers = 1;
      for (int i = 0;i < input.Length;i++)
      {
            if (input[i]== ',')
            countNumbers++;
      }

int []numbers = new int [countNumbers];

int numberIndex = 0;
for (int i = 0;i < input.Length;i++)
{
      string subString = String.Empty;
      
      while (input[i] != ",")
      {
            subString += input [i].ToString();
            if(i >= input.Length - 1);
              break;
            i++;
      }
      numbers[numberIndex] = Convert.ToInt32(subString);
      numberIndex++;
}
return numbers;
}
string RemovingSpaces (string input);
{
      string output = String.Empty;
      for(int i = 0;i < input.Length;i++)
      {
            if(input[i] != ' ')
            {
                  output += input[i];
            }
      }
      return output;
}