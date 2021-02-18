using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {


            int n = 15;
            int[] masPtr = new int[n];
            Array.Clear(masPtr, 0, masPtr.Length);
            grid.ColumnCount = 15;
            grid.RowCount = 2;
            for (int i = 1; i < 15; i++)
            {
                grid.Rows[0].Cells[i].Value = "Вопрос № " + i;
                
            }
            string[] arr = new string[]
            {
                Program.getResult("quest1"),
                Program.getResult("quest2"),
                Program.getResult("quest3"),
                Program.getResult("quest4"),
                Program.getResult("quest5"),
                Program.getResult("quest6"),
                Program.getResult("quest7"),
                Program.getResult("quest8"),
                Program.getResult("quest9"),
                Program.getResult("quest10"),
                Program.getResult("quest11"),
                Program.getResult("quest12"),
                Program.getResult("quest13"),
                Program.getResult("quest14"),
            };
            grid.Rows[1].Cells[1].Value = Program.getResult("quest1");
            grid.Rows[1].Cells[2].Value = Program.getResult("quest2");
            grid.Rows[1].Cells[3].Value = Program.getResult("quest3");
            grid.Rows[1].Cells[4].Value = Program.getResult("quest4");
            grid.Rows[1].Cells[5].Value = Program.getResult("quest5");
            grid.Rows[1].Cells[6].Value = Program.getResult("quest6");
            grid.Rows[1].Cells[7].Value = Program.getResult("quest7");
            grid.Rows[1].Cells[8].Value = Program.getResult("quest8");
            grid.Rows[1].Cells[9].Value = Program.getResult("quest9");
            grid.Rows[1].Cells[10].Value = Program.getResult("quest10");
            grid.Rows[1].Cells[11].Value = Program.getResult("quest11");
            grid.Rows[1].Cells[12].Value = Program.getResult("quest12");
            grid.Rows[1].Cells[13].Value = Program.getResult("quest13");
            grid.Rows[1].Cells[14].Value = Program.getResult("quest14");
            int Width = 0;
            for (int s = 0; s < grid.ColumnCount; s++)
                Width += grid.Columns[s].Width;
            if (Width > 10000)
                grid.Width = 10000;
            else
                grid.Width = Width;


            KozhanovLibrary.Class1.add();
            //Создание структуры БД
            KozhanovLibrary.Class1.add_struct();
            //Заполнение БД
            KozhanovLibrary.Class1.add_zap(ref masPtr, ref arr);
            // Заполнение Word
            KozhanovLibrary.Class1.WordImport(n, arr);






        }

        
    }
    
}
