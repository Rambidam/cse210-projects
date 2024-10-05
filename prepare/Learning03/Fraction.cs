using System;

    public class Fraction
    {
        // attributes or member variables
        private int _top; 
        private int _bottom;

        // constructors
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }
        
        // methods or member functions
        public string GetFractionString()
        {
            string text = $"{_top}/{_bottom}";
            return text;

        }
        public double GetDecimalValue()
        {
            return (double)_top / (double)_bottom;
        }
    }