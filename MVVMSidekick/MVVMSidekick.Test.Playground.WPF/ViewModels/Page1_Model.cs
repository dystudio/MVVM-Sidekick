﻿using System.Reactive;
using System.Reactive.Linq;
using MVVMSidekick.ViewModels;
using MVVMSidekick.Views;
using MVVMSidekick.Reactive;
using MVVMSidekick.Services;
using MVVMSidekick.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace MVVMSidekick.Test.Playground.WPF.ViewModels
{

    public class Page1_Model : ViewModel<Page1_Model>
    {
        // If you have install the code sniplets, use "propvm + [tab] +[tab]" create a property propcmd for command
        // 如果您已经安装了 MVVMSidekick 代码片段，请用 propvm +tab +tab 输入属性 propcmd 输入命令

        public Page1_Model()
        {
            if (IsInDesignMode)
            {

            }

        }


        //propvm tab tab string tab Title




        public CommandModel CommandNext
        {
            get => _CommandNextLocator(this).Value;
            set => _CommandNextLocator(this).SetValueAndTryNotify(value);
        }
        #region Property CommandModel CommandNext Setup        

        protected Property<CommandModel> _CommandNext = new Property<CommandModel>(_CommandNextLocator);
        static Func<BindableBase, ValueContainer<CommandModel>> _CommandNextLocator = RegisterContainerLocator(nameof(CommandNext), (model, n) => model.Initialize(n, ref model._CommandNext, ref _CommandNextLocator, _CommandNextDefaultValueFactory));
        static Func<BindableBase, CommandModel> _CommandNextDefaultValueFactory =
            model =>
            {
                var state = default (object);           // Command state  
                var commandId = nameof(CommandNext);
                var vm = CastToCurrentType(model);
                var cmd = new ReactiveCommand(canExecute: true) { ViewModel = model }; //New Command Core

                cmd.DoExecuteUIBusyTask(
                        vm,
                        async e =>
                        {
                            var v = vm.StageManager.DefaultStage.Show<Page1_Model>();
                            await Task.Yield();
                        })
                    .DoNotifyDefaultEventRouter(vm, commandId)
                    .Subscribe()
                    .DisposeWith(vm);

                var cmdmdl = cmd.CreateCommandModel(state);

                cmdmdl.ListenToIsUIBusy(
                    model: vm,
                    canExecuteWhenBusy: false);
                return cmdmdl;
            };

        #endregion

    }

}

