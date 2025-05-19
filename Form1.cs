namespace FASE2PrograDASA35VD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string figura = textBox1.Text;
            MessageBox.Show("La figura ingresada es: " + figura);

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string figura = textBox1.Text;
            //Diego Saquil VD 35
            //La variable A se puede relacionar como los lados
            //En algunos casos se toma como mimba base, ancho o el caso que sea seg�n la figura A o B
            double a, b;
            if (!double.TryParse(textBox2.Text, out a) || !double.TryParse(textBox3.Text, out b))
            {
                MessageBox.Show("Error: Ingrese valores num�ricos v�lidos.");
                return;
            }

            double Resultado = 0;

            if (figura == "Triangulo Equi")
            {
                Resultado = 3 * a;
                MessageBox.Show("El perimetro del Tri�ngulo es: " + Resultado);
            }
            else if (figura == "Cuadrado")
            {
                Resultado = 4 * a;
                MessageBox.Show("El per�metro del Cuadrado es: " + Resultado);
            }
            else if (figura == "Rectangulo")
            {
                Resultado = 2 * (a + b);
                MessageBox.Show("El per�metro del Rect�ngulo es: " + Resultado);
            }
            else if (figura == "Circulo")
            {
                Resultado = 2 * Math.PI * a;
                MessageBox.Show("El per�metro del Circulo es: " + Resultado);
            }
            else if (figura == "Rombo")
            {
                Resultado = 4 * a;
                MessageBox.Show("El per�metro del Rombo es: " + Resultado);
            }
            else if (figura == "Pentagono regular")
            {
                Resultado = 5 * a;
                MessageBox.Show("El per�metro del pentagono regular es: " + Resultado);
            }
            else if (figura == "Hexagono regular")
            {
                Resultado = 6 * a;
                MessageBox.Show("El per�metro del Hexagono regular es: " + Resultado);
            }
            else if (figura == "Heptagono regular")
            {
                Resultado = 7 * a;
                MessageBox.Show("El per�metro del Heptagono regular es: " + Resultado);
            }
            else if (figura == "Octagono regular")
            {
                Resultado = 8 * a;
                MessageBox.Show("El per�metro del Octagono regular es: " + Resultado);
            }
            else if (figura == "Paralelogramo")
            {
                Resultado = 2 * (a + b);
                MessageBox.Show("El per�metro del Paralelogramo es: " + Resultado);
            }
            else if (figura == "Trapezoide")
            {
                Resultado = a + b + a + b;
                MessageBox.Show("El per�metro del Trapezoide es: " + Resultado);
            }
            else if (figura == "Triangulo Is�sceles")
            {
                Resultado = 2 * (a + b);
                MessageBox.Show("El per�metro del Triangulo Is�sceles es: " + Resultado);
            }
            else if (figura == "Estrella")
            {
                Resultado = 10 * a;
                MessageBox.Show("El per�metro de la estrella es: " + Resultado);
            }
            else if (figura == "Elipse")
            {
                Resultado = Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
                MessageBox.Show("El per�metro de la elipse es: " + Resultado);
            }
            else if (figura == "Nonagono regular")
            {
                Resultado = 9 * a;
                MessageBox.Show("El per�metro del Nonagono regular es: " + Resultado);
            }
            else if (figura == "Decagono regular")
            {
                Resultado = 10 * a;
                MessageBox.Show("El per�metro del Decagono regular es: " + Resultado);
            }
            else if (figura == "Dodecagono regular")
            {
                Resultado = 12 * a;
                MessageBox.Show("El per�metro del Dodecagono regular es: " + Resultado);
            }
            else if (figura == "Triangulo Escaleno")
            {
                Resultado = a + a + b + b;
                MessageBox.Show("El per�metro del Triangulo escaleno es: " + Resultado);
            }
            else if (figura == "Romboide")
            {
                Resultado = 2 * (a + b);
                MessageBox.Show("El per�metro del Romboide regular es: " + Resultado);
            }
            else if (figura == "Trapecio")
            {
                Resultado = a + b + a + b;
                MessageBox.Show("El per�metro del Trapecio es: " + Resultado);

            }
        }
    }
}
