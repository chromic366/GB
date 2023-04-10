int[] array = {54, 12, 23, 4, 54, 23, 74, 8};

int n = array.Length;
int find = 23;

int index = 0;

while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}