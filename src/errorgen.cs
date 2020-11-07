using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Errorgen
{
    class program
    {
        static void Main(string[] args)
        {
            
            // getting input
            Console.WriteLine("Enter error type(error, warning, question, info | Input must be lowercase):");
            string Type = Console.ReadLine();

            Console.WriteLine("Enter error title:");
            string Title = Console.ReadLine();

            Console.WriteLine("Enter error message:");
            string Message = Console.ReadLine();

            // generating
            if (Type == "error")
            {
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else if (Type == "warning")
            {
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }else if (Type == "question")
            {
                MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }else if (Type == "info")
            {
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else
            {
                Console.WriteLine("Invalid input in error type");
            }
        }
    }
}