using MyHomeProject.DataAccessLayer.Models;
using MyHomeProject.DomainLayer.Calculations;
using MyHomeProject.DomainLayer;



namespace MyHomeProject.DomainLayer.Calculations
{
    public class CreatinineBedsideSchwartz : IEstimations
    {
       
        public decimal Calculate(PatientsAntropometricsDTO antropometrics)
        {
            decimal result = 0.413m * antropometrics.Height / antropometrics.SCreatinine;
            return Math.Round(result, 2);
        }
    }
}
