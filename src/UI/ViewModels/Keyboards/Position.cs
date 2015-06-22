﻿using System;
using Microsoft.Practices.Prism.Mvvm;

namespace JuliusSweetland.OptiKey.UI.ViewModels.Keyboards
{
    public class Position : BindableBase, IKeyboard, IBackAction
    {
        private readonly Action backAction;

        public Position(Action backAction)
        {
            this.backAction = backAction;
        }

        public Action BackAction
        {
            get { return backAction; }
        }
    }
}