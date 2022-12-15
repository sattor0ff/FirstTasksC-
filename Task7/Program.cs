int n,cnt=0;
n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
for (int i = 0; i < n; i++)
{
    if(arr[i]%2!=0){
    System.Console.WriteLine(arr[i]);
    cnt++;
    break;
    }
}
if (cnt==0)
{
    System.Console.WriteLine(0);
}