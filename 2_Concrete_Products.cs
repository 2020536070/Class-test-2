﻿/* CSIS2664, 2025
 * Class test 2, Question 1
 * Student number:2079034130
 * Surname, Initials: Blignaut, PJ
 */

public abstract class ACar : ICar
{
    protected string model, colour;
    //public string CarColor { get { return colour; } }
    public string CarColor => colour;
    //public string GetCarModel() { return model; }
    public string GetCarModel() => model;
}

class Honda : ACar
{
    //private string model, colour;

    //public string CarColor
    //{
    //    get { return colour; }
    //}

    public Honda(string model, string colour)
    {
        this.model = model;
        this.colour = colour;
    }

    //public string GetCarModel()
    //{
    //    return model;
    //}
} //class Honda

class BMW : ACar
{
    public BMW(string model, string colour)
    {
        this.model = model;
        this.colour = colour;
    }
} //class BMW
