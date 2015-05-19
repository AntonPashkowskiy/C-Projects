using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using QuestionsLibrary;

namespace TestEditor
{
	public partial class MainForm : Form
	{
		public const int MaxQuestionCount = 30;

		private delegate void AddInButton();
		private AddQuestionForm form = new AddQuestionForm();


		public MainForm()
		{
			InitializeComponent();
		}

		private void AddQuestion( object sender, EventArgs e )
		{
			AddQuestionDialog();
		}

		private void Edit( object sender, EventArgs e )
		{
			AddQuestionDialog();
		}

		private void AddQuestionDialog()
		{
			DialogResult result = form.ShowDialog();

			if ( result == DialogResult.OK )
			{
				IEnumerable<string> questionHeaders = form.GetAllHeaders();
				lbMain.Items.Clear();

				if ( questionHeaders != null )
				{
					foreach ( var header in questionHeaders )
					{
						lbMain.Items.Add( header );
					}
				}
			}
		}

		private void DeleteQuestion( object sender, EventArgs e )
		{
			DialogResult result = MessageBox.Show( "Вы действительно хотите удалить вопросы?", 
												   "Удаление",
												   MessageBoxButtons.OKCancel,
												   MessageBoxIcon.Question );
			if ( result == DialogResult.OK )
			{
				lbMain.Items.Clear();
				form.DeleteAllQuestion();
			}
		}

		private void SaveTest( object sender, EventArgs e )
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Файл с тестом (*.test)|*.test";
			dialog.FileName = "Безымянный";
			DialogResult result = dialog.ShowDialog();

			if ( result == DialogResult.OK )
			{
				string pathToFile = dialog.FileName;
				btTestDelete.Enabled = false;

				Thread saveThread = new Thread( Save );
				saveThread.Start( pathToFile );
			}
			
		}

		private void Save( object path )
		{
			AddInButton onDeleteButton = new AddInButton( OnDeleteButton );
			string pathToFile = (string)path;
			Question[] test = form.GetAllQuestion();
			
			if ( test != null )
			{
				QuestionsConnector.SetDirectoryPath( pathToFile );
				QuestionsConnector.WriteQuestions( test );
			}

			//по завершению сохранения включаем кнопку
			btTestDelete.Invoke( onDeleteButton );
		}

		private void OnDeleteButton()
		{
			btTestDelete.Enabled = true;
		}

		private void OpenTest( object sender, EventArgs e )
		{
			MessageBox.Show( "При открытии нового теста текущий удаляется.", "Warning", 
							  MessageBoxButtons.OK, 
							  MessageBoxIcon.Warning  
						   );

			OpenFileDialog openDialog = new OpenFileDialog();
			openDialog.Filter = "файлы с тестами(*.test)|*.test";
			DialogResult result = openDialog.ShowDialog();

			if ( result == DialogResult.OK )
			{ 
				try
				{
					form.ReadAndSetTest( openDialog.FileName );
				}
				catch ( Exception )
				{
					MessageBox.Show( "Не удалось открыть файл", "Error", 
									  MessageBoxButtons.OK, 
									  MessageBoxIcon.Error 
								   );
				}
			}
		}
	}
}
