/* CSIS2664, 2025
 * Class test 2, Question 1
 * Student number:
 * Surname, Initials:
 */

class HondaFactory : ACarFactory
{
    public override ICar MakeCar(string model, string colour)
    {
        return new Honda(model, colour);
    }
} //class HondaFactory

class BMWFactory : ACarFactory
{
    public override ICar MakeCar(string model, string colour)
    {
        return new BMW(model, colour);
    }
} //class BMWFactory
