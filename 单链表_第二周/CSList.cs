using System;
using System.Collections.Generic;
using System.Text;

namespace DS_CS
{
    class CSListnode<Type>//单链表结点类
    {

        private Type data;
        private CSListnode<Type> next;
        private bool exist;
        private int age = 0;
        //--------------------------------------------------------------------------------
        public CSListnode()
        {
            //data=0;
            next = null;
        }
        public CSListnode(Type data)
        {
            this.data = data;
            next = null;
        }
        public CSListnode(Type data, CSListnode<Type> next)
        {
            this.data = data;
            this.next = next;
        }
        public bool Exist
        {
            get { return exist; }
            set { exist = value; }
        }
        public Type Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public CSListnode<Type> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
    //================================================================================
    class CSList<Type> // 单链表类
    {
        private CSListnode<Type> head;
        private CSListnode<Type> current;//指向当前节点的指针
        //--------------------------------------------------------------------------------
        public CSList()
        {
            head = new CSListnode<Type>();
            current = head;

        }

        //public void SetCurrent(CSListnode<Type> cp) { current = cp; }//设置当前指针
        //public CSListnode<Type> GetCurrent() { return current; }//返回当前指针
        //public Type GetCurrentData() { return current.data; }//返回当前数据
        //public CSListnode<Type> Getnext() { return current.next; }//返回下一结点地址
        //public CSListnode<Type> Gethead() { return head; }//返回头结点地址
        //public void Modifydata(Type value) { current.data = value; }//修改当前结点数据
        public CSListnode<Type> Current//返回指针
        {
            get
            {
                return current;
            }
            set
            {
                current = value;
            }
        }
        public CSListnode<Type> Next
        {
            get
            {
                return current.Next;
            }
        }
        public CSListnode<Type> Head
        {
            get
            {
                return head;
            }
        }
        public Type CurrentData
        {
            get
            {
                return current.Data;
            }
            set
            {
                current.Data = value;
            }
        }
        public CSListnode<Type> Rear
        {
            get
            {
                CSListnode<Type> p = head;
                while (p.Next != null)
                    p = p.Next;
                return p;
            }
        }
        public int Length//单链表长度
        {
            get
            {
                CSListnode<Type> p = head.Next;
                int count = 0;
                while (p != null)
                {
                    p = p.Next;
                    count++;
                }
                return count;
            }
        }
        public Type FirstNode()    //设置头结点为当前结点
        {
            current = head;
            return current.Data;
        }

        public Type NextNode()      //设置下一结点为当前结点
        {
            if (current.Next != null)
                current = current.Next;
            return current.Data;
        }

        public void Create(Type[] dt, int n, bool InsertInHead)//生成n个结点
        {
            MakeEmpty();
            if (InsertInHead)
            {
                for (int i = 1; i <= n; i++)
                    Insert(dt[i - 1], 1);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                    Insert(dt[i - 1], i);
            }
            current = head;
        }
        public void CreateHead(Type[] dt, int n)//头插法生成n个结点
        {
            MakeEmpty();
            for (int i = 1; i <= n; i++)
                head.Next = new CSListnode<Type>(dt[i - 1], head.Next);
            current = head.Next;
        }

        public void CreateRear(Type[] dt, int n)//尾插法生成n个结点
        {
            MakeEmpty();
            for (int i = 1; i <= n; i++)
            {
                current = new CSListnode<Type>(dt[i - 1], null);
                Rear.Next = current;
            }
        }
        public void MakeEmpty()//清空单链表
        {
            head.Next = null;
            current = head;
        }

        public void DeleteLast()//删除最后一个节点
        {


        }
        //public CSListnode<Type> Find(Type value)//按给定值查找单链表
        //{

        //}
        //public CSListnode<Type> Getnode(int i)//返回第i个结点的地址
        //{

        //}
        //public Type Getdata(int i)//返回第i个结点的数据
        //{

        //}
        public void Insert(Type value, int i)//在第i个结点处插入结点
        {

        }
        public void Insert(Type value, bool before)//在当前结点处插入结点
        {
            if (current == head)
                before = false;
            if (before)
            {
                CSListnode<Type> p = head;
                while (p.Next != current)
                    p = p.Next;
                p.Next = new CSListnode<Type>(value, p.Next);
                current = p.Next;
            }
            else
            {
                current.Next = new CSListnode<Type>(value, current.Next);
                current = current.Next;
            }
        }

        public void InsertHead(Type value)//在头插法插入结点
        {
            head.Next = new CSListnode<Type>(value, head.Next);
            current = head.Next;
        }
        public void AppendRear(Type value)//在尾插法插入结点
        {
            Rear.Next = new CSListnode<Type>(value, null);
            current = Rear;
        }

        public void Delete()//删除当前结点
        {

            if (current == head)
                return;
            CSListnode<Type> p = head;
            while (p.Next != current)
                p = p.Next;

            p.Next = current.Next;
            if (p.Next != null)
                current = p.Next;
            else
                current = p;
        }

        public void Delete(int i)//删除第i个结点
        {

        }
        // 转置
        public void Reverse()
        {
            CSListnode<Type> p = head.Next;
            Type[] index = new Type[Length];
            for (int i = Length - 1; i >= 0; i--)
            {
                index[i] = p.Data;
                p = p.Next;
            }
            p = head.Next;
            for (int i = 0; i < Length; i++)
            {
                p.Data = index[i];
                p = p.Next;
            }
        }
        /// <summary>
        /// 实现一定范围内的元素转置
        /// </summary>
        /// <param name="start">转置的开始位置</param>
        /// <param name="end">转置的结束位置</param>
        public void Reverse(int start, int end)
        {
            if (this.Length == 0)
                throw new Exception("当前单链表的长度为0，请先进行初始化");
            if (!(start < end))
                throw new Exception("逆转的开始元素必须小于结束位置");
            if (!(start > 0 && start < this.Length))
                throw new Exception($"输入逆转的开始位置必须大于0，小于此单链表的长度{Length}");
            if (!(1 < end && end <= Length))
                throw new Exception($"输入逆转的结束位置必须大于1，不大于此单链表的长度{Length}");
            CSListnode<Type> p = head.Next;
            // p指定为起始位置
            for (int i = 0; i < start-1; i++)
            {
                p = p.Next;
            }
            //  储存数据
            Type[] index = new Type[end - start + 1];
            for (int i = end - 1; i >= start-1; i--)
            {
                index[i-(start-1)] = p.Data;
                p = p.Next;
            }
            p = head.Next;
            // p指定为起始位置
            for (int i = 0; i < start - 1; i++)
            {
                p = p.Next;
            }
            for (int i = start-1; i < end; i++)
            {
                p.Data = index[i- (start - 1)];
                p = p.Next;
            }
        }
        public void Upside()
        {
            //current = head.Next;
            CSListnode<Type> q,
                                            p = head.Next;
            head.Next = null;
            while (p != null)
            {
                q = p;
                p = p.Next;
                q.Next = head.Next;
                head.Next = q;
            }
        }

        public void Circle()
        {
            Rear.Next = head;
        }
    }
}
