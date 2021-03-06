﻿using System.Collections.Generic;
using System.ComponentModel;
using XAF.Command;

namespace XAF.UI
{
    public interface IViewModel : INotifyPropertyChanged
    {

        void RegisterViewModelDescriptor(IViewModelDescriptor viewModelDescriptor);

        void RegisterViewModelDescriptors(IList<IViewModelDescriptor> viewModelDescriptors);

        T CreateViewModel<T>() where T : IViewModel;
    }
}