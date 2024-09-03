using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaDGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //Adiciona o conteudo das caixas de texto nas colunas correspondentes
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);
            //limpa as caixas de texto
            txtCurso.Clear();
            txtNome.Clear();
            //exibe uma mensagem ao usuário de inclusão com sucesso!
            MessageBox.Show("Aluno incluido com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //exibe na label o quantidade de linhas no GridView atualizado após a inserção
            lblTotal.Text = dgvAlunos.Rows.Count.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.RowCount > 0)
            {
                //Remove a linha selecionada Do grid
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
                //exibe uma mensagem ao usuário de exclusão com sucesso 
                MessageBox.Show("Aluno excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Exibe na label o contador de linhas do GridView atualizado após a remoção 
                lblTotal.Text = dgvAlunos.RowCount.ToString();
            }
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica a existência de linhas no Grid
            if (dgvAlunos.RowCount > 0)
            {
                //move o Conteúdo da primeira célula da linha selecionada para a caixa de texto
                txtAlterarNome.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlterarNome.Text != "")
            {
                //Move o novo valor da caixa de texto Alteração para a célula selecionada
                dgvAlunos.CurrentRow.Cells[0].Value = txtAlterarNome.Text;
                //exibe a mensagem de alteração
                MessageBox.Show("nome atualizado com sucesso!", "atualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void btnExcluirTodos_Click(object sender, EventArgs e)
        {
            //zera as linhas do Grid
            dgvAlunos.RowCount = 0;
            //exibe na label o contador de linhas do Grid View Após ser zerado
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
