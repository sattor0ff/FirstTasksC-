int n, cnt = 0;
n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n ; i++)
{
    cnt = 0;
    for (int j = 0 ; j < n; j++)
    {
        if (arr[i] == arr[j] && i != j)
            cnt++;
    }
    if (cnt==0)
    {
        System.Console.Write($"{arr[i]} ");
    } 
}