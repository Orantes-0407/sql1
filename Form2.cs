using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            // Implementación del botón síncrono
            lblEstado.Text = "Preparando desayuno...";
            
            // Simular preparación de café
            System.Threading.Thread.Sleep(2000);
            lblCafe.Text = "Café: ✓";

            // Simular preparación de tostadas
            System.Threading.Thread.Sleep(3000);
            lblTostadas.Text = "Tostadas: ✓";

            // Simular preparación de jugo
            System.Threading.Thread.Sleep(1000);
            lblJugo.Text = "Jugo: ✓";

            lblEstado.Text = "¡Desayuno listo!";
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            // Implementación del botón asíncrono
            lblEstado.Text = "Preparando desayuno de forma asíncrona...";
            
            // Resetear etiquetas
            lblCafe.Text = "Café: ❌";
            lblTostadas.Text = "Tostadas: ❌";
            lblJugo.Text = "Jugo: ❌";

            // Preparar todas las tareas en paralelo
            var tareasCafe = PrepararCafeAsync();
            var tareasTostadas = PrepararTostadasAsync();
            var tareasJugo = PrepararJugoAsync();

            // Esperar a que todas las tareas se completen
            await Task.WhenAll(tareasCafe, tareasTostadas, tareasJugo);

            lblEstado.Text = "¡Desayuno listo!";
        }

        private async Task PrepararCafeAsync()
        {
            await Task.Delay(2000); // Simular 2 segundos de preparación
            lblCafe.Text = "Café: ✓";
        }

        private async Task PrepararTostadasAsync()
        {
            await Task.Delay(3000); // Simular 3 segundos de preparación
            lblTostadas.Text = "Tostadas: ✓";
        }

        private async Task PrepararJugoAsync()
        {
            await Task.Delay(1000); // Simular 1 segundo de preparación
            lblJugo.Text = "Jugo: ✓";
        }
    }
}