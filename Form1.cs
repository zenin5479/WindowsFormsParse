using System;
using System;
using System.Collections.Generic;
using System.Globalization;
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
         int a = int.Parse(TextBoxOne.Text);

         int i = Convert.ToInt32(TextBoxOne.Text);


         RichTextBoxOne.AppendText(a.GetType().Name + Environment.NewLine);
         RichTextBoxOne.AppendText(a.GetType().FullName + Environment.NewLine);
         string name = a.GetType().AssemblyQualifiedName;
         if (name != null) RichTextBoxOne.AppendText(name);

         //RichTextBoxOne.AppendText( i.GetType().Name + Environment.NewLine);
         //RichTextBoxOne.AppendText(i.GetType().FullName + Environment.NewLine);
      }

      private void ButtonParseTwo_Click(object sender, EventArgs e)
      {

      }
   }
}