using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuestionsLibrary;
using System.Threading;
using System.IO;

namespace Game
{
	public partial class TestWindow : Form
	{
		private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
		private List<Question> _questionsList;
		private int _countCorrectAnswers = 0;
		private int _questionCount = 30;
		private int _secondsLeft = 45;
		private bool _fiftyByFiftyIsUsed;

		public double Result { get; private set; }
		public bool TestIsOver { get; private set; }

		public TestWindow( string pathToTest )
		{
			InitializeComponent();

			if ( !File.Exists( pathToTest ) )
			{
				throw new ArgumentException( "Тест не найден!" );
			}

			try
			{
				Question[] questionsArray = QuestionsConnector.ReadQuestions( pathToTest );
				_questionsList = questionsArray.ToList<Question>();
			}
			catch( Exception )
			{
				throw new FileLoadException( "Не удалось открыть тест!" );
			}

			StartTest();
		}

		private void StartTest()
		{
			var timer = new System.Windows.Forms.Timer();
			timer.Interval = 1000;
			timer.Tick += OneTickOfTimer;
			
			SetQuestion();
			timer.Start();
		}

		private void SetQuestion()
		{
			Random randIndex = new Random( Environment.TickCount );
			int index = randIndex.Next( 0, _questionsList.Count );
			Answer[] answers = _questionsList[ index ].Answers;

			//устанавливаем вопрос по индексу
			tbQuestion.Text = _questionsList[ index ].QuestionText;
			//устанавливаем ответы
			SetAnswers( answers );
			//устанавливаем подсказки
			btCallBill.Tag = _questionsList[ index ].CallFriend;
			btStack.Tag = _questionsList[ index ].HelpPublic;
			//удаляем заданный вопрос из списка
			_questionsList.Remove( _questionsList[ index ] );
		}

		private void OneTickOfTimer( object sender, EventArgs e )
		{
			if ( _secondsLeft != 0 )
			{
				_secondsLeft --;
				lbTimer.Text = "00:" + string.Format( "{0:D2}", _secondsLeft );
			}
			else
			{
				Result = ( double )( _countCorrectAnswers * 100 ) / ( double )_questionCount;
				FinishTest();
			}
		}

		private void AnswerOnQuestion( object sender, EventArgs e )
		{
			Button button = sender as Button;
			bool answerIsRight = ( bool )button.Tag;

			if ( answerIsRight )
			{
				//останавливаем таймер
				timer.Stop();
				//устанавливаем начальное значение времени
				_secondsLeft = 45;
				
				Color oldColor = button.BackColor;
				button.BackColor = Color.Chartreuse;
				
				this.Refresh();
				Thread.Sleep( 1000 );

				//возвращаем всё как было
				button.BackColor = oldColor;
				button.UseVisualStyleBackColor = true;

				SetNextQuestion();
			}
			else
			{
				timer.Stop();
				button.BackColor = Color.Red;
				Result = (double)(_countCorrectAnswers * 100)/(double)_questionCount;
				//обновляем форму
				this.Refresh();
				Thread.Sleep( 1000 );
				FinishTest();
			}
		}

		private void ShowHelp( object sender, EventArgs e )
		{
			Button senderButton = (Button)sender;

			Help helpDialog = new Help( senderButton.Text, (string)senderButton.Tag );
			helpDialog.ShowDialog();

			senderButton.Enabled = false;
		}

		private void FiftyByFiftyHelp( object sender, EventArgs e )
		{
			List<Button> buttons = new List<Button>();
			buttons.Add( btAnswerA );
			buttons.Add( btAnswerB );
			buttons.Add( btAnswerC );
			buttons.Add( btAnswerD );

			int disabled = 0;
			Random randNumber = new Random( Environment.TickCount );

			while ( disabled != 2 )
			{
				int index = randNumber.Next( 0, buttons.Count );

				if ( !( bool )buttons[ index ].Tag )
				{
					buttons[ index ].Enabled = false;
					disabled ++;
					buttons.Remove( buttons[ index ] );
				}
			}

			bt50.Enabled = false;
			_fiftyByFiftyIsUsed = true;
		}

		private void EnableAllButton()
		{
			btAnswerA.Enabled = true;
			btAnswerB.Enabled = true;
			btAnswerC.Enabled = true;
			btAnswerD.Enabled = true;
		}

		private void SetAnswers( Answer[] answers )
		{
			List<Answer> answersList = answers.ToList<Answer>();
			Random randNumber = new Random( Environment.TickCount );
			int index = 0;
			
			index = randNumber.Next( 0, answersList.Count );
			btAnswerA.Text = answersList[ index ].AnswerText;
			btAnswerA.Tag = answersList[ index ].IsTrue;
			answersList.Remove( answersList[ index ] );

			index = randNumber.Next( 0, answersList.Count );
			btAnswerB.Text = answersList[ index ].AnswerText;
			btAnswerB.Tag = answersList[ index ].IsTrue;
			answersList.Remove( answersList[ index ] );

			index = randNumber.Next( 0, answersList.Count );
			btAnswerC.Text = answersList[ index ].AnswerText;
			btAnswerC.Tag = answersList[ index ].IsTrue;
			answersList.Remove( answersList[ index ] );

			btAnswerD.Text = answersList[ 0 ].AnswerText;
			btAnswerD.Tag = answersList[ 0 ].IsTrue;
		}

		private void SetNextQuestion()
		{
			if ( _fiftyByFiftyIsUsed )
			{
				EnableAllButton();
				_fiftyByFiftyIsUsed = false;
			}

			_countCorrectAnswers++;
			lbProgress.Text = _countCorrectAnswers.ToString() + " / 30";

			if ( _countCorrectAnswers == _questionCount )
			{
				Result = ( double )( _countCorrectAnswers * 100 ) / ( double )_questionCount;
				FinishTest();
			}

			SetQuestion();
			timer.Start();
		}

		private void FinishTest()
		{
			TestIsOver = true;
			this.Close();
		}
	}
}
