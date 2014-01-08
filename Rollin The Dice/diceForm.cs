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

/* Program: Rollin The Dice Ver 2.00
 * Programmer: William Mitchell
 * Date of last update: 01/08/2014
 * Course: POS/409
 * Instructor: Dr. Brad Purdy*/


namespace Rollin_The_Dice
{
    public partial class diceForm : Form
    {

        private DataTable tblResults = new DataTable(); //declares datatable as class variable used in several methods
        private DiceDAO data = new DiceDAO(); //instantiates DiceDAO class
        private int[] resultsArray = new int[100];

        public diceForm()
        {
            InitializeComponent();
        }

        //calls the toolTipLoad on initialization of the form
        private void diceForm_Load(object sender, EventArgs e)
        {
            toolTipLoad();
            clearLabels();
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
            DiceHandler dice = new DiceHandler(); //instantiates DiceHandler class
            dice.rollTheDice(dieOne, dieTwo, 100, tblResults, resultsArray); //calls rollTheDice method from DiceHandler class
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
            this.clearLabels();

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
                data.arrayToFile("arrayFile.txt", resultsArray); //calls save array to file method
                this.sslInfo.Text = "The results of your rolls have been saved"; //updates status strip
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            int rolledTwo = 0;
            int rolledThree = 0;
            int rolledFour = 0;
            int rolledFive = 0;
            int rolledSix = 0;
            int rolledSeven = 0;
            int rolledEight = 0;
            int rolledNine = 0;
            int rolledTen = 0;
            int rolledEleven = 0;
            int rolledTwelve = 0;
            //Declares an array that represents the possible results of throws of two dice
            int[,] possibleResults = { { 2, rolledTwo }, { 3, rolledThree }, { 4, rolledFour }, 
                                     { 5, rolledFive }, { 6, rolledSix }, { 7, rolledSeven }, 
                                     { 8, rolledEight }, { 9, rolledNine }, { 10, rolledTen }, 
                                     { 11, rolledEleven }, { 12, rolledTwelve } }; 

            resetForm(); //calls reset form method
            defineColumns(); //calls define columns method
            tblResults.Rows.Clear(); //clears the rows from the datatable
            data.loadFromFile("resultsFile.txt", "arrayFile.txt", tblResults, resultsArray); //calls load method from DiceDAO class
            this.dgResults.DataSource = tblResults; //displays results in datagridview

            //For each entry in the file, increments the element of the array corresponding to that result
            foreach (int value in resultsArray)
            {
                switch (value)
                {
                    case 2:
                        rolledTwo++;
                        break;
                    case 3:
                        rolledThree++;
                        break;
                    case 4:
                        rolledFour++;
                        break;
                    case 5:
                        rolledFive++;
                        break;
                    case 6:
                        rolledSix++;
                        break;
                    case 7:
                        rolledSeven++;
                        break;
                    case 8:
                        rolledEight++;
                        break;
                    case 9:
                        rolledNine++;
                        break;
                    case 10:
                        rolledTen++;
                        break;
                    case 11:
                        rolledEleven++;
                        break;
                    case 12:
                        rolledTwelve++;
                        break;
                    default:
                        break;
                }

                //displays the frequency count for that simulation.
                this.lblTwoRolled.Text = "The sum was two " + rolledTwo + " times";
                this.lblThreeRolled.Text = "The sum was three " + rolledThree + " times";
                this.lblFourRolled.Text = "The sum was four " + rolledFour + " times";
                this.lblFiveRolled.Text = "The sum was five " + rolledFive + " times";
                this.lblSixRolled.Text = "The sum was six " + rolledSix + " times";
                this.lblSevenRolled.Text = "The sum was seven " + rolledSeven+ " times";
                this.lblEightRolled.Text = "The sum was eight " + rolledEight + " times";
                this.lblNineRolled.Text = "The sum was nine " + rolledNine + " times";
                this.lblTenRolled.Text = "The sum was ten " + rolledTen + " times";
                this.lblElevenRolled.Text = "The sum was eleven " + rolledEleven + " times";
                this.lblTwelveRolled.Text = "The sum was twelve " + rolledTwelve+ " times";
            }

            this.sslInfo.Text = "The results of your rolls have been loaded"; //updates status strip

        }

        //clears the labels
        private void clearLabels()
        {
            lblTwoRolled.Text = string.Empty;
            lblThreeRolled.Text = string.Empty;
            lblFourRolled.Text = string.Empty;
            lblFiveRolled.Text = string.Empty;
            lblSixRolled.Text = string.Empty;
            lblSevenRolled.Text = string.Empty;
            lblEightRolled.Text = string.Empty;
            lblNineRolled.Text = string.Empty;
            lblTenRolled.Text = string.Empty;
            lblElevenRolled.Text = string.Empty;
            lblTwelveRolled.Text = string.Empty;
        }


    }
}
