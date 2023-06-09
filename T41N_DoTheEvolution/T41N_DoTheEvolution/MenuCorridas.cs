﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace T41N_DoTheEvolution
{
    public partial class MenuCorridas : Form
    {
        Principal principal;

        public string IDcorrida, status = "Ativa";


        public MenuCorridas(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        private void btnCancelarCorrida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuCorridas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnBuscarSolicitante_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new
              SqlConnection(Properties.Settings.Default.strConexao.ToString());

                SqlCommand command = new SqlCommand();
                command.CommandText = "ps_CorridaCPFouCNPJ";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;


                command.Parameters.AddWithValue("cpfouCPNJCliente", txtSolicitanteCorrida.Text); // MUDAR PARA NOME E CPF NA BUSCA


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable ds = new DataTable();

                adapter.Fill(ds);

                DGVcorridas.DataSource = ds;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.HResult + ":" + ex.Message;
                
            }
           
        }

        private void btnExcluirCorrida_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.strConexao.ToString());
                SqlCommand command = new SqlCommand();
                command.CommandText = "pc_Corrida";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("cpfouCPNJCliente", IDcorrida);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Corrida Cancelada");

                Listar();
            }
            catch (Exception ex) { lblMensagem.Text = ex.HResult + ":" + ex.Message;  }
            
        }

        private void btnEditarCorrida_Click(object sender, EventArgs e)
        {
            DirecionarCorrida Atualizar = new DirecionarCorrida(IDcorrida);
            Atualizar.Show();
        }

        private void btnFinalizarCorrida_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.strConexao.ToString());
                SqlCommand command = new SqlCommand();
                command.CommandText = "pf_Corrida";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("idCorrida", IDcorrida);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Corrida Finalizada !");

                Listar();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.HResult + ":" + ex.Message;
               
            }

        }
        private void Listar()
        {
            try
            {
                SqlConnection connection = new
               SqlConnection(Properties.Settings.Default.strConexao.ToString());


                SqlCommand command = new SqlCommand();
                command.CommandText = "ListarCorrida";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;


                command.Parameters.AddWithValue("statusCorrida", status); // MUDAR PARA NOME E CPF NA BUSCA


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable ds = new DataTable();

                adapter.Fill(ds);

                DGVcorridas.DataSource = ds;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.HResult + ":" + ex.Message;
                
            }

        }

        private void DGVcorridas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            IDcorrida = DGVcorridas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }






    }



}
