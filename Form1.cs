using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refit;

namespace Consulta_de_cep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            String CepInformado="";
            try
            {
                Cidade.Visible = true;
                var CepCliente = RestService.For<CepService>("http://viacep.com.br");
                CepInformado = Convert.ToString(Cep.Text);
                var address = await CepCliente.GetAdderessAsync(CepInformado);
                Cep.Text = address.Cep;
                Logradouro.Text = address.Logradouro;
                Complemento.Text = address.Complemento;
                Bairro.Text = address.Bairro;
                Localidade.Text = address.Localidades;
                Estado.Text = address.UF;
                IBGE.Text = address.IBGE;
                GIA.Text = address.GIA;
                DDD.Text = address.DDD;
                Siafi.Text = address.SIAFI;
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor digite um cep brasileiro válido " + ex.Message);
               
            }
            finally
            {
                MessageBox.Show("Cep encontrado e carregado");
            }
        }
    }
}
