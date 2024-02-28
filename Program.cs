int[] numbers = {5,72,3,14,7,1};

Console.WriteLine("printing the array before sort");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("  " + numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Here is the array after the execution of the Selection Sort Algorithm: ");
Selection_Sort(numbers);
Console.WriteLine("");
static void Selection_Sort(int[] arr)
{
    // min is used to track least number 
    int min;
    int temp;

    for (int i = 0; i < arr.Length; i++)
    {
       
        min = i;
        for (int x = i + 1; x < arr.Length; x++)
        {
            if (arr[x] < arr[min])
            {
                min = x;
            }
        } 

        if (min != i)
        {
            temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
        Console.Write(" -- " + arr[i]);
    }
} 
