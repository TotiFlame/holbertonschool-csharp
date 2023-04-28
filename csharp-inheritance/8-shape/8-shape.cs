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
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
    /// <summary> public area method</summary>
    public override int Area()
    {
        return height * width;
    }
    /// <summary> public ToString method </summary>
    public override string ToString()
    {
        return "[Rectangle] " + width + " / " + height;
    }
}

class Square : Rectangle
{
    private int size;

    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = value;
                Width = value;
                Height = value;
            }
        }
    }
    /// <summary> public ToString method </summary>
    public override string ToString()
    {
        return "[Square] " + size + " / " + size;
    }
}