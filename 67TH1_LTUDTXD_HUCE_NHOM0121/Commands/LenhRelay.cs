  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _67TH1_LTUDTXD_HUCE_NHOM0121.Commands
{
    class LenhRelay : ICommand
    {
        private readonly Action<object> _thucThi;
        private readonly Predicate<object> _coTheThucThi;

        public LenhRelay(Action<object> thucThi, Predicate<object> coTheThucThi = null)
        {
            _thucThi = thucThi ?? throw new ArgumentNullException(nameof(thucThi));
            _coTheThucThi = coTheThucThi;
        }

        public bool CanExecute(object parameter) => _coTheThucThi == null || _coTheThucThi(parameter);

        public void Execute(object parameter) => _thucThi(parameter);

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public void RaiseCanExecuteChanged() => CommandManager.InvalidateRequerySuggested();
    }
}

