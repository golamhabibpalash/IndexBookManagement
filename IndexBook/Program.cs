using IndexBook.Model;
using IndexBook.Service;

BookIndexRepository bookIndexRepository = new BookIndexRepository();

//Initialise Data
//bookIndexRepository.BookIndexEntries.Add("ABC", "01234567890");
//bookIndexRepository.BookIndexEntries.Add("XYZ", "01234567891");


int serviceId = 0;
int outputNumber; 

CommonInstruction();

while (true)
{
    var userResponse = Console.ReadLine();

    if (int.TryParse(userResponse, out int num))
    {
        
    }
    else
    {
        Console.WriteLine("You entered invalid code.\n");
        Environment.Exit(0);
    }

    serviceId = Convert.ToInt32(userResponse);
    if (serviceId > 4 )
    {
        Console.WriteLine("You entered invalid code.\n");
        CommonInstruction();
    }

	
	if (serviceId==0)
	{
		Console.WriteLine("Thank you for using our service.");
		Environment.Exit(0);
	}


    // Client respons 1
    // Add / Create
    if(serviceId ==1)
    {
        Console.Write("Enter the Name:");
        string inputName = Console.ReadLine();

        Console.Write("Enter the Number:");
        string inputNumber = Console.ReadLine();

        bookIndexRepository.BookIndexEntries.Add(inputName, inputNumber);
        Console.WriteLine("New contact is added.");
        CommonInstruction();
    }


    // Read// Client respons 2
    if (serviceId == 2)
    {
        //ConstructionOngingInstruction("Read");
        if (bookIndexRepository.BookIndexEntries != null && bookIndexRepository.BookIndexEntries.Count > 0) {
            foreach (var item in bookIndexRepository.BookIndexEntries)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
        else 
        {
            Console.WriteLine("Your Index book is empty");
        }
        Console.WriteLine("\n");
        CommonInstruction();
    }

    // Update// Client respons 3
    if (serviceId == 3)
    {
        Console.Write("Which name you want to update:");
        var nameKey = Console.ReadLine();
        //is exist?
        var result = bookIndexRepository.BookIndexEntries.TryGetValue(nameKey, out var bookIndexEntry);
        if (result) {
            Console.WriteLine($"Your existing number is {bookIndexEntry}.");
            Console.Write($"Enter your updated number:");
            var updatedNumber = Console.ReadLine();
            bookIndexRepository.BookIndexEntries[nameKey] = updatedNumber;
        }
        else
        {
            Console.WriteLine($"{nameKey} is not available in your contacts.");
        }

            CommonInstruction();
    }

    // Delete// Client respons 4
    if (serviceId == 4)
    {
        Console.Write("Which name you want to delete:");
        var nameKey = Console.ReadLine();
        //is exist?
        var result = bookIndexRepository.BookIndexEntries.TryGetValue(nameKey, out var bookIndexEntry);
        if (result)
        {
            bookIndexRepository.BookIndexEntries.Remove(nameKey); 
            Console.WriteLine($"{nameKey} is deleted from your contacts.");
        }
        else
        {
            Console.WriteLine($"{nameKey} is not available in your contacts.");
        }

        CommonInstruction();
    }
} 

void CommonInstruction()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1. Create\n2. Read \n3. Update \n4. Delete \n0. Exit");
}

void ConstructionOngingInstruction(string serviceName)
{
    Console.WriteLine($"{serviceName} Construction Service is ongoing.\n");
}