using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApi.Models;

[Table("employees")]
public class Employee
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("department")]
    public string Department { get; set; } = string.Empty;
}