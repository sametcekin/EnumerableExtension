namespace EnumerableExtension.Test
{
    public class EnumerableExtensionSafeCheck
    {
        List<string> list = null;
        [Fact]
        public void When_ListIsNull_AnyCheckWillThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => list.Any());
        }

        [Fact]
        public void When_ListIsNull_And_NullableOperatorAdded_AnyCheck_ReturnNull()
        {
            Assert.Null(list?.Any());
        }

        [Fact]
        public void When_ListIsNull_And_SafeCheckUsed_AnyCheckWillNotThrowException_And_ReturnFalse()
        {
            var result = list.Safe().Any();
            Assert.False(result);
        }

        [Fact]
        public void When_ListHasNewInstance_AnyCheckReturnFalse()
        {
            list = new List<string>();

            Assert.False(list.Any());
            Assert.Empty(list);
        }

        [Fact]
        public void When_ListHasItem_AnyCheckReturnTrue()
        {
            list = new List<string>
            {
                "1"
            };

            Assert.True(list.Any());
            Assert.NotEmpty(list);
        }
    }
}