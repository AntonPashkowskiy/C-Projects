using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuestionsLibrary;

namespace TestEditor
{
	public partial class AddQuestionForm : Form
	{
		public const int AnswerCount = 4;

		private List<Question> _questionsList = new List<Question>();
		private List<string> _headersList = new List<string>();
		private int _currentPosition = 0;
		private bool _questionIsChanged;
		private bool _questionsAreAdded;

		public AddQuestionForm()
		{
			InitializeComponent();
			SetStandartTuning();
			//устанавливаем счётчик
			lbEnumerate.Text = ( _questionsList.Count ).ToString() + "  /  " + "30";
		}
		
		private void NextButtonClick( object sender, EventArgs e )
		{
			SaveQuestionDialog();

			_currentPosition ++;
			SetText( _currentPosition ); 
		}
		
		private void PrevButtonClick( object sender, EventArgs e )
		{
			SaveQuestionDialog();

			_currentPosition --;

			if ( _currentPosition == 0 )
			{
				btPrev.Enabled = false;
			}

			SetText( _currentPosition );
		}

		private void EnteringData( object sender, EventArgs e )
		{
			//изменили текущую форму
			_questionIsChanged = true;

			bool flag = CheckTextBoxes();
			btNext.Enabled = flag;

			if ( _currentPosition > 0 )
			{
				btPrev.Enabled = flag;
			}		
		}

		private bool CheckTextBoxes()
		{
			bool flag = true;

			Control.ControlCollection controls = this.Controls;

			foreach ( var item in controls )
			{
				GroupBox groupBoxes = item as GroupBox;

				if ( groupBoxes != null )
				{
					Control.ControlCollection childs = groupBoxes.Controls;

					foreach ( var temp in childs )
					{
						TextBox textControl = temp as TextBox;

						if ( textControl != null )
						{
							if ( String.IsNullOrEmpty( textControl.Text ) ||
								 String.IsNullOrWhiteSpace( textControl.Text )
							   )
							{
								flag = false;
							}
						}
					}
				}
			}

			return flag;
		}

		private void SaveQuestion( int questionNumber )
		{
			if ( questionNumber > _questionsList.Count )
			{
				throw new ArgumentException();
			}

			if ( !CheckTextBoxes() )
			{
				return;
			}

			Answer[] answers = new Answer[ AnswerCount ];

			answers[ 0 ].AnswerText = tbA.Text;
			answers[ 0 ].IsTrue = ( rbA.Checked )? true : false;

			answers[ 1 ].AnswerText = tbB.Text;
			answers[ 1 ].IsTrue = ( rbB.Checked ) ? true : false;

			answers[ 2 ].AnswerText = tbC.Text;
			answers[ 2 ].IsTrue = ( rbC.Checked ) ? true : false;

			answers[ 3 ].AnswerText = tbD.Text;
			answers[ 3 ].IsTrue = ( rbD.Checked ) ? true : false;
			
			string questionText = tbQuestion.Text;
			
			Question addingQuestion = new Question( questionText, answers );
			addingQuestion.CallFriend = tbCalling.Text;
			addingQuestion.FiftyByFifty = tb50.Text;
			addingQuestion.HelpPublic = tbHelp.Text;

			if ( questionNumber == _questionsList.Count )
			{
				_questionsList.Add( addingQuestion );
				_headersList.Add( tbHeader.Text );
			}
			else
			{
				_questionsList[ questionNumber ] = addingQuestion;
				_headersList[ questionNumber ] = tbHeader.Text;
			}

			//поскольку изменения сохранены - убираем признак того что форма изменена
			_questionIsChanged = false;
			//разрешение добавления вопросов только при достаточном их количестве
			if ( _questionsList.Count > MainForm.MaxQuestionCount )
			{
				btAdd.Enabled = true;
			}
			//перерисовываем надпись
			lbEnumerate.Text = ( _questionsList.Count ).ToString() + "  /  " + "30";
		}

		private void SaveQuestionDialog()
		{
			if ( _currentPosition < _questionsList.Count && _questionIsChanged )
			{
				DialogResult result = MessageBox.Show( "Вы хотите сохранить изменения?",
														"Сохранение",
														 MessageBoxButtons.OKCancel,
														 MessageBoxIcon.Question
													 );
				if ( result == DialogResult.OK )
				{
					SaveQuestion( _currentPosition );
				}
				else
				{
					_questionIsChanged = false;
				}
			}
			else if ( _currentPosition == _questionsList.Count )
			{
				SaveQuestion( _currentPosition );
			}
		}

		private void SetText( int questionNumber )
		{
			if ( questionNumber >= _questionsList.Count )
			{
				SetStandartTuning();
			}
			else
			{
				tbHeader.Text = _headersList[ questionNumber ];
				tbQuestion.Text = _questionsList[ questionNumber ].QuestionText;
				Answer[] answers = _questionsList[ questionNumber ].GetAnswers();

				tbA.Text = answers[ 0 ].AnswerText;
				rbA.Checked = answers[ 0 ].IsTrue;

				tbB.Text = answers[ 1 ].AnswerText;
				rbB.Checked = answers[ 1 ].IsTrue;

				tbC.Text = answers[ 2 ].AnswerText;
				rbC.Checked = answers[ 2 ].IsTrue;

				tbD.Text = answers[ 3 ].AnswerText;
				rbD.Checked = answers[ 3 ].IsTrue;

				tb50.Text = _questionsList[ questionNumber ].FiftyByFifty;
				tbCalling.Text = _questionsList[ questionNumber ].CallFriend;
				tbHelp.Text = _questionsList[ questionNumber ].HelpPublic;

				//просто установили текст ничего не меняя
				_questionIsChanged = false;
				//поскольку мы находимся на заполненой форме - кнопка далее разрешена
				//кнопка Назад разрешена только если мы не на первой форме
				btNext.Enabled = true;
				if ( _currentPosition > 0 )
				{
					btPrev.Enabled = true;
				}
			}
		}

		private void SetStandartTuning()
		{
			tbHeader.Text = "";
			tbQuestion.Text = "";
			tbA.Text = "";
			tbB.Text = "";
			tbC.Text = "";
			tbD.Text = "";
			tb50.Text = "";
			tbHelp.Text = "";
			tbCalling.Text = "";

			btAdd.Enabled =  ( _questionsList.Count >= MainForm.MaxQuestionCount )? true : false;
			btPrev.Enabled = ( _currentPosition > 0 )? true : false;
			btNext.Enabled = false;
		}

		

		private void ThrowValues()
		{
			_questionsList.Clear();
			_headersList.Clear();
			_currentPosition = 0;
			_questionIsChanged = false;
			lbEnumerate.Text = "0  /  30";
		}

		private void CancelButtonClick( object sender, EventArgs e )
		{
			if ( !_questionsAreAdded )
			{
				DeleteAllQuestion();
			}
		}

		private void AddQuestionClick( object sender, EventArgs e )
		{
			_questionsAreAdded = true;
		}
		
		public Question[] GetAllQuestion()
		{
			if ( _questionsList.Count >= MainForm.MaxQuestionCount )
			{
				return _questionsList.ToArray();
			}
			else
			{
				return null;
			}
		}

		public string[] GetAllHeaders()
		{
			if ( _questionsList.Count >= MainForm.MaxQuestionCount )
			{
				return _headersList.ToArray();
			}
			else
			{
				return null;
			}
		}

		public void DeleteAllQuestion()
		{
			ThrowValues();
			SetStandartTuning();
		}

		public void ReadAndSetTest( string pathToTest )
		{
			DeleteAllQuestion();

			Question[] questions = QuestionsConnector.ReadQuestions( pathToTest );

			if ( questions != null && questions.Length >= MainForm.MaxQuestionCount )
			{
				for ( int i = 0; i < questions.Length; i++ )
				{
					_questionsList.Add( questions[ i ] );
					_headersList.Add( "Header" );
				}

				SetText( 0 );

				btAdd.Enabled = true;
				lbEnumerate.Text = _questionsList.Count.ToString() + "  /  30";
			}
		}

	} 
}
