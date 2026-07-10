namespace MedicalRecords.Core.Entities
{
public class Doctor{

public int Id {get; set;}
public required string FirstName { get; set; }
public required string LastName { get; set; }
public required string Gender { get; set; }
public required string Specialisation { get; set;}
public required string Email { get; set; }
public string? PhoneNumber { get; set; }
public DateTime CreatedDate {get; set; }

}

}
