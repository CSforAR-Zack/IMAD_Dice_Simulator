namespace IMAD_Dice_Simulator;

public partial class MainPage : ContentPage
{
	Random rand = new Random();
    List<string> dice = SetupDice();

	public MainPage()
	{
		InitializeComponent();
    }

    static List<string> SetupDice()
    {
        List<string> list = new List<string>();
        list.Add("one.png");
        list.Add("two.png");
        list.Add("three.png");
        list.Add("four.png");
        list.Add("five.png");
        list.Add("six.png");
        return list;
    }

    void RollDice(object sender, EventArgs args)
    {
		int leftNum = rand.Next(0, 6);
        int rightNum = rand.Next(0, 6);

        leftDice.Source = dice[leftNum];
        rightDice.Source = dice[rightNum];
    }
}

