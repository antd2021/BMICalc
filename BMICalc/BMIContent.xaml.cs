namespace BMICalc;

public partial class BMIContent : ContentPage
{
	public BMIContent()
	{
		InitializeComponent();
	}

    string choice = "Male";

    private void TapMale_Tapped(object sender, EventArgs e)
    {
        choice = "Male";
        FrameMale.BorderColor = Color.FromArgb("#0a0e29");
        FrameFemale.BorderColor = Color.FromArgb("#fdfdfd");
    }

    private void TapFemale_Tapped(object sender, EventArgs e)
    {
        choice = "Female";
        FrameFemale.BorderColor = Color.FromArgb("0a0e29");
        FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
    }

    private void Btn_Clicked(object sender, EventArgs e)
    {
        double heightInInches = sliderHeight.Value;
        double weightInLbs = sliderWeight.Value;

        double bmi = (weightInLbs * 703) / (heightInInches * heightInInches);

        Navigation.PushAsync(new ResultsPage(choice, bmi));
    }
}