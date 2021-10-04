using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class FormAvionesModel : PageModel
    {
        private readonly RepositorioAviones repositorioAviones;
        [BindProperty]
        public Aviones Aviones {get;set;}
 
        public FormAvionesModel(RepositorioAviones repositorioAviones)
       {
            this.repositorioAviones=repositorioAviones;
       }
 
        
public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            {
            Aviones= repositorioAviones.Create(Aviones);
            }
            return Page();
        }

    }
}
