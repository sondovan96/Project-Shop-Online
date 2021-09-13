using ProjectFinal.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProjectFinal.ViewModel
{
    public class ControlBarViewModel : BaseViewModel
    {
        #region commands
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand DragMoveWindowCommand { get; set; }



        #endregion
        public ControlBarViewModel()
        {
            CloseWindowCommand = new RelayCommand<ControlBarUC>((p) => { return p == null ? false : true; }, (p) => {
                FrameworkElement window = Window.GetWindow(p);
                var w = window as Window;
                if (w != null)
                {
                    Environment.Exit(0);
                }
            });
            MinimizeWindowCommand = new RelayCommand<ControlBarUC>((p) => { return p == null ? false : true; }, (p) => {
                FrameworkElement window = Window.GetWindow(p);
                var w = window as Window;
                if (w != null)
                {
                    w.WindowState = WindowState.Minimized;
                }
            });
            DragMoveWindowCommand = new RelayCommand<ControlBarUC>((p) => { return p == null ? false : true; }, (p) => {
                FrameworkElement window = Window.GetWindow(p);
                var w = window as Window;
                if (w != null)
                {
                    w.DragMove();
                }
            });
        }
    }
}
