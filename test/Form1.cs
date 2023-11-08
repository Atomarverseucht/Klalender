using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.Calendar;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       List<string> events = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dtbDate.MinDate = DateTime.Now;
            CalendarView cw = new CalendarView();
            cw.Show();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
              events.Add(dtbDate.Value.Year + "ඞ" + dtbDate.Value.Month + "ඞ" + dtbDate.Value.Day + "ඞ" + tbTitle.Text + "ඞ" + cbCathegory.Text);
            tbTitle.Text = events[events.Count-1];
            updateCalendar();
        }

        public void updateCalendar()
        {
            for(int i=0; i < events.Count;i++)
            {
                string date = decodeEvents(i)[2] + "." + decodeEvents(i)[1] + "." + decodeEvents(i)[0];
                mcCalendar.BoldedDates.Append(Convert.ToDateTime(date));
            }
        }

        public string[] decodeEvents(int index)
        {
            return events[index].Split ('ඞ');
        }
    }
}
