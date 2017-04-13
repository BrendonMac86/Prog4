// Program 4
// CIS 200-01
// Fall 2016
// Due: 11/29/2016
// By: C8045

// File: Parcel.cs
//The Parcel class is a small application that sorts Parcel objects using the IComparable interface, 
// which differentiates cost values and sorts the objects ascendingly. It also does everything Program1A 
// accomplished.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel : IComparable <Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        return String.Format("Origin Address:{3}{0}{3}{3}Destination Address:{3}{1}{3}Cost: {2:C}",
            OriginAddress, DestinationAddress, CalcCost(), Environment.NewLine);
    }
    //Precondition: None
    //Postcondition: Returns an int indicating the order of parcels by string comparison
    public int CompareTo(Parcel p)
    {
        //Checks if both values are null and makes them equal, checks if only "this" is null and returns -1,
        // checks if p is null and returns 1
        if (this == null && p == null)
            return 0;
        if (this == null)
            return -1;                                      //null is less than p
        if (p == null)
            return 1;                                       //p is greater than null
        return this.CalcCost().CompareTo(p.CalcCost());     //compares CalcCost values and returns their order
    }
}
