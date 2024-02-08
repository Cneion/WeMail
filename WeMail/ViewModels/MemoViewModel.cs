using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using WeMail.Common.Models;

namespace WeMail.ViewModels
{
    public class MemoViewModel : BindableBase
    {
        public MemoViewModel()
        {
            MemoDtos = new ObservableCollection<MemoDto>();
            CreateToDoList();
            AddCommand = new DelegateCommand(Add);
        }

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
        private ObservableCollection<MemoDto> memoDtos;

        public ObservableCollection<MemoDto> MemoDtos
        {
            get { return memoDtos; }
            set { memoDtos = value; }
        }

        void CreateToDoList()
        {
            MemoDtos.Add(new MemoDto()
            {
                Title = "站岗",
                Content = "明天下午三点"
            });
            MemoDtos.Add(new MemoDto()
            {
                Title = "考科三",
                Content = "2.4号"
            });
        }

    }
}
