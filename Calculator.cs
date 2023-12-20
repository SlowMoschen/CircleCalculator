namespace Calculator
{
    public class Calculator
    {
        const double PI = Math.PI; 
        public string[] calculateViaRadius(int radius)
        {
            string area = (PI * Math.Pow(radius, 2)).ToString("F2");
            string circumference = (2 * PI * radius).ToString("F2");
            string diameter = (2 * radius).ToString("F2");
            return new string[] { area, circumference, diameter, radius.ToString() };
        }

        public string[] calculateViaDiameter(int diameter)
        {
            double radius = (diameter / 2);
            string area = (PI * Math.Pow(radius, 2)).ToString("F2");
            string circumference = (2 * PI * radius).ToString("F2");
            return new string[] { area, circumference, diameter.ToString(), radius.ToString("F2") };
        }

        public string[] calculateViaPerimeter(int perimeter)
        {
            double radius = perimeter / (2 * PI);
            string area = (PI * Math.Pow(radius, 2)).ToString("F2");
            string diameter = (2 * radius).ToString("F2");
            return new string[] { area, perimeter.ToString(), diameter, radius.ToString("F2") };
        }

        public string[] calculateViaArea(int area)
        {
            double radius = Math.Sqrt(area / PI);
            string diameter = (2 * radius).ToString("F2");
            string perimeter = (2 * PI * radius).ToString("F2");
            return new string[] { area.ToString(), perimeter, diameter, radius.ToString("F2") };
        }
    }
}