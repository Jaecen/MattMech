using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Battletech
{
	public class WatermarkTextBox : TextBox
	{
		private const uint ECM_FIRST = 0x1500;
		private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

		[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, SetLastError = false)]
		static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

		private string _WatermarkText;

		public string WatermarkText 
		{
			get
			{
				return _WatermarkText;
			}

			set
			{
				_WatermarkText = value;

				if(!String.IsNullOrEmpty(_WatermarkText))
					SendMessage(Handle, EM_SETCUEBANNER, 0, _WatermarkText ?? String.Empty);
			}
		}
	}
}
