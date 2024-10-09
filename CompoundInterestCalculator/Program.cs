// See https://aka.ms/new-console-template for more information
Console.WriteLine("Compound Interest Calculator(anual)");

string insertedValue = "";
Boolean rightValue = false;

double interestRate, amount;
int investmentYears;

// get the initial amout from user
do
{
	Console.WriteLine("Insert the initial amout(€):");
	insertedValue = Console.ReadLine();

	rightValue = double.TryParse(insertedValue, out amount);

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

Console.WriteLine("---------------------------------------");
Console.WriteLine("|Year|   Amount|Interest value|Accumulated value|");

for (int i = 1; i <= investmentYears;i++)
{
	var finalValue = amount * Math.Pow(1 + r, i);
	var interestValue = amount * Math.Pow(1 + r, i) - amount;

	Console.WriteLine("|" + i.ToString().PadLeft(4) + "|" + amount.ToString("0.00").PadLeft(9) + "|" + interestValue.ToString("0.00").PadLeft(14) + "|" +  finalValue.ToString("0.00").PadLeft(17) + "|");

	amount = finalValue;
}