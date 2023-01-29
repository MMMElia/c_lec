Console.Clear();
int[] array={1,5,6,7,9,4,3,5,6,8,5,6};
int n=array.Length;
int find=6;
int i=0;

while (i<n)
{
if (array[i]==find) {Console.WriteLine(i);
                     break;}

i++;
}

