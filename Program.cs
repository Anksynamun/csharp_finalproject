// See https://aka.ms/new-console-template for more information
int i, j, m = 0;
Console.Write("Введите любые слова: ");
string[] array = Array.ConvertAll(Console.ReadLine()!.Split(), Convert.ToString)!;
j = array.Length;
string[] newarray = new string[j];
for (i = 0; i < array.Length; i++)
{
int stringlength = array[i].Length;
if (stringlength <= 3)
    {
        newarray[m] = array[i];
        Console.Write(newarray[m] + ", ");
        m++;
    }
}
Console.WriteLine();