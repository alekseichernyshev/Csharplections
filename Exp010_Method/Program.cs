int[] array = { 13, 21, 13, 41, 91, 51, 16, 17, 81, 91 };

int n = array.Length;
int find = 91;

int index = 0;

while(index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}
