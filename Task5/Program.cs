int n;
n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [n];
for (int i=0; i<n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i=1; i<n; i++)
{
    if(arr[i]>0 && arr[i-1]>0 || arr[i]<0 && arr[i-1]<0)
    {
       System.Console.Write($"{arr[i-1]} {arr[i]}"); 
       break;
    }
    
}