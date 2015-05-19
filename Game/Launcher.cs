using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using PlayersConnector;

namespace Game
{
	public partial class Launcher : Form
	{
		private Player currentPlayer = new Player();
		private RecordTable _table = null;

		private string _cppTestName = @"Тесты\cpp.test";
		private string _csTestName = @"Тесты\cs.test";
		private string _cTestName = @"Тесты\pureC.test";
		private string _programmerTestName = @"Тесты\programmer.test";
		private string _path;
		

		public Launcher()
		{
			InitializeComponent();

			//получение пути к текущей сборке
			Assembly current = Assembly.GetExecutingAssembly();
			string pathToExe = new Uri( current.EscapedCodeBase ).LocalPath;
			_path = Path.GetDirectoryName( pathToExe );
		}
		
		private void NewGame( object sender, EventArgs e )
		{
			try
			{
				this.Visible = false;

				string pathToTest = null;
				Switcher dialog = new Switcher();

				if ( dialog.ShowDialog() == DialogResult.OK )
				{
					ProgrammingLanguage choosedCategory = dialog.Category;
					currentPlayer.Category = dialog.Category;

					switch ( choosedCategory )
					{
						case ProgrammingLanguage.CPP:
							pathToTest = Path.Combine( _path, _cppTestName );
							break;

						case ProgrammingLanguage.CSharp:
							pathToTest = Path.Combine( _path, _csTestName );
							break;

						case ProgrammingLanguage.C:
							pathToTest = Path.Combine( _path, _cTestName );
							break;

						case ProgrammingLanguage.SuperProger:
							pathToTest = Path.Combine( _path, _programmerTestName );
							break;
					}

					TestWindow test = new TestWindow( pathToTest );
					test.ShowDialog();

					if ( test.TestIsOver )
					{
						ShowCongratulations( test.Result );
						SaveResultDialog( test.Result );
					}
				}

				this.Visible = true;
			}
			catch ( ArgumentException exc )
			{
				MessageBox.Show( exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.Visible = true;
			}
			catch ( FileLoadException exc )
			{
				MessageBox.Show( exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.Visible = true;
			}
			catch ( Exception exc )
			{
				MessageBox.Show( exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.Visible = true;
			}
		}

		private void ShowRecordTable( object sender, EventArgs e )
		{
			try
			{
				this.Visible = false;

				if ( _table == null )
				{
					_table = new RecordTable( _path );
				}

				_table.ShowDialog();

				this.Visible = true;
			}
			catch ( ArgumentNullException exc )
			{
				MessageBox.Show( exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.Visible = true;
			}
			catch ( Exception exc )
			{
				MessageBox.Show( exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.Visible = true;
			}
		}
		
		private void Exit( object sender, EventArgs e )
		{
			this.Close();
		}

		private void ClosingHandler( object sender, FormClosingEventArgs e )
		{
			if ( _table != null )
			{
				try
				{
					_table.SaveChanges();
				}
				catch ( ArgumentNullException exc )
				{
					MessageBox.Show( exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error );
					Environment.Exit( -1 );
				}
			}
		}

		private void ShowCongratulations( double resultInPercent )
		{
			if ( resultInPercent >= 0 && resultInPercent < 25 )
			{
				MessageBox.Show(
									string.Format( "Ваш результат - {0:F2}%\n", resultInPercent ) +
									"Возможно, ища себя вы пару раз свернули не туда.",
									"Результат",
									MessageBoxButtons.OK,
									MessageBoxIcon.Asterisk
							   );
			}
			else if ( resultInPercent >= 25 && resultInPercent < 50 )
			{
				MessageBox.Show(
									string.Format( "Ваш результат - {0:F2}%\n", resultInPercent ) +
									"Иногда ваш код компилируется.\n Иногда он после этого даже работает правильно.\n" +
									"Но вам стоит больше работать над собой.",
									"Результат",
									MessageBoxButtons.OK,
									MessageBoxIcon.Asterisk
							   );
			}
			else if ( resultInPercent >= 50 && resultInPercent < 75 )
			{
				MessageBox.Show(
									string.Format( "Ваш результат - {0:F2}%\n", resultInPercent ) +
									"Вы идёте к успеху - удачной вам дороги.",
									"Результат",
									MessageBoxButtons.OK,
									MessageBoxIcon.Asterisk
							   );
			}
			else if ( resultInPercent >= 75 && resultInPercent < 100 )
			{
				MessageBox.Show(
									string.Format( "Ваш результат - {0:F2}%\n", resultInPercent ) +
									"Вы восхитительны.",
									"Результат",
									MessageBoxButtons.OK,
									MessageBoxIcon.Asterisk
							   );
			}
			else if ( resultInPercent == 100 )
			{
				MessageBox.Show(
									string.Format( "Ваш результат - {0:F2}%\n", resultInPercent ) +
									"Кто-нибудь - уберите Торвальдса от компьютера.",
									"Результат",
									MessageBoxButtons.OK,
									MessageBoxIcon.Asterisk
							   );
			}
		}
		
		private void SaveResultDialog( double resultInPercent )
		{
			currentPlayer.ResultInPercent = resultInPercent;
			
			Authorization authorization = new Authorization( currentPlayer.Category, currentPlayer.ResultInPercent );
			authorization.ShowDialog();

			if ( authorization.NameHonestSaved )
			{
				currentPlayer.Name = authorization.PlayerName;
			}
			else
			{
				currentPlayer.Name = "Нечестный игрок";
			}

			currentPlayer.FinishedTime = DateTime.Now;
			currentPlayer.MachineName = Environment.MachineName;

			if ( _table != null )
			{
				_table.Add( currentPlayer );
			}
			else if( _table == null )
			{
				_table = new RecordTable( _path );
				_table.Add( currentPlayer );
			}	
		}
	}	
}
