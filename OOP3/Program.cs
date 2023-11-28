namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            vehicleCreditManager.Calculate();

            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vehicleCreditManager2 = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            needCreditManager.Calculate();
            vehicleCreditManager2.Calculate();
            housingCreditManager.Calculate();
        }
    }
}
