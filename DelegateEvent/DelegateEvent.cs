using System;
namespace DesignPattern.DelegateEvent
{
	public class DelegateEvent
	{

		public delegate void OnGrantHandler();
		public delegate void OnRefuseHandler();

		public event OnGrantHandler OnGrantEvent;
		public event OnGrantHandler OnRefuseEvent;

		/*public DelegateEvent()
		{
			SetEventHandler();
        }*/

		private void SetEventHandler()
		{
			OnGrantEvent += OnGrant;
            OnRefuseEvent += OnRefuse;
        }

		private void OnGrant()
		{
            Console.WriteLine("OnGrant");
        }

        private void OnRefuse()
        {
			Console.WriteLine("OnRefuse");
        }

    }
}

