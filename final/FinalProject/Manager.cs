using System.Diagnostics.CodeAnalysis;

public class Manager
{
    private float _invoicedQuantity;

    private List<Employee> employees = new List<Employee>();
    private List<Area> areas = new List<Area>();
    private List<Supplies> suppliesList = new List<Supplies>();

    public void Run()
    {

        int option = 0;
        _invoicedQuantity = 0;
        while (option != 9) // 7 will take the user out of the loop
        {
            if (option == 1 || option == 2) //Add a Doctor or nurse
            {
                AddNewEmployee(option);
            }
            else if (option == 3 || option == 4)//Add a private room or shared room
            {
                AddRoom(option);
            }
            else if (option == 5) // Add clinic
            {
                AddClinic();
            }
            else if (option == 6) // Add supplies
            {
                AddSupplies();
            }
            else if (option == 7) // Modify Fee for employees
            {
                ModifyEmployeeFee();
            }
            else if (option == 8)// Display all
            {
                DisplayAllCosts();
            }
            Console.WriteLine("Welcome to the Hospital Management System");
            Console.WriteLine($"Your invoice is ${_invoicedQuantity}");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Add Nurse");
            Console.WriteLine("3. Add Private Room ");
            Console.WriteLine("4. Add Shared Room");
            Console.WriteLine("5. Add Clinic");
            Console.WriteLine("6. Add Supplies");
            Console.WriteLine("7. Modify Employees Fees");
            Console.WriteLine("8. Display all details ");
            Console.WriteLine("9. Quit");
            Console.Write("Please select an option: ");
            string optionText = Console.ReadLine();
            option = int.Parse(optionText);
        }

    }
    
    public void AddSupplies()
    {
        Console.Write("What supplies did the patient need? ");
        string name = Console.ReadLine();

        Console.Write("What is the unitary cost? ");
        string unitaryCostText = Console.ReadLine();
        float unitaryCost = float.Parse(unitaryCostText);

        Console.Write("What is the amount of supplies needed? ");
        string amountText = Console.ReadLine();
        int amount = int.Parse(amountText);

        Supplies s = new Supplies(name,unitaryCost,amount);
        _invoicedQuantity += s.GetCost();
        suppliesList.Add(s);
    }

    public void AddClinic()
    {
        Console.Write("What is the hourly rate to use this area? ");
        string hourlyRateText = Console.ReadLine();
        float hourlyRate = float.Parse(hourlyRateText);

        Console.Write("How many hours did you used this area? ");
        string hoursUsedText = Console.ReadLine();
        int hoursUsed = int.Parse(hoursUsedText);

        Clinic c = new Clinic(hourlyRate,hoursUsed);
        _invoicedQuantity += c.CostOfUse();
        areas.Add(c);
    }

    public void AddRoom(int option)
    {
        Console.Write("What is the daily rate for this area? ");
        string dailyRateText = Console.ReadLine();
        float dailyRate = float.Parse(dailyRateText);

        Console.Write("How many days are you using this area? ");
        string daysUsedText = Console.ReadLine();
        int daysUsed = int.Parse(daysUsedText);

        if (option == 3) // private room
        {
            PrivateRoom pR = new PrivateRoom(dailyRate,daysUsed);
            _invoicedQuantity += pR.CostOfUse();
            areas.Add(pR);
        }
        else if (option == 4) // shared room
        {
            SharedRoom sR = new SharedRoom(dailyRate,daysUsed);
            _invoicedQuantity += sR.CostOfUse();
            areas.Add(sR);
        }
    }

    public void AddNewEmployee(int option)
    {
        Console.Write("Please enter the name of the employee ");
        string name = Console.ReadLine();
        
        Console.Write("Please enter the small fee ");
        string smallFeeText = Console.ReadLine();
        float smallFee = float.Parse(smallFeeText);

        Console.Write("Please enter the surgery fee ");
        string surgeryFeeText = Console.ReadLine();
        float surgeryFee = float.Parse(surgeryFeeText);

        if (option == 1)// add doctor
        {
            Doctor d = new Doctor(smallFee,surgeryFee, name);
            _invoicedQuantity += d.GetFee();
            employees.Add(d);
        }
        else if (option == 2)// add nurse
        {
            Nurse n = new Nurse(smallFee, surgeryFee, name);
            _invoicedQuantity += n.GetFee();
            employees.Add(n);
        }
    }
    public void DisplayEmployees()
    {
        int index = 1;
        foreach(Employee e in employees)
        {
            string write = $"{index}. {e.Display()}";
            Console.WriteLine(write);
            index++;
        }
    }

    public void DisplayAreas()
    {
        int index =1;
        foreach(Area a in areas)
        {
            string write = $"{index}. {a.DisplayAreaCost()}";
            Console.WriteLine(write);
            index++;
        }
    }

    public void DisplayAllSupplies()
    {
        int index = 1;
        foreach(Supplies s in suppliesList)
        {
            string write = $"{index}. {s.DisplaySupplies()}";
            Console.WriteLine(write);
            index++;
        }
    }

    public void DisplayAllCosts()
    {
        Console.WriteLine("Employee Costs -----------------------");
        DisplayEmployees();
        Console.WriteLine("");
        Console.WriteLine("Area costs----------------------------");
        DisplayAreas();
        Console.WriteLine("");
        Console.WriteLine("Supplies costs------------------------");
        DisplayAllSupplies();
        Console.WriteLine("");
        Console.WriteLine($"Total: ${_invoicedQuantity}");
    }

    public void ModifyEmployeeFee()
    {
        DisplayEmployees();
        Console.Write("Please indicate which employee you want to modify the fee: ");
        string indexText = Console.ReadLine();
        int index = int.Parse(indexText) - 1;
        Console.WriteLine("");
        Console.WriteLine("Fees Available");
        Console.WriteLine("1. Small Fee");
        Console.WriteLine("2. Surgery Fee");
        Console.Write("Which fee do you want to apply? ");
        string feeChoiceText = Console.ReadLine();
        int feeChoice = int.Parse(feeChoiceText);
        if(feeChoice == 1) // small fee - true
        {
            bool choice = true;
            _invoicedQuantity -= employees[index].GetFee();
            employees[index].ModifyFee(choice);
            _invoicedQuantity += employees[index].GetFee();
            
        }
        else if( feeChoice == 2) // surgery fee  - false
        {
            bool choice = false;
            _invoicedQuantity -= employees[index].GetFee();
            employees[index].ModifyFee(choice);
            _invoicedQuantity += employees[index].GetFee();
        }
    }
}