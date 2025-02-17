namespace BMICalc;

public partial class ResultsPage : ContentPage
{

    private string classification;
    public ResultsPage(string choice, double bmi)
	{
		InitializeComponent();

        if (choice == "Male")
        {
            if (bmi < 18.5) classification = "Underweight";
            else if (bmi < 25) classification = "Normal weight";
            else if (bmi < 30) classification = "Overweight";
            else classification = "Obese";
        }
        else if (choice == "Female")
        {
            if (bmi < 18) classification = "Underweight";
            else if (bmi < 24) classification = "Normal weight";
            else if (bmi < 29) classification = "Overweight";
            else classification = "Obese";
        }

        txtResults.Text = $"BMI: {bmi:F1}\nClassification: {classification}";
    }

    private void BtnBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void BtnNext_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RecommendationsPage(classification));
    }
}