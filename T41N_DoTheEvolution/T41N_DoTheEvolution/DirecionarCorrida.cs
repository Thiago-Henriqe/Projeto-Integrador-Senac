using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.PortableExecutable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace T41N_DoTheEvolution
{
    public partial class DirecionarCorrida : Form
    {
        Principal principal;

        string IDEditar;

        public DirecionarCorrida(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        public DirecionarCorrida(String IDcorrida)
        {

            this.IDEditar = IDcorrida;
            InitializeComponent();
        }




        private void btnCancelarCorrida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCorrida_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new
               SqlConnection(Properties.Settings.Default.strConexao.ToString());


                SqlCommand command = new SqlCommand();
                command.CommandText = "ps_ClienteCorrida";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;


                command.Parameters.AddWithValue("nomeCliente", txtNomeSolicitante.Text);
                //command.Parameters.AddWithValue("cpfouCPNJCliente", txtNomeSolicitante.Text);


                SqlDataReader reader;

                //5) Abrir a conexão com o banco de dados e executar o comando
                connection.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    txtIDcliente.Text = reader.GetInt32("ID").ToString();
                    txtNomeCliente.Text = reader.GetString("Cliente");

                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult + ":" + ex.Message);

                
            }
            


        }

        private void btnConfirmarCorrida_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());

                SqlCommand command = new SqlCommand();
                command.CommandText = "pi_CorridaForm";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;


                command.Parameters.AddWithValue("idMotoboy", txtIDMotoboy.Text);
                command.Parameters.AddWithValue("idCliente", txtIDcliente.Text);
                command.Parameters.AddWithValue("idFuncionario", txtIdFuncionario.Text);
                command.Parameters.AddWithValue("valorCorrida", txtValorCorrida.Text);
                command.Parameters.AddWithValue("distanciaCorrida", txtDistanciaCorrida.Text);
                //Retira
                command.Parameters.AddWithValue("horarioRetiraCorrida", dtpHoraRetira.Value);
                command.Parameters.AddWithValue("dataRetiraCorrida", dtpDataRetira.Value);
                command.Parameters.AddWithValue("cidadeRetiradaCorrida", txtCidadeRetira.Text);
                command.Parameters.AddWithValue("enderecoRetiradaCorrida", txtEnderecoRetira.Text);
                command.Parameters.AddWithValue("enderecoNumeroRetiradaCorrida", txtNumRetira.Text);
                command.Parameters.AddWithValue("enderecoComplementoRetiradaCorrida", txtComRetira.Text);
                command.Parameters.AddWithValue("cepRetiraCorrida", txtCepRetira.Text);
                //Entrega
                command.Parameters.AddWithValue("horarioEntregaCorrida", dtpHoraEntrega.Value);
                command.Parameters.AddWithValue("dataEntregaCorrida", dtpDataEntrega.Value);
                command.Parameters.AddWithValue("cidadeEntregaCorrida", txtCidadeEntrega.Text);
                command.Parameters.AddWithValue("enderecoEntregaCorrida", txtEnderecoEntrega.Text);
                command.Parameters.AddWithValue("enderecoNumeroEntregaCorrida", txtNumEntrega.Text);
                command.Parameters.AddWithValue("enderecoComplementoEntregaCorrida", txtComEntrega.Text);
                command.Parameters.AddWithValue("cepEntregaCorrida", txtCepEntrega.Text);
                //status
                //command.Parameters.AddWithValue("statusCorrida", txtStatusCorrida.Text);



                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Corrida cadastrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult + ":" + ex.Message);

            }

           



        }


        private void DirecionarCorrida_Load(object sender, EventArgs e)
        {
            try
            {

                preenchercmb();

                txtIdFuncionario.Text = Login.idFun.ToString();

                if (IDEditar != null)
                {
                    SqlConnection connection = new
                    SqlConnection(Properties.Settings.Default.strConexao.ToString());

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "ps_Corrida";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;


                    command.Parameters.AddWithValue("IdBuscar", IDEditar);

                    SqlDataReader reader;

                    connection.Open();

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();


                        //txtIDMotoboy.Text = reader.GetInt32("idMotoboy").ToString();
                        txtIDcliente.Text = reader.GetInt32("idCliente").ToString();
                       /* txtIdFuncionario.Text = reader.GetInt32("IdFuncionario").ToString();*/ //e se mudar o usuario ?
                        txtValorCorrida.Text = reader.GetString("valorCorrida");
                        ////datateste = reader.GetDateTime(6); 
                        txtDistanciaCorrida.Text = reader.GetString("distanciaCorrida");
                        //Retira

                        //TextBox1.Text = Convert.ToDateTime(MyReader["DateField"]).ToString("dd/MM/yyyy");


                        dtpHoraRetira.Value = reader.GetDateTime("horarioRetiraCorrida");
                        //dtpHoraRetira.Value = Convert.ToDateTime(reader["horarioRetiraCorrida"]);
                        dtpDataRetira.Value = reader.GetDateTime("dataRetiraCorrida");
                        txtCidadeRetira.Text = reader.GetString("cidadeRetiradaCorrida");
                        txtEnderecoRetira.Text = reader.GetString("enderecoRetiradaCorrida");
                        txtNumRetira.Text = reader.GetString("enderecoNumeroRetiradaCorrida");
                        txtComRetira.Text = reader.GetString("enderecoComplementoRetiradaCorrida");
                        txtCepRetira.Text = reader.GetDecimal("cepRetiraCorrida").ToString();
                        //Entrega
                        dtpHoraEntrega.Value = reader.GetDateTime("horarioEntregaCorrida");
                        //dtpHoraRetira.Value = Convert.ToDateTime(reader["horarioEntregaCorrida"]);
                        dtpDataEntrega.Value = reader.GetDateTime("dataEntregaCorrida");
                        txtCidadeEntrega.Text = reader.GetString("cidadeEntregaCorrida");
                        txtEnderecoEntrega.Text = reader.GetString("enderecoEntregaCorrida");
                        txtNumEntrega.Text = reader.GetString("enderecoNumeroEntregaCorrida");
                        txtComEntrega.Text = reader.GetString("enderecoComplementoEntregaCorrida");
                        txtCepEntrega.Text = reader.GetDecimal("cepEntregaCorrida").ToString();
                        //status
                        //txtStatusCorrida.Text = reader.GetString("statusCorrida");


                    }
                    else
                    {
                        MessageBox.Show("Corrida não encontrada.");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult + ":" + ex.Message);

            }





        }

        private void preenchercmb()
        {
            try
            {

                SqlConnection connection = new
               SqlConnection(Properties.Settings.Default.strConexao.ToString());

                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select nomeMotoboy, idMotoboy from Motoboy where ativoInativoMotoboy='Ativo'";

                command.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbMotoboy.Items.Add(dr["nomeMotoboy"].ToString());
                }


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult + ":" + ex.Message);

               
            }


        }


        private void cmbMotoboy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.strConexao.ToString());

                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select idMotoboy from Motoboy where nomeMotoboy = '" + cmbMotoboy.Text + "'";
                command.ExecuteNonQuery();

                SqlDataReader reader;

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    txtIDMotoboy.Text = reader.GetInt32(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult + ":" + ex.Message);

                
            }
            

        }

        private void btn_AtualizarCorrida_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());

                SqlCommand command = new SqlCommand();
                command.CommandText = "pu_CorridaFuncionario";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;


                command.Parameters.AddWithValue("idCorrida", IDEditar);
                command.Parameters.AddWithValue("idMotoboy", txtIDMotoboy.Text);
                //command.Parameters.AddWithValue("idCliente", txtIDcliente.Text);
                command.Parameters.AddWithValue("idFuncionario", txtIdFuncionario.Text);
                command.Parameters.AddWithValue("valorCorrida", txtValorCorrida.Text);

                command.Parameters.AddWithValue("distanciaCorrida", txtDistanciaCorrida.Text);
                //Retira
                command.Parameters.AddWithValue("horarioRetiraCorrida", dtpHoraRetira.Text);
                command.Parameters.AddWithValue("dataRetiraCorrida", dtpDataRetira.Value);
                command.Parameters.AddWithValue("cidadeRetiradaCorrida", txtCidadeRetira.Text);
                command.Parameters.AddWithValue("enderecoRetiradaCorrida", txtEnderecoRetira.Text);
                command.Parameters.AddWithValue("enderecoNumeroRetiradaCorrida", txtNumRetira.Text);
                command.Parameters.AddWithValue("enderecoComplementoRetiradaCorrida", txtComRetira.Text);
                command.Parameters.AddWithValue("cepRetiraCorrida", txtCepRetira.Text);
                //Entrega
                command.Parameters.AddWithValue("horarioEntregaCorrida", dtpHoraEntrega.Text);
                command.Parameters.AddWithValue("dataEntregaCorrida", dtpDataEntrega.Value);
                command.Parameters.AddWithValue("cidadeEntregaCorrida", txtCidadeEntrega.Text);
                command.Parameters.AddWithValue("enderecoEntregaCorrida", txtEnderecoEntrega.Text);
                command.Parameters.AddWithValue("enderecoNumeroEntregaCorrida", txtNumEntrega.Text);
                command.Parameters.AddWithValue("enderecoComplementoEntregaCorrida", txtComEntrega.Text);
                command.Parameters.AddWithValue("cepEntregaCorrida", txtCepEntrega.Text);
                //status
                //command.Parameters.AddWithValue("statusCorrida", txtStatusCorrida.Text);



                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Corrida cadastrada");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult + ":" + ex.Message);

            }
            



        }
    }
}
