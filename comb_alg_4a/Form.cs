using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace comb_alg_4a
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public void ShowRes(long timeSort, long timeGreed, int deltaExact, int deltaGreed, string exactAlgRes, string greedyAlg)
        {
            tbExactAlg.Clear();
            tbGreedAlg.Clear();

            tbExactAlg.Text += exactAlgRes + Environment.NewLine;
            tbGreedAlg.Text += greedyAlg + Environment.NewLine;

            dgv.RowCount = 2;
            dgv.Rows[0].Cells[0].Value = "Время работы:";
            dgv.Rows[1].Cells[0].Value = "Дельта:";
            dgv.Rows[0].Cells[1].Value = timeSort.ToString();
            dgv.Rows[0].Cells[2].Value = timeGreed.ToString();
            dgv.Rows[1].Cells[1].Value = deltaExact.ToString();
            dgv.Rows[1].Cells[2].Value = deltaGreed.ToString();
            dgv.AutoResizeColumns();
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            if ((tbElems.Text == "") || (tbSum.Text == ""))
            {
                MessageBox.Show("Введите исходные данные.");
            }
            else
            {

                int[] elems = null;
                try
                {
                    elems = tbElems.Text.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();
                    //elems = elems.Distinct().ToArray();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при вводе чисел.");
                }

                //время выполнения и "погрешность"
                long timeExact = 0; int deltaExact = 0;
                long timeGreed = 0; int deltaGreed = 0;

                string exactAlgRes = ExactAlgorithm.Result(elems, int.Parse(tbSum.Text), out timeExact, out deltaExact);
                string greedAlgRes = GreedAlgorithm.Result(elems, int.Parse(tbSum.Text), out timeGreed, out deltaGreed);

                ShowRes(timeExact, timeGreed, deltaExact, deltaGreed, exactAlgRes, greedAlgRes);

            }
        }

        private void tbElems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void tbElems_TextChanged(object sender, EventArgs e)
        {
            tbExactAlg.Clear();
            tbGreedAlg.Clear();
            tbSum.Clear();
            dgv.Rows.Clear();
        }

        private void tbSum_TextChanged(object sender, EventArgs e)
        {
            tbExactAlg.Clear();
            tbGreedAlg.Clear();
            dgv.Rows.Clear();
        }
    }
}
