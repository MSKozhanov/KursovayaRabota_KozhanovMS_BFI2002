using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;





namespace KozhanovLibrary
{
    public class Class1
    {
       public static void WordImport( int n, params string[] arr)
       {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            var Wrd = new Microsoft.Office.Interop.Word.Application();
            Wrd.Visible = true;
            var inf = Type.Missing;
            String str;
            var Doc = Wrd.Documents.Add(inf, inf, inf, inf);
            Wrd.Selection.TypeText("Результаты тестирования");
            Object t1 = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object t2 = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
            Microsoft.Office.Interop.Word.Table tbl = Wrd.ActiveDocument.Tables.Add(Wrd.Selection.Range, 2, n, t1, t2);
            for (int i = 0; i < arr.Length; i++)
            {
                tbl.Cell(1, i + 1).Range.InsertAfter(" № " + Convert.ToString(i + 1) );
                str = String.Format("{0:f0}", arr[i]);
                tbl.Cell(2, i + 1).Range.InsertAfter(str);
            }






       }
        public static void que6(HScrollBar hScrollBar1, TextBox textBox1)
        {
            if (hScrollBar1.Value == 4)
            {
                MessageBox.Show("Вы ответили правильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hScrollBar1.Enabled = false;
                textBox1.Text = "1 балл";
                textBox1.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hScrollBar1.Enabled = false;
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                
            }
        }

        public static bool que7(CheckedListBox checkedListBox1, TextBox textBox1)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Надо ответить на вопрос!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
               
            else
                if (checkedListBox1.SelectedIndex == 1)
                {
                    checkedListBox1.Items.Clear();
                    MessageBox.Show("Вы ответили правильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "1 балл";
                    textBox1.Enabled = false;
                    return true;
                }
            else
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkedListBox1.Items.Clear();
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                return true;
            }
        }
        public static bool que8(CheckedListBox checkedListBox1, TextBox textBox1)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Надо ответить на вопрос!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
                
            else
                if (checkedListBox1.SelectedIndex == 1)
                {
                    checkedListBox1.Items.Clear();
                    MessageBox.Show("Вы ответили правильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "1 балл";
                    textBox1.Enabled = false;
                    return true;
                }
            else
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkedListBox1.Items.Clear();
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                return true;
            }
        }
        public static bool que9(ComboBox comboBox1, TextBox textBox1)
        {
            if ((comboBox1.SelectedIndex == 2))
            {
                MessageBox.Show("Вы ответили правильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = false;
                textBox1.Text = "1 балл";
                textBox1.Enabled = false;
                return true;


            }
            else
               if ((comboBox1.SelectedIndex == -1))
               {
                    MessageBox.Show("Надо ответить на вопрос!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
               }
            
            else
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Enabled = false;
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                return true;
            }

        }
        public static void que10(HScrollBar hScrollBar1, TextBox textBox1)
        {
            if (hScrollBar1.Value == 3)
            {
                MessageBox.Show("Вы ответили правильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hScrollBar1.Enabled = false;
                textBox1.Text = "1 балл";
                textBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hScrollBar1.Enabled = false;
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
            }
        }
        // Метод  add() предназначен для создания базы данных на диске
        public static void add()
        {
            var k = new ADOX.Catalog();
            try
            {
                k.Create("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + "\\Database1.mdb");
                MessageBox.Show("База данных успешно создана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Runtime.InteropServices.COMException sit)
            {
                MessageBox.Show(sit.Message);
            }
            finally
            {
                k = null;
            }
        }
        //Метод add_struct() предназначен для формирования структуры базы данных
        public static void add_struct()
        {

            var p = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + "\\Database1.mdb");
            p.Open();
            var c = new OleDbCommand("CREATE TABLE [Database1]([Номер вопроса] COUNTER, [Результаты] char(200))", p);
            try
            {
                c.ExecuteNonQuery();
                MessageBox.Show("Структура базы данных успешно создана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception sit)
            {
                MessageBox.Show(sit.Message);
            }
            p.Close();
        }
        //Метод add_zap() предназначен для записи  в таблицу базы данных информации
        public static void add_zap(ref int[] masPtr, ref string[] arr)
        {
            for (int i = 0; i < masPtr.Length-1 ; i++)
            {
                var p = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "\\Database1.mdb");
                p.Open();
                var c = new OleDbCommand("INSERT INTO [Database1](" + "[Результаты]) VALUES('"  + arr[i] + "')");
                c.Connection = p;
                c.ExecuteNonQuery();
                
                

            }
            MessageBox.Show("Информация в базу данных успешно добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
