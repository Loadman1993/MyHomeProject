namespace MyHomeProject.DomainLayer.Calculations
{
    public class CystatinCBased:IEstimations
    {
        public decimal Calculate(PatientsAntropometricsDTO antropometrics)
        {
           
            decimal result = 70.69m * Convert.ToDecimal(Math.Pow((double)antropometrics.SCystatinC, -0.931));
            return result = Math.Round(result, 2);
        }

    }
}
