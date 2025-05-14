class Program
{
    static void Main(string[] args)
    {
        var list = new LinkedList();
        list.InsertAfter(4.0, 2);
        list.InsertAfter(5.0, 2);

        Console.WriteLine("The initial list is: ");
        list.PrintList();

        double value = 1;
        double? twiceGreater = list.FindTwiceGreater(value);
        if (twiceGreater != null)
        {
            Console.WriteLine($"The first number that is twice greater than {value} is: " + twiceGreater);
        }
        else
        {
            Console.WriteLine($"There is no number that is twice greater than {value} in the list.");
        }
        Console.WriteLine($"The amount of elements larger than 3.14 is {list.FindGreaterThan(3.14)}");
        
        var newList = list.NewList(2.0);
        Console.WriteLine("The new list is: ");
        newList.PrintList();

        list.DeleteGreaterThanAverage();
        Console.WriteLine("The list after deleting elements greater than the average is: ");
        list.PrintList();

        list.InsertAfter(6.0, 2);
        list.InsertAfter(7.0, 2);
        list.InsertAfter(8.0, 2);
        list.InsertAfter(9.0, 2);
        list.InsertAfter(10.0, 2);

        Console.WriteLine("Iterating using foreach: ");
        foreach(var item in list) Console.Write(item + " -> ");
        Console.WriteLine("null");
        Console.WriteLine();

        Console.WriteLine("The element at index 2 is: " + list[2]);

        list.DeleteElementByIndex(2);
        Console.WriteLine("The list after deleting the element at index 2 is: ");
        list.PrintList();
    }
}
