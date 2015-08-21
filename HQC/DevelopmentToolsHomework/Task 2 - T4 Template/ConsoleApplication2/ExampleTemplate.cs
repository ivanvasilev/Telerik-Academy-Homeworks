
public class T4ExampleClass
{
	// I make 4 different players, as each player has private field and public property
	 
	private string player1;
	 
	private string player2;
	 
	private string player3;
	 
	private string player4;
	
	 
	public string Player1
	{
		private set
		{
			this.player1 = value;
		}
		
		get
		{
			return this.player1;
		}
	}
	 
	public string Player2
	{
		private set
		{
			this.player2 = value;
		}
		
		get
		{
			return this.player2;
		}
	}
	 
	public string Player3
	{
		private set
		{
			this.player3 = value;
		}
		
		get
		{
			return this.player3;
		}
	}
	 
	public string Player4
	{
		private set
		{
			this.player4 = value;
		}
		
		get
		{
			return this.player4;
		}
	}
	}