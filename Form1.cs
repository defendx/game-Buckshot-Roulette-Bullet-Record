using System.Windows.Forms;

namespace 恶魔轮盘子弹记录
{

    public partial class Form1 : Form
    {
        Image image1 = Properties.Resources.图1;
        Image image2 = Properties.Resources.图2;
        Image image3 = Properties.Resources.图3;
        Image image4 = Properties.Resources.图4;
        bool AnNiu1 = false;
        bool AnNiu2 = false;
        bool AnNiu3 = false;
        bool AnNiu4 = false;
        bool KAnNiu1 = false;
        bool KAnNiu2 = false;
        bool KAnNiu3 = false;
        bool KAnNiu4 = false;
        public Form1()
        {
            InitializeComponent();
            ZiDan1.BackgroundImage = image4;
            ZiDan2.BackgroundImage = image4;
            ZiDan3.BackgroundImage = image4;
            ZiDan4.BackgroundImage = image4;
            ZiDan5.BackgroundImage = image4;
            ZiDan6.BackgroundImage = image4;
            ZiDan7.BackgroundImage = image4;
            ZiDan8.BackgroundImage = image4;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            AnNiu1 = false;
            AnNiu2 = false;
            AnNiu3 = false;
            AnNiu4 = false;
            KAnNiu1 = false;
            KAnNiu2 = false;
            KAnNiu3 = false;
            KAnNiu4 = false;
            ZiDan1.BackgroundImage = image4;
            ZiDan2.BackgroundImage = image4;
            ZiDan3.BackgroundImage = image4;
            ZiDan4.BackgroundImage = image4;
            ZiDan5.BackgroundImage = image4;
            ZiDan6.BackgroundImage = image4;
            ZiDan7.BackgroundImage = image4;
            ZiDan8.BackgroundImage = image4;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown5.Value = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown2.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (AnNiu1 == false)
            {
                if (ZiDan1.BackgroundImage == image4)
                {
                    ZiDan1.BackgroundImage = image3;
                }
                else if (ZiDan2.BackgroundImage == image4)
                {
                    ZiDan2.BackgroundImage = image3;
                }
                else if (ZiDan3.BackgroundImage == image4)
                {
                    ZiDan3.BackgroundImage = image3;
                }
                else if (ZiDan4.BackgroundImage == image4)
                {
                    ZiDan4.BackgroundImage = image3;
                }
                else if (ZiDan5.BackgroundImage == image4)
                {
                    ZiDan5.BackgroundImage = image3;
                }
                if (numericUpDown2.Value < 8)
                {
                    numericUpDown2.Value = numericUpDown2.Value + 1;
                    numericUpDown3.Value = numericUpDown3.Value + 1;

                }
                AnNiu1 = true;
                AnNiu2 = true;
                AnNiu3 = true;
                AnNiu4 = true;
                GaiLvFuZhi();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (AnNiu2 == false)
            {
                if (ZiDan1.BackgroundImage == image4)
                {
                    ZiDan1.BackgroundImage = image3;
                    ZiDan2.BackgroundImage = image3;
                }
                else if (ZiDan2.BackgroundImage == image4)
                {
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                }
                else if (ZiDan3.BackgroundImage == image4)
                {
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                }
                else if (ZiDan4.BackgroundImage == image4)
                {
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                }
                else if (ZiDan5.BackgroundImage == image4)
                {
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                }
                if (numericUpDown2.Value < 7)
                {

                    numericUpDown2.Value = numericUpDown2.Value + 2;
                    numericUpDown3.Value = numericUpDown3.Value + 2;
                }
                AnNiu1 = true;
                AnNiu2 = true;
                AnNiu3 = true;
                AnNiu4 = true;
                GaiLvFuZhi();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (AnNiu3 == false)
            {
                if (ZiDan1.BackgroundImage == image4)
                {
                    ZiDan1.BackgroundImage = image3;
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                }
                else if (ZiDan2.BackgroundImage == image4)
                {
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                }
                else if (ZiDan3.BackgroundImage == image4)
                {
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                }
                else if (ZiDan4.BackgroundImage == image4)
                {
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                }
                else if (ZiDan5.BackgroundImage == image4)
                {
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                    ZiDan7.BackgroundImage = image3;
                }
                if (numericUpDown2.Value < 6)
                {
                    numericUpDown2.Value = numericUpDown2.Value + 3;
                    numericUpDown3.Value = numericUpDown3.Value + 3;
                }
                AnNiu1 = true;
                AnNiu2 = true;
                AnNiu3 = true;
                AnNiu4 = true;
                GaiLvFuZhi();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (AnNiu4 == false)
            {
                if (ZiDan1.BackgroundImage == image4)
                {
                    ZiDan1.BackgroundImage = image3;
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                }
                else if (ZiDan2.BackgroundImage == image4)
                {
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                }
                else if (ZiDan3.BackgroundImage == image4)
                {
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                }
                else if (ZiDan4.BackgroundImage == image4)
                {
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                    ZiDan7.BackgroundImage = image3;
                }
                else if (ZiDan5.BackgroundImage == image4)
                {
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                    ZiDan7.BackgroundImage = image3;
                    ZiDan8.BackgroundImage = image3;
                }
                if (numericUpDown2.Value < 5)
                {
                    numericUpDown2.Value = numericUpDown2.Value + 4;
                    numericUpDown3.Value = numericUpDown3.Value + 4;
                }
                AnNiu1 = true;
                AnNiu2 = true;
                AnNiu3 = true;
                AnNiu4 = true;
                GaiLvFuZhi();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (KAnNiu1 == false)
            {
                if (ZiDan1.BackgroundImage == image4)
                {
                    ZiDan1.BackgroundImage = image3;
                }
                else if (ZiDan2.BackgroundImage == image4)
                {
                    ZiDan2.BackgroundImage = image3;
                }
                else if (ZiDan3.BackgroundImage == image4)
                {
                    ZiDan3.BackgroundImage = image3;
                }
                else if (ZiDan4.BackgroundImage == image4)
                {
                    ZiDan4.BackgroundImage = image3;
                }
                else if (ZiDan5.BackgroundImage == image4)
                {
                    ZiDan5.BackgroundImage = image3;
                }
                if (numericUpDown2.Value < 8)
                {
                    numericUpDown2.Value = numericUpDown2.Value + 1;
                    numericUpDown4.Value = numericUpDown4.Value + 1;
                }
                KAnNiu1 = true;
                KAnNiu2 = true;
                KAnNiu3 = true;
                KAnNiu4 = true;
                GaiLvFuZhi();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (KAnNiu2 == false)
            {
                if (ZiDan1.BackgroundImage == image4)
                {
                    ZiDan1.BackgroundImage = image3;
                    ZiDan2.BackgroundImage = image3;
                }
                else if (ZiDan2.BackgroundImage == image4)
                {
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                }
                else if (ZiDan3.BackgroundImage == image4)
                {
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                }
                else if (ZiDan4.BackgroundImage == image4)
                {
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                }
                else if (ZiDan5.BackgroundImage == image4)
                {
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                }
                if (numericUpDown2.Value < 7)
                {
                    numericUpDown2.Value = numericUpDown2.Value + 2;
                    numericUpDown4.Value = numericUpDown4.Value + 2;
                }
                KAnNiu1 = true;
                KAnNiu2 = true;
                KAnNiu3 = true;
                KAnNiu4 = true;
                GaiLvFuZhi();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (KAnNiu3 == false)
            {
                if (ZiDan1.BackgroundImage == image4)
                {
                    ZiDan1.BackgroundImage = image3;
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                }
                else if (ZiDan2.BackgroundImage == image4)
                {
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                }
                else if (ZiDan3.BackgroundImage == image4)
                {
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                }
                else if (ZiDan4.BackgroundImage == image4)
                {
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                }
                else if (ZiDan5.BackgroundImage == image4)
                {
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                    ZiDan7.BackgroundImage = image3;
                }
                if (numericUpDown2.Value < 6)
                {
                    numericUpDown2.Value = numericUpDown2.Value + 3;
                    numericUpDown4.Value = numericUpDown4.Value + 3;
                }
                KAnNiu1 = true;
                KAnNiu2 = true;
                KAnNiu3 = true;
                KAnNiu4 = true;
                GaiLvFuZhi();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (KAnNiu4 == false)
            {
                if (ZiDan1.BackgroundImage == image4)
                {
                    ZiDan1.BackgroundImage = image3;
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                }
                else if (ZiDan2.BackgroundImage == image4)
                {
                    ZiDan2.BackgroundImage = image3;
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                }
                else if (ZiDan3.BackgroundImage == image4)
                {
                    ZiDan3.BackgroundImage = image3;
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                }
                else if (ZiDan4.BackgroundImage == image4)
                {
                    ZiDan4.BackgroundImage = image3;
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                    ZiDan7.BackgroundImage = image3;
                }
                else if (ZiDan5.BackgroundImage == image4)
                {
                    ZiDan5.BackgroundImage = image3;
                    ZiDan6.BackgroundImage = image3;
                    ZiDan7.BackgroundImage = image3;
                    ZiDan8.BackgroundImage = image3;
                }
                if (numericUpDown2.Value < 5)
                {
                    numericUpDown2.Value = numericUpDown2.Value + 4;
                    numericUpDown4.Value = numericUpDown4.Value + 4;
                }
                KAnNiu1 = true;
                KAnNiu2 = true;
                KAnNiu3 = true;
                KAnNiu4 = true;
                GaiLvFuZhi();
            }
        }
        private void ZiDan1_Click(object sender, EventArgs e)
        {
            if (ZiDan1.BackgroundImage == image3)
            {
                ZiDan1.BackgroundImage = image2;
            }
            else if (ZiDan1.BackgroundImage == image2)
            {
                ZiDan1.BackgroundImage = image1;
            }
            else if (ZiDan1.BackgroundImage == image1)
            {
                ZiDan1.BackgroundImage = image3;
            }
            GaiLvFuZhi();
        }
        private void ZiDan2_Click(object sender, EventArgs e)
        {
            if (ZiDan2.BackgroundImage == image3)
            {
                ZiDan2.BackgroundImage = image2;
            }
            else if (ZiDan2.BackgroundImage == image2)
            {
                ZiDan2.BackgroundImage = image1;
            }
            else if (ZiDan2.BackgroundImage == image1)
            {
                ZiDan2.BackgroundImage = image3;
            }
            GaiLvFuZhi();
        }
        private void ZiDan3_Click(object sender, EventArgs e)
        {
            if (ZiDan3.BackgroundImage == image3)
            {
                ZiDan3.BackgroundImage = image2;
            }
            else if (ZiDan3.BackgroundImage == image2)
            {
                ZiDan3.BackgroundImage = image1;
            }
            else if (ZiDan3.BackgroundImage == image1)
            {
                ZiDan3.BackgroundImage = image3;
            }
            GaiLvFuZhi();
        }
        private void ZiDan4_Click(object sender, EventArgs e)
        {
            if (ZiDan4.BackgroundImage == image3)
            {
                ZiDan4.BackgroundImage = image2;
            }
            else if (ZiDan4.BackgroundImage == image2)
            {
                ZiDan4.BackgroundImage = image1;
            }
            else if (ZiDan4.BackgroundImage == image1)
            {
                ZiDan4.BackgroundImage = image3;
            }
            GaiLvFuZhi();
        }
        private void ZiDan5_Click(object sender, EventArgs e)
        {
            if (ZiDan5.BackgroundImage == image3)
            {
                ZiDan5.BackgroundImage = image2;
            }
            else if (ZiDan5.BackgroundImage == image2)
            {
                ZiDan5.BackgroundImage = image1;
            }
            else if (ZiDan5.BackgroundImage == image1)
            {
                ZiDan5.BackgroundImage = image3;
            }
            GaiLvFuZhi();
        }
        private void ZiDan6_Click(object sender, EventArgs e)
        {
            if (ZiDan6.BackgroundImage == image3)
            {
                ZiDan6.BackgroundImage = image2;
            }
            else if (ZiDan6.BackgroundImage == image2)
            {
                ZiDan6.BackgroundImage = image1;
            }
            else if (ZiDan6.BackgroundImage == image1)
            {
                ZiDan6.BackgroundImage = image3;
            }
            GaiLvFuZhi();
        }
        private void ZiDan7_Click(object sender, EventArgs e)
        {
            if (ZiDan7.BackgroundImage == image3)
            {
                ZiDan7.BackgroundImage = image2;
            }
            else if (ZiDan7.BackgroundImage == image2)
            {
                ZiDan7.BackgroundImage = image1;
            }
            else if (ZiDan7.BackgroundImage == image1)
            {
                ZiDan7.BackgroundImage = image3;
            }
            GaiLvFuZhi();
        }
        private void ZiDan8_Click(object sender, EventArgs e)
        {

            if (ZiDan8.BackgroundImage == image3)
            {
                ZiDan8.BackgroundImage = image2;
            }
            else if (ZiDan8.BackgroundImage == image2)
            {
                ZiDan8.BackgroundImage = image1;
            }
            else if (ZiDan8.BackgroundImage == image1)
            {
                ZiDan8.BackgroundImage = image3;
            }
            GaiLvFuZhi();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                numericUpDown1.Value = numericUpDown2.Value;
            }
            if (numericUpDown1.Value == 0)
            {
                AnNiu1 = false;
                AnNiu2 = false;
                AnNiu3 = false;
                AnNiu4 = false;
                KAnNiu1 = false;
                KAnNiu2 = false;
                KAnNiu3 = false;
                KAnNiu4 = false;
                ZiDan1.BackgroundImage = image4;
                ZiDan2.BackgroundImage = image4;
                ZiDan3.BackgroundImage = image4;
                ZiDan4.BackgroundImage = image4;
                ZiDan5.BackgroundImage = image4;
                ZiDan6.BackgroundImage = image4;
                ZiDan7.BackgroundImage = image4;
                ZiDan8.BackgroundImage = image4;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown5.Value = 0;
            }
            if (numericUpDown2.Value - numericUpDown1.Value == 1)
            {
                ZiDan1.BackgroundImage = image4;
            }
            if (numericUpDown2.Value - numericUpDown1.Value == 2)
            {
                ZiDan2.BackgroundImage = image4;
            }
            if (numericUpDown2.Value - numericUpDown1.Value == 3)
            {
                ZiDan3.BackgroundImage = image4;
            }
            if (numericUpDown2.Value - numericUpDown1.Value == 4)
            {
                ZiDan4.BackgroundImage = image4;
            }
            if (numericUpDown2.Value - numericUpDown1.Value == 5)
            {
                ZiDan5.BackgroundImage = image4;
            }
            if (numericUpDown2.Value - numericUpDown1.Value == 6)
            {
                ZiDan6.BackgroundImage = image4;
            }
            if (numericUpDown2.Value - numericUpDown1.Value == 7)
            {
                ZiDan7.BackgroundImage = image4;
            }
            if (numericUpDown2.Value - numericUpDown1.Value == 8)
            {
                ZiDan8.BackgroundImage = image4;
            }
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value + numericUpDown4.Value > numericUpDown1.Value)
            {
                numericUpDown3.Value = numericUpDown3.Value - 1;
            }
            if (numericUpDown2.Value == 0)
            {
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
            }
            numericUpDown1.Value = numericUpDown3.Value + numericUpDown4.Value;
            GaiLvFuZhi();
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value + numericUpDown4.Value > numericUpDown1.Value)
            {
                numericUpDown4.Value = numericUpDown4.Value - 1;
            }
            if (numericUpDown2.Value == 0)
            {
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
            }
            numericUpDown1.Value = numericUpDown3.Value + numericUpDown4.Value;
            GaiLvFuZhi();
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value == 0)
            {
                numericUpDown5.Value = 0;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value / 100.0;
        }
         private (int ShiTiDan,int KongBaoDan,int WeiZhi) TongJiShuLiang()
         {
            int ShiTiDan = 0;
            int KongBaoDan = 0;
            int WeiZhi = 0;
            if (ZiDan1.BackgroundImage == image1)
             {
                 ShiTiDan++;
             }
             if (ZiDan2.BackgroundImage == image1)
             {
                 ShiTiDan++;
             }
             if (ZiDan3.BackgroundImage == image1)
             {
                 ShiTiDan++;
             }
             if (ZiDan4.BackgroundImage == image1)
             {
                 ShiTiDan++;
             }
             if (ZiDan5.BackgroundImage == image1)
             {
                 ShiTiDan++;
             }
             if (ZiDan6.BackgroundImage == image1)
             {
                 ShiTiDan++;
             }
             if (ZiDan7.BackgroundImage == image1)
             {
                 ShiTiDan++;
             }
             if (ZiDan8.BackgroundImage == image1)
             {
                 ShiTiDan++;
             }
             if (ZiDan1.BackgroundImage == image2)
             {
                 KongBaoDan++;
             }
             if (ZiDan2.BackgroundImage == image2)
             {
                 KongBaoDan++;
             }
             if (ZiDan3.BackgroundImage == image2)
             {
                 KongBaoDan++;
             }
             if (ZiDan4.BackgroundImage == image2)
             {
                 KongBaoDan++;
             }
             if (ZiDan5.BackgroundImage == image2)
             {
                 KongBaoDan++;
             }
             if (ZiDan6.BackgroundImage == image2)
             {
                 KongBaoDan++;
             }
             if (ZiDan7.BackgroundImage == image2)
             {
                 KongBaoDan++;
             }
             if (ZiDan8.BackgroundImage == image2)
             {
                 KongBaoDan++;
             }
            if (ZiDan1.BackgroundImage == image3)
            {
                WeiZhi++;
            }
            if (ZiDan2.BackgroundImage == image3)
            {
                WeiZhi++;
            }
            if (ZiDan3.BackgroundImage == image3)
            {
                WeiZhi++;
            }
            if (ZiDan4.BackgroundImage == image3)
            {
                WeiZhi++;
            }
            if (ZiDan5.BackgroundImage == image3)
            {
                WeiZhi++;
            }
            if (ZiDan6.BackgroundImage == image3)
            {
                WeiZhi++;
            }
            if (ZiDan7.BackgroundImage == image3)
            {
                WeiZhi++;
            }
            if (ZiDan8.BackgroundImage == image3)
            {
                WeiZhi++;
            }
            return (ShiTiDan,KongBaoDan,WeiZhi);
    }
        private void GaiLvFuZhi()
        {
            (int ShiTiDan, int KongBaoDan, int WeiZhi) = TongJiShuLiang();
            int ShiTiDan_1 = (int)numericUpDown3.Value - ShiTiDan;
            if (ShiTiDan_1 < 0) { ShiTiDan_1 = 0; }
            double GaiLv = (double)ShiTiDan_1/ WeiZhi;
            if (ZiDan1.BackgroundImage == image1) { GaiLv1.Text = "100%"; }
            if (ZiDan2.BackgroundImage == image1) { GaiLv2.Text = "100%"; }
            if (ZiDan3.BackgroundImage == image1) { GaiLv3.Text = "100%"; }
            if (ZiDan4.BackgroundImage == image1) { GaiLv4.Text = "100%"; }
            if (ZiDan5.BackgroundImage == image1) { GaiLv5.Text = "100%"; }
            if (ZiDan6.BackgroundImage == image1) { GaiLv6.Text = "100%"; }
            if (ZiDan7.BackgroundImage == image1) { GaiLv7.Text = "100%"; }
            if (ZiDan8.BackgroundImage == image1) { GaiLv8.Text = "100%"; }
            if (ZiDan1.BackgroundImage == image2) { GaiLv1.Text = "0%"; }
            if (ZiDan2.BackgroundImage == image2) { GaiLv2.Text = "0%"; }
            if (ZiDan3.BackgroundImage == image2) { GaiLv3.Text = "0%"; }
            if (ZiDan4.BackgroundImage == image2) { GaiLv4.Text = "0%"; }
            if (ZiDan5.BackgroundImage == image2) { GaiLv5.Text = "0%"; }
            if (ZiDan6.BackgroundImage == image2) { GaiLv6.Text = "0%"; }
            if (ZiDan7.BackgroundImage == image2) { GaiLv7.Text = "0%"; }
            if (ZiDan8.BackgroundImage == image2) { GaiLv8.Text = "0%"; }
            if (ZiDan1.BackgroundImage == image3) { GaiLv1.Text = GaiLv.ToString("P0"); }
            if (ZiDan2.BackgroundImage == image3) { GaiLv2.Text = GaiLv.ToString("P0"); }
            if (ZiDan3.BackgroundImage == image3) { GaiLv3.Text = GaiLv.ToString("P0"); }
            if (ZiDan4.BackgroundImage == image3) { GaiLv4.Text = GaiLv.ToString("P0"); }
            if (ZiDan5.BackgroundImage == image3) { GaiLv5.Text = GaiLv.ToString("P0"); }
            if (ZiDan6.BackgroundImage == image3) { GaiLv6.Text = GaiLv.ToString("P0"); }
            if (ZiDan7.BackgroundImage == image3) { GaiLv7.Text = GaiLv.ToString("P0"); }
            if (ZiDan8.BackgroundImage == image3) { GaiLv8.Text = GaiLv.ToString("P0"); }
            if (ZiDan1.BackgroundImage == image4) { GaiLv1.Text = ""; }
            if (ZiDan2.BackgroundImage == image4) { GaiLv2.Text = ""; }
            if (ZiDan3.BackgroundImage == image4) { GaiLv3.Text = ""; }
            if (ZiDan4.BackgroundImage == image4) { GaiLv4.Text = ""; }
            if (ZiDan5.BackgroundImage == image4) { GaiLv5.Text = ""; }
            if (ZiDan6.BackgroundImage == image4) { GaiLv6.Text = ""; }
            if (ZiDan7.BackgroundImage == image4) { GaiLv7.Text = ""; }
            if (ZiDan8.BackgroundImage == image4) { GaiLv8.Text = ""; }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 0){
                (int ShiTiDan, int KongBaoDan, int WeiZhi) = TongJiShuLiang();
                int buttonIndex = (int)(numericUpDown2.Value - numericUpDown1.Value + 1);
                Button currentButton = this.Controls.Find("ZiDan" + buttonIndex, true).FirstOrDefault() as Button;
                if (currentButton.BackgroundImage == image2)
                {
                    numericUpDown4.Value--;
                }
                else if (currentButton.BackgroundImage == image1)
                {
                    numericUpDown3.Value--;
                }
                else if (numericUpDown3.Value - ShiTiDan == 0)
                {
                    numericUpDown4.Value--;
                }
                else if (currentButton.BackgroundImage == image3)
                {
                    numericUpDown3.Value--;
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (numericUpDown4.Value >0) 
            {
                (int ShiTiDan, int KongBaoDan,int WeiZhi) = TongJiShuLiang();
                int buttonIndex = (int)(numericUpDown2.Value - numericUpDown1.Value + 1);
                Button currentButton = this.Controls.Find("ZiDan" + buttonIndex, true).FirstOrDefault() as Button;
                if (currentButton.BackgroundImage == image1)
                {
                    numericUpDown3.Value--;
                }
                else if (currentButton.BackgroundImage == image2)
                {
                    numericUpDown4.Value--;
                }
                else if (numericUpDown4.Value - KongBaoDan == 0)
                {
                    numericUpDown3.Value--;
                }
                else if (currentButton.BackgroundImage == image3)
                {
                    numericUpDown4.Value--;
                }
            }
        }
    }
}
