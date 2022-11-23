
internal class Car
{
    private bool status = true;
    private string _model;
    public string Model
    {
        get => _model; set
        {

            if (!string.IsNullOrWhiteSpace(value))
            {

                _model = value;
                status = false;
            }
            else
            {

                while (status)
                {
                    Console.WriteLine("qardas zehmet olmasa duzemelli gir");
                    Model = Console.ReadLine();
                }
            }

        }
    }
    public string Marka { get; set; }
    public double Millage { get; set; }
    public double FuelOfAmount { get; set; }
    public double Usage { get; set; }

    public Car(string model, string marka, double millage, double fuelOf,double uage)
    {
        this.Model = model;
        this.Marka=marka;
        this.Millage = millage;
        this.FuelOfAmount = fuelOf;
        this.Usage = uage;
    }

    public double GetFuel()
        => FuelOfAmount;

    public double PosibilityWay()
        => (FuelOfAmount * 100) / Usage;

    public void ServiceInfo()
    {
        int ServiceCount = (int)Math.Floor(Millage / 5000);
        Console.WriteLine($"Nece defe servicede olub {ServiceCount}");

        double nextService = 5000 - (Millage - (5000 * ServiceCount));
        Console.WriteLine($"Nece km sonra gedecek {nextService}");

        double eliNext = 5000 - (Millage % 5000);
        Console.WriteLine($"elinin usuku {eliNext}");


    }






}
