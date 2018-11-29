using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AirAtlantique.Class
{
    public class Supprimer
    {
        int id=1;
        Connexion cnx = new Connexion();
        MySqlCommand delete = new MySqlCommand("DELETE FROM avion WHERE numero =");

    }
}
