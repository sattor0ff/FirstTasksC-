    int n,cnt=0;
    n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n]; 
    for (int i = 0; i < n; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    } 
    for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (arr[i] == arr[j])
            cnt++;
    }
}
    System.Console.WriteLine(cnt);