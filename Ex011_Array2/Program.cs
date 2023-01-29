Console.Clear();
void Fill(int[] collect)
{
     int l=collect.Length;
     int i=0;
     while (i<l)
     {
        collect[i]=new Random().Next(1,10);
        i++;
     }

}


void Print(int[] col)
{
     int count=col.Length;
     int pos=0;
     while (pos<count)
     {
     Console.WriteLine(col[pos]); 
     pos++;
     }

}

int [] array = new int[10];

Fill(array);
Print(array);
