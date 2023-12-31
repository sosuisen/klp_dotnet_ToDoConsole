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

                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. Exit");
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
                }
            } while (userInput != "3");
        }
    }
}