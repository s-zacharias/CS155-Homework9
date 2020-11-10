/// Homework 9		Project No. 1
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  November 9, 2020
///
/// Problem Statement: Create a class called Vehicle and a class called Truck
/// that is derived from Vehicle. Finish the definition of the Person class
/// as well.
/// 
/// 
/// Overall Plan:
/// 1) Create a class called Vehicle that contains the manufacturer name,
///    number of cylinders, and the owner.
/// 2) Create a class called Truck that is derived from Vehicle that has the
///    additional properties: load capacity, and towing capacity.
/// 3) Finish the definition of the Person class.
/// 4) Write a driver program to test all the methods.

using System;

namespace Project1
{
    public enum ManufacturerName
    {
        Honda,
        Toyota,
        Ford,
        GMC,
        Dodge
    };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Vehicle
    {
        ManufacturerName manufacturerName;
        int numberOfCylinders;
        Person owner;

        public ManufacturerName ManufacturerName
        {
            get
            {
                return manufacturerName;
            }
        }

        public int NumberOfCylinders
        {
            get
            {
                return numberOfCylinders;
            }
            set
            {
                numberOfCylinders = value;
            }
        }

        public Person Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        public String toString()
        {
            return "The manufacturer of this vehicle is " + manufacturerName +
                ". The vehicle has " + numberOfCylinders + " cylinders and " +
                "the owner is " + owner.GetName();
        }

        public bool equals(Vehicle obj)
        {
            if (this.numberOfCylinders == obj.numberOfCylinders && this.owner ==
                obj.owner)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }

    public class Truck : Vehicle
    {
        double loadCapacity; // in tons
        int towingCapacity; // in pounds

        public double LoadCapacity
        {
            get
            {
                return loadCapacity;
            }
            set
            {
                loadCapacity = value;
            }
        }

        public int TowingCapacity
        {
            get
            {
                return towingCapacity;
            }
            set
            {
                towingCapacity = value;
            }
        }

        public new String toString()
        {
            return "The load capacity of this truck is " + loadCapacity +
                " tons and the towing capacity is " + towingCapacity +
                " pounds.";
        }

        public bool equals(Truck obj)
        {
            if (this.loadCapacity == obj.loadCapacity && this.towingCapacity ==
                obj.towingCapacity)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    public class Person
    {
        private String name;
        public Person()
        {

        }
        public Person(String theName)
        {

        }
        public Person(Person obj)
        {

        }
        public String GetName()
        {
            return name;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public String toString()
        {
            return "This person is named " + name;
        }
        public bool equals(Person obj)
        {
            if (this.name == obj.name)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
