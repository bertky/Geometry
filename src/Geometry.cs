using System;

namespace Geometry {
	public class Rectangle {
		private int _l;
		private int _w;
		public int l
		{
			get { return _l; }
			set { _l = value; }
		}
		public int w
		{
			get { return _w; }
			set { _w = value; }
		}
		public int Area
		{
			get { return _l * _w; }
		}
		public int Perimeter
		{
			get {return (_l * 2) + (_w * 2);}
		}
	}
	public class Square {
		private int _l;
		public int l
		{
			get { return _l; }
			set { _l = value; }
		}
		public int w
		{
			get { return _l; }
			set { _l = value; }
		}
		public int Area
		{
			get {return _l * _l;}
		}
		public int Perimeter
		{
			get {return _l * 4;}
		}
	}
}
