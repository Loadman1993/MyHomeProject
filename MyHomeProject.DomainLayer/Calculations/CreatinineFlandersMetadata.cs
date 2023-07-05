namespace MyHomeProject.DomainLayer.Calculations
{
    public class CreatinineFlandersMetadata:IEstimations

    {
        public decimal Calculate(PatientsAntropometricsDTO antropometrics)
        {

            decimal result = (0.0414m * antropometrics.Age) + 0.3018m * antropometrics.Height / antropometrics.SCreatinine;
            return Math.Round(result, 2);

        }
    }
}
