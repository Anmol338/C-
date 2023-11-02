using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                /*
                const int MAX = 5;
                int[] nums = new int[MAX];
                */
                int[] nums = { 4, 5, 7, 1, 2, 6, 7, 1, 2 };
                /*
                foreach(int n in nums) {
                    Console.WriteLine(n);
                }
                */

            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            ArrayList myList = new ArrayList();
            myList.Add(true);
            myList.Add('A');
            myList.Add(345);
            myList.Add(567.890);
            myList.Add("PCPS College");
            foreach (Object item in myList) {
                Console.WriteLine(item);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            Dictionary<string, string> person = new Dictionary<string, string>();
            person.Add("pid", "1"); //key->value
            person.Add("name", "Raj");
            person.Add("address", "Ktm");
            var keys = person.Keys;
            foreach (string key in keys) {
                Console.WriteLine(person[key]);
            }


        }
    }
}
