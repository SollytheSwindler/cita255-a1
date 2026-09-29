namespace CITA255_Assignment_01
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CounterEntry.Text))
            {
                HoursAndMinutes.Text = "Type Any Number";
                return;
            }
            int hours = (int)double.Parse(CounterEntry.Text) * 24;
            int minutes = hours * 60;
            HoursAndMinutes.Text = CounterEntry.Text + "Days, " + hours + "Hours, " + minutes + "Minutes.";
        }
    }
}
