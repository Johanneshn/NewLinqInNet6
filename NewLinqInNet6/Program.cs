



var arr = new[] { "1", "2", "3", "4", "5", "6" };
var arr2 = new[] { "a", "b", "c", "d", "e" };


var chunked = arr.Chunk(3);



var secondLastItem = arr.ElementAt(^2);

var thirditem = arr.Take(2);
var firstThreeitems = arr.Take(0..3);
var lastTwoitems = arr.Take(^2..^0);




if (arr.TryGetNonEnumeratedCount(out var count))
{
    Console.WriteLine(count);
}
else
{
    Console.WriteLine(arr.Count());
}

var zip = arr.Zip(arr2, new[] { 1, 2, 3 });


var persons = new List<Person> { new Person(10), new Person(50) };

var youngestOld = persons.OrderBy(person => person.Age).Last();
var youngestNew = persons.MinBy(person => person.Age);







Console.ReadKey();

class Person
{
    public Person (int age)
    {
        Age = age;
    }

    public int Age { get; private set; }

}





