﻿using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using EdFi.Common.InversionOfControl;
using NUnit.Framework;

namespace EdFi.Ods.Tests.EdFi.Common.InversionOfControl
{
    [TestFixture]
    public class WindsorContainerExTests
    {
        // ReSharper disable once ClassNeverInstantiated.Local
        private class ServiceLocatorDependencyTestClass
        {
            private readonly IServiceLocator _locator;

            public ServiceLocatorDependencyTestClass(IServiceLocator locator)
            {
                _locator = locator;
            }

            public bool HasValidLocator()
            {
                return _locator.Resolve<ServiceLocatorDependencyTestClass>() != null;
            }
        }

        [Test]
        public void Conatiner_Should_Implement_IServiceLocator()
        {
            var container = new WindsorContainerEx();
            // ReSharper disable once UnusedVariable
            var serviceLocator = (IServiceLocator)container;
        }

        [Test]
        [ExpectedException(typeof(Exception), MatchType = MessageMatch.StartsWith, ExpectedMessage = "Self-registering")]
        public void Container_Should_Not_Allow_WindsorContainer_To_Be_Registered()
        {
            var container = new WindsorContainerEx();
            container.Register(
                Component.For<WindsorContainer>()
                );
        }

        [Test]
        [ExpectedException(typeof(Exception), MatchType = MessageMatch.StartsWith, ExpectedMessage = "Self-registering")]
        public void Container_Should_Not_Allow_WindsorContainer_Instance_To_Be_Registered()
        {
            var container = new WindsorContainerEx();
            container.Register(
                Component.For<WindsorContainer>().Instance(container)
                );
        }

        [Test]
        [ExpectedException(typeof(Exception), MatchType = MessageMatch.StartsWith, ExpectedMessage = "Self-registering")]
        public void Container_Should_Not_Allow_WindsorContainerEx_To_Be_Registered()
        {
            var container = new WindsorContainerEx();
            container.Register(
                Component.For<WindsorContainerEx>()
                );
        }

        [Test]
        [ExpectedException(typeof(Exception), MatchType = MessageMatch.StartsWith, ExpectedMessage = "Self-registering")]
        public void Container_Should_Not_Allow_WindsorContainerEx_Instance_To_Be_Registered()
        {
            var container = new WindsorContainerEx();
            container.Register(
                Component.For<WindsorContainerEx>().Instance(container)
                );
        }

        [Test]
        public void Container_Should_Allow_WindsorContainerEx_Dependency_To_Be_Registered()
        {
            var container = new WindsorContainerEx();
            container.Register(
                Component.For<ServiceLocatorDependencyTestClass>()
                .DependsOn(Dependency.OnValue<IServiceLocator>(container))
                );

            var obj = container.Resolve<ServiceLocatorDependencyTestClass>();

            Assert.IsTrue(obj.HasValidLocator());
        }
    }
}
