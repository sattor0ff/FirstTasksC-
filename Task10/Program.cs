int n, k;
n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
k = arr[n-1];
for (int i = n-2; i >= 0; i--)
{
      arr[i+1]=arr[i];
}
arr[0]=k;
for (int i = 0; i < n; i++)
{
      System.Console.Write(arr[i]+" ");
}