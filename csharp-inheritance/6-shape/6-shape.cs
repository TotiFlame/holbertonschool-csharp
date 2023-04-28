﻿using System;

class Shape
{
    /// <summary> public area method </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get 
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        } 
    }

    public int Height
    {
        get 
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        } 
    }
}
