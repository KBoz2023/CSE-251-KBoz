using System;

class Person
{
    public string _givenName;
    public string _familyName;
    public Person(string _givenName, string _familyName){
        this._familyName = _familyName;
        this._givenName = _givenName;
    }
    public void EasternStyleName(){
        Console.WriteLine($"{this._familyName}, {this._givenName}");
    }
    public void WesternStyleName()
    {
        Console.WriteLine($"{_givenName}, {_familyName}");
    }
}
