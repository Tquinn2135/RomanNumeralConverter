using Roman;


namespace RomanNumeralConverter;

public partial class MainPage : ContentPage
{
    private Converter _converter;

    public MainPage()
    {
        InitializeComponent();
        _converter = new Converter();
    }


    private void Convert_OnClicked(object sender, EventArgs e)
    {
        if (int.TryParse(TxtEntry.Text, out int number) && number >= 1)
        {
            string romanNumeral = _converter.NumberToRoman(number);
            lblRoman.Text = romanNumeral;
        }
        else
        {
            lblRoman.Text = "Invalid Entry. Please Try Again!";
        }
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        TxtEntry.Text = "";
        lblRoman.Text = "";
    }
}