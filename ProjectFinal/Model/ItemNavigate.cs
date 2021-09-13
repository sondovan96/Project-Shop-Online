using MaterialDesignThemes.Wpf;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectFinal.Enum.ALL_ENUM;

namespace ProjectFinal.Model
{
    public class ItemNavigate : BindableBase
    {
        private String _displayName;
        private ViewType _type;
        private PackIconKind _icon;
        private bool _isSelected;



        public PackIconKind Icon
        {
            get { return _icon; }
            set { _icon = value; OnPropertyChanged(); }
        }
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; OnPropertyChanged(); }
        }
        public ViewType Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged(); }
        }
        public String DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; OnPropertyChanged(); }
        }
    }
}
