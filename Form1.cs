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
         bool isNumber = int.TryParse(TextBoxOne.Text, out int a);
         RichTextBoxOne.AppendText(isNumber + Environment.NewLine + a + Environment.NewLine);

         int b = int.Parse(TextBoxOne.Text);
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