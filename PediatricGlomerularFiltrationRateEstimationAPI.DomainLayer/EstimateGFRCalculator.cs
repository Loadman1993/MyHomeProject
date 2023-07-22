using MyHomeProject.DomainLayer;
using MyHomeProject.DomainLayer.Calculations;

namespace PediatricGlomerularFiltrationRateEstimationApi.DomainLayer
{
    // Class for estimating GFR based on calculations
    public class EstimatedGFRCalulator
    {
        PatientsAntropometricsDTO data; // Data of patient's anthropometrics

        // Dictionary to store equations for calculations
        //Key - Identifier that is connected to a specific equation
        //Value - equation for calculation
        Dictionary<string, IEstimations> equations;

        // Constructor to initialize the calculator with data and equations
        public EstimatedGFRCalulator(PatientsAntropometricsDTO data, Dictionary<string, IEstimations> equations)
        {
            this.data = data;
            this.equations = equations;
        }

        // Method to perform calculations for a list of given keys
        public List<CalculationResult> Calculate(List<string> keys)
        {
            var result = new List<CalculationResult>();

            foreach (var key in keys)
            {
                var equation = this.equations[key]; // Get the equation for the current key
                var value = equation.Calculate(data); // Calculate the value using the equation

                result.Add(new CalculationResult() { Key = key, Value = value }); // Add the calculation result to the list
            }

            return result;
        }
    }

    // Class to represent the calculation result
    public class CalculationResult
    {
        public string Key { get; set; } // Key representing the calculation parameter
        public decimal Value { get; set; } // Calculated value
    }
}

