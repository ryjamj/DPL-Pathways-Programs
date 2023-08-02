/*
Program Name: Car
Last Updated: 07/31/2023
Program Description:
    a custom 'Car' class to use with the oop1 program to pratice creating and using classes in OOP.
*/

using System;
namespace MyApplication
{
    class Car
    {
        // ----------------------------------------------------------
        // declare variables for the Car class

        public string model;
        public string color;


        // ----------------------------------------------------------
        // constructors()

        // Create a constructor to auto return some default values for the variables
        public Car()
        {
            color = "unassinged";
            model = "unassinged";
        }

        // Create a constructor that auto accepts parameter values to set to the variables
        public Car(string newColor, string newModel)
        {
            color = newColor;
            model = newModel;
        }


        // ----------------------------------------------------------
        // methods()

        // return the value of color and model varibles, either the default value or a passed in parameter if provided
        public string getColor() // return the value for color variable
        {
            return color;
        }
        public string getModel() // return the value for model variable
        {
            return model;
        }

        // set the value of color and model variables to whatever the pass in parameter is
        public void setColor(string newColor)  // set the passed in value for color variable
        {
            color = newColor;
        }
        public void setModel(string newModel)  // set the passed in value for model variable
        {
            model = newModel;
        }

    } // end class Car
} // end namespace