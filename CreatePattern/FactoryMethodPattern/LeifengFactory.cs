namespace FactoryMethodPattern
{
    internal interface ILeifengFactory
    {
        Leifeng CreateLeifeng();
    }

    internal class UndergraduteFactory : ILeifengFactory
    {
        public Leifeng CreateLeifeng()
        {
            return new Undergradute();
        }
    }

    internal class VolunteerFactory : ILeifengFactory
    {
        public Leifeng CreateLeifeng()
        {
            return new Volunteer();
        }
    }
}
