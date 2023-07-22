namespace MyHomeProject.DomainLayer.Calculations
{
    public class CreatininePottel : IEstimations
    {
        public decimal Calculate(PatientsAntropometricsDTO antropometrics)
        {
            decimal Q = antropometrics.Height * 0.0035m;

            decimal result = 107.3m / (antropometrics.SCreatinine / Q);
            return Math.Round(result, 2);
           
        }
    }
}
