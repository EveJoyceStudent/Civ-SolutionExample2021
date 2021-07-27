using System;

namespace ProjectCarClass
{
    public class Car
    {
        public Car(string rego, int odometer)
        {
            this.rego = rego;
            this.odometer = odometer;
        }

        public string rego { get; set; }
        public int odometer { get; set; }
    }
}
