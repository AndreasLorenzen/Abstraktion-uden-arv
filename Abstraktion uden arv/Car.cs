using System.Reflection;

namespace Apstract_Virtual_Arv
{
    class Car : Vehicle
    {
        public Car(string brand, string model, DateTime productionDate, DateTime lastInspection) : base(brand, model, productionDate, lastInspection)
        {
        }

        public override string InstectionStatus()
        {
            if ((DateTime.Now - ProductionDate).TotalDays > 4 * 365)
                return "Car requires instection";
            return "Car does not require instection";
        }

        public override string DisplayInfo()
        {
            return $"Car: {Brand} {Model}";
        }

        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 16 : 22;
        }
    }
}
