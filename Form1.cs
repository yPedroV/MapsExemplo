namespace MapsExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //esse projeto vai baixar o html da pagina remota e capturar os dados das DIVS
            //ou seja, serve para qualquer pagina que funcione via browser

            //aqui eu prefixei o endereco do google, mas caso seja um endereço
            //dinamico posso pegar o link direto do front por um campo de input
            string enderecoPrefixo = "https://www.google.com.br/maps/place/";
            try
            {
                WebTest wc = new WebTest();
                //se fosse um endereço dinamico eu colocaria aqui abaixo o input direto
                string resultado = wc.RequestDadosWeb(enderecoPrefixo + txtCEP.Text);
                //aqui estou dando um slipt para pegar a posição com o dados desejado
                string[] resul = resultado.Split("\"");
                txtEndereco.Text = resul[43];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}