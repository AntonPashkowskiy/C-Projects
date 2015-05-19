using System;

namespace QuestionsLibrary
{
	
	/// <exception cref = "Exceptions">
	/// ArgumentNullException
	/// </exception>
	[Serializable]
	public struct Answer
	{	
		public string AnswerText;
		public bool IsTrue;
		
		public Answer( string text, bool isTrue )
		{
			if ( text == null )
			{
				throw new ArgumentNullException();
			}

			AnswerText = text;
			IsTrue = isTrue;
		}
	}

	/// <summary>
	/// Класс для операций с вопросами
	/// </summary>
	/// <exception cref = "Exception">
	/// ArgumentNullException
	/// ArgumentException
	/// </exception>
	[Serializable]
	public class Question : ICloneable
	{
		public const int AnswerCount = 4;

		private Answer[] _answers;
		
		public Answer[] Answers
		{
			get
			{
				Answer[] answers = new Answer[ AnswerCount ];
				_answers.CopyTo( answers, 0 );

				return answers;
			}
			set
			{
				if ( value == null ) throw new ArgumentNullException();
				if ( value.Length != AnswerCount ) throw new ArgumentException();

				_answers = new Answer[ AnswerCount ];
				value.CopyTo( _answers, 0 );
			}
		}

		public string CallFriend { get; set; }
		public string HelpPublic { get; set; }

		public string QuestionText { get; set; }

		public Question( string question, Answer[] arrayOfAnswers )
		{
			if ( question == null || arrayOfAnswers == null ) throw new ArgumentNullException();
			if( arrayOfAnswers.Length != AnswerCount ) throw new ArgumentException();

			QuestionText = question;
			Answers = arrayOfAnswers;
		}

		public object Clone()
		{
			Question temp = new Question( this.QuestionText, this.Answers );
			temp.CallFriend = this.CallFriend;
			temp.HelpPublic = this.HelpPublic;
			
			return temp;
		}
	}
}
