namespace CardPicker  /*The class Program is defined inside the namespace CardPicker, 
                       * this way this class can be accessed from other parts of the application.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();  //assigns the result to a variable called `line`

            /*It uses the int.TryParse method to check if the text entered by the user can be converted to a valid integer, 
             * which is passed as the first argument of the method. 
             * The second argument is an out variable numberOfCards, 
             * and if the conversion is successful, it will assign the converted integer to this variable, 
             * otherwise it will be assigned zero, this is why numberOfCards is being used as an out variable.*/
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
            /*If the user input can be successfully parsed as an integer, 
             * the Main method uses a foreach loop to iterate over an array of strings returned by calling CardPicker.PickSomeCards(numberOfCards), 
             * which is the method defined in the CardPicker class that you provided earlier.
             *For each card in the array, 
             *it writes the card to the console using Console.WriteLine(). 
             *If the input is not parseable as an integer the method will print a message "Please enter a valid number.".*/
        }
    }
}