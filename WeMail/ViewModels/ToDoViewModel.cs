using MyToDo.Shared.Dtos;
using MyToDo.Shared.Parameters;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using WeMail.Service;

namespace WeMail.ViewModels
{
    public class ToDoViewModel : BindableBase
    {
        public ToDoViewModel(IToDoService service)
        {
            ToDoDtos = new ObservableCollection<ToDoDto>();
            this.service = service;
            AddCommand = new DelegateCommand(Add);
            CreateToDoList();
        }
        private readonly Service.IToDoService service;
        private bool isRightDrawerOpen;

        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { isRightDrawerOpen = value; RaisePropertyChanged(); }
        }

        private void Add()
        {
            IsRightDrawerOpen = true;
        }

        public DelegateCommand AddCommand { get; private set; }
        private ObservableCollection<ToDoDto> toDoDtos;

        public ObservableCollection<ToDoDto> ToDoDtos
        {
            get { return toDoDtos; }
            set { toDoDtos = value; }
        }

        async void CreateToDoList()
        {
            ToDoDtos.Clear();
            var todoResult = await service.GetAllAsync(new QueryParameter()
            {
                PageIndex = 0,
                PageSize = 100
            });
            if (todoResult.Status == 200)
            {
                ToDoDtos.Clear();
                foreach (var item in todoResult.Data.Items)
                {
                    ToDoDtos.Add(item);
                }
            }
        }

    }
}
