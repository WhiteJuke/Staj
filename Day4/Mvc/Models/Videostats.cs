using System.ComponentModel.DataAnnotations;
namespace Mvc.Models;

public class Videostats
{
    public int Id { get; set; }
    public string? Link { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }

}