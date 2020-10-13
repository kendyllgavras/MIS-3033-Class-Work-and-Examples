﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
	public class Address
	{

		public int StreetNumber { get; set; }
		public string StreetName { get; set; }
		public string State { get; set; }
		public string City { get; set; }
		public int ZipCode { get; set; }



		public Address()
		{
			StreetNumber = 0;
			StreetName = "";
			State = "";
			City = "";
			ZipCode = 0;
		}

		public Address(int streetnumber, string streetname, string state, string city, int zipcode)
		{
			
			StreetNumber = streetnumber;
			StreetName = streetname;
			State = state;
			City = city;
			ZipCode = zipcode;
		}
	}
}
