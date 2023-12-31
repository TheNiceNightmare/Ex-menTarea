using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public ObservableCollection<Tasks> Tareas { get; set; } = new ObservableCollection<Tasks>();

        public MainPage()
        {
            InitializeComponent();
            CreateOneTask();
         MessagingCenter.Subscribe<AddTasks, Tasks>(this, "AddTask", (sender, tarea) =>
         {
            Tareas.Add(tarea);
         });
           BindingContext = this;
        }

        private void CreateOneTask()
        {
            var MiTarea = new Tasks()
            {
                TaskName = "Comprar Pan",
                Status = "Pendiente",
                ColorText = "Blue"
            };

            Tareas.Add(MiTarea);
        }
        private void AddBtn_Clicked(object sender, EventArgs e)
        {

         Navigation.PushAsync(new AddTasks());



           /*Tareas.Add(new Tasks()
            {
                TaskName = "Estudiar",
                Status = "Pendiente",
                ColorText = "Blue"
            });*/
        }
    }
}
