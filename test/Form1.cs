using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<string> events = new List<string>(); // static, weil einfacher zum Zugreifen

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDate.MinDate = DateTime.Now;
            Calendar cw = new Calendar();
            cw.Show();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            events.Add(dtpDate.Value.ToString("yyyy.mm.dd") + "ඞ" + tbTitle.Text + "ඞ" + cbCathegory.Text);
            tbTitle.Text = events[events.Count-1];
            events.Sort();
        }

        public static int searchEvent(DateTime searchedDate)
        {
            for(int i=0; i < events.Count; i++)
            {
                if(DateTime.ParseExact(decodeEvents(i)[0],"yyyy.mm.dd") == searchedDate)
                {
                    return i;
                }
                else if(Convert.ToDateTime(decodeEvents(i)[0]) > searchedDate)
                {
                    return -1;
                }
            }
            return -1;
        }


        public static string[] decodeEvents(int index)
        {
            if(events[index] != null)
            {
                return events[index].Split ('ඞ');
            }
            return null;
        }
    }
}
