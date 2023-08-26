using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imoveis.Models;
namespace ImoveisApp.Global
{
    public class Config
    {
        //Api
        public static string apiBaseUrl = "http://localhost:5255/api/";

        public static Imoveiss tempImovel = new Imoveiss();
        public static bool edit = false;
    }
}
