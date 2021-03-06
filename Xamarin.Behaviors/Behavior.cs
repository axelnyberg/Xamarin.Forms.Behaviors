//Updated to v 1.4.6392 
using System;

using Xamarin.Forms;

namespace Xamarin.Behaviors
{
	public abstract class Behavior : BindableObject, IBehavior
	{
		protected abstract void OnAttach();
		protected abstract void OnDetach();


		public virtual BindableObject AssociatedObject
		{
			get;
			private set;
		}

		public virtual void Detach()
		{
			OnDetach();
			AssociatedObject = null;
		}

		public virtual void Attach(BindableObject dependencyObject)
		{
			AssociatedObject = dependencyObject;
			OnAttach();
		}
	}
}