using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

 
namespace LotterySelection
{
    public partial class FrmMain : Form
    {
        //create Selector obj
        private Models.Selector selector = new Models.Selector();
        public FrmMain()
        {
            InitializeComponent();

            //Disable related buttons
            this.btn_clear.Enabled = false;
            this.btn_print.Enabled = false;
            this.btn_confirm.Enabled = false;
            this.btn_delete.Enabled = false;
        }



        #region  拖动窗体的实现

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //timed generated random numbers
        private void randomTimer_Tick(object sender, EventArgs e)
        {
            //generate random numbers
            string[] strings = selector.createNumber();
            //show random numbers
            this.bigNum1.Text = strings[0];
            this.bigNum2.Text = strings[1];
            this.bigNum3.Text = strings[2];
            this.bigNum4.Text = strings[3];
            this.bigNum5.Text = strings[4];
            this.bigNum6.Text = strings[5];
            this.bigNum7.Text = strings[6];
        }

        //confirm the number
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.randomTimer.Stop();
            string[] selectNums =
            {
                this.bigNum1.Text,
                this.bigNum2.Text,
                this.bigNum3.Text,
                this.bigNum4.Text,
                this.bigNum5.Text,
                this.bigNum6.Text,
                this.bigNum7.Text
            };
            //store selected numbers
            selector.SelectNumbers.Add(selectNums);
            //show selected numbers
            showSelectedNumbers();
        }

        private void showSelectedNumbers()
        {
            this.numberList.Items.Clear();
            this.numberList.Items.AddRange(this.selector.getPrintedNumbers().ToArray());

            //restart button
            this.btn_random.Enabled = true;
            this.btn_clear.Enabled = this.btn_delete.Enabled = this.btn_print.Enabled = true;
        }

        //start to choose number
        private void btn_random_Click(object sender, EventArgs e)
        {
            this.randomTimer.Start();

            this.btn_random.Enabled = false;
            this.btn_confirm.Enabled = true;
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            //need check input format should be number
            string[] selectNums =
            {
                this.smallNum1.Text,
                this.smallNum2.Text,
                this.smallNum3.Text,
                this.smallNum4.Text,
                this.smallNum5.Text,
                this.smallNum6.Text,
                this.smallNum7.Text
            };
            //store selected numbers
            selector.SelectNumbers.Add(selectNums);
            //show selected numbers
            showSelectedNumbers();
        }

        private void btn_random_group_Click(object sender, EventArgs e)
        {
            this.randomTimer.Stop();
            this.selector.createGroupNumber(Convert.ToInt32(this.textNumber.Text.Trim()));
            //show selected numbers
            showSelectedNumbers();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.numberList.Items.Count == 0 || this.numberList.SelectedItems == null) return;
            int index = this.numberList.SelectedIndex;
            selector.SelectNumbers.RemoveAt(index);
            if(selector.SelectNumbers.Count == 0)
            {
                this.btn_clear.Enabled = false;
                this.btn_delete.Enabled = false;
                this.btn_print.Enabled = false;
            }
            //show selected numbers
            showSelectedNumbers();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.numberList.Items.Clear();
            this.selector.SelectNumbers.Clear();

            //Disable related buttons
            this.btn_clear.Enabled = false;
            this.btn_print.Enabled = false;
            this.btn_confirm.Enabled = false;
            this.btn_delete.Enabled = false;

            this.bigNum1.Text = "0";
            this.bigNum2.Text = "0";
            this.bigNum3.Text = "0";
            this.bigNum4.Text = "0";
            this.bigNum5.Text = "0";
            this.bigNum6.Text = "0";
            this.bigNum7.Text = "0";


            this.smallNum1.Text = "0";
            this.smallNum2.Text = "0";
            this.smallNum3.Text = "0";
            this.smallNum4.Text = "0";
            this.smallNum5.Text = "0";
            this.smallNum6.Text = "0";
            this.smallNum7.Text = "0";


        }
    }
}