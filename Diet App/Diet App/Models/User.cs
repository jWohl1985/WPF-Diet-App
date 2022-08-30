using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Models
{
    public class User
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public float WeightInLbs { get; private set; }
        public int HeightFeetComponent { get; private set; }
        public float HeightInchComponent { get; private set; }
        public float HeightInInches => (HeightFeetComponent * 12) + HeightInchComponent;
        public int HoursExercisePerWeek { get; private set; }
        public Sex Sex { get; private set; }
        public Goal Goal { get; private set; }
        public BodyMeasurements Measurements { get; private set; }

        public User(string name, int age, float weightInLbs, int heightFeetComponent, float heightInchComponent,
            int hoursExercisePerWeek, Sex sex, Goal goal, BodyMeasurements measurements)
        {
            this.Name = name;
            this.Age = age;
            this.WeightInLbs = weightInLbs;
            this.HeightFeetComponent = heightFeetComponent;
            this.HeightInchComponent = heightInchComponent;
            this.HoursExercisePerWeek = hoursExercisePerWeek;
            this.Sex = sex;
            this.Goal = goal;
            this.Measurements = measurements;
        }
    }
}
