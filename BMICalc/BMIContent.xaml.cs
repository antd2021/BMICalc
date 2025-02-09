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

        string classification = "";
        if (choice == "Male")
        {
            if (bmi < 18.5) classification = "Underweight";
            else if (bmi < 25) classification = "Normal weight";
            else if (bmi < 30) classification = "Overweight";
            else classification = "Obese";
        }
        else if (classification == "Female")
        {
            if (bmi < 18) classification = "Underweight";
            else if (bmi < 24) classification = "Normal weight";
            else if (bmi < 29) classification = "Overweight";
            else classification = "Obese";
        }

        string instruction = "";
        if (classification == "Underweight")
            { instruction = "Increase calorie intake with nutrient-Rich foods (e.g., lean rotien, whole grains). Incorprate strength training to build muscle mass. Consult a nutritionist if needed"; }
        else if (classification == "Normal weight")
            { instruction = "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health."; }
        else if (classification == "Overweight")
        { instruction = "Reduce provessed foods and focuse on portion control. Engage in regular aerobic exercises (e.g. jogging, swimming) and strength training. Drink plenty of water and track your progress"; }
        else
        { instruction = "Consult a doctor for personalized guidance. Start with low impact excersizes (e.g. walking, cycling). Follow a structured weight loss meal plan and consider behavioral thereapy for lifestyle changes Avoid sugary drinks and maintain a consistent sleep scedule"; }
        DisplayAlert("BMI Result", $"Your BMI is {bmi:F2} \n Health Status: {classification} \n Recommendations: {instruction}" ,"OK");
    }
}