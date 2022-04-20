

int [] arr = {1,3,4,5};
foreach ( ref int item in arr.AsSpan())
{
    item++;
}
Console.WriteLine(String.Join(",", arr));