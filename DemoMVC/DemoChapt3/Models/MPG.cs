namespace DemoChapt3.Models
{
    public class MPG
    {
        private double _milesDriven;
        private double _gallonsUsed;

        public double MilesDriven
        {
            get => _milesDriven;
            set
            {
                _milesDriven = value;
            }
        }

        public double GallonsUsed
        {
            get => _gallonsUsed;
            set
            {
                _gallonsUsed = value;
            }
        }
    }

    
}
