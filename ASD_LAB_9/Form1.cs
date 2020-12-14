﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
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

            result.Text = $"{Binary.binSearch(arr.ToArray(), Convert.ToInt32(value.Text), 0, arr.Count - 1)}"; 
        }
    }
}
