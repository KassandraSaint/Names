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

namespace Names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Creating method to read files and add contents to a list
        private void ReadFile(string file, List<string> nameList)
        {
            // Trying to read a file
            try
            {
                StreamReader inputFile = File.OpenText(file);

                // While there is data in the file reading it
                while (!inputFile.EndOfStream)
                {
                    // Adding each entry to a list
                    nameList.Add(inputFile.ReadLine());
                }
                // Closing the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                errorMsg.Text = ex.Message;
            }
        }

        // Creating a method to search for names and their index
        private int NameSearch(string name, List<string> nameList)
        {
            // Initializing a variable to hold index of the name
            int nameIndex = nameList.IndexOf(name);

            // Returning index of the name
            return nameIndex;
        }

        // Creating a method to check a name entered in a TextBox and providing information accordingly 
        private void NameCheck(TextBox control, Label info, List<string> nameList)
        {
            try
            {
                // Initializing name variable to hold a name entered by user
                string name;
                // If nothing was entered in a TextBox
                if (control.Text == "")
                {
                    // Not showing anything
                    info.Text = "";
                }
                else
                {
                    // Otherwise storing name entered in the TextBox in the name variable
                    name = control.Text;
                    // Calling NameSearch method passing name and list of names nd storing returned index in 
                    // nameIndex variable
                    int nameIndex = NameSearch(name, nameList);

                    // If nameIndex is not -1, aka if name is on the list
                    if (nameIndex != -1)
                    {
                        // Showing a message in the label control
                        info.Text = "Name " + name + " is on the list, its position is: " + nameIndex + " out of 200";
                    }
                    // Otherwise showing a message that name is not on the list
                    else
                    {
                        info.Text = "Name " + name + " is not on the list! Try another one!";
                    }
                }
            }
            // Showing an exception if any
            catch (Exception ex)
            {
                info.Text = ex.Message;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Creating a list to hold boy's names
            List<string> boysNames = new List<string>();
            // Creating a list to hold girl's names
            List<string> girlsNames = new List<string>();

            // Reading files and adding contents to lists
            ReadFile("Resources/BoyNames.txt", boysNames);
            ReadFile("Resources/GirlNames.txt", girlsNames);

            // Calling NameCheck method passing controls and lists for boys' and girls' names
            NameCheck(boyBox, infoBoy, boysNames);
            NameCheck(girlBox, infoGirl, girlsNames);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing form
            this.Close();
        }
    }
}
