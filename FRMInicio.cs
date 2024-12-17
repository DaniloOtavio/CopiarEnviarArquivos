using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CopiaCompactaFiscal
{
    public partial class FRMInicio : Form
    {
        public readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string NomePasta { get; set; } = "";
        public int QtdeArquivosEncontrados { get; set; }
        public FRMInicio()
        {
            InitializeComponent();
        }

        private void FRMInicio_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            decimal mes, ano;

            mes = now.Month - 1;
            ano = now.Year;

            txtMes.Text = mes.ToString();
            txtAno.Text = ano.ToString();

            lblAreaTrabalho.Text = desktopPath;

        }
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Configurações opcionais
            folderBrowserDialog.Description = "Selecione uma pasta";
            folderBrowserDialog.ShowNewFolderButton = true; // Permitir criar novas pastas
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop; // Pasta inicial

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                string selectedPath = folderBrowserDialog.SelectedPath;
                txtPasta.Text = selectedPath;

                NomePasta = Path.GetFileName(selectedPath);

                MessageBox.Show(NomePasta);

                try
                {
                    // Obtém todos os arquivos na pasta
                    string[] arquivos = Directory.GetFiles(selectedPath);

                    // Conta os arquivos
                    int quantidadeArquivos = arquivos.Length;

                    lblProcessados.Text = $"0 de {quantidadeArquivos} arquivos processados";
                    QtdeArquivosEncontrados = quantidadeArquivos;

                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("A pasta especificada não foi encontrada");
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Você não tem permissão para acessar essa pasta. Tente executar em modo Administrador");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            txtMes.Enabled = false;
            txtAno.Enabled = false;
            btnProcurar.Enabled = false;
            btnProcessar.Enabled = false;
            btnSair.Enabled = false;

            var mes = txtMes.Value;
            var ano = txtAno.Value;
            string origem = txtPasta.Text;
            string destino = Path.Combine(desktopPath, $"{NomePasta} - {mes} - {ano}");
            string zipDestino = $"{destino}.zip";

            pbProcessados.Minimum = 0;
            pbProcessados.Maximum = QtdeArquivosEncontrados;
            pbProcessados.Value = 0;
            lblProcessados.Text = $"0 de {QtdeArquivosEncontrados} arquivos processados";
            try
            {
                if (!Directory.Exists(origem))
                {
                    Console.WriteLine("A pasta de origem não existe.");
                    return;
                }
                if (!Directory.Exists(destino))
                    Directory.CreateDirectory(destino);

                var arquivos = Directory.GetFiles(origem);
                int x = 1;
                foreach (var arquivo in arquivos)
                {
                    FileInfo infoArquivo = new(arquivo);

                    // Filtrar pelo mês e ano
                    if (infoArquivo.LastWriteTime.Month == mes && infoArquivo.LastWriteTime.Year == ano)
                    {
                        // Copiar o arquivo para o destino
                        string caminhoDestino = Path.Combine(destino, infoArquivo.Name);
                        File.Copy(arquivo, caminhoDestino, overwrite: true);
                    }
                    lblProcessados.Text = $"{x} de {QtdeArquivosEncontrados} arquivos processados";
                    pbProcessados.Value = x;
                    Application.DoEvents();
                    x++;
                }
                if (File.Exists(zipDestino))
                    File.Delete(zipDestino);

                ZipFile.CreateFromDirectory(destino, zipDestino);
                MessageBox.Show("Finalizado!");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro", ex);
            }
            finally
            {
                txtMes.Enabled = true;
                txtAno.Enabled = true;
                btnProcurar.Enabled = true;
                btnProcessar.Enabled = true;
                btnSair.Enabled = true;

            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnConfigEmail_Click(object sender, EventArgs e)
        {
            var frm = new ConfigEmail();

            frm.ShowDialog();
        }
    }
}
