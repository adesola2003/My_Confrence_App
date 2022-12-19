using My_Confrence_App.ViewModels;

namespace My_Confrence_App.Pages;



[QueryProperty(nameof(Day), nameof(Day))]
public partial class SchedulePage : ContentPage
{
	readonly ScheduleViewModel vm;
	public static int Day { get; set; }

    public SchedulePage(ScheduleViewModel vm)
	{
		InitializeComponent();

		Day++;
		vm.Day = Day;


		BindingContext = this.vm = vm;
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();

        if (vm.Schedule.Count == 0)
            await vm.LoadDataCommand.ExecuteAsync(null);
    }
	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);


		
	}
}