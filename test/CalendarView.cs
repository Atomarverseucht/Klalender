﻿using System;
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
        // Variabendeklaration für den Zeitraum des Kalenders
        public int year;
        public int month;
        Form1 form1 = new Form1();

        public Calendar()
        {
            InitializeComponent();
        }

        // Zurück bzw. Vorwährtsspringen
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
        
        // Lade-Methode
        private void CalendarView_Load(object sender, EventArgs e)
        {
            year = Convert.ToInt32(DateTime.Now.Year);
            month = Convert.ToInt32(DateTime.Now.Month);
            MonthCalendarView() ;
        }

        // erstellt die Monatsansicht
        public void MonthCalendarView()
        {
            // frägt Anfangstag ab / frägt Anzahl der Tage ab
            int startDay = Convert.ToInt16(DateTime.Parse(new DateTime(year,month, 1).ToString()).DayOfWeek) - 1;
            int lastDay = Convert.ToInt16(DateTime.DaysInMonth(year, month));

            // Da Kalender standardmäßig mit Sonntag anfängt muss bei Sonntag (-1) der Wert auf 6 gesetzt werden um auch in Reihenfolge Mo-So zu sein
            if (startDay == -1)
            {
                startDay = 6;                
            }
            
            // Anzeige des angezeigten Monats und Jahres
            lbInfo.Text = "Calendar of " + month.ToString()+ "/" + year.ToString();
           
            // Reset der Tabelle und Deaktivierung aller unnötigen Tabellenzellen
            for(int i = 1; i <= 42; i++)
            {
                giveCalendarObject(i).Text = "";

                if(i <= startDay || i >= (lastDay + startDay + 1))
                {
                   giveCalendarObject(i).Visible = false; // Deaktiviert unnötige Kalenderzeilen
                }
                else
                {
                   giveCalendarObject(i).Visible = true; // Aktiviert nötige Kalenderzeilen
                }
            }

            // Durchnummerierung der Monatsansicht
            for(int i = 1; i <= lastDay; i++)
            {
                //hi
                int id = i + startDay;
		        DateTime dt = Convert.ToDateTime(i.ToString()+"."+month.ToString()+"."+year.ToString());                
                giveCalendarObject(id).SelectionFont = new Font(giveCalendarObject(id).Font, FontStyle.Bold);
                giveCalendarObject(id).Text = i.ToString();

                int index = Form1.searchEvent(dt);
                if(index != -1)
                {
                    giveCalendarObject(id).Text = giveCalendarObject(id).Text + "\n\n moin" ;	
                }
            }
        }
        
        // Resize
        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            tlpCalendar.Width = this.Width - 80;
            tlpCalendar.Height = this.Height - 150;
        }
    
        // Ansteuerung der RTBs der Tabelle: Gibt die gewünschte RTB mit der [id] weiter
        public RichTextBox giveCalendarObject(int id)
        {
            switch (id)
            {   
                default: return rtbCalendar01; break;
                case 01: return rtbCalendar01; break;
                case 02: return rtbCalendar02; break;
                case 03: return rtbCalendar03; break;
                case 04: return rtbCalendar04; break;
                case 05: return rtbCalendar05; break;
                case 06: return rtbCalendar06; break;
                case 07: return rtbCalendar07; break;
                case 08: return rtbCalendar08; break;
                case 09: return rtbCalendar09; break;
                case 10: return rtbCalendar10; break;
                case 11: return rtbCalendar11; break;
                case 12: return rtbCalendar12; break;
                case 13: return rtbCalendar13; break;
                case 14: return rtbCalendar14; break;
                case 15: return rtbCalendar15; break;
                case 16: return rtbCalendar16; break;
                case 17: return rtbCalendar17; break;
                case 18: return rtbCalendar18; break;
                case 19: return rtbCalendar19; break;
                case 20: return rtbCalendar20; break;
                case 21: return rtbCalendar21; break;
                case 22: return rtbCalendar22; break;
                case 23: return rtbCalendar23; break;
                case 24: return rtbCalendar24; break;
                case 25: return rtbCalendar25; break;
                case 26: return rtbCalendar26; break;
                case 27: return rtbCalendar27; break;
                case 28: return rtbCalendar28; break;
                case 29: return rtbCalendar29; break;
                case 30: return rtbCalendar30; break;
                case 31: return rtbCalendar31; break;
                case 32: return rtbCalendar32; break;
                case 33: return rtbCalendar33; break;
                case 34: return rtbCalendar34; break;
                case 35: return rtbCalendar35; break;
                case 36: return rtbCalendar36; break;
                case 37: return rtbCalendar37; break;
                case 38: return rtbCalendar38; break;
                case 39: return rtbCalendar39; break;
                case 40: return rtbCalendar40; break;
                case 41: return rtbCalendar41; break;
                case 42: return rtbCalendar42; break;
            }
        }
    }
}