namespace DemoChapt3.Models
{
    public class MPG
    {
        public double? MilesDriven { get; set; }
        public double? GallonsUsed { get; set; }

        public double? CalcMpg()
        {
            double? mpg = MilesDriven / GallonsUsed;
            return mpg;
        }
    }


}
