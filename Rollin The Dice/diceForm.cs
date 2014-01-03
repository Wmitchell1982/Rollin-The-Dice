using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/* Program: Rollin The Dice Ver 1.01
 * Programmer: William Mitchell
 * Date of last update: 01/02/2014
 * Course: POS/409
 * Instructor: Dr. Brad Purdy*/


namespace Rollin_The_Dice
{
    public partial class diceForm : Form
    {

        private DataTable tblResults = new DataTable(); //declares datatable as class variable used in several methods
        private DiceDAO data = new DiceDAO(); //instantiates DiceDAO class
               
        public diceForm()
        {
            InitializeComponent();
        }

        //calls the toolTipLoad on initialization of the form
        private void diceForm_Load(object sender, EventArgs e)
        {
            toolTipLoad();
        }

        //loads tooltips
        private void toolTipLoad()
        {
            this.ttInfo.SetToolTip(this.dgResults, "This is where results of the roll are displayed and loaded");
            this.ttInfo.SetToolTip(this.btnExit, "Exits the application");
            this.ttInfo.SetToolTip(this.btnLoad, "Loads the saved results");
            this.ttInfo.SetToolTip(this.btnSave, "Saves the results");
            this.ttInfo.SetToolTip(this.btnRoll, "Rolls the dice");
            this.ttInfo.SetToolTip(this.btnReset, "Resets the form");
            
        }

        //defines the columns for the DataTable
        private void defineColumns()
        {
            tblResults.Columns.Add("Roll Number", typeof(int));
            tblResults.Columns.Add("Die 1", typeof(int));
            tblResults.Columns.Add("Die 2", typeof(int));
            tblResults.Columns.Add("Die 1 + 2", typeof(int));
        }

        //sets action listener for the roll button
        private void btnRoll_Click(object sender, EventArgs e)
        {
            resetForm(); //calls reset form method
            defineColumns(); //calls define columns method
            tblResults.Rows.Clear();//clears the rows from the datatable
            int[] dieOne = { 1, 2, 3, 4, 5, 6 }; //sets numbers for first die to be used in caluclation this allows user customization for the number of sides on the die
            int[] dieTwo = { 1, 2, 3, 4, 5, 6 }; //sets numbers for second die to be used in caluclation this allows user customization for the number of sides on the die
            var dice = new DiceHandler(); //instantiates DiceHandler class
            dice.rollTheDice(dieOne, dieTwo, 100, tblResults); //calls rollTheDice method from DiceHandler class
            this.dgResults.DataSource = tblResults; //displays results in datagridview
            this.sslInfo.Text = "The results of your rolls are displayed above"; //updates status strip
        }

        //resets form
        private void resetForm()
        {
            this.dgResults.DataSource = null;
            this.tblResults.Columns.Clear();
            this.tblResults.Columns.Clear();
            this.sslInfo.Text = string.Empty;
            
        }

        //sets action listener for the reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();//calls reset form method
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            applicationExit(); //calls the application exit method

        }

        //exits application
        private void applicationExit()
        {
            DialogResult exitConfirm;
            exitConfirm = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //asks user to confirm exit
            if (exitConfirm == System.Windows.Forms.DialogResult.Yes) //if confirmed exits application
            {
                Application.Exit();
            }

        }

        //sets action listener for the save button
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (tblResults.Rows.Count == 0) //tests if table is empty and displays message
            {
                MessageBox.Show("Please Roll The Dice First", "You Must roll to save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //saves the roll data
            {
                
                data.saveToFile("resultsFile.txt", tblResults); //calls save method from DiceDAO class
                this.sslInfo.Text = "The results of your rolls have been saved"; //updates status strip
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            resetForm(); //calls reset form method
            defineColumns(); //calls define columns method
            tblResults.Rows.Clear(); //clears the rows from the datatable
            data.loadFromFile("resultsFile.txt", tblResults); //calls load method from DiceDAO class
            this.dgResults.DataSource = tblResults; //displays results in datagridview
            this.sslInfo.Text = "The results of your rolls have been loaded"; //updates status strip

        }


    }
}
