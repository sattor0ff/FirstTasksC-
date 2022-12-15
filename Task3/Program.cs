int n, cnt=0;
n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [n];
for (int i=0; i<n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i=0; i<n; i++)
{
    if(arr[i]>0)
    {cnt++;}
}
System.Console.Write(cnt);
