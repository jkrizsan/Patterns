using FactoryMethod.AbstractProducts;
using FactoryMethod.ConcreteProducts;

namespace FactoryMethod.ConcreteCreators
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
