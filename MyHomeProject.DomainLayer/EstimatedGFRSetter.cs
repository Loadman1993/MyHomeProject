using MyHomeProject.DomainLayer;
using MyHomeProject.DomainLayer.Calculations;

var estimatedGFR = new EstimatedGFRDTO();
var setter = new EstimatedGFRSetter(estimatedGFR);
var estimator = new CreatinineBedsideSchwartz();
var antropometrics = new PatientsAntropometricsDTO
{
    
    Id = 1,
    Height = 180,
    Age = 35,
    SCreatinine = 1.2m
};

decimal result = estimator.Calculate(antropometrics);
setter.SetCreatinineBedsideSchwartz(result);



public class EstimatedGFRSetter
{
    private EstimatedGFRDTO estimatedGFR;

    public EstimatedGFRSetter(EstimatedGFRDTO estimatedGFR)
    {
        this.estimatedGFR = estimatedGFR;
    }

    public void SetCreatinineBedsideSchwartz(decimal value)
    {
        estimatedGFR.CreatinineBedsideSchwartz = value;
    }

    
}

