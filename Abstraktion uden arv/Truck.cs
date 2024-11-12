using System.Reflection;

namespace Apstract_Virtual_Arv
{
    class Truck : Vehicle
    {
        public Truck(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        {
        }

        public override string InstectionStatus()
        {
            if ((DateTime.Now - ProductionDate).TotalDays > 1 * 365)
                return "Truck requires instection";
            return "Truck does not require instection";
        }

        public override string DisplayInfo()
        {
            return $"Truck: {Brand} {Model}";
        }

        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 17 : 20;
        }
    }
}
