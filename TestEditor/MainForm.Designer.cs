namespace TestEditor
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
			this.gbQuestionList = new System.Windows.Forms.GroupBox();
			this.lbMain = new System.Windows.Forms.ListBox();
			this.btTestSave = new System.Windows.Forms.Button();
			this.btTestAdd = new System.Windows.Forms.Button();
			this.btTestEdit = new System.Windows.Forms.Button();
			this.btTestDelete = new System.Windows.Forms.Button();
			this.tbOpenTest = new System.Windows.Forms.Button();
			this.gbQuestionList.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbQuestionList
			// 
			this.gbQuestionList.Controls.Add( this.lbMain );
			this.gbQuestionList.Location = new System.Drawing.Point( 12, 13 );
			this.gbQuestionList.Name = "gbQuestionList";
			this.gbQuestionList.Size = new System.Drawing.Size( 259, 439 );
			this.gbQuestionList.TabIndex = 0;
			this.gbQuestionList.TabStop = false;
			this.gbQuestionList.Text = "Список вопросов";
			// 
			// lbMain
			// 
			this.lbMain.FormattingEnabled = true;
			this.lbMain.Location = new System.Drawing.Point( 6, 18 );
			this.lbMain.Name = "lbMain";
			this.lbMain.Size = new System.Drawing.Size( 247, 407 );
			this.lbMain.TabIndex = 0;
			// 
			// btTestSave
			// 
			this.btTestSave.Location = new System.Drawing.Point( 350, 180 );
			this.btTestSave.Name = "btTestSave";
			this.btTestSave.Size = new System.Drawing.Size( 167, 31 );
			this.btTestSave.TabIndex = 4;
			this.btTestSave.Text = "Сохранить тест...";
			this.btTestSave.UseVisualStyleBackColor = true;
			this.btTestSave.Click += new System.EventHandler( this.SaveTest );
			// 
			// btTestAdd
			// 
			this.btTestAdd.Location = new System.Drawing.Point( 350, 31 );
			this.btTestAdd.Name = "btTestAdd";
			this.btTestAdd.Size = new System.Drawing.Size( 167, 31 );
			this.btTestAdd.TabIndex = 1;
			this.btTestAdd.Text = "Добавить вопросы...";
			this.btTestAdd.UseVisualStyleBackColor = true;
			this.btTestAdd.Click += new System.EventHandler( this.AddQuestion );
			// 
			// btTestEdit
			// 
			this.btTestEdit.Location = new System.Drawing.Point( 350, 68 );
			this.btTestEdit.Name = "btTestEdit";
			this.btTestEdit.Size = new System.Drawing.Size( 167, 31 );
			this.btTestEdit.TabIndex = 2;
			this.btTestEdit.Text = "Редактирование...";
			this.btTestEdit.UseVisualStyleBackColor = true;
			this.btTestEdit.Click += new System.EventHandler( this.Edit );
			// 
			// btTestDelete
			// 
			this.btTestDelete.Location = new System.Drawing.Point( 350, 105 );
			this.btTestDelete.Name = "btTestDelete";
			this.btTestDelete.Size = new System.Drawing.Size( 167, 31 );
			this.btTestDelete.TabIndex = 3;
			this.btTestDelete.Text = "Удалить вопросы...";
			this.btTestDelete.UseVisualStyleBackColor = true;
			this.btTestDelete.Click += new System.EventHandler( this.DeleteQuestion );
			// 
			// tbOpenTest
			// 
			this.tbOpenTest.Location = new System.Drawing.Point( 350, 143 );
			this.tbOpenTest.Name = "tbOpenTest";
			this.tbOpenTest.Size = new System.Drawing.Size( 167, 31 );
			this.tbOpenTest.TabIndex = 5;
			this.tbOpenTest.Text = "Открыть тест...";
			this.tbOpenTest.UseVisualStyleBackColor = true;
			this.tbOpenTest.Click += new System.EventHandler( this.OpenTest );
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size( 553, 464 );
			this.Controls.Add( this.tbOpenTest );
			this.Controls.Add( this.btTestDelete );
			this.Controls.Add( this.btTestEdit );
			this.Controls.Add( this.btTestAdd );
			this.Controls.Add( this.btTestSave );
			this.Controls.Add( this.gbQuestionList );
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Редактор тестов";
			this.TransparencyKey = System.Drawing.Color.Gray;
			this.gbQuestionList.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.GroupBox gbQuestionList;
		private System.Windows.Forms.Button btTestSave;
		private System.Windows.Forms.Button btTestAdd;
		private System.Windows.Forms.Button btTestEdit;
		private System.Windows.Forms.Button btTestDelete;
		private System.Windows.Forms.ListBox lbMain;
		private System.Windows.Forms.Button tbOpenTest;




	}
}

