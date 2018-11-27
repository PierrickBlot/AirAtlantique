using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace AirAtlantique.Class
{
    class Connexion
    {
        private MySqlConnection connection;

        // Constructeur
        public void Bdd()
        {
             this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            //chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=aa_admin; UID=aa_admin; PASSWORD=epsi2018";
            this.connection = new MySqlConnection(connectionString);
        }
    }
}
