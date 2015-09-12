﻿using MVVMSidekick.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TableGame_Sidekick.Models
{
    
    public class Game<TContext> : BindableBase<Game<TContext>>, IGameModel<TContext>
    {

        public TContext GameExecutingContext
        {
            get { return _GameExecutingContextLocator(this).Value; }
            set { _GameExecutingContextLocator(this).SetValueAndTryNotify(value); }
        }
        #region Property TContext GameExecutingContext Setup        
        protected Property<TContext> _GameExecutingContext = new Property<TContext> { LocatorFunc = _GameExecutingContextLocator };
        static Func<BindableBase, ValueContainer<TContext>> _GameExecutingContextLocator = RegisterContainerLocator<TContext>("GameExecutingContext", model => model.Initialize("GameExecutingContext", ref model._GameExecutingContext, ref _GameExecutingContextLocator, _GameExecutingContextDefaultValueFactory));
        static Func<TContext> _GameExecutingContextDefaultValueFactory = () => default(TContext);
        #endregion


        /// <summary>
        /// 游戏名 Game Name
        /// </summary>
        public string Name
        {
            get { return _NameLocator(this).Value; }
            set { _NameLocator(this).SetValueAndTryNotify(value); }
        }
        #region Property string Name Setup        
        protected Property<string> _Name = new Property<string> { LocatorFunc = _NameLocator };
        static Func<BindableBase, ValueContainer<string>> _NameLocator = RegisterContainerLocator<string>("Name", model => model.Initialize("Name", ref model._Name, ref _NameLocator, _NameDefaultValueFactory));
        static Func<string> _NameDefaultValueFactory = () => default(string);
        #endregion
        
        /// <summary>
        /// 游戏说明 Game Description
        /// </summary>
        public string Description
        {
            get { return _MyPropertyLocator(this).Value; }
            set { _MyPropertyLocator(this).SetValueAndTryNotify(value); }
        }
        #region Property string MyProperty Setup        
        protected Property<string> _MyProperty = new Property<string> { LocatorFunc = _MyPropertyLocator };
        static Func<BindableBase, ValueContainer<string>> _MyPropertyLocator = RegisterContainerLocator<string>("MyProperty", model => model.Initialize("MyProperty", ref model._MyProperty, ref _MyPropertyLocator, _MyPropertyDefaultValueFactory));
        static Func<string> _MyPropertyDefaultValueFactory = () => default(string);
        #endregion


        /// <summary>
        /// 游戏开始状态  Start State/Scence of Game
        /// </summary>
        public GameState<TContext> StartState
        {
            get { return _StartStateLocator(this).Value; }
            set { _StartStateLocator(this).SetValueAndTryNotify(value); }
        }
        #region Property GameState<TContext> StartState Setup        
        protected Property<GameState<TContext>> _StartState = new Property<GameState<TContext>> { LocatorFunc = _StartStateLocator };
        static Func<BindableBase, ValueContainer<GameState<TContext>>> _StartStateLocator = RegisterContainerLocator<GameState<TContext>>("StartState", model => model.Initialize("StartState", ref model._StartState, ref _StartStateLocator, _StartStateDefaultValueFactory));
        static Func<GameState<TContext>> _StartStateDefaultValueFactory = () => default(GameState<TContext>);
        #endregion


        /// <summary>
        /// 游戏当前状态 Current State/Scence  of Game
        /// </summary>
        public GameState<TContext> CurrentState
        {
            get { return _CurrentStateLocator(this).Value; }
            set { _CurrentStateLocator(this).SetValueAndTryNotify(value); }
        }
        #region Property GameState<TContext> CurrentState Setup        
        protected Property<GameState<TContext>> _CurrentState = new Property<GameState<TContext>> { LocatorFunc = _CurrentStateLocator };
        static Func<BindableBase, ValueContainer<GameState<TContext>>> _CurrentStateLocator = RegisterContainerLocator<GameState<TContext>>("CurrentState", model => model.Initialize("CurrentState", ref model._CurrentState, ref _CurrentStateLocator, _CurrentStateDefaultValueFactory));
        static Func<GameState<TContext>> _CurrentStateDefaultValueFactory = () => default(GameState<TContext>);
        #endregion


        /// <summary>
        /// 游戏结束状态 End State/Scence  of Game
        /// </summary>
        public IDictionary<string, GameState<TContext>> EndStates
        {
            get { return _EndStatesLocator(this).Value; }
            set { _EndStatesLocator(this).SetValueAndTryNotify(value); }
        }
        #region Property IDictionary<string, GameState<TContext>>  EndStates Setup        
        protected Property<IDictionary<string, GameState<TContext>>> _EndStates = new Property<IDictionary<string, GameState<TContext>>> { LocatorFunc = _EndStatesLocator };
        static Func<BindableBase, ValueContainer<IDictionary<string, GameState<TContext>>>> _EndStatesLocator = RegisterContainerLocator<IDictionary<string, GameState<TContext>>>("EndStates", model => model.Initialize("EndStates", ref model._EndStates, ref _EndStatesLocator, _EndStatesDefaultValueFactory));
        static Func<IDictionary<string, GameState<TContext>>> _EndStatesDefaultValueFactory = () => default(IDictionary<string, GameState<TContext>>);
        #endregion



        /// <summary>
        /// 所有状态 All States
        /// </summary>
        public IDictionary<string, GameState<TContext>> AllStates
        {
            get { return _AllStatesLocator(this).Value; }
            set { _AllStatesLocator(this).SetValueAndTryNotify(value); }
        }
        #region Property IDictionary<string, GameState<TContext>> AllStates Setup        
        protected Property<IDictionary<string, GameState<TContext>>> _AllStates = new Property<IDictionary<string, GameState<TContext>>> { LocatorFunc = _AllStatesLocator };
        static Func<BindableBase, ValueContainer<IDictionary<string, GameState<TContext>>>> _AllStatesLocator = RegisterContainerLocator<IDictionary<string, GameState<TContext>>>("AllStates", model => model.Initialize("AllStates", ref model._AllStates, ref _AllStatesLocator, _AllStatesDefaultValueFactory));
        static Func<IDictionary<string, GameState<TContext>>> _AllStatesDefaultValueFactory = () => default(IDictionary<string, GameState<TContext>>);
        #endregion


    }
}
