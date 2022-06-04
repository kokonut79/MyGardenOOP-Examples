namespace OOP_homework2
{
    public class Plant :  IGardenItems
    {
        public double  WaterRequired { get; set; }
        public Plant(double waterRequired)
        {
            this.WaterRequired = waterRequired;
        }
    }
}