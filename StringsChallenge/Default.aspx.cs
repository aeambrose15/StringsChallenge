using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StringsChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name

            string input = "Amy Ambrose";
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                resultLabel.Text = output += input[i];
            }



            // 2.  Reverse this sequence:

            string names = "Luke,Leia,Han,Chewbacca";
            When you're finished it should look like this:
             Chewbacca,Han,Leia,Luke

            string names = "Luke,Leia,Han,Chewbacca";
            string[] characters = names.Split(',');
            string output = "";

            for (int i = characters.Length - 1; i >= 0; i--)
            {
                output += characters[i] + ",";
            }
            output = output.Remove(output.Length - 1, 1);
            resultLabel.Text = output;


            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string[] characters = names.Split(',');
            string output = "";
            for (int i = 0; i < characters.Length; i++)
            {
                int padLeft = (14 - characters[i].Length) / 2;
                string temp = characters[i].PadLeft(characters[i].Length + padLeft, '*');
                output += temp.PadRight(14, '*');
                output += "<br />";
            }
            resultLabel.Text = output;



            // 4. Solve this puzzle:
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
                  
            string remove = "remove-me";
            int index = puzzle.IndexOf(remove);
            puzzle = puzzle.Remove(index, remove.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");

            resultLabel.Text = puzzle;

                   
         }
    }
}