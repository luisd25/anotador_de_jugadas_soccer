using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace WindowsFormsApplication1
{
    class DB
    {
        

        public String connectionString;
        public SQLiteConnection connect;
        private String SQLsituacion = "INSERT INTO score(Juego, Tiempo, Jugador, Equipo, Jugada, Puntuacion) VALUES( ?, ?, ?, ?, ?, ?)";
        private String SQLfin = "Insert INTO score(Juego, Tiempo, Jugador, Equipo, Jugada, Puntuacion, Terminado) VALUES( ?, ?, ?, ?, ?, ?, ?)";


        public void Connect()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            connect = new SQLiteConnection(connectionString);
        }
        public void regJugada(string juego, string jugador, string tiempo,  string equipo, string jugada, string score)
        {
            if (connect.State != ConnectionState.Open) connect.Open();
            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = SQLsituacion;
            command.Parameters.AddWithValue("Juego", juego);
            command.Parameters.AddWithValue("Tiempo", tiempo);
            command.Parameters.AddWithValue("Jugador", jugador);
            command.Parameters.AddWithValue("Equipo", equipo);
            command.Parameters.AddWithValue("Jugada", jugada);
            command.Parameters.AddWithValue("Puntuacion", score);
            command.ExecuteNonQuery();
            connect.Close();



        }

        public void endGame(string tiempo, string juego, string score) {

            if (connect.State != ConnectionState.Open) connect.Open();
            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = SQLfin;
            command.Parameters.AddWithValue("Juego", juego);
            command.Parameters.AddWithValue("Tiempo", tiempo);
            command.Parameters.AddWithValue("Jugador", "-");
            command.Parameters.AddWithValue("Equipo", "-");
            command.Parameters.AddWithValue("Jugada", "Fin del Partido");
            command.Parameters.AddWithValue("Puntuacion", score);
            command.Parameters.AddWithValue("Terminado", 1);
            command.ExecuteNonQuery();
            connect.Close();
        }
     

    }
}
