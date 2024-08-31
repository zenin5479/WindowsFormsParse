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
         TextBoxTwo = new System.Windows.Forms.TextBox();
         LabelSpent = new System.Windows.Forms.Label();
         TextBoxOne = new System.Windows.Forms.TextBox();
         LabelAverage = new System.Windows.Forms.Label();
         ButtonParseOne = new System.Windows.Forms.Button();
         ButtonParseTwo = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // LabelMilliseconds
         // 
         LabelMilliseconds.AutoSize = true;
         LabelMilliseconds.Location = new System.Drawing.Point(12, 143);
         LabelMilliseconds.Name = "LabelMilliseconds";
         LabelMilliseconds.Size = new System.Drawing.Size(104, 21);
         LabelMilliseconds.TabIndex = 56;
         LabelMilliseconds.Text = "миллисекунд";
         // 
         // LabelCalls
         // 
         LabelCalls.AutoSize = true;
         LabelCalls.Location = new System.Drawing.Point(256, 143);
         LabelCalls.Name = "LabelCalls";
         LabelCalls.Size = new System.Drawing.Size(72, 21);
         LabelCalls.TabIndex = 55;
         LabelCalls.Text = "вызывов";
         // 
         // TextBoxTwo
         // 
         TextBoxTwo.Location = new System.Drawing.Point(118, 12);
         TextBoxTwo.Name = "TextBoxTwo";
         TextBoxTwo.Size = new System.Drawing.Size(100, 29);
         TextBoxTwo.TabIndex = 54;
         TextBoxTwo.Text = "10";
         // 
         // LabelSpent
         // 
         LabelSpent.AutoSize = true;
         LabelSpent.Location = new System.Drawing.Point(122, 143);
         LabelSpent.Name = "LabelSpent";
         LabelSpent.Size = new System.Drawing.Size(128, 21);
         LabelSpent.TabIndex = 53;
         LabelSpent.Text = "Затраченное на ";
         // 
         // TextBoxOne
         // 
         TextBoxOne.Location = new System.Drawing.Point(12, 12);
         TextBoxOne.Name = "TextBoxOne";
         TextBoxOne.Size = new System.Drawing.Size(100, 29);
         TextBoxOne.TabIndex = 52;
         TextBoxOne.Text = "10";
         // 
         // LabelAverage
         // 
         LabelAverage.AutoSize = true;
         LabelAverage.Location = new System.Drawing.Point(12, 122);
         LabelAverage.Name = "LabelAverage";
         LabelAverage.Size = new System.Drawing.Size(336, 21);
         LabelAverage.TabIndex = 51;
         LabelAverage.Text = "Cреднее арифметическое время выполнения";
         // 
         // ButtonParseOne
         // 
         ButtonParseOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         ButtonParseOne.Location = new System.Drawing.Point(12, 47);
         ButtonParseOne.Name = "ButtonParseOne";
         ButtonParseOne.Size = new System.Drawing.Size(100, 29);
         ButtonParseOne.TabIndex = 57;
         ButtonParseOne.Text = "Парсить";
         ButtonParseOne.UseVisualStyleBackColor = true;
         // 
         // ButtonParseTwo
         // 
         ButtonParseTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         ButtonParseTwo.Location = new System.Drawing.Point(118, 47);
         ButtonParseTwo.Name = "ButtonParseTwo";
         ButtonParseTwo.Size = new System.Drawing.Size(100, 29);
         ButtonParseTwo.TabIndex = 58;
         ButtonParseTwo.Text = "Парсить";
         ButtonParseTwo.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         ClientSize = new System.Drawing.Size(744, 522);
         Controls.Add(ButtonParseTwo);
         Controls.Add(ButtonParseOne);
         Controls.Add(LabelMilliseconds);
         Controls.Add(LabelCalls);
         Controls.Add(TextBoxTwo);
         Controls.Add(LabelSpent);
         Controls.Add(TextBoxOne);
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
      private System.Windows.Forms.TextBox TextBoxTwo;
      private System.Windows.Forms.Label LabelSpent;
      private System.Windows.Forms.TextBox TextBoxOne;
      private System.Windows.Forms.Label LabelAverage;
      private System.Windows.Forms.Button ButtonParseOne;
      private System.Windows.Forms.Button ButtonParseTwo;
   }
}