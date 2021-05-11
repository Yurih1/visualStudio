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

namespace Crud_teste
{
    public partial class LblEmail : Form
    {
        public LblEmail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database='crud3manha'");

                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;

                string sql = "insert into usuario(nome,email,senha) values('" + nome + "','" + email + "','" + senha +"')";


            MySqlCommand comm = new MySqlCommand(sql, conn);
                conn.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();
                conn.Close();
                MessageBox.Show("Registro salvo com sucesso!");
                limpar();
            } catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o segunite erro: " + ex.Message);
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database='crud3manha'");
                string id = txtId.Text;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;

                string sql = "update usuario set nome='" + nome + "',email='" + email + "',senha='" + senha + "' where id=" + id;


                MySqlCommand comm = new MySqlCommand(sql, conn);
                conn.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();
                conn.Close();
                MessageBox.Show("Registro atualizado com sucesso!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o segunite erro: " + ex.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database='crud3manha'");
                string id = txtId.Text;
                string sql = "delete from usuario where id=" + id;
                MySqlCommand comm = new MySqlCommand(sql, conn);
                conn.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();
                conn.Close();
                MessageBox.Show("Registro excluido com sucesso!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
        }

        private void limpar()
        {
            txtEmail.Clear();
            txtId.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database='crud3manha'");
                string id = txtId.Text;
                string sql = "select * from usuario where id=" + id;
                MySqlCommand comm = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtSenha.Text = dr["senha"].ToString();
                }
                else
                {
                    MessageBox.Show("Registro nenhum registro foi encontrado!");
                }
                comm.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
        }
    }
}
