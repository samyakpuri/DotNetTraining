using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmDay2.Services;
using MvvmDay2.ViewModels;
using MvvmDay2.Models;

namespace MvvmDay2.Tests
{
    [TestClass]
    public class ViewModelTests
    {
        [TestMethod]
        public void AddPersonCommandOnCallingChangesPersonNameToChanged()
        {
            Mock<IDialogService> mock = new Mock<IDialogService>();
            mock.Setup(it => it.ShowDialog()).Returns("This is from Test");
            MainViewModel mainViewModel = new MainViewModel(mock.Object);
            Person person = new Person();
            person.Name = "Hi";
            mainViewModel.Person = person;
            mainViewModel.AddPersonCommand.Execute(null);
            mock.Verify(it => it.Show(It.IsAny<string>()), Times.Once);
            Assert.AreEqual(mainViewModel.Person.Name, "This is from Test");
        }
    }
}
