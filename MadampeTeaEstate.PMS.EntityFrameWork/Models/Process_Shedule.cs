using System;
using System.Collections.Generic;

namespace MadampeTeaEstate.PMS.EntityFrameWork.Models
{
    public partial class Process_Shedule
    {
        public int RowId { get; set; }
        public int CropId { get; set; }
        public int ProcessId { get; set; }
        public int MachineCount { get; set; }
        public int ProcessCount { get; set; }
        public System.DateTime EnterdDate { get; set; }
        public virtual Crop_Details Crop_Details { get; set; }
        public virtual Process_Details Process_Details { get; set; }
    }
}
