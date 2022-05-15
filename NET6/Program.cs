using NET6;
using NET6.算法;

string[] strings = { "Plase", "sort", "the", "String", "in" };
Array.Sort(strings) ;
foreach (var item in strings) {
    Console.WriteLine(  item);
}