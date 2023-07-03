

namespace MyHomeProject.DataAccessLayer.Models
{
    public class PatientsAntropometrics
    {
        public uint Id { get; set; }
        public decimal Height { get; set; }
        public decimal Age { get; set; }
        public Gender Gender { get; set; }
        
        public decimal BUN { get; set; }
        public decimal SCreatinine { get; set; }
        public decimal SCystatinC { get; set; }   
    }
    public enum Gender
    {
        Male,
        Female
    }
}
