namespace OOP_homework2
{
    public class Flowers : Plant , IBeauty
    {
        public double BeautyScore { get; set; }
        public Flowers(double beautyScore, double waterRequired) : base(waterRequired)
        {
            this.BeautyScore = beautyScore;
        }
        
    }
}