using System.Diagnostics;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

// Faction class
public class Fraction
{
    //Attributes are private
    private int _topNumbers;
    private int _bottomNumbers;


    //Constructor has no parameter
    public Fraction()
    {
        _bottomNumbers = 1;
        _topNumbers = 1;
       
    }

    //Constructor has one parameter
    public Fraction(int top)
    {
        _topNumbers = top;
        _bottomNumbers = 1;

    }

    //Constructor has two parameters
    public Fraction(int top, int bottom)
    {
        _topNumbers =top;
        _bottomNumbers = bottom;

    }

    //Create getters and setters for both the top values

    public int GetTop()
    {
        return _topNumbers;
    }

    public void SetTop(int topNumbers)
    {
        _topNumbers = topNumbers;
    }

    //Create getters and setters for the bottom values
    public int GetBottom()
    {
        return _bottomNumbers;
    }

    public void SetBottom(int bottomNumbers)
    {
        _bottomNumbers = bottomNumbers  ;
    }

    // method called GetFractionString that returns the fraction 
    public string GetFractionString()
    {
        return $"{_topNumbers}/{_bottomNumbers}";
    }

    // method called GetDecimalValue that returns a double
    public double GetDecimalValue()
    {
        return (double)_topNumbers / _bottomNumbers;
    }    
    
}