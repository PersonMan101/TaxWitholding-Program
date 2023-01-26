// Tax Witholding Program

double hourlyRate;
double hoursWorked;
double fedTax;
double FICATax;
double ohioTax;
double cityTax; Console.Write("Enter your pay rate: ");
hourlyRate = double.Parse(Console.ReadLine());
Console.Write("Enter your hours worked: ");
hoursWorked = double.Parse(Console.ReadLine());
FICATax = FICATaxWithheld(hourlyRate, hoursWorked);
fedTax = FedTaxWithheld(hourlyRate, hoursWorked);
ohioTax = OhioTaxWithheld(hourlyRate, hoursWorked);
cityTax = CityTaxWithheld(hourlyRate, hoursWorked);
PayStubDisplay(hourlyRate, hoursWorked, FICATax, fedTax, ohioTax, cityTax);
static double FedTaxWithheld(double hourlyRate, double hoursWorked)
{
    double fedTax = hourlyRate * hoursWorked * 0.22;
    return fedTax;
}
static double FICATaxWithheld(double hourlyRate, double hoursWorked)
{
    double FICATax = hourlyRate * hoursWorked * .0765;
    return FICATax;
}
static double OhioTaxWithheld(double hourlyRate, double hoursWorked)
{
    double OhioTax = hourlyRate * hoursWorked * .0575;
    return OhioTax;
}
static double CityTaxWithheld(double hourlyRate, double hoursWorked)
{
    double CityTax = hourlyRate * hoursWorked * .02;
    return CityTax;
}
static double PayStubDisplay(double hourlyRate, double hoursWorked, double fedTax, double FICATax, double ohioTax, double cityTax)
{
    Console.WriteLine("---------------");
    double grossPay = hoursWorked * hourlyRate;
    Console.WriteLine("Gross pay: {0:C}", grossPay);
    Console.WriteLine("Federal Tax: {0:C}", fedTax);
    Console.WriteLine("FICA Tax: {0:C}", FICATax);
    Console.WriteLine("Ohio Tax: {0:C}", ohioTax);
    Console.WriteLine("City Tax: {0:C}", cityTax);
    Console.WriteLine("---------------");
    double netPay = grossPay - fedTax - ohioTax - cityTax;
    Console.WriteLine("Net Pay is {0:C}", netPay);
    Console.WriteLine("---------------");
    return grossPay;
}