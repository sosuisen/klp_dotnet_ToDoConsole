namespace ToDoListConsole
{
    class Program
    {
        static void Main()
        {
            var toDoList = new List<string>();
            string userInput;
            do
            {
                Console.WriteLine("\nToDo List:");
                foreach (var item in toDoList)
                {
                    Console.WriteLine("- " + item);
                }

                Console.WriteLine(@"
Choose an option:
1. Add Task
2. Remove Task
3. Exit");
                userInput = Console.ReadLine() ?? "";

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter a task to add: ");

                        // Add task to list
                        // Use Console.ReadLine() to get a task



                        break;
                    case "2":
                        Console.Write("Enter task index to remove: ");

                        // Remove task from list
                        // Use Console.ReadLine() to get an index number



                        break;
                }
            } while (userInput != "3");
        }
    }
}