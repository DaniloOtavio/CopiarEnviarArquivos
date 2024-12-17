using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopiaCompactaFiscal
{
    public partial class ConfigEmail : Form
    {
        private static readonly string CaminhoEXE = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string configPath = Path.Combine(CaminhoEXE, "config.txt");
        public ConfigEmail()
        {
            InitializeComponent();
        }

        private void ConfigEmail_Load(object sender, EventArgs e)
        {

            
            if (File.Exists(configPath))
            {
                string content = File.ReadAllText(configPath);
                var contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelConfigEmail>(content);
                if (contentObj is null) return;

                txtEmail.Text = contentObj.EmailRemetente;
                txtSenha.Text = contentObj.SenhaEmail;
                portaSMTP.Value = contentObj.PortaSMTP;
                txtServidor.Text = contentObj.ServidorSMTP;

                switch (contentObj.Auth)
                {
                    case Auth.SSL:
                        rdoSSL.Checked = true;
                        break;
                    case Auth.TLS:
                        rdoTLS.Checked = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                File.Create(configPath);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool camposVazios = false;
            camposVazios = string.IsNullOrWhiteSpace(txtEmail.Text);
            camposVazios = string.IsNullOrWhiteSpace(txtSenha.Text);
            camposVazios = string.IsNullOrWhiteSpace(txtServidor.Text);
            camposVazios = portaSMTP.Value == 0;
            camposVazios = (!rdoSSL.Checked && !rdoTLS.Checked);

            if (camposVazios)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            var auth = rdoSSL.Checked ? Auth.SSL : Auth.TLS;

            var config = new ModelConfigEmail()
            {
                EmailRemetente = txtEmail.Text,
                PortaSMTP = int.Parse(portaSMTP.Value.ToString()),
                SenhaEmail = txtSenha.Text,
                ServidorSMTP = txtServidor.Text,
                Auth = auth,
            };

            var jsonConfig = Newtonsoft.Json.JsonConvert.SerializeObject(config);
            var cryptJsonConfig = CryptHelper.Criptografar(jsonConfig);

            using (StreamWriter writer = new(configPath, true)) // 'true' para adicionar ao final do arquivo
            {
                writer.WriteLine(cryptJsonConfig);
            }


            this.Close();
        }
    }

}
