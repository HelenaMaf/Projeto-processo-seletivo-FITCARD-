using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Projeto_FitCard_Helena_Azevedo
{
    public partial class Form1 : Form
    {

        Estabelecimento tabEstabelecimento;
        HttpClient Cliente;
        HttpResponseMessage response;

        public object JsonConvert { get; private set; }

        public Form1()
        {
            tabEstabelecimento = new Estabelecimento();
            Cliente = new HttpClient();
            response = new HttpResponseMessage();
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private async void consultarEstabelecimentos()
        {
            response = await Cliente.GetAsync(textURL.Text);
            if (response.IsSuccessStatusCode)
            {
                //A variável recebe o resultado da resposta do servidor
                var estabelecimentos = await response.Content.ReadAsStringAsync();
                dataGridView.DataSource = JsonConvert.DeserializeObject<Estabelecimento[]>(estabelecimentos).ToList();
            }
            else
            {
                MessageBox.Show("Não foi possível realizar a consulta");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            consultarEstabelecimentos();
        }
    }
    }
        


