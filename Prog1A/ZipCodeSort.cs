// Program 4
// CIS 200-01
// Fall 2016
// Due: 11/29/2016
// By: C8045

// File: ZipCodeSort.cs
//The ZipCodeSort class is a small application that sorts Parcel objects using the Comparer interface, 
// which differentiates Destination Address zipcode values and sorts the objects in descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ZipCodeSort:Comparer<Parcel>
    {
        // Precondition:None
        // Postcondition:Reverses natural Destination Address zipcode order, so that its descending
        public override int Compare(Parcel x, Parcel y)
        {
            if (x == null && y == null)
                return 0;       //When x == y, method returns zero
            if (x == null)
                return -1;      //When x > y, method returns negative #
            if (y == null)  
                return 1;       //When x < y, method returns positive #
            return (-1) * (x.DestinationAddress.Zip.CompareTo(y.DestinationAddress.Zip));   //Reverses the natural order by multiplying the result with -1
        }
    }
}
