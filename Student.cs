using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

public class Student
{
    public int ID { get; set; }

   
    public string? Name { get; set; }

   
    public string? Class { get; set; }

   
    public bool HasPRN { get; set; }

    public string? Gender { get; set; }


}