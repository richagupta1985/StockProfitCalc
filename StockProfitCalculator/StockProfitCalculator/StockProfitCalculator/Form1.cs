using StockProfitCalculator.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProfitCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseFile_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select the Stock Input File.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select stock Input File";
            this.GainLabel.Visible = false;
            this.GainDetailText.Visible = false;
            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .TXT file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                try
                {
                    this.GainLabel.Visible = true;
                    if (sr.Peek() != -1)
                    {
                        string resultString = ImportFileHelper.ReadInputFile(sr);

                        if (resultString == string.Empty)
                        {
                            SetGainText("Input file doesnt have sufficient stock quotes", Color.Red, FontStyle.Bold);
                        }
                        else
                        {
                            SetGainText("Biggest Gain Trading Dates:", Color.White, FontStyle.Regular);
                            SetGainDetaiProperties(resultString);                        
                        }
                    }
                    else
                    {
                        SetGainText("Input file doesnt have stock price(s)", Color.Red, FontStyle.Bold);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    sr.Close();

                }
            }

        }
        private void SetGainText(string msgText,Color fontColor, FontStyle fontStyle)
        {
            this.GainLabel.Text = msgText;
            this.GainLabel.ForeColor = fontColor;
            this.GainLabel.Font = new Font(GainLabel.Font, fontStyle);
        }
        /// <summary>
        /// This will update the GainDetailText Label with maximum gain details
        /// </summary>
        /// <param name="resultString"></param>
        private void SetGainDetaiProperties(string resultString)
        {
            GainDetailText.ForeColor = Color.White;
            GainDetailText.Text = resultString;
            GainDetailText.Visible = true;
        }

    }
}
