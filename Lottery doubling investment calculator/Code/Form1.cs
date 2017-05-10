using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 倍投计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int count = this.Controls.Count * 2 + 2;
            float[] factor = new float[count];
            int i = 0;
            factor[i++] = Size.Width;
            factor[i++] = Size.Height;
            foreach (Control ctrl in this.Controls)
            {
                factor[i++] = ctrl.Location.X / (float)Size.Width;
                factor[i++] = ctrl.Location.Y / (float)Size.Height;
                ctrl.Tag = ctrl.Size;//!!!
            }
            Tag = factor;
        }

        #region 文本框

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool x小数点检测 = zj.Text.Contains(".");

            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != 8 && (e.KeyChar != 46))
            {
                e.Handled = true;
            }
            else if (x小数点检测 && (e.KeyChar == 46)) //如果输入了小数点，并且再次输入 
            {
                e.Handled = true;
            }
        }

        #endregion

        Form2 f2;
        Form3 f3;

        public void SkinButton1_Click(object sender, EventArgs k)
        {
            if (bt.Text != "" || ct.Text != "" || zj.Text != "")
            {
                if (Convert.ToDouble(zj.Text) != 1 || Convert.ToDouble(zj.Text) < 1)
                {
                    Out.Text = null;
                    int a = 1;
                    int i = 0;      //初投资金
                    int e = 0;      //总金额
                    int j = 0;      //期数
                    double z = 0;   //赔率
                    double y = 0;   //可得利益
                    double Z = 0;   //本期中奖
                    string txt = null;
                    bool f = true;

                    StringBuilder sb = new StringBuilder();
                    sb.Append(Out.Text);


                    j = Convert.ToInt32(bt.Text);
                    i = Convert.ToInt32(ct.Text);
                    z = Convert.ToDouble(zj.Text);

                    while (j != 0)
                    {
                        j--;

                        while (f == true)
                        {
                            if ((z * i) - (e + i) > 0)
                            {
                                e = e + i;
                                Z = z * i;
                                y = Z - e;

                                f = false;
                                goto bb;
                            }

                            i++;
                        }

                        e = e + i;
                        Z = z * i;
                        y = Z - e;

                    bb:
                        txt = "第" + a + "期    投资金额：" + Convert.ToString(i) + "元    总金额："
                            + Convert.ToString(e) + "元    中奖金额：" + Convert.ToString(Z) + "元    可得利益："
                            + Convert.ToString(y) + "元\r\n";

                        sb.Append(txt);

                        a++;
                        f = true;
                    }


                    Out.Text = Convert.ToString(sb);
                }
                else
                {
                    if (bt.Text != "" && ct.Text != "")
                    {
                        f2 = new Form2();
                        f2.ShowDialog();
                    }
                    else
                    {
                        f3 = new Form3();
                        f3.ShowDialog();
                    }
                }
            }
            else
            {
                f3 = new Form3();
                f3.ShowDialog();
            }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float[] scale = (float[])Tag;
            int i = 2;

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Left = (int)(Size.Width * scale[i++]);
                ctrl.Top = (int)(Size.Height * scale[i++]);
                ctrl.Width = (int)(Size.Width / (float)scale[0] * ((Size)ctrl.Tag).Width);//!!!
                ctrl.Height = (int)(Size.Height / (float)scale[1] * ((Size)ctrl.Tag).Height);//!!!

                //每次使用的都是最初始的控件大小，保证准确无误。
            }
        }
    }
}
