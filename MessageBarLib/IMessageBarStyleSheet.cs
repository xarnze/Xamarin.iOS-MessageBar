//
// IMessageBarStyleSheet.cs
//
// Author:
//       Prashant Cholachagudda <pvc@outlook.com>
//
// Copyright (c) 2013 Prashant Cholachagudda
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.


using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace MessageBar
{
	public interface IMessageBarStyleSheet
	{
		UIColor BackgroundColorForMessageType (MessageType type);

		UIColor StrokeColorForMessageType (MessageType type);

		UIImage IconImageForMessageType (MessageType type);
	}

	public interface IMessageViewDelegate
	{
		IMessageBarStyleSheet StyleSheetForMessageView (MessageView messageView);
	}

	public class MyClass:NSObject, IMessageViewDelegate
	{
		static MyClass _myClass;

		public static MyClass GetInstance()
		{
			return _myClass ?? (_myClass = new MyClass ());
		}

		public MyClass ()
		{
			System.Console.WriteLine ("This is my class");
		}

		#region IMessageViewDelegate implementation

		public IMessageBarStyleSheet StyleSheetForMessageView (MessageView messageView)
		{
			throw new System.NotImplementedException ();
		}

		#endregion
	}
}