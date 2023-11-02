using System.Collections;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int MAX = 5;
            // declare
            int[] nums = new int[MAX];
            int[] nums2 = { 45, 67, 32, 56, 80 };

            try
            {
                // Assign
                nums[0] = 8;
                nums[1] = 10;
                nums[2] = 20;
                nums[3] = 30;
                nums[4] = 50;
                // nums[5] = 100; // Out of range exception
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();

            try
            {
                myList.Add(true);
                myList.Add('A');
                myList.Add(345);
                myList.Add(234.567);
                myList.Add("PCPS College");

                foreach (Object items in myList)
                {
                    Console.WriteLine(items.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Dictionary
            // Key-value pairing
            Dictionary<string, string> person = new Dictionary<string, string>();

            try
            {
                person.Add("pid", "1");
                person.Add("fullname", "Anmol Shrestha");
                person.Add("email", "anmolstha011@gmail.com");

                // Console.WriteLine(person.ToString());
                // Console.WriteLine(person.Keys);
                // Console.WriteLine(person.Values);

                foreach (string key in person.Keys)
                {
                    // Console.WriteLine(key);
                    Console.WriteLine(person[key]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}