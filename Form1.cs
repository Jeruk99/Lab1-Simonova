using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingoHelpApp
{
    public partial class Lab : Form
    {
        public Lab()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender,EventArgs e)
        {

        }
        private void PrintSeq(int n,int k,int prevElement, string seq)
        {
            if (prevElement != 0)
                seq += $"{prevElement} ";
            if (seq.Length/2 == n)
            {
                ResultOut.Rows.Add(seq[..^1]);
            }
            else
                for (int i = prevElement + 1; i <= k; i++)
                    PrintSeq(n, k, i, seq);
        }
        private void DoTask_Click(object sender, EventArgs e)
        {
            int n, k;
            if (Int32.TryParse(EnterN.Text, out n) && Int32.TryParse(EnterK.Text, out k) && n > 0 && k > 0)
            {
                if (ResultOut.Columns.Count > 0)
                    ResultOut.Columns.RemoveAt(0);
                ResultOut.Columns.Add("Column","Последовательность");
                ResultOut.Columns[0].Width = 263;
                PrintSeq(n, k, 0, "");
            }
            else
                ErrorLabel.Text = "Введены не натуральные числа";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Info_Click(object sender, EventArgs e)
        {

        }
    }
}
