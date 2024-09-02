﻿using System;
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

         //bool result2 = int.Parse(TextBoxOne.Text, out int anumber);
         int b = int.Parse(TextBoxOne.Text);
         RichTextBoxOne.AppendText("Метод int.Parse" + Environment.NewLine);
         if (result2)
            RichTextBoxOne.AppendText("Преобразование прошло успешно. Выходное значение: " + number + Environment.NewLine);
         else
            RichTextBoxOne.AppendText("Преобразование завершилось неудачей" + Environment.NewLine);


         int c = Convert.ToInt32(TextBoxOne.Text);

         RichTextBoxOne.AppendText(b.GetType().Name + Environment.NewLine);
         RichTextBoxOne.AppendText(b.GetType().FullName + Environment.NewLine);
         string name = b.GetType().AssemblyQualifiedName;
         if (name != null) RichTextBoxOne.AppendText(name);

         RichTextBoxOne.AppendText(c.GetType().Name + Environment.NewLine);
         RichTextBoxOne.AppendText(c.GetType().FullName + Environment.NewLine);
      }

      private void ButtonParseTwo_Click(object sender, EventArgs e)
      {

      }
   }
}