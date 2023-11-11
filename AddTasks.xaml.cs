namespace ToDoListApp;

public partial class AddTasks : ContentPage
{
  public Tasks NewTask { get; set; }
  public AddTasks()
  {
    InitializeComponent();
    NewTask = new Tasks();
    BindingContext = this;
  }

  private void ConfirmarBtn_Clicked(object sender, EventArgs e)
  {
    MessagingCenter.Send(this, "AddTask", NewTask);
    Navigation.PopAsync();
  }
}
