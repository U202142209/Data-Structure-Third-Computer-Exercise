
/*void DrawSList()
{
    //画背景色
    Graphics myg = pBox_slist.CreateGraphics();
    Brush bkbrush = new SolidBrush(Color.White);
    int xmin = 0;
    int ymin = 0;
    int xmax = pBox_slist.Width;
    int ymax = pBox_slist.Height;
    // 画矩形(笔, x1, y1, x2, y2)
    myg.FillRectangle(bkbrush, xmin, ymin, xmax - xmin, ymax - ymin);

    CSListnode<int> cp;
    cp = m_slist.Current;
    //设置坐标数组
    int n;
    n = m_slist.Length;
    int[] lx = new int[n + 2];
    int[] ly = new int[n + 2];
    int cw = xmax / 15;
    int cwd = (xmax - (xmax / 15 * 10)) / 11 - 4;
    int ch = ymax / 15;
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
        ly[i + 1] = ymax / 11 * (i / 10 + 1);
    }
    //设置显示颜色
    Color bkColor0, bkColor1, bkColor2;
    Brush bkBrushnow, bkBrush0, bkBrush1, bkBrush2;
    bkColor0 = Color.FromArgb(255, 125, 125, 125);//头节点颜色
    bkBrush0 = new SolidBrush(bkColor0);
    bkColor1 = Color.FromArgb(255, 255, 255, 0);//一般节点颜色
    bkBrush1 = new SolidBrush(bkColor1);
    bkColor2 = Color.FromArgb(255, 0, 255, 0);//当前节点颜色
    bkBrush2 = new SolidBrush(bkColor2);
    string m_nodedata;
    Point p1, p2;
    //遍历单链表
    m_slist.FirstNode();
    for (int i = 0; i <= n; i++)
    {
        if (m_slist.Current == cp)
        {
            bkBrushnow = bkBrush2;
            if (i == 0)
                m_nodedata = "";
            else
                m_nodedata = "" + m_slist.CurrentData;
                //    tb_address.Text = "" + m_slist.Current.GetHashCode();
                //    tb_data.Text = "" + m_nodedata;
                //    if (m_slist.Next != null)
                //        tb_next.Text = "" + m_slist.Next.GetHashCode();
                //    else
                //        tb_next.Text = "null";
                //}
            else if (i == 0)
            {
                bkBrushnow = bkBrush0;
                m_nodedata = "";
            }
            else
            {
                bkBrushnow = bkBrush1;
            }
            Rectangle rc = new Rectangle(lx[i + 1] - cw / 2, ly[i + 1] - ch / 2, cw, ch);
            myg.FillRectangle(bkBrushnow, rc);

            System.Drawing.Drawing2D.AdjustableArrowCap lineCap = new System.Drawing.Drawing2D.AdjustableArrowCap(4, 4, true);
            Pen penLine = new Pen(Color.Red, 1);
            penLine.CustomEndCap = lineCap;
            Pen pen1 = new Pen(Color.Red, 1);
            myg.DrawRectangle(pen1, rc);
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
                if (i % 10 != 9)
                {
                    if ((i / 10) % 2 == 0)
                    {
                        p1 = new Point(lx[i + 1] + cw / 2, ly[i + 1]);
                        p2 = new Point(lx[i + 1] + cw / 2 + cwd, ly[i + 1]);
                        myg.DrawLine(penLine, p1, p2);
                    }
                    else
                    {
                        p1 = new Point(lx[i + 1] - cw / 2, ly[i + 1]);
                        p2 = new Point(lx[i + 1] - cw / 2 - cwd, ly[i + 1]);
                        myg.DrawLine(penLine, p1, p2);
                    }
                }

                if (i % 10 == 9)
                {
                    if ((i / 10) % 2 == 0)
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
                    else
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
        //        }

    }

    */
