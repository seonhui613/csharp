using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project1023_1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
        }

        public class Actress
        {
            public string name;
            public int year;
            public Actress(string name, int year)
            {
                this.name = name;
                this.year = year;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "ListView";
            Size = new Size(550, 500);

            ColumnHeader h1 = new ColumnHeader();
            h1.Text = "Name";
            h1.Width = 150;
            h1.TextAlign = HorizontalAlignment.Center;

            ColumnHeader h2 = new ColumnHeader();
            h2.Text = "Year";
            h2.Width = 150;
            h2.TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add(h1);
            listView1.Columns.Add(h2);

            List<Actress> actresses = new List<Actress>();

            actresses.Add(new Actress("Jessica Alba", 1981));
            actresses.Add(new Actress("Angelina Jolie", 1975));
            actresses.Add(new Actress("Natalie Portman", 1981));
            actresses.Add(new Actress("Rachel Weiss", 1971));
            actresses.Add(new Actress("Scarlett Johansson", 1984));

            foreach (Actress act in actresses)
            {
                ListViewItem item = new ListViewItem();
                item.Text = act.name;
                item.SubItems.Add(act.year.ToString());
                listView1.Items.Add(item);
            }
        }
        private void listView1_Column_Click(object sender, ColumnClickEventArgs e)
        {
            ListView lv = (ListView)sender;
            if (lv.Sorting == SortOrder.Ascending)
            {
                lv.Sorting = SortOrder.Descending;
            }
            else
            {
                lv.Sorting = SortOrder.Ascending;
            }
        }

       

        private void listView1_Click(object sender, EventArgs e)
        {
            ListView lv2 = (ListView)sender;
            string name = lv2.SelectedItems[0].SubItems[0].Text;
            string born = lv2.SelectedItems[0].SubItems[1].Text;
            toolStripStatusLabel1.Text = name + ", " + born;
        }
    }
}
