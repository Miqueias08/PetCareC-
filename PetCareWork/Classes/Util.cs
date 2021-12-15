using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetCareWork.Classes
{
    class Util
    {
        static string titulo = "Nome do Sistema";
        //acrescenta a condição do if do program.cs
        public static int tipo_usuario = 0; //Valid user



        //Método para mensagens
        public static void Mensagem(string texto)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        //Método para perguntas
        public static bool Pergunta(string texto)
        {
            DialogResult resposta;

            resposta = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Método para configurar formularios
        public static void ConfigForm(Form f)
        {
            f.StartPosition = FormStartPosition.CenterScreen;
            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.MinimizeBox = false;
            f.MaximizeBox = false;
            f.ShowInTaskbar = false;
            //f.BackColor = Color.FromArgb(200,100,50);
        }

        public static void ConfigDataGrid(DataGridView d)
        {
            d.AllowUserToAddRows = false;
            d.AllowUserToDeleteRows = false;
            d.AllowUserToResizeRows = false;
            //d.AllowUserToResizeColumns = false;
            d.AllowUserToOrderColumns = false;
            d.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;
            d.BackgroundColor = System.Drawing.Color.White;
            d.CellBorderStyle = DataGridViewCellBorderStyle.None;
            d.EditMode = DataGridViewEditMode.EditProgrammatically;
            d.RowHeadersVisible = false;
            d.ScrollBars = ScrollBars.Both;
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.MultiSelect = false;
            d.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //NOVO            
        }
    }
}
