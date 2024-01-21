using System.Data;

namespace Porfolio_App
{
    partial class Home
    {
        DataTable portfolio = new DataTable();
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Text = "Form1";
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            portfolio.Columns.Add("Combien de thunes ?");
            portfolio.Columns.Add("Combien de Action ?");
            portfolio.Columns.Add("Combien de thunes ?");
            portfolio.Columns.Add("Combien de thunes ?");
            portfolio.Columns.Add("Combien de thunes ?");
            //zeazeaizeb.Datasource = portfolio;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Test1_Click(object sender, EventArgs e)
        {
            TestTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}