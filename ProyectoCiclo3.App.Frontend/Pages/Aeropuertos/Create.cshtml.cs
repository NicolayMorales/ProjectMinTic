using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class FormAeropuertoModel : PageModel
    {
        private readonly RepositorioAeropuertos repositorioAeropuertos;
        private readonly RepositorioAviones repositorioAviones;
        public IEnumerable<Aviones> Aviones {get;set;}

        [BindProperty]
        public Aeropuertos Aeropuerto {get;set;}
 
        public FormAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos,RepositorioAviones repositorioAviones)
       {
            this.repositorioAeropuertos=repositorioAeropuertos;
            
            this.repositorioAviones=repositorioAviones;
       }
         public void OnGet()
        {
    Aviones=repositorioAviones.GetAll();
        }

public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            {
            Aeropuerto= repositorioAeropuertos.Create(Aeropuerto);
            }
            return RedirectToPage("./List");
        }

    }
}
