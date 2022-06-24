namespace NúmeroBinário 
{
    public partial class NúmeroBinário : Form
    {
        public NúmeroBinário()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);  //Declarando variáveis
            int div;
            int mod;


            while (x >= 1)  //Criando laço de repetição while
            {

                div = x;  //Atribuindo valor de x a div
                mod = div % 2; //calculando resto da divisão
                textBox2.Text += (mod.ToString());
                x = div / 2; //Alterando o valor de x, fazendo com que agora ele seja a divisão de div por 2
                if (x == 1)  //Fazendo condicional
                {
                    mod = div / 2;  //Caso seja igual o valor de mod será a divisão por 2
                }
               




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";  //Limpa textos
            textBox2.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";  //Limpa textos
            textBox2.Text = "";
        }
    }
}
