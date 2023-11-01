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
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Artur Ferreira", "875.032.950-41", "artur01@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "Barbara Arg", "005.002.905-81", "barbara@sp.senai.br", "Atila");
        Cliente cliente3 = new Cliente(03, "Claudia de Paula Costa", "753.322.650-47", "claudiap@sp.senai.br", "Mimi");
        Cliente cliente4 = new Cliente(04, "Marcia Gonçalves", "985.902.000-00", "marciag01@sp.senai.br", "Pimenta");
        Cliente cliente5 = new Cliente(05, "Paulo Gouveia", "675.552.450-33", "paulog2010@sp.senai.br", "Thor");

        //Lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Sandox SA", "87.503.295/0001-41", "sandoxadm@sandox.com.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Bayer S.A.", "00.600.905/0001-81", "bayerpet@bayer.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Tik Tik Ltda", "53.322.650/0001-47", "tiktil_pet@tiktik.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Purina Alimentos Ltda", "95.920.000/0001-00", "comercial@putinaalimentos.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "BootsPet Inc", "675.552.450-33", "bootsadm@boots.br");

        //Lista de fornecedor
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

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
