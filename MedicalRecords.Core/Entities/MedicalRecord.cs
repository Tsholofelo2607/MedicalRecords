namespace MedicalRecords.Core.Entities {

public class MedicalRecord
    {
        public int Id { get; set;}
        public int PatientId { get; set;}
        public Patient? Patient { get; set;}
        public int DoctorId { get; set;}
        public Doctor? Doctor { get; set; }
        public DateTime DateOfVisit { get; set; }
        public required string Diagnosis { get; set; }
        public string? Notes { get; set; }
        public required string RecordType { get; set; }
        public DateTime CreatedDate { get; set; }


        
}

}
