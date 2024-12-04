using Task1App;

DataManager dataManager = new DataManager();

Console.Write("Press 1. Add a New Employee\r\n" +
              "Press 2. View All Employees\r\n" +
              "Press 3. Search for an Employee by ID\r\n" +
              "Press 4. Update an Employee's Salary\r\n" +
              "Press 5. Delete an Employee\r\n" +
              "Press 6. Exit\r\n");

var command = Console.ReadLine();

while(command != "6")
{
    switch (command)
    {
        case "1":
            Console.WriteLine("Enter the Id: ");
            var resultID = Console.ReadLine();
            bool checkIdResult = Utils.IsInteger(resultID);

            while (!checkIdResult)
            {
                Console.WriteLine("Please enter a number !!!");
                Console.Write("Enter the age:");
                resultID = Console.ReadLine();
                checkIdResult = Utils.IsInteger(resultID);
            }
            int id = Convert.ToInt32(resultID);

            Console.WriteLine("Enter the name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the Phone: ");
            var phone = Console.ReadLine();

            Console.WriteLine("Enter the Salary: ");
            var resultSalary = Console.ReadLine();
            bool checkSalaryResult = Utils.IsInteger(resultSalary);

            while (!checkSalaryResult)
            {
                Console.WriteLine("Please enter a number !!!");
                Console.Write("Enter the salary:");
                resultSalary = Console.ReadLine();
                checkSalaryResult = Utils.IsInteger(resultSalary);
            }
            int salary = Convert.ToInt32(resultSalary);

            Console.WriteLine("Enter the age: ");
            var resultAge = Console.ReadLine();
            bool checkAgeResult = Utils.IsInteger(resultAge);

            while (!checkAgeResult)
            {
                Console.WriteLine("Please enter a number !!!");
                Console.Write("Enter the age:");
                resultAge = Console.ReadLine();
                checkIdResult = Utils.IsInteger(resultAge);
            }
            int age = Convert.ToInt32(resultAge);

            dataManager.AddEmployee(id, name, phone, salary, age);
            break;

        case "2":
            foreach (var emp in dataManager.GetEmployees())
            {
                Console.WriteLine($"ID: {emp.Id}");
                Console.WriteLine($"Name : {emp.Name}");
                Console.WriteLine($"Phone : {emp.Phone}");
                Console.WriteLine($"Salary : {emp.Salary}");
                Console.WriteLine($"Age : {emp.Age}");
            }
            break;

        case "31":
            // Code block for value3
            break;
        case "4":
            // Code block for value3
            break;
        case "5":
            // Code block for value3
            break;
    }

    Console.Write("Press 1. Add a New Employee\r\n" +
              "Press 2. View All Employees\r\n" +
              "Press 3. Search for an Employee by ID\r\n" +
              "Press 4. Update an Employee's Salary\r\n" +
              "Press 5. Delete an Employee\r\n" +
              "Press 6. Exit\r\n");

    command = Console.ReadLine();
}



                 