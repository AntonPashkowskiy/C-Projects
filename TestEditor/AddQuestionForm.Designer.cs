namespace TestEditor
{
	partial class AddQuestionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( AddQuestionForm ) );
			this.gbQuestion = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbHeader = new System.Windows.Forms.TextBox();
			this.tbQuestion = new System.Windows.Forms.TextBox();
			this.gbAnswers = new System.Windows.Forms.GroupBox();
			this.rbD = new System.Windows.Forms.RadioButton();
			this.rbC = new System.Windows.Forms.RadioButton();
			this.rbB = new System.Windows.Forms.RadioButton();
			this.rbA = new System.Windows.Forms.RadioButton();
			this.tbD = new System.Windows.Forms.TextBox();
			this.tbC = new System.Windows.Forms.TextBox();
			this.tbB = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbA = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbHelp = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbHelp = new System.Windows.Forms.TextBox();
			this.tb50 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbCalling = new System.Windows.Forms.TextBox();
			this.btCancel = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.btNext = new System.Windows.Forms.Button();
			this.btPrev = new System.Windows.Forms.Button();
			this.lbEnumerate = new System.Windows.Forms.Label();
			this.gbQuestion.SuspendLayout();
			this.gbAnswers.SuspendLayout();
			this.gbHelp.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbQuestion
			// 
			this.gbQuestion.Controls.Add( this.label8 );
			this.gbQuestion.Controls.Add( this.tbHeader );
			this.gbQuestion.Controls.Add( this.tbQuestion );
			this.gbQuestion.Location = new System.Drawing.Point( 13, 13 );
			this.gbQuestion.Name = "gbQuestion";
			this.gbQuestion.Size = new System.Drawing.Size( 509, 93 );
			this.gbQuestion.TabIndex = 0;
			this.gbQuestion.TabStop = false;
			this.gbQuestion.Text = "Вопрос";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point( 20, 22 );
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size( 61, 13 );
			this.label8.TabIndex = 0;
			this.label8.Text = "Заголовок";
			// 
			// tbHeader
			// 
			this.tbHeader.Location = new System.Drawing.Point( 87, 19 );
			this.tbHeader.MaxLength = 20;
			this.tbHeader.Name = "tbHeader";
			this.tbHeader.Size = new System.Drawing.Size( 156, 20 );
			this.tbHeader.TabIndex = 1;
			this.tbHeader.TextChanged += new System.EventHandler( this.EnteringData );
			// 
			// tbQuestion
			// 
			this.tbQuestion.Location = new System.Drawing.Point( 7, 43 );
			this.tbQuestion.MaxLength = 100;
			this.tbQuestion.Multiline = true;
			this.tbQuestion.Name = "tbQuestion";
			this.tbQuestion.Size = new System.Drawing.Size( 496, 44 );
			this.tbQuestion.TabIndex = 2;
			this.tbQuestion.TextChanged += new System.EventHandler( this.EnteringData );
			// 
			// gbAnswers
			// 
			this.gbAnswers.Controls.Add( this.rbD );
			this.gbAnswers.Controls.Add( this.rbC );
			this.gbAnswers.Controls.Add( this.rbB );
			this.gbAnswers.Controls.Add( this.rbA );
			this.gbAnswers.Controls.Add( this.tbD );
			this.gbAnswers.Controls.Add( this.tbC );
			this.gbAnswers.Controls.Add( this.tbB );
			this.gbAnswers.Controls.Add( this.label4 );
			this.gbAnswers.Controls.Add( this.label3 );
			this.gbAnswers.Controls.Add( this.label2 );
			this.gbAnswers.Controls.Add( this.tbA );
			this.gbAnswers.Controls.Add( this.label1 );
			this.gbAnswers.Location = new System.Drawing.Point( 13, 113 );
			this.gbAnswers.Name = "gbAnswers";
			this.gbAnswers.Size = new System.Drawing.Size( 509, 127 );
			this.gbAnswers.TabIndex = 0;
			this.gbAnswers.TabStop = false;
			this.gbAnswers.Text = "Ответы";
			// 
			// rbD
			// 
			this.rbD.AutoSize = true;
			this.rbD.Location = new System.Drawing.Point( 355, 92 );
			this.rbD.Name = "rbD";
			this.rbD.Size = new System.Drawing.Size( 14, 13 );
			this.rbD.TabIndex = 0;
			this.rbD.TabStop = true;
			this.rbD.UseVisualStyleBackColor = true;
			// 
			// rbC
			// 
			this.rbC.AutoSize = true;
			this.rbC.Location = new System.Drawing.Point( 355, 69 );
			this.rbC.Name = "rbC";
			this.rbC.Size = new System.Drawing.Size( 14, 13 );
			this.rbC.TabIndex = 0;
			this.rbC.TabStop = true;
			this.rbC.UseVisualStyleBackColor = true;
			// 
			// rbB
			// 
			this.rbB.AutoSize = true;
			this.rbB.Location = new System.Drawing.Point( 355, 48 );
			this.rbB.Name = "rbB";
			this.rbB.Size = new System.Drawing.Size( 14, 13 );
			this.rbB.TabIndex = 0;
			this.rbB.TabStop = true;
			this.rbB.UseVisualStyleBackColor = true;
			// 
			// rbA
			// 
			this.rbA.AutoSize = true;
			this.rbA.Checked = true;
			this.rbA.Location = new System.Drawing.Point( 355, 25 );
			this.rbA.Name = "rbA";
			this.rbA.Size = new System.Drawing.Size( 14, 13 );
			this.rbA.TabIndex = 0;
			this.rbA.TabStop = true;
			this.rbA.UseVisualStyleBackColor = true;
			// 
			// tbD
			// 
			this.tbD.Location = new System.Drawing.Point( 73, 89 );
			this.tbD.MaxLength = 30;
			this.tbD.Name = "tbD";
			this.tbD.Size = new System.Drawing.Size( 265, 20 );
			this.tbD.TabIndex = 6;
			this.tbD.TextChanged += new System.EventHandler( this.EnteringData );
			// 
			// tbC
			// 
			this.tbC.Location = new System.Drawing.Point( 73, 67 );
			this.tbC.MaxLength = 30;
			this.tbC.Name = "tbC";
			this.tbC.Size = new System.Drawing.Size( 265, 20 );
			this.tbC.TabIndex = 5;
			this.tbC.TextChanged += new System.EventHandler( this.EnteringData );
			// 
			// tbB
			// 
			this.tbB.Location = new System.Drawing.Point( 73, 45 );
			this.tbB.MaxLength = 30;
			this.tbB.Name = "tbB";
			this.tbB.Size = new System.Drawing.Size( 265, 20 );
			this.tbB.TabIndex = 4;
			this.tbB.TextChanged += new System.EventHandler( this.EnteringData );
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point( 20, 92 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 46, 13 );
			this.label4.TabIndex = 0;
			this.label4.Text = "Ответ Г";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 20, 70 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 47, 13 );
			this.label3.TabIndex = 0;
			this.label3.Text = "Ответ В";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 20, 48 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 47, 13 );
			this.label2.TabIndex = 0;
			this.label2.Text = "Ответ Б";
			// 
			// tbA
			// 
			this.tbA.Location = new System.Drawing.Point( 73, 22 );
			this.tbA.MaxLength = 30;
			this.tbA.Name = "tbA";
			this.tbA.Size = new System.Drawing.Size( 265, 20 );
			this.tbA.TabIndex = 3;
			this.tbA.TextChanged += new System.EventHandler( this.EnteringData );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 20, 25 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 47, 13 );
			this.label1.TabIndex = 0;
			this.label1.Text = "Ответ А";
			// 
			// gbHelp
			// 
			this.gbHelp.Controls.Add( this.label7 );
			this.gbHelp.Controls.Add( this.label6 );
			this.gbHelp.Controls.Add( this.tbHelp );
			this.gbHelp.Controls.Add( this.tb50 );
			this.gbHelp.Controls.Add( this.label5 );
			this.gbHelp.Controls.Add( this.tbCalling );
			this.gbHelp.Location = new System.Drawing.Point( 13, 247 );
			this.gbHelp.Name = "gbHelp";
			this.gbHelp.Size = new System.Drawing.Size( 509, 110 );
			this.gbHelp.TabIndex = 0;
			this.gbHelp.TabStop = false;
			this.gbHelp.Text = "Подсказки";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point( 20, 74 );
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size( 50, 13 );
			this.label7.TabIndex = 0;
			this.label7.Text = "Помощь";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point( 20, 48 );
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size( 36, 13 );
			this.label6.TabIndex = 0;
			this.label6.Text = "50/50";
			// 
			// tbHelp
			// 
			this.tbHelp.Location = new System.Drawing.Point( 73, 71 );
			this.tbHelp.Name = "tbHelp";
			this.tbHelp.Size = new System.Drawing.Size( 411, 20 );
			this.tbHelp.TabIndex = 9;
			this.tbHelp.TextChanged += new System.EventHandler( this.EnteringData );
			// 
			// tb50
			// 
			this.tb50.Location = new System.Drawing.Point( 73, 45 );
			this.tb50.Name = "tb50";
			this.tb50.Size = new System.Drawing.Size( 411, 20 );
			this.tb50.TabIndex = 8;
			this.tb50.TextChanged += new System.EventHandler( this.EnteringData );
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point( 20, 22 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 44, 13 );
			this.label5.TabIndex = 0;
			this.label5.Text = "Звонок";
			// 
			// tbCalling
			// 
			this.tbCalling.Location = new System.Drawing.Point( 73, 19 );
			this.tbCalling.Name = "tbCalling";
			this.tbCalling.Size = new System.Drawing.Size( 411, 20 );
			this.tbCalling.TabIndex = 7;
			this.tbCalling.TextChanged += new System.EventHandler( this.EnteringData );
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = new System.Drawing.Point( 440, 376 );
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size( 82, 23 );
			this.btCancel.TabIndex = 13;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler( this.CancelButtonClick );
			// 
			// btAdd
			// 
			this.btAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btAdd.Location = new System.Drawing.Point( 147, 376 );
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size( 82, 23 );
			this.btAdd.TabIndex = 10;
			this.btAdd.Text = "Добавить";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler( this.AddQuestionClick );
			// 
			// btNext
			// 
			this.btNext.Location = new System.Drawing.Point( 352, 376 );
			this.btNext.Name = "btNext";
			this.btNext.Size = new System.Drawing.Size( 82, 23 );
			this.btNext.TabIndex = 12;
			this.btNext.Text = "Далее >";
			this.btNext.UseVisualStyleBackColor = true;
			this.btNext.Click += new System.EventHandler( this.NextButtonClick );
			// 
			// btPrev
			// 
			this.btPrev.Location = new System.Drawing.Point( 269, 376 );
			this.btPrev.Name = "btPrev";
			this.btPrev.Size = new System.Drawing.Size( 82, 23 );
			this.btPrev.TabIndex = 11;
			this.btPrev.Text = "< Назад";
			this.btPrev.UseVisualStyleBackColor = true;
			this.btPrev.Click += new System.EventHandler( this.PrevButtonClick );
			// 
			// lbEnumerate
			// 
			this.lbEnumerate.AutoSize = true;
			this.lbEnumerate.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.lbEnumerate.Location = new System.Drawing.Point( 17, 384 );
			this.lbEnumerate.Name = "lbEnumerate";
			this.lbEnumerate.Size = new System.Drawing.Size( 51, 15 );
			this.lbEnumerate.TabIndex = 0;
			this.lbEnumerate.Text = "0  \\  30";
			// 
			// AddQuestionForm
			// 
			this.AcceptButton = this.btAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size( 534, 411 );
			this.ControlBox = false;
			this.Controls.Add( this.lbEnumerate );
			this.Controls.Add( this.btPrev );
			this.Controls.Add( this.btNext );
			this.Controls.Add( this.btAdd );
			this.Controls.Add( this.btCancel );
			this.Controls.Add( this.gbHelp );
			this.Controls.Add( this.gbAnswers );
			this.Controls.Add( this.gbQuestion );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddQuestionForm";
			this.Text = "Добавление вопросов";
			this.gbQuestion.ResumeLayout( false );
			this.gbQuestion.PerformLayout();
			this.gbAnswers.ResumeLayout( false );
			this.gbAnswers.PerformLayout();
			this.gbHelp.ResumeLayout( false );
			this.gbHelp.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbQuestion;
		private System.Windows.Forms.GroupBox gbAnswers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbHelp;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.TextBox tbQuestion;
		private System.Windows.Forms.TextBox tbD;
		private System.Windows.Forms.TextBox tbC;
		private System.Windows.Forms.TextBox tbB;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbA;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbHelp;
		private System.Windows.Forms.TextBox tb50;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbCalling;
		private System.Windows.Forms.RadioButton rbD;
		private System.Windows.Forms.RadioButton rbC;
		private System.Windows.Forms.RadioButton rbB;
		private System.Windows.Forms.RadioButton rbA;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbHeader;
		private System.Windows.Forms.Button btNext;
		private System.Windows.Forms.Button btPrev;
		private System.Windows.Forms.Label lbEnumerate;
	}
}