using System.ComponentModel.DataAnnotations;
namespace vehicle;

public class Vehicle
{
    [Required]
    public int id { get; set; }

    [Required]
    public String name { get; set; }
    [Required]
    public String company {get;set;}

    [Required]
    public String price {get;set;}
    [Required]
    public String engine {get;set;}

    public Vehicle()
    {
        
    }
    public Vehicle(int id,String name,String company,string price,string engine)
    {
        this.id=id;
        this.name=name;
        this.company=company;
        this.price=price;
        this.engine=engine;
    }
}
