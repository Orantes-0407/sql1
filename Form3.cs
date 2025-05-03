using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWindowsForms
{
    public partial class Form3 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        
        public Form3()
        {
            InitializeComponent();
        }

        private async void btnConsulta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para consultar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Consultar API de Pokemon para obtener datos
                string nombre = txtNombre.Text.ToLower().Trim();
                var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{nombre}");
                
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var pokemonData = JsonSerializer.Deserialize<JsonElement>(content);

                    // Mostrar información
                    lblNombre.Text = $"Nombre: {char.ToUpper(nombre[0]) + nombre.Substring(1)}";
                    lblPeso.Text = $"Peso: {pokemonData.GetProperty("weight").GetInt32() / 10.0} kg";
                    lblAltura.Text = $"Altura: {pokemonData.GetProperty("height").GetInt32() / 10.0} m";

                    // Cargar imagen
                    string imageUrl = pokemonData.GetProperty("sprites").GetProperty("front_default").GetString();
                    using (var pictureStream = await _httpClient.GetStreamAsync(imageUrl))
                    {
                        pictureBox1.Image = Image.FromStream(pictureStream);
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontró información para '{nombre}'.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}