using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(100);
            book.AddGrade(100);
            book.AddGrade(100);
            //act
            var result = book.GetStatistics();
            //assert
            Assert.Equal(100, result.Average);
            Assert.Equal(100, result.High);
            Assert.Equal(100, result.Low);
        }
    }
}

