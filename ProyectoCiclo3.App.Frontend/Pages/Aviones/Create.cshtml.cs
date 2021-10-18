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
    public class FormAvionModel : PageModel
    {
        private readonly RepositorioAviones repositorioAviones;
        private readonly RepositorioRutas repositorioRutas;
        public IEnumerable<Rutas> Rutas {get;set;}

        [BindProperty]
        public Aviones Avion {get;set;}
 
        public FormAvionModel(RepositorioAviones repositorioAviones,RepositorioRutas repositorioRutas)
       {
            this.repositorioAviones=repositorioAviones;
            
            this.repositorioRutas=repositorioRutas;
       }
        

public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            Avion= repositorioAviones.Create(Avion);
            return RedirectToPage("./List");
        }

    }
}
