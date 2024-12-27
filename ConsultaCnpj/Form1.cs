using Newtonsoft.Json;
using RestSharp;

namespace ConsultaCnpj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            limpaDados();

            inputCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            bool cpfValido = ValidaCNPJ(inputCnpj.Text);
            if (!cpfValido)
            {
                inputCnpj.ForeColor = Color.Red;
                limpaDados();
                return;
            }
            else inputCnpj.ForeColor = Color.Green;

            try
            {
                var options = new RestClientOptions("https://api-publica.speedio.com.br")
                {
                    MaxTimeout = -1,
                    UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36",
                };
                var client = new RestClient(options);
                var request = new RestRequest("/buscarcnpj?cnpj=" + inputCnpj.Text, Method.Get);
                request.AddHeader("authority", "api-publica.speedio.com.br");
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
                request.AddHeader("origin", "https://apiconsultacnpj.com.br");
                request.AddHeader("referer", "https://apiconsultacnpj.com.br/");
                request.AddHeader("sec-ch-ua", "\"Chromium\";v=\"112\", \"Google Chrome\";v=\"112\", \"Not:A-Brand\";v=\"99\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "cross-site");
                RestResponse response = await client.ExecuteAsync(request);

                Empresa empresa = JsonConvert.DeserializeObject<Empresa>(response.Content);
                if (empresa.error != null)
                {
                    MessageBox.Show(empresa.error);
                }
                else
                {
                    preencherDadosEmpresa(empresa);
                    inputCnpj.TextMaskFormat = MaskFormat.IncludeLiterals;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Não foi possível buscar o CNPJ informado."+ex.Message);
            }
        }
        private void limpaDados()
        {
            txtNomeFantasia.Text = String.Empty;
            txtRazaoSocial.Text = String.Empty;
            txtCnpj.Text = String.Empty;
            txtStatus.Text = String.Empty;
            txtCnaePCodigo.Text = String.Empty;
            txtCnaePDescricao.Text = String.Empty;
            txtDdd.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtCep.Text = String.Empty;
            txtTipoLogradouro.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtMunicípio.Text = String.Empty;
            txtUF.Text = String.Empty;
            txtDataAbertura.Text = String.Empty;
        }

        private void preencherDadosEmpresa(Empresa e)
        {
            txtNomeFantasia.Text = e.NOMEFANTASIA;
            txtRazaoSocial.Text = e.RAZAOSOCIAL;
            txtCnpj.Text = e.CNPJ;
            txtStatus.Text = e.STATUS;
            txtCnaePCodigo.Text = e.CNAEPRINCIPALCODIGO;
            txtCnaePDescricao.Text = e.CNAEPRINCIPALDESCRICAO;
            txtDdd.Text = e.DDD;
            txtTelefone.Text = e.TELEFONE;
            txtEmail.Text = e.EMAIL;
            txtCep.Text = e.CEP;
            txtTipoLogradouro.Text = e.TIPOLOGRADOURO;
            txtLogradouro.Text = e.LOGRADOURO;
            txtNumero.Text = e.NUMERO;
            txtBairro.Text = e.BAIRRO;
            txtMunicípio.Text = e.MUNICIPIO;
            txtUF.Text = e.UF;
            txtDataAbertura.Text = e.DATAABERTURA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputCnpj.Text = String.Empty;
            limpaDados();
        }

        public bool ValidaCNPJ(string cnpj)
        {

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        private void txtNomeFantasia_MouseClick(object sender, MouseEventArgs e)
        {
            txtNomeFantasia.Text += 'A';
        }

        private void lblNomeFantasia_Click(object sender, EventArgs e)
        {
            if (txtNomeFantasia.Text != string.Empty)
                CopiarAreaTransferencia(txtNomeFantasia.Text);
 
        }

        private void lblRazaoSocial_Click(object sender, EventArgs e)
        {
            if (txtRazaoSocial.Text != string.Empty)
                CopiarAreaTransferencia(txtRazaoSocial.Text);
        }

        private void lblCnpj_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text != string.Empty)
                CopiarAreaTransferencia(txtCnpj.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {
                CopiarAreaTransferencia(txtCep.Text);
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text != string.Empty)
                CopiarAreaTransferencia(txtStatus.Text);
        }

        private void lblCnae_Click(object sender, EventArgs e)
        {
            if (txtCnaePDescricao.Text != string.Empty)
                CopiarAreaTransferencia(txtCnaePDescricao.Text);
        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {
            if (txtDdd.Text != string.Empty && txtTelefone.Text != string.Empty)
                CopiarAreaTransferencia(txtDdd.Text + txtTelefone.Text);
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
                CopiarAreaTransferencia(txtEmail.Text);
        }

        private void lblTipoLogradouro_Click(object sender, EventArgs e)
        {
            if (txtTipoLogradouro.Text != string.Empty)
                CopiarAreaTransferencia(txtTipoLogradouro.Text);
        }

        private void lblLogradouro_Click(object sender, EventArgs e)
        {
            if (txtLogradouro.Text != string.Empty)
                CopiarAreaTransferencia(txtLogradouro.Text);
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != string.Empty)
                CopiarAreaTransferencia(txtNumero.Text);
        }

        private void lblBairro_Click(object sender, EventArgs e)
        {
            if (txtBairro.Text != string.Empty)
                CopiarAreaTransferencia(txtBairro.Text);
        }

        private void lblMunicipio_Click(object sender, EventArgs e)
        {
            if (txtMunicípio.Text != string.Empty)
                CopiarAreaTransferencia(txtMunicípio.Text);
        }

        private void lblUF_Click(object sender, EventArgs e)
        {
            if (txtUF.Text != string.Empty)
                CopiarAreaTransferencia(txtUF.Text);
  
        }

        private void lblDataAbertura_Click(object sender, EventArgs e)
        {
            if (txtDataAbertura.Text != string.Empty)
                CopiarAreaTransferencia(txtDataAbertura.Text);
            
        }

        public void CopiarAreaTransferencia(string texto)
        {
            Clipboard.SetText(texto);
            exibeMensagemCampoCopiado();
        }
        private void imprimeTemplate()
        {
            String txt = "Razão Social: "+ txtRazaoSocial.Text +"\n" +
                "Nome Fantasia: "+ txtNomeFantasia.Text+" \n" +
                "Endereço: "+ txtTipoLogradouro.Text + " "+ txtLogradouro.Text +" \n" +
                "Bairro: "+ txtBairro.Text +"\n" +
                "Cidade: "+ txtMunicípio.Text + " - " + txtUF.Text +" \n" +
                "CEP: "+ txtCep.Text +" \n" +
                "CNPJ: "+ txtCnpj.Text +"\n" +
                "INSC:\n" +
                "Proprietário:\n" +
                "Nascimento:\n" +
                "CPF:\n" +
                "Telefone:"+ txtTelefone.Text+"\n" +
                "E-mail: "+ txtEmail.Text +"\n" +
                "Regime Tributário: \n" +
                "Esc Contabil.:\n" +
                "Tel.:\n" +
                "Contador: \n" +
                "Email:";
            CopiarAreaTransferencia(txt);
        }
        private void exibeMensagemCampoCopiado()
        {
            MessageBox.Show("Campo para área de transferência.");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimeTemplate();
        }
    }
}