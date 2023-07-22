

using System.Buffers.Text;

namespace MyHomeProject.DataAccessLayer.Models
{
    public class EstimatedGFR
    {
        public decimal CreatinineBedsideSchwartz{ get; set; }
        public decimal CreatinineCystatinCCKiD { get; set; }
        public decimal CystatinCBased { get; set; }
        public decimal CreatinineSchwartzLyon { get; set; }
        public decimal CreatininePottel { get; set; }
        public decimal CreatinineFlandersMetadata { get; set; }
    }
}
