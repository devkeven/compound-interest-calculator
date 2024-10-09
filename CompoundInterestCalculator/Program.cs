// See https://aka.ms/new-console-template for more information
Console.WriteLine("Compound Interest Calculator(anual)");

string insertedValue = "";
Boolean rightValue = false;

decimal amount;
double interestRate;
int investmentYears;

// get the initial amout from user
do
{
	Console.WriteLine("Insert the initial amout(€):");
	insertedValue = Console.ReadLine();

	rightValue = decimal.TryParse(insertedValue, out amount);

} while (!rightValue);

// get the interest rate from user
do
{
	Console.WriteLine("Insert the interest rate:(%)");
	insertedValue = Console.ReadLine();

	rightValue = double.TryParse(insertedValue, out interestRate);

} while (!rightValue);

// get the interest rate from user
do
{
	Console.WriteLine("How long will the investment take (years)?");
	insertedValue = Console.ReadLine();

	rightValue = Int32.TryParse(insertedValue, out investmentYears);

} while (!rightValue);

// calculations
double r = interestRate/100;

// final value
var finalValue = (double) amount * Math.Pow(1 + r, investmentYears);

var interestValue = (double)amount * Math.Pow(1 + r, investmentYears);

Console.WriteLine(finalValue);