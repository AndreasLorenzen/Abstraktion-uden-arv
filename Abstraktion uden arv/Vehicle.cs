public abstract class Vehicle : IWheels
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public DateTime ProductionDate { get; set; }
    public DateTime LastInspection { get; set; }

    public int MaxRimSize { get; set; }

    public Vehicle(string brand, string model, DateTime productionDate, DateTime lastInspection)
    {
        Brand = brand;
        Model = model;
        ProductionDate = productionDate;
        LastInspection = lastInspection;
    }

    public abstract string InstectionStatus();

    public virtual string DisplayInfo()
    {
        return $"{Brand}, {Model}, Production Date: {ProductionDate.ToShortDateString()}";
    }

    public virtual void SetTireType(bool isWinterTire)
    {
        // Custom implementation can be added in derived classes
    }

    public string Info()
    {
        return "Brug mig for alle objekter som køres på hjul.";
    }

    public string GetInterfaceInfo()
    {
        return Info();
    }
}
