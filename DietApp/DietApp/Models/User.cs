using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Models
{
    public class User
    {
        // Entity relationships
        public int UserId { get; set; }
        public BodyMeasurements Measurements { get; set; }
        public ICollection<WeightLogEntry> WeightLog { get; set; }
        public ICollection<Meal> Meals { get; set; }

        // User properties
        public string Name { get; set; }
        public int Age { get; set; }
        public float WeightInLbs { get; set; }
        public int HeightFeetComponent { get; set; }
        public float HeightInchComponent { get; set; }
        public float HeightInInches => (HeightFeetComponent * 12) + HeightInchComponent;
        public int HoursExercisePerWeek { get; set; }
        public Sex Sex { get; set; }
        public Goal Goal { get; set; }

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

        public User()
        {

        }
    }
}
