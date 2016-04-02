using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GP.Opgavesaet2.Opgave2_1.Model.Tests
{
    [TestClass]
    public class ArrayExtensionsTests
    {
        [TestMethod]
        public void ReversedReversesArray()
        {
            var array = new[] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            var expectedArray = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            var returnedArray = array.Reversed();

            returnedArray.AreEqualTo(expectedArray);
        }

        [TestMethod]
        public void SubArrayReturnsCorrectPartOfArray()
        {
            var array = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            var expectedArray = new[] { 6, 5, 4 };

            var returnedArray = array.SubArray(3,3);

            returnedArray.AreEqualTo(expectedArray);
        }

        [TestMethod]
        public void OccurrencesOfReturnsCorrectNumberOfOccurrences()
        {
            var array = new[] { 0, 5, 2, 3, 4, 5, 6, 7, 8, 5 };
            var expectedNumberOfOccurrences = 3;

            var returnedNumberOfOccurrences = array.OccurrencesOf(5);

            Assert.AreEqual(expectedNumberOfOccurrences, returnedNumberOfOccurrences);
        }

        [TestMethod]
        public void FirstPositionOfReturnsCorrectPosition()
        {
            var array = new[] { 0, 5, 2, 3, 4, 5, 6, 7, 8, 5 };
            var expectedPosition = 1;

            var returnedPosition = array.FirstPositionOf(1);

            Assert.AreEqual(expectedPosition, returnedPosition);
        }

        [TestMethod]
        public void FirstPositionOfThrowsExceptionIfKindIsNotFound()
        {
            var array = new[] { 0, 5, 2, 3, 4, 5, 6, 7, 8, 5 };
            var ecxeptionThrown = false;

            try
            {
                var notUsed = array.FirstPositionOf(999);
            }
            catch (Exception)
            {
                ecxeptionThrown = true;
            }

            Assert.AreEqual(true, ecxeptionThrown);
        }
    }
}
