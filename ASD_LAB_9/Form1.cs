using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASD_LAB_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int binSearch(int[] arr, int val, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int mid = (left + right) / 2;

            int[] temp = new int[right - left];
            for(int i = left; i < right; i++)
            {
                temp[i - left] = arr[i];
            }
            arrToLog(temp, $"mid INDEX = {mid} el({arr[mid]}) | range ({left}; {right})");

            if (arr[mid] == val)
            {
                return mid;
            }
            else if (arr[mid] < val)
            {
                return binSearch(arr, val, mid + 1, right);
            }
            else
            {
                return binSearch(arr, val, left, mid - 1);
            }
        }

        public void clear()
        {
            log.Text = "";
        }

        public void logOut(string text)
        {
            log.Text += text;
        }

        public void arrToLog(int[] arr, string title = "")
        {
            logOut("\n" + title + "\n");
            foreach(int i in arr)
            {
                logOut(string.Format("{0,4} ", i));
            }
            logOut("\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            Random rnd = new Random();
            List<int> arr = new List<int>();

            int n = Convert.ToInt32(size.Text);
            for (int i = 0; i < n; i++)
            {
                arr.Add(rnd.Next(-10, 10));
            }

            arr.Sort();
            foreach(int i in arr)
            {
                if (i > 0)
                {
                    arr[arr.IndexOf(i)] = 0;
                    break;
                }
            }

            arrToLog(arr.ToArray(), "INPUT ARRAY : ");
            result.Text = $"{binSearch(arr.ToArray(), Convert.ToInt32(value.Text), 0, arr.Count)}"; 
        }
    }
}
