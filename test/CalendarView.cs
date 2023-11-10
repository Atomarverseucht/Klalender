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
        public int year;
        public int month;
        public Calendar()
        {
            InitializeComponent();
        }

        private void CalendarView_Load(object sender, EventArgs e)
        {
            year = Convert.ToInt32(DateTime.Now.Year);
            month = Convert.ToInt32(DateTime.Now.Month);
            MonthCalendarView() ;
        }
        public void MonthCalendarView()
        {
            DateTime firstDate = new DateTime(year,month, 1);
            // frägt Anfangstag ab / frägt Anzahl der Tage ab
            int startDay = Convert.ToInt16(DateTime.Parse(firstDate.ToString()).DayOfWeek)-1;
            int lastDay = Convert.ToInt16(DateTime.DaysInMonth(year, month));
            if (startDay == -1)
            {
                startDay = 6;
            }
            lbInfo.Text = "Calendar of " + month.ToString()+ "/" + year.ToString();
            // Anzeige
            for(int i = 1; i <= 42; i++)
            {
                writeCalendar("", i);
                lockCalendar(i, true);
            }
            for(int i = 1; i <= lastDay; i++)
            {
                writeCalendar(i.ToString(), i + startDay);
            }
            tlpCalendar.Visible = true;
            for (int i = 1; i<= startDay; i++)
            {
                lockCalendar(i,false);
            }
            for(int i = (lastDay + startDay + 1); i <= 42; i++)
            {
                lockCalendar(i,false);
            }
            
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

        private void btLast_Click(object sender, EventArgs e)
        {
            month--;
            if(month == 0)
            {
                month = 12;
                year--;
            }
            MonthCalendarView();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            month++;
            if(month == 13)
            {
                month = 1;
                year++;
            }
            MonthCalendarView();
        }  
        
        /// <summary>
        /// Schreibt in das RTB mit der Zahl ID rein
        /// </summary>
        /// <param name="content"></param> 
        /// <param name="id"></param>
        public void writeCalendar(string content, int id)
        {
            switch (id)
            {   
                default: break;
                case 1: rtbCalendar01.Text = content; break;
                case 2: rtbCalendar02.Text = content; break;
                case 3: rtbCalendar03.Text = content; break;
                case 4: rtbCalendar04.Text = content; break;
                case 5: rtbCalendar05.Text = content; break;
                case 6: rtbCalendar06.Text = content; break;
                case 7: rtbCalendar07.Text = content; break;
                case 8: rtbCalendar08.Text = content; break;
                case 9: rtbCalendar09.Text = content; break;
                case 10: rtbCalendar10.Text = content; break;
                case 11: rtbCalendar11.Text = content; break;
                case 12: rtbCalendar12.Text = content; break;
                case 13: rtbCalendar13.Text = content; break;
                case 14: rtbCalendar14.Text = content; break;
                case 15: rtbCalendar15.Text = content; break;
                case 16: rtbCalendar16.Text = content; break;
                case 17: rtbCalendar17.Text = content; break;
                case 18: rtbCalendar18.Text = content; break;
                case 19: rtbCalendar19.Text = content; break;
                case 20: rtbCalendar20.Text = content; break;
                case 21: rtbCalendar21.Text = content; break;
                case 22: rtbCalendar22.Text = content; break;
                case 23: rtbCalendar23.Text = content; break;
                case 24: rtbCalendar24.Text = content; break;
                case 25: rtbCalendar25.Text = content; break;
                case 26: rtbCalendar26.Text = content; break;
                case 27: rtbCalendar27.Text = content; break;
                case 28: rtbCalendar28.Text = content; break;
                case 29: rtbCalendar29.Text = content; break;
                case 30: rtbCalendar30.Text = content; break;
                case 31: rtbCalendar31.Text = content; break;
                case 32: rtbCalendar32.Text = content; break;
                case 33: rtbCalendar33.Text = content; break;
                case 34: rtbCalendar34.Text = content; break;
                case 35: rtbCalendar35.Text = content; break;
                case 36: rtbCalendar36.Text = content; break;
                case 37: rtbCalendar37.Text = content; break;
                case 38: rtbCalendar38.Text = content; break;
                case 39: rtbCalendar39.Text = content; break;
                case 40: rtbCalendar40.Text = content; break;
                case 41: rtbCalendar41.Text = content; break;
                case 42: rtbCalendar42.Text = content; break;
            }
        }
        public void lockCalendar(int id, bool value)
        {
                        switch (id)
            {   
                default: break;
                case 1: rtbCalendar01.Visible = value; break;
                case 2: rtbCalendar02.Visible = value; break;
                case 3: rtbCalendar03.Visible = value; break;
                case 4: rtbCalendar04.Visible = value; break;
                case 5: rtbCalendar05.Visible = value; break;
                case 6: rtbCalendar06.Visible = value; break;
                case 7: rtbCalendar07.Visible = value; break;
                case 8: rtbCalendar08.Visible = value; break;
                case 9: rtbCalendar09.Visible = value; break;
                case 10: rtbCalendar10.Visible = value; break;
                case 11: rtbCalendar11.Visible = value; break;
                case 12: rtbCalendar12.Visible = value; break;
                case 13: rtbCalendar13.Visible = value; break;
                case 14: rtbCalendar14.Visible = value; break;
                case 15: rtbCalendar15.Visible = value; break;
                case 16: rtbCalendar16.Visible = value; break;
                case 17: rtbCalendar17.Visible = value; break;
                case 18: rtbCalendar18.Visible = value; break;
                case 19: rtbCalendar19.Visible = value; break;
                case 20: rtbCalendar20.Visible = value; break;
                case 21: rtbCalendar21.Visible = value; break;
                case 22: rtbCalendar22.Visible = value; break;
                case 23: rtbCalendar23.Visible = value; break;
                case 24: rtbCalendar24.Visible = value; break;
                case 25: rtbCalendar25.Visible = value; break;
                case 26: rtbCalendar26.Visible = value; break;
                case 27: rtbCalendar27.Visible = value; break;
                case 28: rtbCalendar28.Visible = value; break;
                case 29: rtbCalendar29.Visible = value; break;
                case 30: rtbCalendar30.Visible = value; break;
                case 31: rtbCalendar31.Visible = value; break;
                case 32: rtbCalendar32.Visible = value; break;
                case 33: rtbCalendar33.Visible = value; break;
                case 34: rtbCalendar34.Visible = value; break;
                case 35: rtbCalendar35.Visible = value; break;
                case 36: rtbCalendar36.Visible = value; break;
                case 37: rtbCalendar37.Visible = value; break;
                case 38: rtbCalendar38.Visible = value; break;
                case 39: rtbCalendar39.Visible = value; break;
                case 40: rtbCalendar40.Visible = value; break;
                case 41: rtbCalendar41.Visible = value; break;
                case 42: rtbCalendar42.Visible = value; break;
            }                                    
        }
    }
}
