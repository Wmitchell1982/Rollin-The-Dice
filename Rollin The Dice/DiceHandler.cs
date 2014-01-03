using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Program: Rollin The Dice Ver 1.0
 * Programmer: William Mitchell
 * Date of last update: 12/31/2013
 * Course: POS/409
 * Instructor: Dr. Brad Purdy*/
namespace Rollin_The_Dice
{
    //class for handling dice events
    public class DiceHandler
    {
        //method for rolling two dice, calls for arrays for the numbers on the side of the dice, the number of rolls and the datatable
        public void rollTheDice(int[] dieOne, int[] dieTwo, int rollNumbers, DataTable table)
        {
            
            int dieOneResult; //sets variable for result of first die
            int dieTwoResult; //sets variable for result of second die
            int diceResult; //sets variable for result of both dice added together
           
            Random randomRoll = new Random(); //creates a random for randomly selecting a value from the array

            //for loop for filling the datatable
            for (int counter = 0; counter < rollNumbers; counter++)
            {
                dieOneResult = dieOne[randomRoll.Next(0, dieOne.Length)];
                dieTwoResult = dieTwo[randomRoll.Next(0, dieTwo.Length)];
                diceResult = (dieOneResult + dieTwoResult);
                table.Rows.Add(counter + 1, dieOneResult, dieTwoResult, diceResult);
                
            }



        }
    }
}
