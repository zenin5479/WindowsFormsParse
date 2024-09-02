using System;
using System.Windows.Forms;

namespace WindowsFormsParse
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void ButtonParseOne_Click(object sender, EventArgs e)
      {
         bool result = int.TryParse(TextBoxOne.Text, out int number);
         RichTextBoxOne.AppendText("Метод int.TryParse" + Environment.NewLine);
         if (result)
            RichTextBoxOne.AppendText("Преобразование прошло успешно. Выходное значение: " + number + Environment.NewLine);
         else
            RichTextBoxOne.AppendText("Преобразование завершилось неудачей" + Environment.NewLine);


         int b = int.Parse(TextBoxOne.Text);
         RichTextBoxOne.AppendText("Метод int.Parse" + Environment.NewLine);
         if (b != 0)
         {
            RichTextBoxOne.AppendText("Преобразование прошло успешно. Выходное значение: " + b + Environment.NewLine);
            RichTextBoxOne.AppendText("Текущий тип локальной переменной: " + b.GetType().Name + Environment.NewLine);
            RichTextBoxOne.AppendText("Полное имя типа локальной переменной, включая пространство имен: " + b.GetType().FullName + Environment.NewLine);
            string name = b.GetType().AssemblyQualifiedName;
            if (name != null) RichTextBoxOne.AppendText("Имя типа локальной переменной с указанием сборки, включающее имя сборки, из которой была загружена переменная: " + name);
         }
         else
         {
            RichTextBoxOne.AppendText("Преобразование завершилось неудачей" + Environment.NewLine);
         }
         
         int c = Convert.ToInt32(TextBoxOne.Text);
         RichTextBoxOne.AppendText(c.GetType().Name + Environment.NewLine);
         RichTextBoxOne.AppendText(c.GetType().FullName + Environment.NewLine);
         
         RichTextBoxOne.ScrollToCaret();
      }

      private void ButtonParseTwo_Click(object sender, EventArgs e)
      {

      }
   }
}