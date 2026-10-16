using System.Diagnostics.CodeAnalysis;
//Sorry this took so long to get in I had my wisdom teeth taken out last week


//registration problem code

decimal total = 0;


for (decimal i = 1; i < 945001; i += 2)
{
    total += i * i;
}

Console.WriteLine(total);

//problem 1 code

IEnumerable<int> result = ((ParallelQuery<int>)ParallelEnumerable.Range(0, 1000)).Where(n => n % 3 == 0 || n % 5 == 0).Select(res => res);

Console.WriteLine(result.Sum());



