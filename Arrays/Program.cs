var array1 = new int[4];

array1[0] = 7;
array1[1] = 5;
array1[2] = 9;
array1[3] = 8;

Console.WriteLine(array1);
Console.WriteLine(array1[0]);

// Array Initializer
var array2 = new int[] { 8, 16, 21, 26 };

Console.WriteLine(array2);
Console.WriteLine(array2[0]);   

// alternative syntax
int[] array3 = {4, 5, 6, 7};
Console.WriteLine(array3);
Console.WriteLine(array3[0]);

// Uninitialized elements
int[] array4 = new int[5];
Console.WriteLine(array4[0]);


// Example array of reference type
Person[] persons = new Person[2];
persons[0] = new Person("James");
persons[1] = new Person("Covenant");

Console.WriteLine(persons);
var person0 = persons[0];
Console.WriteLine(person0.Name);

foreach (Person person in persons)
{
    Console.WriteLine(person.Name);
}

public class Person 
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}