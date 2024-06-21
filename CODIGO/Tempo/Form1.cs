using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void converterTempo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Valor.Text))
                {
                    Resultado.Text = "ERRO: POR FAVOR, PREENCHA TODOS O CAMPO!";
                    return;
                }

                if (float.TryParse(Valor.Text, out float valorSegundos))
                {
                    float tempoMinutos = valorSegundos / 60;
                    float tempoHoras = tempoMinutos / 60;
                    float tempoDias = tempoHoras / 24;
                    float tempoSemanas = tempoDias / 7;
                    float tempoMeses = tempoDias / 30; 
                    float tempoAnos = tempoDias / 365; 

                    Resultado.Text = $"O tempo em minutos é: {tempoMinutos:F2} minutos\n" +
                                     $"O tempo em horas é: {tempoHoras:F2} horas\n" +
                                     $"O tempo em dias é: {tempoDias:F2} dias\n" +
                                     $"O tempo em semanas é: {tempoSemanas:F2} semanas\n" +
                                     $"O tempo em meses é: {tempoMeses:F2} meses\n" +
                                     $"O tempo em anos é: {tempoAnos:F2} anos";
                }
                else
                {
                    Resultado.Text = "ERRO: POR FAVOR, INSIRA VALORES NUMÉRICOS VÁLIDOS!";
                }
            }
            catch (Exception ex)
            {
                Resultado.Text = $"OCORREU UM ERRO: {ex.Message}";
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Valor.Text = null;
            Resultado.Text = null;
        }
    }
}
