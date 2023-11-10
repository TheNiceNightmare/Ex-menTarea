namespace ToDoListApp;

public partial class AddTasks : ContentPage
{
  public Tasks NuevaTarea { get; set; }
  public AddTasks()
  {
    InitializeComponent();
    NuevaTarea = new Tasks();
    BindingContext = this;
  }

  private void ConfirmarBtn_Clicked(object sender, EventArgs e)
  {
    MessagingCenter.Send(this, "AgregarTarea", NuevaTarea);
    Navigation.PopAsync();
  }
}
