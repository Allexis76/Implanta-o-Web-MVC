using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo clientes
        Cliente cliente1 = new Cliente(01, "Pietro Villela", "293.091.284-68", "pietrov@gmail.com", "Bob");
        Cliente cliente2 = new Cliente(02, "Aline Monnerat", "020.497.294-99", "aline_m@gmail.com",  "Zé");
        Cliente cliente3 = new Cliente(03, "Jéssica Soares", "123.854.368-00", "soaresj@gmail.com", "Otto");
        Cliente cliente4 = new Cliente(04, "Antônio  Pádua", "653.958.214-25", "paduaant@gmail.com", "Kratos");
        Cliente cliente5 = new Cliente(05, "Sheyla C. Maria", "326.258.369-01", "patyshey@gmail.com", "Ragnar");

        // lista de clientes e atribuição de clientes
        List<Cliente> ListaClientes = new List<Cliente>();
        ListaClientes.Add(cliente1);
        ListaClientes.Add(cliente2);
        ListaClientes.Add(cliente3);
        ListaClientes.Add(cliente4);
        ListaClientes.Add(cliente5);

        ViewBag.ListaClientes = ListaClientes;


        // instancias do tipo fornecedor e atribuição de fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "Casa do Dog", "15.201.254/0001-69", "casadog@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Pets House S/A", "22.051.358/0001-63", "petshouse@hotmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Ração Alegria", "35.247.658/000198", "racaoalegre@ig.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Paulista Rações", "25.478.653/0001-66", "paulistaracoes@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Life Pets", "33.258.456./0001-32", "lifepets@proctonmail.com");

        // lista de fornecedores
        List<Fornecedor> ListaFornecedores = new List<Fornecedor>();
        ListaFornecedores.Add(fornecedor1);
        ListaFornecedores.Add(fornecedor2);
        ListaFornecedores.Add(fornecedor3);
        ListaFornecedores.Add(fornecedor4);
        ListaFornecedores.Add(fornecedor5);

        ViewBag.ListaFornecedores = ListaFornecedores;
        

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
