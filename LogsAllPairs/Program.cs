int[] arr = { 1, 2, 3, 4, 5 };

for (int i = 0; i < arr.Length; i++)
{
    int aux = arr[i];
    for (int j = 0; j < arr.Length; j++)
    {
        int aux2 = arr[j];
        Console.WriteLine(aux + "," + aux2);
    }
}

// Big O of the algorithm to show all pairs = O(n(1st foor loop) * n (2do for loop)) lo que sería = O(n^2)