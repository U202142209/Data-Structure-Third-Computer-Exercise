using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DS_CS;


namespace 单链表_第二周
{

    public partial class Form1 : Form
    {
        private CSList<int> m_slist;
        Random ran = new Random();
        // 随机数生成
        public int fun_ran(int id, int[] index)
        {
            //获取到随机数
            int p = ran.Next(id) + 1;

            //判断是否获取到相同的随机数
            for (int q = 0; q < index.Length; q++)
            {
                if (p == index[q])
                {
                    //如果获取的数重复重新获取
                    return fun_ran(id, index);
                }
            }
            return p;
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            m_slist = new CSList<int>();
            tb_slistcount.Text = "32";
            tb_modify.Text = "100";
        }

        public void DrawSList()
        {
            //画背景色
            Graphics myg = pBox_slist.CreateGraphics();
            Brush bkbrush = new SolidBrush(Color.White);
            int xmin = 0;
            int ymin = 0;
            int xmax = pBox_slist.Width;
            int ymax = pBox_slist.Height;
            //填充背景: 矩形(笔, x1, y1, x2, y2)
            myg.FillRectangle(bkbrush, xmin, ymin, xmax - xmin, ymax - ymin);

            CSListnode<int> cp;// 当前结点
            cp = m_slist.Current;
            //设置坐标数组
            int n;
            n = m_slist.Length;
            int[] lx = new int[n + 2];
            int[] ly = new int[n + 2];
            int cw = xmax / 15; // 每个矩形宽度
            int cwd = (xmax - (xmax / 15 * 10)) / 11 - 4; // 箭头长度(两矩形之间长度)
            int ch = ymax / 15; // 每个矩形高度
            int chd = (ymax - (ymax / 15 * 10)) / 11;
            for (int i = 0; i <= n; i++)
            {
                if ((i / 10) % 2 == 0)
                {
                    lx[i + 1] = xmax / 11 * (i % 10 + 1);
                }
                else
                {
                    lx[i + 1] = xmax / 11 * (10 - i % 10);
                }
                // 每行10个y坐标, 10个一样
                ly[i + 1] = ymax / 11 * (i / 10 + 1);
            }
            //设置显示颜色
            Color bkColor0, bkColor1, bkColor2, bkColor3;
            Brush bkBrushnow, bkBrush0, bkBrush1, bkBrush2, bkBrush3;
            bkColor0 = Color.FromArgb(255, 125, 125, 125);//头节点颜色
            bkBrush0 = new SolidBrush(bkColor0);
            bkColor1 = Color.FromArgb(255, 255, 255, 0);//一般节点颜色
            bkBrush1 = new SolidBrush(bkColor1);
            bkColor2 = Color.FromArgb(90, 0, 255, 122);//当前节点颜色
            bkBrush2 = new SolidBrush(bkColor2);
            bkColor3 = Color.FromArgb(90, 0, 0, 122);//范围节点颜色
            bkBrush3 = new SolidBrush(bkColor3);
            string m_nodedata;
            Point p1, p2;
            //遍历单链表
            m_slist.FirstNode();
            for (int i = 0; i <= n; i++)
            {
                // 当前节点信息(地址, data, next)
                if (m_slist.Current == cp)
                {
                    bkBrushnow = bkBrush2;
                    if (i == 0) // 只有头结点
                        m_nodedata = "";
                    else
                        m_nodedata = "" + m_slist.CurrentData;
                    
                    tb_address.Text = "" + m_slist.Current.GetHashCode();
                    tb_data.Text = "" + m_nodedata;
                    if (m_slist.Next != null)
                        tb_next.Text = "" + m_slist.Next.GetHashCode();
                    else
                        tb_next.Text = "null";
                }

                // 只有头结点
                // 只有头结点
                // 只有头结点
                // 只有头结点
                else if (i == 0)
                {
                    bkBrushnow = bkBrush0;
                    m_nodedata = "";
                }
                // 范围内的结点
                else if(m_slist.Current.Exist)
                {
                    bkBrushnow = bkBrush3;
                }
                // 其他节点
                else
                {
                    bkBrushnow = bkBrush1;
                }
                          
                Rectangle rc = new Rectangle(lx[i + 1] - cw / 2, ly[i + 1] - ch / 2, cw, ch);
                myg.FillRectangle(bkBrushnow, rc); // 填充矩形

                // 箭头
                System.Drawing.Drawing2D.AdjustableArrowCap lineCap = new 
                System.Drawing.Drawing2D.AdjustableArrowCap(4, 4, true);
                Pen penLine = new Pen(Color.Red, 1);
                penLine.CustomEndCap = lineCap;
                Pen pen1 = new Pen(Color.Red, 1);
                myg.DrawRectangle(pen1, rc); // 画矩形
                if (i != 0)
                {
                    string str = "" + m_slist.CurrentData;
                    Font font = new Font("Arial", 12);
                    SolidBrush b1 = new SolidBrush(Color.Blue);
                    StringFormat sf1 = new StringFormat();
                    myg.DrawString(str, font, b1, lx[i + 1] - cw / 2 + 5, ly[i + 1] - ch / 2 + 6, sf1);
                }
                if (i <= n - 1)
                {
                    if (i % 10 != 9) // 普通箭头
                    {
                        if ((i / 10) % 2 == 0) // 奇数行箭头→
                        {
                            p1 = new Point(lx[i + 1] + cw / 2, ly[i + 1]);
                            p2 = new Point(lx[i + 1] + cw / 2 + cwd, ly[i + 1]);
                            myg.DrawLine(penLine, p1, p2);
                        }
                        else // 偶数行箭头←
                        {
                            p1 = new Point(lx[i + 1] - cw / 2, ly[i + 1]);
                            p2 = new Point(lx[i + 1] - cw / 2 - cwd, ly[i + 1]);
                            myg.DrawLine(penLine, p1, p2);
                        }
                    }

                    if (i % 10 == 9) // 换行箭头(分左换行, 右换行)
                    {
                        if ((i / 10) % 2 == 0)  // 奇数行箭头换行→↓←
                        {
                            p1 = new Point(lx[i + 1] + cw / 2, ly[i + 1]);
                            p2 = new Point(lx[i + 1] + cw / 2 + cwd, ly[i + 1]);
                            myg.DrawLine(pen1, p1, p2);
                            p1 = new Point(lx[i + 1] + cw / 2 + cwd, ly[i + 1]);
                            p2 = new Point(lx[i + 1] + cw / 2 + cwd, ly[i + 2]);
                            myg.DrawLine(pen1, p1, p2);
                            p1 = new Point(lx[i + 1] + cw / 2 + cwd, ly[i + 2]);
                            p2 = new Point(lx[i + 1] + cw / 2, ly[i + 2]);
                            myg.DrawLine(penLine, p1, p2);
                        }
                        else // 偶数行箭头换行←↓→
                        {
                            p1 = new Point(lx[i + 1] - cw / 2, ly[i + 1]);
                            p2 = new Point(lx[i + 1] - cw / 2 - cwd, ly[i + 1]);
                            myg.DrawLine(pen1, p1, p2);
                            p1 = new Point(lx[i + 1] - cw / 2 - cwd, ly[i + 1]);
                            p2 = new Point(lx[i + 1] - cw / 2 - cwd, ly[i + 2]);
                            myg.DrawLine(pen1, p1, p2);
                            p1 = new Point(lx[i + 1] - cw / 2 - cwd, ly[i + 2]);
                            p2 = new Point(lx[i + 1] - cw / 2, ly[i + 2]);
                            myg.DrawLine(penLine, p1, p2);
                        }
                    }
                }
                m_slist.NextNode();
            }
            m_slist.Current = cp;
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            int m_createno = Convert.ToInt16(tb_slistcount.Text);
            int[] dt = new int[m_createno];
            for (int i = 0; i<m_createno; i++)
                dt[i] = i + 1;
            if (m_createno < 100 && m_createno >0)
            {
                if (rb_head1.Checked == true)
                {
                    m_slist.CreateHead(dt, m_createno);
                }
                else if(rb_rear1.Checked == true)
                    m_slist.CreateRear(dt, m_createno);
                DrawSList();
            }
           
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            m_slist.MakeEmpty();
            DrawSList();
        }

        private void bt_headnode_Click(object sender, EventArgs e)
        {
            m_slist.FirstNode();
            DrawSList();
        }

        private void bt_nextnode_Click(object sender, EventArgs e)
        {
            m_slist.NextNode();
            DrawSList();
        }

        private void bt_modify_Click(object sender, EventArgs e)
        {
            int modifyno = Convert.ToInt16(tb_modify.Text);
            CSListnode<int> p = m_slist.Head;
            m_slist.CurrentData = modifyno;
            //if (rb_insert0.Checked == true) // 头
            //{
            //    p.Next.Data = modifyno;
            //}
            //else if (rb_insert1.Checked == true) // 前
            //{
            //    while (p.Next != m_slist.Current)
            //        p = p.Next;
            //    p.Data = modifyno;
            //}
            //else if (rb_insert2.Checked == true) // 后
            //{
            //    p = m_slist.Current.Next;
            //    p.Data  = modifyno;
            //}
            //else if (rb_insertn.Checked == true) // 尾
            //{
            //    m_slist.Rear.Data = modifyno;
            //}
            DrawSList();
        }

        // 插入
        private void bt_insert_Click(object sender, EventArgs e)
        {
            int modifyno = Convert.ToInt16(tb_modify.Text);
            CSListnode<int> p = m_slist.Head;
            if (m_slist.Length < 99)
            {
                if (rb_insert0.Checked == true) // 头
                {
                    m_slist.InsertHead(modifyno);
                    //m_slist.Head.Next = new CSListnode<int>(modifyno, m_slist.Head.Next);
                    //m_slist.Current = m_slist.Head.Next;

                }

                else if (rb_insert1.Checked == true) // 前
                {
                    m_slist.Insert(modifyno, true);
                    //while (p.Next != m_slist.Current)
                    //    p = p.Next;
                    //p.Next = new CSListnode<int>(modifyno, p.Next);
                    //m_slist.Current = p.Next;
                }

                else if (rb_insert2.Checked == true) // 后
                {
                    m_slist.Insert(modifyno, false);
                    //m_slist.Current.Next = new CSListnode<int>(modifyno, m_slist.Current.Next);
                    //m_slist.Current = m_slist.Current.Next;
                }

                else if (rb_insertn.Checked == true) // 尾
                {
                    m_slist.AppendRear(modifyno);
                    //m_slist.Rear.Next = new CSListnode<int>(modifyno, null);
                    //m_slist.Current = m_slist.Rear;
                }
                DrawSList();
            }
            else
                MessageBox.Show("不好意思, 链表满了");
            
        }

        // 删除
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (m_slist.Length > 0)
            {
                CSListnode<int> p = m_slist.Head;
                m_slist.Delete();
                //if (rb_insert0.Checked == true) // 头
                //{
                //    m_slist.Current = m_slist.Head.Next;
                //    m_slist.Delete();
                //}
                //else if (rb_insert1.Checked == true) // 前
                //{
                //    while (p.Next != m_slist.Current)
                //        p = p.Next;
                //    m_slist.Current = p;
                //    m_slist.Delete();
                //}
                //else if (rb_insert2.Checked == true) // 后
                //{
                //    m_slist.Current = m_slist.Current.Next;
                //    m_slist.Delete();
                //}
                //else if (rb_insertn.Checked == true) // 尾
                //{
                //    m_slist.Current = m_slist.Rear;
                //    m_slist.Delete();
                //}
                DrawSList();
            }
            else
                MessageBox.Show("不好意思, 链表没元素了");
        }

        private void bt_upside_Click(object sender, EventArgs e)
        {
            m_slist.Reverse();
            DrawSList();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            int findno = Convert.ToInt16(tb_modify.Text);
            bool exist = false;
            CSListnode<int> p = m_slist.Current;
            while(p.Next !=null)
            {
                p = p.Next;
                if (p.Data == findno)
                {
                    exist = true;
                    break;
                }
            }
            if (exist)
                m_slist.Current = p;
            else
                m_slist.Current = m_slist.Head;
            DrawSList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(tb_num1.Text);
            int num2 = Convert.ToInt32(tb_num2.Text);
            int max = num1 > num2 ? num1 : num2;
            int min = num1 + num2 - max;
            for (CSListnode<int> p = m_slist.Head.Next; p != null; p = p.Next)
            {
                if (p.Data >= min && p.Data <= max)
                {
                    m_slist.Current = p;
                    m_slist.Delete();
                }
            }
            DrawSList();
        }

        private void bt_random_Click(object sender, EventArgs e)
        {
            int m_createno = Convert.ToInt16(tb_slistcount.Text);
            int[] dt = new int[m_createno];
            for (int i = 0; i < m_createno; i++)
            {
                dt[i] = fun_ran(m_createno, dt);
            }
            if (m_createno < 100 && m_createno > 0)
            {
                if (rb_head1.Checked == true)
                {
                    m_slist.CreateHead(dt, m_createno);
                }
                else if (rb_rear1.Checked == true)
                    m_slist.CreateRear(dt, m_createno);
                DrawSList();
            }
        }

        private void bt_rangefind_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(tb_num1.Text);
            int num2 = Convert.ToInt32(tb_num2.Text);
            int max = num1 > num2 ? num1 : num2;
            int min = num1 + num2 - max;
            for (CSListnode<int> p = m_slist.Head.Next; p !=null; p = p.Next)
            {
                if (p.Data >= min && p.Data <= max)
                    p.Exist = true;
                else
                    p.Exist = false;
            }
            DrawSList();

        }
        // 获取长度
        private void btn_getLength_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"单链表的长度：{m_slist.Length}");
            }catch(Exception error)
            {
                MessageBox.Show("发生了错误：" + error.Message);
            }
            
        }

        private void btn_reverse_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(tbRStart.Text);
                int j = int.Parse(tbREnd.Text);
                m_slist.Reverse(i, j);
                DrawSList();
            }
            catch(FormatException)
            {
                MessageBox.Show("发生了错误:输入的位置必须为整数。" );
            }
            catch(Exception error)
            {
                MessageBox.Show("发生了错误:" + error.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            m_slist.Reverse();
            DrawSList();
        }
    }
}

