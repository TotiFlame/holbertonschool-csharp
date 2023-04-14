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

    public Dog(string name, float age, string owner, Rating rating) {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    public override string ToString() {
        return $"Dog name: {name}\nAge: {age}\nOwner: {this.owner}\nRating: {this.rating}";
    }
}
