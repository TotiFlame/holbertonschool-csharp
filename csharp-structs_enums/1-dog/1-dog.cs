using System;

public enum Rating {
    Good = 0,
    Great = 1,
    Excellent = 2
}

public struct Dog {
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}