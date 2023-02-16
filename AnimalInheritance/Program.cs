using System;

namespace animalinheritance
{
    // base Class 
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    class AnimalClass : Animal
    {
        private string Field1;
        protected string Field2;
        public string Field3;

        public void setField1(string Field1)
        {
            this.Field1 = Field1;
        }
        public virtual string getField1()
        {
            return this.Field1;
        }
        public void setField2(string Field2)
        {
            this.Field2 = Field2;
        }
        public virtual string getField2()
        {
            return this.Field2;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // base class display
            Animal animal = new Animal();
            animal.setName("animalName");
            animal.setType("TypeOne");
            animal.color = "red";

            Console.WriteLine("[ ! ] ANIMAL CLASS DISPLAY [ ! ]");
            Console.WriteLine(animal.getName());
            Console.WriteLine(animal.getType());
            Console.WriteLine(animal.color);

            // inherited class display
            AnimalClass newAnimal = new AnimalClass();
            newAnimal.setName("newAnimalName");
            newAnimal.setType("TypeTwo");
            newAnimal.color = "Blue";
            newAnimal.setField1("Field1Set");
            newAnimal.setField2("Field2Set");
            newAnimal.Field3 = "Field3Set";

            Console.WriteLine("[ ! ] ANIMALCLASS INHERITED CLASS DISPLAY [ ! ]");
            Console.WriteLine(newAnimal.getName());
            Console.WriteLine(newAnimal.getType());
            Console.WriteLine(newAnimal.color);
            Console.WriteLine(newAnimal.getField1());
            Console.WriteLine(newAnimal.getField2());
            Console.WriteLine(newAnimal.Field3);

        }
    }
    
}
