using System.ComponentModel.DataAnnotations;

namespace DemoChapt2.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Enter a monthly investment amount.")]
        [Range(1, 500, ErrorMessage = "Monthly investment amount must be between 1 and 500")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Enter a yearly interest rate.")]
        [Range(0.1, 10.0, ErrorMessage = "Interest rate must be between 0.1 and 10.0.")]
        public decimal? YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "Please enter the number of years.")]
        [Range(1, 50, ErrorMessage = "Year range must be  between 1 and 50.")]
        public int? Years { get; set; }
        public decimal? CalculateFutureValue() { 
        
            int? months = Years * 12;
            decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal? futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
