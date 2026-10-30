using System.Collections;
using System.Windows;
using System.Windows.Documents;
using System.Collections.Generic; 
namespace Mymoniter
{
    /// <summary>
    /// Interaction logic for DemoColl.xaml
    /// </summary>
    public partial class DemoColl : Window
    {
        public DemoColl()
        {
            InitializeComponent();
        }
        private void btnarray_Click(object sender, EventArgs e)
        {
            //Dynamic size Allocation
            //
            ArrayList List = new ArrayList(10) { "ram", 11, true };
            List.Insert(1, "Indie");
            int countvalue = List.Count;
            List.Add(1);
            MessageBox.Show(List.Capacity.ToString());
            List.Add("hi");
            List.Add(true);
            List.Add(5);
            List.Add("include");
            MessageBox.Show(List.Capacity.ToString());
            List.Add(3);
            List.Add(4);
            List.Add(5);
            List.Add(8);
            MessageBox.Show(List.Capacity.ToString());
            for (int i = 0; i < List.Count; i++)
            {
                MessageBox.Show(List[i].ToString());
            }
            foreach (object item in List)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void btnashTable_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("sno", 1);
            ht.Add("Sname", "Suresh");
            ht.Add("Mark", 100);
            MessageBox.Show(ht["Sname"].ToString());
            foreach (var item in ht.Keys)
            {
                MessageBox.Show(item.ToString());
            }
            foreach (var item in ht.Values)
            {
                MessageBox.Show(item.ToString());
            }
            foreach (DictionaryEntry item in ht)
            {
                MessageBox.Show(item.Key.ToString() + item.Value.ToString());
            }
                if(ht.ContainsKey("sno") == true)
                {
                    ht.Remove("sno");
                }
        }
        private void btnstack_Click(object sender, EventArgs e)
        { 
            Stack stackobj = new Stack();
            stackobj.Push("gokul");
            stackobj.Push("sandy");
            stackobj.Push("shyn");
            MessageBox.Show(stackobj.Peek().ToString());
            stackobj.Pop();
            stackobj.Clear();
            int count = stackobj.Count;

        }
        private void btnque_Click(object sender, EventArgs e)
        {
            Queue queue= new Queue();
            queue.Enqueue("Item1");
            queue.Enqueue("Item2");
            queue.Enqueue("Item3");
            MessageBox.Show(queue.Peek().ToString());
            queue.Dequeue();
        }
        private void btnbit_Click(object sender, EventArgs e)
        {
            BitArray obit = new BitArray(4);
            obit.Set(0, true);
        }
        private void btnsort_Click(object sender, EventArgs e)
        {
         SortedList os = new SortedList();
            os.Add("zso", 1);
            os.Add("sno", 2);
            os.Add("asno",5);
            foreach(var item in os)
            {
                MessageBox.Show(item.ToString());
            }
        }
        private void btnlist_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("naveen");
            list.Add("ben");
            list.Add("sabari");

            List<int> inlist= new List<int>() { 1,2,3, 4, 5 };

            Dictionary<string,int> dict = new Dictionary<string,int>();
            dict.Add("Sno",1);
            dict.Add("asn", 2);
            foreach (var item in dict)
            {
                MessageBox.Show(item.ToString());
            }
            Stack<int> stack= new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            foreach (var item in stack)
            {
                MessageBox.Show(item.ToString());
            }
            //Queue
            Queue<int> queue= new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            foreach (var item in queue)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}
