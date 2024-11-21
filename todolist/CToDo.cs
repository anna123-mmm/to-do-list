using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    public class CToDo
    {
        private string m_task, m_category, m_description;
        private bool m_done;
        private DateTime m_startdate, m_duedate;

        public string Task
        {
            get { return m_task; }
            set { m_task = value; }
        }

        public string Category
        {
            get { return m_category; }
            set { m_category = value; }
        }

        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        public DateTime StartDate
        {
            get { return m_startdate; }
            set { m_startdate = value; }
        }

        public DateTime DueDate
        {
            get { return m_duedate; }
            set { m_duedate = value; }
        }

        public bool Done
        {
            get { return m_done; }
            set { m_done = value; }
        }

        public CToDo()
        {
            m_task = "";
            m_category = "";
            m_description = "";
            m_startdate= DateTime.Now;
            m_duedate= DateTime.Now;
            m_done = true;
        }

        public CToDo(string t, string cg, string dc, bool d, DateTime sd, DateTime dd)
        {
            m_task = t;
            m_category = cg;
            m_description= dc;
            m_done= d;
            m_startdate = sd;
            m_duedate= dd;
        }
    }
}
