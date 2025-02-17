namespace BMICalc;

public partial class RecommendationsPage : ContentPage
{

    string instruction = "";
    public RecommendationsPage(string classification)
	{
		InitializeComponent();

        if (classification == "Underweight")
        { instruction = "Increase calorie intake with nutrient-Rich foods (e.g., lean rotien, whole grains). Incorprate strength training to build muscle mass. Consult a nutritionist if needed"; }
        else if (classification == "Normal weight")
        { instruction = "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health."; }
        else if (classification == "Overweight")
        { instruction = "Reduce provessed foods and focuse on portion control. Engage in regular aerobic exercises (e.g. jogging, swimming) and strength training. Drink plenty of water and track your progress"; }
        else
        { instruction = "Consult a doctor for personalized guidance. Start with low impact excersizes (e.g. walking, cycling). Follow a structured weight loss meal plan and consider behavioral thereapy for lifestyle changes Avoid sugary drinks and maintain a consistent sleep scedule"; }

        txtRecomendations.Text = $"Recommendations \n{instruction}";

    }

    private void BtnBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void BtnHome_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}