namespace ASD_LAB_9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.find = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(27, 63);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(53, 23);
            this.find.TabIndex = 0;
            this.find.Text = "FIND";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.button1_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(102, 39);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(73, 20);
            this.size.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIZE : ";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(102, 65);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(73, 20);
            this.value.TabIndex = 3;
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(102, 91);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(73, 20);
            this.result.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RESULT : ";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.ControlLight;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Location = new System.Drawing.Point(224, 39);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(212, 72);
            this.log.TabIndex = 6;
            this.log.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LOG : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 145);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.find);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label3;
    }
}

