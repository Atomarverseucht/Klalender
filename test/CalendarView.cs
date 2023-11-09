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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void CalendarView_Load(object sender, EventArgs e)
        {
            MonthCalendarView(DateTime.Now.Month, DateTime.Now.Year) ;
        }
        public void MonthCalendarView(int month, int year)
        {
            DateTime firstDate = new DateTime(year,month, 1);
            // frägt Anfangstag ab / frägt Anzahl der Tage ab
            int startDay = Convert.ToInt16(DateTime.Parse(firstDate.ToString()).DayOfWeek) ;
            int lastDay = Convert.ToInt16(DateTime.DaysInMonth(year, month));

            // Anzeige

        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            resizeCalendar();
        }
        public void resizeCalendar()
        {
            tlpCalendar.Width = this.Width - 80;
            tlpCalendar.Height = this.Height - 150;
        }
    }
}
