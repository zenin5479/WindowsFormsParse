namespace WindowsFormsParse
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         LabelMilliseconds = new System.Windows.Forms.Label();
         LabelCalls = new System.Windows.Forms.Label();
         TextBoxCalls = new System.Windows.Forms.TextBox();
         LabelSpent = new System.Windows.Forms.Label();
         TextBoxAverage = new System.Windows.Forms.TextBox();
         LabelAverage = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // LabelMilliseconds
         // 
         LabelMilliseconds.AutoSize = true;
         LabelMilliseconds.Location = new System.Drawing.Point(118, 36);
         LabelMilliseconds.Name = "LabelMilliseconds";
         LabelMilliseconds.Size = new System.Drawing.Size(104, 21);
         LabelMilliseconds.TabIndex = 56;
         LabelMilliseconds.Text = "миллисекунд";
         // 
         // LabelCalls
         // 
         LabelCalls.AutoSize = true;
         LabelCalls.Location = new System.Drawing.Point(663, 9);
         LabelCalls.Name = "LabelCalls";
         LabelCalls.Size = new System.Drawing.Size(72, 21);
         LabelCalls.TabIndex = 55;
         LabelCalls.Text = "вызывов";
         // 
         // TextBoxCalls
         // 
         TextBoxCalls.Location = new System.Drawing.Point(605, 6);
         TextBoxCalls.Name = "TextBoxCalls";
         TextBoxCalls.Size = new System.Drawing.Size(52, 29);
         TextBoxCalls.TabIndex = 54;
         TextBoxCalls.Text = "10";
         // 
         // LabelSpent
         // 
         LabelSpent.AutoSize = true;
         LabelSpent.Location = new System.Drawing.Point(471, 9);
         LabelSpent.Name = "LabelSpent";
         LabelSpent.Size = new System.Drawing.Size(128, 21);
         LabelSpent.TabIndex = 53;
         LabelSpent.Text = "Затраченное на ";
         // 
         // TextBoxAverage
         // 
         TextBoxAverage.Location = new System.Drawing.Point(12, 33);
         TextBoxAverage.Name = "TextBoxAverage";
         TextBoxAverage.Size = new System.Drawing.Size(100, 29);
         TextBoxAverage.TabIndex = 52;
         // 
         // LabelAverage
         // 
         LabelAverage.AutoSize = true;
         LabelAverage.Location = new System.Drawing.Point(12, 9);
         LabelAverage.Name = "LabelAverage";
         LabelAverage.Size = new System.Drawing.Size(336, 21);
         LabelAverage.TabIndex = 51;
         LabelAverage.Text = "Cреднее арифметическое время выполнения";
         // 
         // Form1
         // 
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         ClientSize = new System.Drawing.Size(744, 522);
         Controls.Add(LabelMilliseconds);
         Controls.Add(LabelCalls);
         Controls.Add(TextBoxCalls);
         Controls.Add(LabelSpent);
         Controls.Add(TextBoxAverage);
         Controls.Add(LabelAverage);
         Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         Name = "Form1";
         Text = "Парсинг";
         Load += Form1_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label LabelMilliseconds;
      private System.Windows.Forms.Label LabelCalls;
      private System.Windows.Forms.TextBox TextBoxCalls;
      private System.Windows.Forms.Label LabelSpent;
      private System.Windows.Forms.TextBox TextBoxAverage;
      private System.Windows.Forms.Label LabelAverage;
   }
}