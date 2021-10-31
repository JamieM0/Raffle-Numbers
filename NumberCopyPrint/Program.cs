using System;
using System.IO;

namespace NumberCopyPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofpeopleentered;
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Raffle Number Copy Print");
            Console.WriteLine("Enter the number of people that have entered the raffle.");
            numberofpeopleentered = Convert.ToInt32(Console.ReadLine());

            //int i;
            string fileName = "RaffleNumbers.txt";
            for(int i = 0; i <= numberofpeopleentered; i++)
            {
                Console.WriteLine(i);
                FileStream aFile;
                StreamWriter sw;
                try
                {
                    //Check if the file exists, if not (it does't) then it creates it.
                    if (!File.Exists(fileName))
                    {
                        aFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    }
                    else
                    {
                        //If the file already exists, then open it in append mode.
                        aFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                    }

                    //Create a new connection to the file writer
                    sw = new StreamWriter(aFile);

                    //Write the student details to the file with each piece of data separated with the '~' symbol.
                    sw.WriteLine($"{i}");

                    //Close the connection to the file
                    sw.Close();
                    aFile.Close();

                    //MessageBox.Show("Pupils details have been saved successfully..", "Successful");
                    //btnDashboardGoTo.Enabled = true;
                    //btnSavePupilDetails.Enabled = false;
                    //btnOverviewGoTo.Enabled = true;
                }

                catch (Exception ex)
                {
                    //If the file cannot be found give the user a suitable message
                    //MessageBox.Show(ex.Message, "Pupils details have not been saved successfully, please try again. If this error persists, please file a bug report from the Dashboard.");
                    Console.WriteLine("Failure Saving!");
                }
            }
        }
    }
}
