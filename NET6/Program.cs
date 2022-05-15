using NET6;
using NET6.算法;


int[] arr = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
List<int> arr2 = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToList();
arr2.Sort();//排序
int max = arr2.Where(x => x < arr[1]).Select(x => arr[1] -= x).Count();//计数
Console.WriteLine(max);