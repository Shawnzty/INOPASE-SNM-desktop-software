List<int> scores = [97, 92, 81, 60];

// define the query expression
IEnumerable<int> scoreQuery = 
    from score in scores
    where score > 80
    select score;

foreach (int i in scoreQuery)
{
    Console.WriteLine(i + " ");
}
