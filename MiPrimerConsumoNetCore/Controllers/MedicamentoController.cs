using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceMedicamento;
namespace MiPrimerConsumoNetCore.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> ListarMedicamentos()
        {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            List<MedicamentoCLS> Lista = await oMedicamentosClient.ListarMedicamentosAsync();

            var ListaMedicamento = Lista.Where(p => p.BHabilitado == 1)
                .Select(p => new
                {
                    p.IidMedicamento,
                    p.Nombre,
                    p.Concentracion,
                    p.NombreFormaFarmaceutica,
                    p.Stock,
                    p.Precio,
                    p.Presentacion
                }

                );
            return Json(ListaMedicamento);
        }

        public async Task<JsonResult> ListarFormaFarmaceutica()
        {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();

            List<FormaFarmaceuticaCLS> Lista = await oMedicamentosClient.ListaFormaFarmaceuticaAsync();

            var ListaFormaFarmaceutica = Lista.Select(p =>
              new
              {
                  p.IidFormaFarmaceutica,
                  p.NombreFormaFarmaceutica

              }
            );

            return Json(ListaFormaFarmaceutica);
        }

        public async Task<JsonResult> RecuperarMedicamento(int iidMedicamento)
        {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            var Medicamento = await oMedicamentosClient.RecuperarMedicamentoAsync(iidMedicamento);
            return Json(Medicamento);

        }


        ////////Extraido de proyecto ASP.NET MVC////////


        public async Task<int> AgregarYEditarMedicamento([FromBody]MedicamentoCLS oMedicamentoCLS)
        {
            int rpta = 0;
            try
            {
                MedicamentosClient oMedicamentoClient = new MedicamentosClient();
               // oMedicamentoClient.ClientCredentials.UserName.UserName = "lhurol";
               // oMedicamentoClient.ClientCredentials.UserName.Password = "1234";
                rpta = await oMedicamentoClient.RegistraryActualizarMedicamentoAsync(oMedicamentoCLS);
            }
            catch (Exception)
            {

                rpta = 0;
            }
            return rpta;
        }

        public async Task<int> EliminarMedicamento(int iidMedicamento)
        {

            int rpta = 0;
            try
            {
                MedicamentosClient oMedicamentoClient = new MedicamentosClient();
                //oMedicamentoClient.ClientCredentials.UserName.UserName = "lhurol";
                //oMedicamentoClient.ClientCredentials.UserName.Password = "1234";
                rpta = await oMedicamentoClient.EliminarMedicamentoAsync(iidMedicamento);

            }
            catch (Exception)
            {

                rpta = 0;
            }
            return rpta;
        }


        public async  Task<JsonResult> BuscarMedicamentosPorNombre(string NombreMedicamento)
        {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            //oMedicamentosClient.ClientCredentials.UserName.UserName = "lhurol";
            //oMedicamentosClient.ClientCredentials.UserName.Password = "1234";
            var lista = await oMedicamentosClient.ListarMedicamentosAsync();
             var ListaBusqueda =   lista.Where(p => p.BHabilitado == 1 && p.Nombre.ToLower().Contains(NombreMedicamento.ToLower()))
                .Select(
                p => new
                {
                    p.IidMedicamento,
                    p.Nombre,
                    p.Concentracion,
                    p.NombreFormaFarmaceutica,
                    p.Stock,
                    p.Precio,
                    p.Presentacion
                }
                ).ToList();
            return Json(ListaBusqueda);
        }



        ////////////////////////////////////////////////
    }
}