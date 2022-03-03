using System.ComponentModel.DataAnnotations;

namespace Notely_App.Model;

    public class Items
    {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Company { get; set; }
    public string Name { get; set; }
    public decimal ItemsNo { get; set; }

    public decimal ItemsAm { get; set; }

    public decimal Total { get { return ItemsNo * ItemsAm; } }
    }

