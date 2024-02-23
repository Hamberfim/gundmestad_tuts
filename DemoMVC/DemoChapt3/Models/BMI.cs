namespace DemoChapt3.Models
{
    public class BMI
    {
        private double _weight;
        private double _height;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double CalcBmi()
        {
            return _weight / (_height * _height);

        }

        public string GetCategory()
        {
            string category = "";
            double _bmi = CalcBmi();
            if (_bmi < 18.5)
            {
                category = "underweight";
            }
            else if (_bmi < 25)
            {
                category = "healthy weight";
            }
            else if (_bmi < 30)
            {
                category = "over weight";
            }
            else
            {
                category = "obese";
            }
            return category;
        }

    }
}
