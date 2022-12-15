    int n,k;
    n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n]; 
    for (int i = 0; i < n; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    } 
    for (int i = 0; i<n-1; i+=2)
    {
          k = arr[i];
          arr[i] = arr[i + 1];
          arr[i + 1] = k; 
    } 
    for (int i = 0; i < n; i++)
    {
          System.Console.Write(arr[i]+" ");
    }