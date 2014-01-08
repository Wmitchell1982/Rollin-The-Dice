using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Program: Rollin The Dice Ver 1.0
 * Programmer: William Mitchell
 * Date of last update: 12/31/2013
 * Course: POS/409
 * Instructor: Dr. Brad Purdy*/

namespace Rollin_The_Dice
{
    //Data Access Object for the dice program
    public class DiceDAO
    {
        //method for saving to a file
        //much inspiration from http://stackoverflow.com/questions/11749812/write-rows-from-datatable-to-text-file
        //also from http://stackoverflow.com/questions/18206577/generating-a-txt-file-from-a-datatable
        //and my own work
        public void saveToFile(string filename, DataTable table)
        {

            //try-catch block for io exception
            try
            {
                StreamWriter resultsFileWriter;
                resultsFileWriter = File.CreateText(filename);

                foreach (DataRow row in table.Rows)
                {
                    bool firstCol = true;
                    foreach (DataColumn col in table.Columns)
                    {
                        if (!firstCol) resultsFileWriter.Write(", ");
                        resultsFileWriter.Write(row[col].ToString());
                        firstCol = false;
                    }
                    resultsFileWriter.WriteLine();
                }
                resultsFileWriter.Flush();
                resultsFileWriter.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void arrayToFile(string filename, int[] resultsArray)
        {
            try
            {
                StreamWriter resultsFileWriter;
                resultsFileWriter = File.CreateText(filename);

                foreach (int entry in resultsArray)
                {
                    resultsFileWriter.WriteLine(entry);
                }
                resultsFileWriter.Flush();
                resultsFileWriter.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //method for loading from the file
        public void loadFromFile(string filenameOne, string filenameTwo, DataTable table, int[] resultsArray)
        {
            //try-catch block for io exception
            try
            {
                var lines = File.ReadAllLines(filenameOne).ToList();
                string[] stringResultsArray = File.ReadAllLines(filenameTwo);


                lines.ForEach(line => table.Rows.Add(line.Split((char)',')));

                for (int count = 0; count < stringResultsArray.Length; count++)
                {
                    resultsArray[count] = int.Parse(stringResultsArray[count]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
