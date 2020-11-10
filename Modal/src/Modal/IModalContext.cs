﻿using System;
using System.Threading.Tasks;
using Skclusive.Core.Component;

namespace Skclusive.Material.Modal
{
    public interface IModalContext : IComponentContext
    {
        bool Open { get; }

        bool BackdropInvisible { get; }

        string BackdropClass { get; }

        string BackdropStyle { get; }

        Func<(IReference, bool), Task> OnEnter { get; }

        Func<IReference, Task> OnExited { get; }

        Action OnBackdropClick { get; }
    }

    public class ModalContextBuilder : ComponentContextBuilder<ModalContextBuilder, IModalContext>
    {
        public class ModalContext : ComponentContext, IModalContext
        {
            public bool Open { get; internal set; }

            public bool BackdropInvisible { get; internal set; }

            public string BackdropClass { get; internal set; }

            public string BackdropStyle  { get; internal set; }

            public Func<(IReference, bool), Task> OnEnter { get; internal set; }

            public Func<IReference, Task> OnExited { get; internal set; }

            public Action OnBackdropClick { get; internal set; }
        }

        protected ModalContext MContext => base.Context as ModalContext;

        public ModalContextBuilder() : base(new ModalContext())
        {
        }

        public ModalContextBuilder WithOpen(bool open)
        {
            MContext.Open = open;

            return this;
        }

        public ModalContextBuilder WithBackdropInvisible(bool backdropInvisible)
        {
            MContext.BackdropInvisible = backdropInvisible;

            return this;
        }

        public ModalContextBuilder WithBackdropClass(string backdropClass)
        {
            MContext.BackdropClass = backdropClass;

            return this;
        }

        public ModalContextBuilder WithBackdropStyle(string backdropStyle)
        {
            MContext.BackdropStyle = backdropStyle;

            return this;
        }


        public ModalContextBuilder WithOnEnter(Func<(IReference, bool), Task> onEnter)
        {
            MContext.OnEnter = onEnter;

            return this;
        }

        public ModalContextBuilder WithOnExited(Func<IReference, Task> onExited)
        {
            MContext.OnExited = onExited;

            return this;
        }

        public ModalContextBuilder WithOnBackdropClick(Action onBackdropClick)
        {
            MContext.OnBackdropClick = onBackdropClick;

            return this;
        }

        public override ModalContextBuilder With(IModalContext context)
        {
            base.With(context)
            .WithOpen(context.Open)
            .WithBackdropInvisible(context.BackdropInvisible)
            .WithBackdropClass(context.BackdropClass)
            .WithBackdropStyle(context.BackdropStyle)
            .WithRefBack(context.RefBack)
            .WithOnEnter(context.OnEnter)
            .WithOnExited(context.OnExited)
            .WithOnBackdropClick(context.OnBackdropClick);

            return this;
        }

        protected override ModalContextBuilder This()
        {
            return this;
        }
    }
}