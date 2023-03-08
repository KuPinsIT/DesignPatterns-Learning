using System;
using System.ComponentModel;

namespace Upheads.DesignPattern.Library.StructuralPatterns​.Decorator
{
    public abstract class BaseDecorator
    {
        public abstract string Send();
    }

    // Handle wrapping all decorators together
    class State : BaseDecorator
    {
        protected BaseDecorator _base;

        public State(BaseDecorator component)
        {
            this._base = component;
        }

        public override string Send()
        {
            return this._base.Send();
        }
    }
}


