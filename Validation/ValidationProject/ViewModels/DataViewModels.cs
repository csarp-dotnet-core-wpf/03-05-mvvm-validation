using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationProject.Models;
using ViewModels.BaseClass;

namespace ValidationProject.ViewModels
{
    class DataViewModels : ViewModelBase
    {
        private Data data;

        public RelayCommand InsertCommand { get;  private set; }

        public DataViewModels()
        {
            data = new Data();
            InsertCommand = new RelayCommand(execute => Insert());
        }

        public string Name
        {
            get
            {
                return data.Name;
            }

            set
            {
                data.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Data
        {
            get
            {
                return data.ToString();
            }
        }

        public void Insert()
        {
            OnPropertyChanged(nameof(Data));
        }
    }
}
