namespace ProyectoWindowsForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Abrir Form2
        Form2 form2 = new Form2();
        form2.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        // Abrir Form3
        Form3 form3 = new Form3();
        form3.Show();
    }
}
