using NUnit.Framework;
using Impl = SystemicConsent.Core;

namespace Test
{
    [TestFixture()]
    public class Option
    {
        private Impl.Option _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new Impl.Option("Hallo Welt");
        }

        [Test]
        public void ShouldHaveTheCorrectName()
        {
            Assert.That(_sut.Name, Is.EqualTo("Hallo Welt"));
        }

        [Test]
        public void ShouldBeEqualIfNameIsEqual()
        {
            Assert.That(_sut.Equals(new Impl.Option("Hallo Welt")), Is.True);
        }

        [Test]
        public void ShouldBeSameIfNameIsEqual()
        {
            Assert.That(_sut == new Impl.Option("Hallo Welt"), Is.True);
        }

        [Test]
        public void ShouldHaveAValue()
        {
            Assert.That(_sut.Value, Is.EqualTo(0));
        }

        [Test]
        public void ShouldIncreaseValueByGivenValueOnVote()
        {
            _sut.Vote(5);
            Assert.That(_sut.Value, Is.EqualTo(5));
        }
    }
}

