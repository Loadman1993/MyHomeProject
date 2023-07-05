namespace MyHomeProject.DomainLayer.Calculations
{
    public class CreatinineSchwartzLyon:IEstimations
    {
        public decimal Calculate(PatientsAntropometricsDTO antropometrics)
        {
           
            decimal Q = antropometrics.Gender == Gender.Male & antropometrics.Age > 13 ? 0.413m : 0.368m;

            decimal result = Q * antropometrics.Height / antropometrics.SCreatinine;
            return result = Math.Round(result, 2);
           

        }
    }
}
