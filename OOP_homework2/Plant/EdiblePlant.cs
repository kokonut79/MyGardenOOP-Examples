namespace OOP_homework2
{
    public class EdiblePlant : Plant , IFood
    {
        public double Energy { get; set; }
        public EdiblePlant(double waterRequired, double energy) : base(waterRequired)
        {
            this.Energy = energy;
        }
        
    }
}