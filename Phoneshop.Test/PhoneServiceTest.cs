using Moq;
using Phoneshop.Data.Entities;
using Phoneshop.Data.Interfaces;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;

namespace Phoneshop.Test
{
    public class PhoneServiceTest
    {
        private readonly Mock<IRepository<Phone>> localMock;

        public PhoneServiceTest()
        {
            var repoMock = new Mock<IRepository<Phone>>();
            repoMock.Setup(r => r.Create(It.IsAny<Phone>())).Returns(new Phone() { Id =1});
            localMock = repoMock;
        }
        [Fact]
        void PhoneServiceShouldCreateItemWhenItDoesNotExist()
        {
        }
    }
}
