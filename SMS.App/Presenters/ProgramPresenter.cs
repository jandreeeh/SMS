using SMS.App.Views.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Presenters
{
    public class ProgramPresenter
    {
        private IProgramView _programView;

        public ProgramPresenter(IProgramView programView)
        {
            _programView = programView;

            _programView.CreateEvent += CreateEvent;
            _programView.ReadEvent += ReadEvent;
            _programView.UpdateEvent += UpdateEvent;
            _programView.DeleteEvent += DeleteEvent;
        }

        private void CreateEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ReadEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        private void UpdateEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void DeleteEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
