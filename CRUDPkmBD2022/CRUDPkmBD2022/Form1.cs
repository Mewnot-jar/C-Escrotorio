using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDPkmBD2022
{
    public partial class Form1 : Form
    {
        MySqlConnection mysqlCon = new MySqlConnection(@"Server=localhost;Database=pokemondb;Uid=root;Pwd=");
        public Form1()
        {
            InitializeComponent();
            llenarDGV();
        }

        private void llenarDGV()
        {
            string sql = "SELECT * FROM pokemon;";
            MySqlCommand mysqlCmd = new MySqlCommand(sql, mysqlCon);
            MySqlDataAdapter mysqlDA = new MySqlDataAdapter(mysqlCmd);
            DataTable tabla = new DataTable();
            mysqlDA.Fill(tabla);
            dgvPokemon.DataSource = tabla;
        }

        private void btn_crearPkm_Click(object sender, EventArgs e)
        {
            bool check = true;
            string msg = "";
            if (txt_nombrePkm.Text.Equals(""))
            {
                check = false;
                msg = "\nNombre Pokemon";
            }
            if (txt_pesoPkm.Text.Equals(""))
            {
                check = false;
                msg = "\nPeso Pokemon";
            }
            if (txt_alturaPkm.Text.Equals(""))
            {
                check = false;
                msg = "\nAltura Pokemon";
            }

            if (check)
            {
                mysqlCon.Open();
                String sql = "INSERT INTO `pokemon` (`nombre`, `peso`, `altura`) VALUES (?, ?, ?);";
                MySqlCommand mysqlCmd = new MySqlCommand(sql, mysqlCon);
                mysqlCmd.CommandType = CommandType.Text;
                mysqlCmd.Parameters.AddWithValue("nombre", txt_nombrePkm.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("peso", txt_pesoPkm.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("altura", txt_alturaPkm.Text.Trim());
                if(mysqlCmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Nuevo Pokemon creado");
                    txt_nombrePkm.Text = "";
                    txt_pesoPkm.Text = "";
                    txt_alturaPkm.Text = "";
                    llenarDGV();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el pokemon");
                }

            }
            else
            {
                MessageBox.Show("Los siguientes campos son obligatorios:" + msg);
            }
        }

        private void btn_modificarPkm_Click(object sender, EventArgs e)
        {
            bool check = true;
            string msg = "";
            int numero_pokedex = 0;
            foreach(DataGridViewRow row in dgvPokemon.SelectedRows)
            {
                numero_pokedex = Convert.ToInt32(row.Cells[0].Value.ToString());
            }

            if (txt_nombreUpdt.Text.Equals(""))
            {
                check = false;
                msg = "\nNombre Pokemon";
            }
            if (txt_pesoUpdt.Text.Equals(""))
            {
                check = false;
                msg = "\nPeso Pokemon";
            }
            if (txt_alturaUpdt.Text.Equals(""))
            {
                check = false;
                msg = "\nAltura Pokemon";
            }
            if (check)
            {
                mysqlCon.Open();
                String sql = "UPDATE `pokemon` SET `nombre` = ?, `peso` = ?, `altura` = ? WHERE `numero_pokedex` = ?;";
                MySqlCommand mysqlCmd = new MySqlCommand(sql, mysqlCon);
                mysqlCmd.CommandType = CommandType.Text;
                mysqlCmd.Parameters.AddWithValue("nombre", txt_nombreUpdt.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("peso", txt_pesoUpdt.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("altura", txt_alturaUpdt.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("numero_pokedex", numero_pokedex);
                if (mysqlCmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Pokemon modificado correctamente");
                    txt_nombreUpdt.Text = "";
                    txt_pesoUpdt.Text = "";
                    txt_alturaUpdt.Text = "";
                    llenarDGV();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el pokemon");
                }
                mysqlCon.Close();

            }
            else
            {
                MessageBox.Show("Los siguientes campos son obligatorios:" + msg);
            }
        }
    }
}
