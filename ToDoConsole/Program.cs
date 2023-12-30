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
3. Update Task
4. Exit");
                userInput = Console.ReadLine() ?? "";

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter a task to add: ");
                        toDoList.Add(Console.ReadLine() ?? "");
                        break;
                    case "2":
                        Console.Write("Enter task index to remove: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out var index)
                            && index >= 0
                            && index < toDoList.Count)
                        {
                            toDoList.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index!");
                        }
                        break;
                    case "3":
                        Console.Write("Enter task index to update: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out var updateIndex)
                            && updateIndex >= 0
                            && updateIndex < toDoList.Count)
                        {
                            Console.Write("Enter new task: ");
                            toDoList[updateIndex] = Console.ReadLine() ?? "";
                        }
                        else
                        {
                            Console.WriteLine("Invalid index!");
                        }
                        break;
                }
            } while (userInput != "4");
        }
    }
}