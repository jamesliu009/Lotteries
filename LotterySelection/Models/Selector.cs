using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LotterySelection.Models
{
    internal class Selector
    {
        //generate random number
        private Random random = new Random();
        //generate new barcode
        Fath.BarcodeX barCode = new Fath.BarcodeX();
        //properities
        /// <summary>
        /// selected number(terporary stored)
        /// </summary>
        public List<string[]> SelectNumbers { get; set; }

        //method
        /// <summary>
        /// structure method
        /// </summary>
        public Selector()
        {
            this.SelectNumbers = new List<string[]>();
        }

        /// <summary>
        /// create 7 random number
        /// </summary>
        /// <returns></returns>
        public string[] createNumber()
        {
            
            string[] numbers = new string[7];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10).ToString();
            }
            return numbers;
        }

        /// <summary>
        /// generate given count group random numbers;
        /// </summary>
        /// <param name="count"></param>
        public void createGroupNumber(int count)
        {
            // clear previous number
            SelectNumbers.Clear();
            for(int i = 0; i < count; i++)
            {
                SelectNumbers.Add(createNumber());
            }
        }

        /// <summary>
        /// get printed format numbers
        /// </summary>
        /// <returns></returns>
        public List<string> getPrintedNumbers()
        {
            List<string> printedNumbers = new List<string>();
            for(int i = 0; i < this.SelectNumbers.Count; i++)
            {
                string printedNumber = string.Empty;
                if (i < 9)
                {
                    printedNumber = "0"+(i + 1) + "group: ";
                }
                else
                {
                    printedNumber = (i + 1) + "group: ";
                }
                for(int j = 0; j < this.SelectNumbers[i].Length; j++)
                {
                    if (j == 5)
                    {
                        printedNumber += this.SelectNumbers[i][j] + "   ";
                    }
                    else
                    {
                        printedNumber += this.SelectNumbers[i][j] + " ";
                    }
                }
                printedNumbers.Add(printedNumber);
            }
            return printedNumbers;
        }


        /// <summary>
        /// print lottery result
        /// </summary>
        public void PrintLottery(System.Drawing.Printing.PrintPageEventArgs e, string serialNum, List<string> numList)
        {
            //generate bar code
            barCode.Text = serialNum;//code data
            barCode.Symbology = Fath.bcType.Code128;//set bar code format
            barCode.ShowText = true;//show text          
            e.Graphics.DrawImage(barCode.Image(240, 50), new Point(20, 5));//drae bar code

            //generate content
            float left = 2; //left border of printed area
            float top = 70;//top border of printed area
            Font titlefont = new Font("Microsoft Yahei", 10);//title font
            Font font = new Font("Microsoft Yahei", 8);//content font            
            e.Graphics.DrawString("lottery center", titlefont, Brushes.Blue, left + 20, top, new StringFormat());//print title
            //画一条分界线
            Pen pen = new Pen(Color.Green, 1);
            e.Graphics.DrawLine(pen, new Point((int)left - 2, (int)top + 20), new Point((int)left + (int)180, (int)top + 20));

            //循环打印选号
            for (int i = 0; i < numList.Count; i++)
            {
                e.Graphics.DrawString(numList[i], font, Brushes.Blue, left,
                    top + titlefont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * i + 12, new StringFormat());
            }

            //画一条分界线           
            float topPoint = titlefont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * (numList.Count) + 22;

            e.Graphics.DrawLine(pen, new Point((int)left - 2, (int)top + (int)topPoint),
                new Point((int)left + (int)180, (int)top + (int)topPoint));

            //打印时间
            string time = "buy time：" + DateTime.Now.ToString("yyy-MM-dd  HH:mm:ss");
            e.Graphics.DrawString(time, font, Brushes.Blue, left, top + titlefont.GetHeight(e.Graphics)
                + font.GetHeight(e.Graphics) * (numList.Count + 1) + 12, new StringFormat());

            //二维码图片left和top坐标
            int qrcodetop = (int)(top + titlefont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * (numList.Count + 3) + 12);
            int qrcodeleft = (int)left + 32;

            //生成二维码图片
            // Image bmp = QRcodeCreator.GetQRCodeBmp("http://www.xiketang.com/duijiang/query?id=" + serialNum);//直接添加流水号，将来从网站直接查询
            Image bmp = QRcodeCreator.GetQRCodeBmp("http://www.xiketang.com");
            //打印
            e.Graphics.DrawImage(bmp, new Point(qrcodeleft, qrcodetop));//不同的URL图片大小不同，可以根据需要调整left坐标
            e.Graphics.DrawString("扫描二维码可直接查询兑奖结果", font, Brushes.Blue, left, qrcodetop + bmp.Height + 10, new StringFormat());
        }


        //store lottery infomation user selected
        public void save(string seriaNum)
        {
            DirectoryInfo dir = new DirectoryInfo("numList");
            if (!dir.Exists)
            {
                dir.Create();
            }
            string path = @"numList\" + seriaNum + ".num";
            FileStream file = new FileStream(path, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, this.SelectNumbers);
            file.Close();

        }
    }

}
