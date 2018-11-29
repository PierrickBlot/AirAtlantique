using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace AirAtlantique.Class
{
    public class Connexion
    {
        public MySqlConnection cnx;

        // Constructeur
        public void Bdd()
        {
             this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        public void InitConnexion()
        {
            //chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=aa_admin; UID=aa_admin; PASSWORD=epsi2018";
            this.cnx = new MySqlConnection(connectionString);
        }
    }
}
