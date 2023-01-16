using System.Reflection.PortableExecutable;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using vehicle;
using dal;
namespace NewMvc.Controllers;

public class VehicleController : Controller
{
    private readonly ILogger<VehicleController> _logger;

    public VehicleController(ILogger<VehicleController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Vehicle> list=DbManager.getallvehical();
        ViewBag.insert=list;
        return View();
    }
    

    public IActionResult Registration(){
        return View();
    }
    [HttpPost]
    public IActionResult insert(Vehicle v){
       
       if(!ModelState.IsValid){

               
          return View();

        }
        DbManager.insertvehicle(v);
        return RedirectToAction("Index");
    }
    public IActionResult update(int id)
    {
        Vehicle e=DbManager.findvehicle(id);
        
        Console.WriteLine("eeeeeee"+id);
        ViewBag.update=e;
      
        return View();
    }
    public IActionResult updatee(Vehicle e)
    {
        Console.WriteLine("eeeeeee"+e.id);
        DbManager.updatevehicle(e);
        return RedirectToAction("Index");
    }
    public IActionResult delete(int ssn)
    {
        Console.WriteLine("dfghj"+ssn);
        DbManager.delvehicle(ssn);
        return RedirectToAction("Index");
    }
    
      public IActionResult find(int eidd)
    {
        Console.WriteLine("dfghj"+eidd);
       Vehicle e= DbManager.findvehicle(eidd);
       
        ViewBag.find=e;
        return View();
    }
 
}
